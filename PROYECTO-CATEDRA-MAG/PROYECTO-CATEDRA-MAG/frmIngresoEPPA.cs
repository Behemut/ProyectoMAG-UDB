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
    public partial class frmIngresoEPPA : MetroFramework.Forms.MetroForm
    {
        clsEPPA EPPA = new clsEPPA();
        Conexion objCon = new Conexion();
   
        public frmIngresoEPPA()
        {
            InitializeComponent();
        }

        private void frmIngresoEPPA_Load(object sender, EventArgs e)
        {
            cmbUnidadMedidaEPPA.Items.Clear();
            cmbUnidadMedidaEPPA.Items.Add("Quintal");
            cmbUnidadMedidaEPPA.Items.Add("Libra");
            cmbUnidadMedidaEPPA.Items.Add("Ciento");
            cmbUnidadMedidaEPPA.Items.Add("Quintal");
            cmbUnidadMedidaEPPA.Items.Add("Unidad");
            cmbUnidadMedidaEPPA.Items.Add("Botella");
            cmbUnidadMedidaEPPA.Items.Add("Saco");

            cmbCanalVentaEPPA.Items.Clear();
            cmbCanalVentaEPPA.Items.Add("1. Exportación");
            cmbCanalVentaEPPA.Items.Add("2. Transportista intermediario");
            cmbCanalVentaEPPA.Items.Add("3. Intermediario de convenio");
            cmbCanalVentaEPPA.Items.Add("4. Cooperativa");
            cmbCanalVentaEPPA.Items.Add("5. Mayorista");
            cmbCanalVentaEPPA.Items.Add("6. Minorista");
            cmbCanalVentaEPPA.Items.Add("7. Venta al consumidor final");
            cmbCanalVentaEPPA.Items.Add("8. Ingenio o beneficio");
            cmbCanalVentaEPPA.Items.Add("9. Otro");

            cmbLugarVentaEPPA.Items.Clear();
            cmbLugarVentaEPPA.Items.Add("1. Plaza Local");
            cmbLugarVentaEPPA.Items.Add("2. Mercado");
            cmbLugarVentaEPPA.Items.Add("3. Agencia Mayoreo");
            cmbLugarVentaEPPA.Items.Add("4. Otro");

            /*if (rdbVentaSiEPPA.Checked == true)
            {
                cmbLugarVentaEPPA.Enabled = false;

            }
            if (rdbVentaNoEPPA.Checked == true)
            {
                cmbLugarVentaEPPA.Enabled = true;
            }
            */
        }

   

        private void btnCapturarEPPA_Click(object sender, EventArgs e)
        {
            DateTime FechaVenta = dtFechaVentaEPPA.Value.Date;
            string FechaVentas = string.Format("{0:dd/MM/yyyy}", FechaVenta);
            EPPA.UnidadMedidaEPPA  = cmbUnidadMedidaEPPA.SelectedItem.ToString();
            EPPA.LugarVentaEPPA  = cmbLugarVentaEPPA.SelectedItem.ToString();
            EPPA.CanalVentaEPPA = cmbCanalVentaEPPA.SelectedItem.ToString();
            EPPA.IdDireccion = Convert.ToInt32(txtIdUbicacion.Text);
            EPPA.DepartamentoEPPA = txtDepartamentoEPPA.Text;
            EPPA.MunicipioEPPA = txtMunicipioEPPA.Text;
            EPPA.CantonEPPA = txtCantonEPPA.Text;
            EPPA.NombreSupervisorEPPA = txtNombreSupervisorEPPA.Text;
            EPPA.ApellidoSupervisorEPPA = txtApellidoSupervisorEPPA.Text;
            EPPA.CodigoSupervisorEPPA = Convert.ToInt32(txtCodigoSupervisorEPPA.Text);
            EPPA.DuiSupervisorEPPA = txtDuiSupervisorEPPA.Text;
            EPPA.NombreEncuestadorEPPA = txtNombreEncuestadorEPPA.Text;
            EPPA.ApellidoEncuestadorEPPA = txtApellidoEncuestadorEPPA.Text;
            EPPA.CodigoEncuestadorEPPA = Convert.ToInt32(txtCodigoEncuestadorEPPA.Text);
            EPPA.DuiEncuestadorEPPA = txtDuiEncuestadorEPPA.Text;
            EPPA.IdProductorEPPA = Convert.ToInt32(txtIdProductorEPPA.Text);
            EPPA.NombreProductorEPPA = txtnomProductorEPPA.Text;
            EPPA.ApellidoProductorEPPA = txtApellidoProductorEPPA.Text;
            EPPA.DuiProductorEPPA = txtDuiProductorEPPA.Text;
            EPPA.NombreProductoEPPA = txtnomProductoEPPA.Text;

            EPPA.CodigoProductoEPPA = Convert.ToInt32(txtCodProductoEPPA.Text);
            EPPA.NombreTipoProductoEPPA = txtNomTipoProductoEPPA.Text;

            EPPA.CodigoTipoProductoEPPA = Convert.ToInt32(txtCodTipoProductoEPPA.Text);

            EPPA.IdprecioEPPA  = txtIdPrecio.Text;
            EPPA.PrecioEPPA = Convert.ToDouble(txtPrecioEPPA.Text);
            EPPA.CantidadEPPA = Convert.ToInt32(txtCantidadEPPA.Text);
            EPPA.IdVentaEPPA = Convert.ToInt32(txtIdVenta.Text);
            EPPA.AñoCosechaEPPA = Convert.ToInt32(txtAñoCosechaEPPA.Text);
            EPPA.FechaVentaEPPA = FechaVentas;
            MessageBox.Show("Datos ingresados correctamente");
           
        }

 

        private void btnGuardarEPPA_Click(object sender, EventArgs e)
        {
            if (EPPA.InsertarDireccion() &&
            EPPA.InsertarSupervisor() &&
            EPPA.InsertarEncuestador() &&
            EPPA.InsertarProductor() &&
            EPPA.InsertarProducto() &&
            EPPA.InsertarCategoria() &&
            EPPA.InsertarPrecio() &&
            EPPA.InsertarVenta()) 
            {
                MessageBox.Show("Ingreso de formulario EPPA correcto");
            }
         else{
                MessageBox.Show("Error en el ingreso");
            }  
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIngresoIAPH ingresoIAPH = new PROYECTO_CATEDRA_MAG.frmIngresoIAPH();
            ingresoIAPH.Show();
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new PROYECTO_CATEDRA_MAG.frmMenu();

            this.Close();
            menu.Visible = true;
        }
    }
}
