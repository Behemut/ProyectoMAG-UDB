using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;

using MetroFramework.Interfaces;
using MetroFramework.Controls;
using MetroFramework.Forms;



namespace PROYECTO_CATEDRA_MAG {
    class clsUsuarios : Conexion
    {


        private int id;
        private string nombre;
        private string apellido;
        private string dui;
        private string usuario;
        private string tipousuario;
        private string contraseña;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Dui
        {
            get
            {
                return dui;
            }

            set
            {
                dui = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Tipousuario
        {
            get
            {
                return tipousuario;
            }

            set
            {
                tipousuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }

        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public bool Insertar() {
            try
            {
                string instruccion;
                instruccion = "INSERT INTO  Usuarios(IdUsuario, Nombre, Apellido, Contraseña, usuario, DUI, TipoUsuario)";
                instruccion += "VALUES (@IdUsuario, @Nombre, @Apellido, @Contraseña, @usuario, @DUI, @TipoUsuario)";

                cmd = new SqlCommand(instruccion, conexion);
                cmd.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int));
                cmd.Parameters["@IdUsuario"].Value = id;
                cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                cmd.Parameters["@Nombre"].Value = nombre;
                cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                cmd.Parameters["@Apellido"].Value = apellido;
                cmd.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
                cmd.Parameters["@Contraseña"].Value = contraseña;
                cmd.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar));
                cmd.Parameters["@usuario"].Value = usuario;
                cmd.Parameters.Add(new SqlParameter("@DUI", SqlDbType.VarChar));
                cmd.Parameters["@DUI"].Value = dui;
                cmd.Parameters.Add(new SqlParameter("@TipoUsuario", SqlDbType.VarChar));
                cmd.Parameters["@Tipousuario"].Value = tipousuario;
                conexion.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.Close();
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool ValidarExistencia(int id, string usuario) {
            try
            {
                conexion.Open();
                cmd = new SqlCommand("UsuariosIngresados", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@identidad", id));
                cmd.Parameters.Add(new SqlParameter("@usuario", usuario));

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    if (id == Convert.ToInt32(dt.Rows[0][0]))
                    {
                        MessageBox.Show("Ya existe usuario con ID: " + dt.Rows[0][0].ToString());
                    }
                    else if (usuario == dt.Rows[0][4].ToString())
                    {
                        MessageBox.Show("Ya existe el nombre usuario:  " + dt.Rows[0][4].ToString());
                    }
                    conexion.Close();
                    return false;
                }
                else
                {
                    conexion.Close();
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


        public void MostrarUsuarios(DataGridView tabla) {
            try
            {
                cmd = new SqlCommand("MostrarUsuarios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                tabla.DataSource = dt;
                cmd.Parameters.Clear();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la Tabla usuarios: " + ex.ToString());
            }
        }

        public void EditarUsuarios(int id, MaskedTextBox identificacion, MetroTextBox nombre, MetroTextBox apellido, MetroTextBox contraseña, MetroTextBox usuario, MaskedTextBox dui) {

            cmd = new SqlCommand("Select * from Usuarios where IdUsuario= @Identificacion ", conexion);
            cmd.Parameters.AddWithValue("@Identificacion", id);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            identificacion.Text = dt.Rows[0][0].ToString();
            nombre.Text = dt.Rows[0][1].ToString();
            apellido.Text = dt.Rows[0][2].ToString();
            contraseña.Text = dt.Rows[0][3].ToString();
            usuario.Text = dt.Rows[0][4].ToString();
            dui.Text = dt.Rows[0][5].ToString();
        }

        public bool EliminarUsuario(int identificacion)
        {
            try
            {
                conexion.Open();

                cmd = new SqlCommand("EliminarUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@identidad", identificacion));
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.Close();
                return true;
               
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public bool ModificarUsuario(int identificacion, string nom, string ape, string cont, string user, string dui, string tipo)
        {
            try
            {
                conexion.Open();
                cmd = new SqlCommand("ModificarUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                cmd.Parameters.Add(new SqlParameter("@Nom", nom));
                cmd.Parameters.Add(new SqlParameter("@Ape", ape));
                cmd.Parameters.Add(new SqlParameter("@Cont", cont));
                cmd.Parameters.Add(new SqlParameter("@Usua", user));
                cmd.Parameters.Add(new SqlParameter("@dui", dui));
                cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }


    }
}
