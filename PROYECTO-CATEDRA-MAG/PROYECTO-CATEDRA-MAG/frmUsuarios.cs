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

namespace PROYECTO_CATEDRA_MAG
{
    public partial class frmUsuarios : MetroFramework.Forms.MetroForm
    {

        clsUsuarios usuario = new clsUsuarios();
        


        //Diccionario de Datos para ComboBox de Tipo de Usuarios
        SortedDictionary<string, string> userCache = new SortedDictionary<string, string>{
          {"Administrador", "A"},
          {"Encuestador", "E" }
        };
   
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            
            btnIngresar.Enabled = false;
            dgvUsuarios.DataSource = null;

            dgvUsuarios.ClearSelection();
            pbModificar.Enabled = false;
            pbEliminar.Enabled = false;

            cmbTipoUsuario.DataSource = new BindingSource(userCache, null);
            cmbTipoUsuario.DisplayMember = "Key";
            cmbTipoUsuario.ValueMember = "Value";

            cmbEditarTipo.DataSource = new BindingSource(userCache, null);
            cmbEditarTipo.DisplayMember = "Key";
            cmbEditarTipo.ValueMember = "Value";
            usuario.MostrarUsuarios(dgvUsuarios);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenu menu = new PROYECTO_CATEDRA_MAG.frmMenu();
            this.Close();
            menu.Visible = true;
        }

        private void Reseteo()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDUI.Clear();
            txtUsuario.Clear();
            btnIngresar.Enabled = false;
            txtContraseña.Clear();


            txtEditarDUI.Clear();
            txtEditarID.Clear();
            txtEditarUsuario.Clear();
            txtEditarContraseña.Clear();
            txtEditarApellido.Clear();
            txtEditarNombre.Clear();
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled)&& txtDUI.MaskCompleted) 
            {
                //Todo es correcto, guardamos los datos
                if (usuario.ValidarExistencia(Convert.ToInt32(txtID.Text), txtUsuario.Text))
                {
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.Usuario = txtUsuario.Text;
                    usuario.Contraseña = txtContraseña.Text;
                    usuario.Dui = txtDUI.Text;
                    usuario.Tipousuario = cmbTipoUsuario.SelectedValue.ToString();
                    usuario.Id = Convert.ToInt32(txtID.Text);
                    MessageBox.Show("Datos Añadidos");
                    errorProvider1.SetError(txtDUI, "");
                    btnIngresar.Enabled = true;
                }
            }
            else if(txtDUI.MaskFull==false)
            {
                errorProvider1.SetError(txtDUI, "Complete el campo de DUI");
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar");
            }
         
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuario.Insertar())
            {
              MessageBox.Show("Usuario ingresado con exito");
               Reseteo();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z]+$"))
                e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z]+$"))
                e.Handled = true;
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text == "")
            {
                e.Cancel = true;
                txtID.Select(0, txtID.Text.Length);
                errorProvider1.SetError(txtID, "Campo de ID vacio");
            }    
       }

        private void txtID_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtID, "");
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                e.Cancel = true;
                txtNombre.Select(0, txtNombre.Text.Length);
                errorProvider1.SetError(txtNombre, "Campo de Nombre vacio");
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre, "");
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellido.Text == "")
            {
                e.Cancel = true;
                txtApellido.Select(0, txtApellido.Text.Length);
                errorProvider1.SetError(txtApellido, "Campo de Apellido vacio");
            }
        }

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtApellido, "");
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                e.Cancel = true;
                txtUsuario.Select(0, txtUsuario.Text.Length);
                errorProvider1.SetError(txtUsuario, "Campo de Usuario vacio");
            }
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsuario, "");
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                e.Cancel = true;
                txtContraseña.Select(0, txtContraseña.Text.Length);
                errorProvider1.SetError(txtContraseña, "Campo de Contraseña vacio");
            }
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtContraseña, "");
        }

        private void pbActualizar_Click(object sender, EventArgs e)
        {
            usuario.MostrarUsuarios(dgvUsuarios);
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            int posicion = Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["IdUsuario"].Value);

            if (usuario.EliminarUsuario(posicion))
            {
                MessageBox.Show("Usuario eliminado de la base de datos");
                Reseteo();
                pbEliminar.Enabled = false;
            }
            else
            {
                pbEliminar.Enabled = false;
            }
          
        }
      

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selected = dgvUsuarios.SelectedRows[0];
                int posicion = Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["IdUsuario"].Value);
                usuario.EditarUsuarios(posicion, txtEditarID, txtEditarNombre, txtEditarApellido, txtEditarContraseña,txtEditarUsuario, txtEditarDUI);
                pbModificar.Enabled = true;
                pbEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                pbModificar.Enabled = false;
                pbEliminar.Enabled = false;
                MessageBox.Show(ex.ToString());
            }

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            int posicion = Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells["IdUsuario"].Value);

            if(txtEditarDUI.MaskCompleted &&  usuario.ModificarUsuario(posicion, txtEditarNombre.Text, txtEditarApellido.Text, txtEditarContraseña.Text, txtEditarUsuario.Text, txtEditarDUI.Text, cmbEditarTipo.SelectedValue.ToString())){
                MessageBox.Show("Usuario modificado de la base de datos");
                Reseteo();
                usuario.MostrarUsuarios(dgvUsuarios);
                dgvUsuarios.Rows[0].Selected = false;
                pbModificar.Enabled = false;
                errorProvider1.SetError(txtEditarDUI, "");
            }
            else{
                pbModificar.Enabled = false;
                errorProvider1.SetError(txtEditarDUI, "Campo de DUI no esta completo");
            }


        }

        private void txtEditarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z]+$"))
                e.Handled = true;
        }

        private void txtEditarApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z]+$"))
                e.Handled = true;
        }

        private void txtEditarUsuario_Leave(object sender, EventArgs e)
        {
            if (txtEditarUsuario.Text == "")
            {
                txtEditarUsuario.Select(0, txtEditarUsuario.Text.Length);
                errorProvider1.SetError(txtEditarUsuario, "Campo de Nombre vacio");
            }

            else
            {
                errorProvider1.SetError(txtEditarUsuario, "");
            }
        }

        private void txtEditarNombre_Leave(object sender, EventArgs e)
        {
            if (txtEditarNombre.Text == "")
            {
                txtEditarNombre.Select(0, txtEditarNombre.Text.Length);
                errorProvider1.SetError(txtEditarNombre, "Campo de Nombre vacio");
            }
            else
            {
                errorProvider1.SetError(txtEditarNombre, "");
               
            }
        }

        private void txtEditarApellido_Leave(object sender, EventArgs e)
        {
            if (txtEditarApellido.Text == "")
            {
                txtEditarApellido.Select(0, txtEditarApellido.Text.Length);
                errorProvider1.SetError(txtEditarApellido, "Campo de Nombre vacio");
            }
            else
            {
                errorProvider1.SetError(txtEditarApellido, "");
            }
        }

        private void txtEditarContraseña_Leave(object sender, EventArgs e)
        {
            if (txtEditarContraseña.Text == "")
            {
                txtEditarContraseña.Select(0, txtEditarContraseña.Text.Length);
                errorProvider1.SetError(txtEditarContraseña, "Campo de Nombre vacio");
            }
            else
            {
                errorProvider1.SetError(txtEditarContraseña, "");
            }
        }
    }
}
