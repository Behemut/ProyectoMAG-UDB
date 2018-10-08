using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PROYECTO_CATEDRA_MAG
{
    public partial class frmLogin :  MetroForm 
    {
        Conexion objCon = new Conexion();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void صورة_دائرة1_Click(object sender, EventArgs e)
        {
            //No tocar
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string password = txtPassword.Text;
            
            objCon.cmd = new SqlCommand("Select * from Usuarios where usuario='" + txtUsuario.Text + "'and Contraseña='" + txtPassword.Text + "'", objCon.conexion);

            objCon.da = new SqlDataAdapter(objCon.cmd);
            objCon.dt = new DataTable();

            objCon.da.Fill(objCon.dt);

            if (txtUsuario.Text == "" )
            {
                errorLogin.SetError(txtUsuario, "Campo usuario vacio");
            }
            else if (txtPassword.Text == "") {
                errorLogin.SetError(txtPassword, "Campo de contraseña vacio");
            }
            else
            {
                errorLogin.SetError(txtUsuario, "");
                errorLogin.SetError(txtPassword, "");


                if (objCon.dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bienvenido " + objCon.dt.Rows[0][1].ToString() + " " + objCon.dt.Rows[0][2].ToString());
                   this.Hide();
                    //Enviar variable de usuario a formulario Menu 
                    frmMenu menu = new frmMenu();
                    menu.tipousuario(objCon.dt.Rows[0][2].ToString());
                    menu.Visible = true;             
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                objCon.cerrar();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            objCon.abrir();
        }


    }
}
