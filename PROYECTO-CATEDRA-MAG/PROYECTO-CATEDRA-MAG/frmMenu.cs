using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CATEDRA_MAG
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        string usuario;
        public frmMenu()
        {
            InitializeComponent();
        }

        public void tipousuario(string tipo)
        {
            InitializeComponent();
            usuario = tipo;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            if (usuario == "E")
            {
               // button1.Enabled = false;
            }
        }

        private void picIngreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIngresoEPPA ingresoeppa = new PROYECTO_CATEDRA_MAG.frmIngresoEPPA();
            ingresoeppa.Show();
        }

        private void picMapas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIngresoIAPH ingresoiaph = new PROYECTO_CATEDRA_MAG.frmIngresoIAPH();
            ingresoiaph.Show();
        }

        private void picAdminUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuarios usuario = new PROYECTO_CATEDRA_MAG.frmUsuarios();
            usuario.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin formulogin = new frmLogin();
            this.Hide();
            formulogin.Show();
        }
    }
}
