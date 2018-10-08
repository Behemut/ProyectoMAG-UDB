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
    public partial class frmsplash : MetroFramework.Forms.MetroForm
    {
        public frmsplash()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        int contador = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador += 2;
            metroLabel2.Text = "Iniciando  al Sistema En  " + contador + "%";

            metroProgressBar1.Increment(2);
            if (metroProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmsplash_Load(object sender, EventArgs e)
        {

        }
    }
}
