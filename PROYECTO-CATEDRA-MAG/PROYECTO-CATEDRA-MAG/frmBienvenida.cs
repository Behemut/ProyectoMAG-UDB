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
    public partial class frmBienvenida : MetroFramework.Forms.MetroForm
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void صورة_دائرة1_Click(object sender, EventArgs e)
        {
            frmInformacion formu1 = new frmInformacion();
            formu1.Show();
            this.Hide();
        }

        private void صورة_دائرة2_Click(object sender, EventArgs e)
        {
            frmLogin formu3 = new frmLogin();
            formu3.Show();
            this.Hide();
        }

        private void صورة_دائرة8_Click(object sender, EventArgs e)
        {

        }
    }
}
