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
using MetroFramework.Forms;


//Librerias de GMAP
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;



namespace PROYECTO_CATEDRA_MAG
{
    public partial class frmIngresoIAPH : MetroFramework.Forms.MetroForm
      
    {
        cIsAPH IAPH = new cIsAPH();
        Conexion objCon = new Conexion();
        private SqlCommand insertarUbicacionProduccion;
        private SqlCommand insertarProductores;
        private SqlCommand insertarUbicacionExplotacion;
        private SqlCommand insertarDatosCultivo;



     

        public frmIngresoIAPH()
        {
            InitializeComponent();

        }

        private void frmIngresoIAPH_Load(object sender, EventArgs e)
        {
            txtLatitudIAPH.Text = "13.7299213";
            txtLongitudIAPH.Text = "-89.0454422";

            gmapGeoreferencia.MapProvider = GMapProviders.GoogleTerrainMap;
            gmapGeoreferencia.Position = new PointLatLng(Convert.ToDouble(txtLatitudIAPH.Text), Convert.ToDouble(txtLongitudIAPH.Text));
            gmapGeoreferencia.MinZoom = 1;
            gmapGeoreferencia.MaxZoom = 100;
            gmapGeoreferencia.Zoom = 8;
            gmapGeoreferencia.AutoScroll = true;

            //Arrastrar el mapa por medio del mouse
            gmapGeoreferencia.CanDragMap = true;
            gmapGeoreferencia.DragButton = MouseButtons.Left;

          
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(txtLatitudIAPH.Text), Convert.ToDouble(txtLongitudIAPH.Text)), GMarkerGoogleType.red);
            //   markersOverlay.Markers.Add(marker);
            //  marker.ToolTipText = "Área de las cosechas";
            //  gmapGeoreferencia.Overlays.Add(markersOverlay);

            cmbDepartamentoIAPH.Items.Clear();
            cmbDepartamentoIAPH.Items.Add("Sonsonate");
            cmbDepartamentoIAPH.Items.Add("Ahuachapan");
            cmbDepartamentoIAPH.Items.Add("Santa Ana");
            cmbDepartamentoIAPH.Items.Add("La Libertad");
            cmbDepartamentoIAPH.Items.Add("Chalatenango");
            cmbDepartamentoIAPH.Items.Add("San salvador");
            cmbDepartamentoIAPH.Items.Add("Cuzcatlan");
            cmbDepartamentoIAPH.Items.Add("La Paz");
            cmbDepartamentoIAPH.Items.Add("Cabañas");
            cmbDepartamentoIAPH.Items.Add("Usulutan");
            cmbDepartamentoIAPH.Items.Add("San Miguel");
            cmbDepartamentoIAPH.Items.Add("San Vicente");
            cmbDepartamentoIAPH.Items.Add("Morazan");
            cmbDepartamentoIAPH.Items.Add("La Union");

            cmbExplotacionIAPH.Items.Clear();
            cmbExplotacionIAPH.Items.Add("Sonsonate");
            cmbExplotacionIAPH.Items.Add("Ahuachapan");
            cmbExplotacionIAPH.Items.Add("Santa Ana");
            cmbExplotacionIAPH.Items.Add("La Libertad");
            cmbExplotacionIAPH.Items.Add("Chalatenango");
            cmbExplotacionIAPH.Items.Add("San salvador");
            cmbExplotacionIAPH.Items.Add("Cuzcatlan");
            cmbExplotacionIAPH.Items.Add("La Paz");
            cmbExplotacionIAPH.Items.Add("Cabañas");
            cmbExplotacionIAPH.Items.Add("Usulutan");
            cmbExplotacionIAPH.Items.Add("San Miguel");
            cmbExplotacionIAPH.Items.Add("San Vicente");
            cmbExplotacionIAPH.Items.Add("Morazan");
            cmbExplotacionIAPH.Items.Add("La Union");



        }

        private void btnBuscarCosecha_Click(object sender, EventArgs e)
        {
            if (txtLatitudIAPH.Text!= "")
            {

                gmapGeoreferencia.Position = new PointLatLng(Convert.ToDouble(txtLatitudIAPH.Text), Convert.ToDouble(txtLongitudIAPH.Text));
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(txtLatitudIAPH.Text), Convert.ToDouble(txtLongitudIAPH.Text)), GMarkerGoogleType.red);
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                markersOverlay.Markers.Add(marker);
                 marker.ToolTipText = "Área de las cosechas";
                gmapGeoreferencia.Overlays.Add(markersOverlay);
            }


        }

        private void lbBoletaEPPA_Click(object sender, EventArgs e)
        {

        }

        private void btnCapturarIAPH_Click(object sender, EventArgs e)
        {
            string DepartamentoIAP = cmbDepartamentoIAPH.SelectedItem.ToString();
            string ExplotacionDepartamento = cmbExplotacionIAPH.SelectedItem.ToString();
            IAPH.IdUbicacionProduccionIAPH = txtIdUbicacionProduccion.Text;
            IAPH.DepartamentoIAPH = DepartamentoIAP;
            IAPH.MunicipioIAPH = txtMunicipioIAPH.Text;
            IAPH.CantonIAPH = txtCantonIAPH.Text;
            IAPH.ProductorIAPH = txtProductorIAPH.Text;
            IAPH.ApellidoProductorIAPH = txtApellidoProductorIAPH.Text;
            IAPH.IdProductorIAPH = Convert.ToInt32(txtIdProductorIAPH.Text);
            IAPH.DuiProductorIAPH = txtDuiProductorIAPH.Text;
            IAPH.ExplotacionIAPH = ExplotacionDepartamento;
            IAPH.MunicipioExplotacionIAPH = txtMunicipioExplotacionIAPH.Text;
            IAPH.IdCultivoIAPH = txtIdCultivoIAPH.Text;
            IAPH.CultivoIAPH = txtnomCultivoIAPH.Text;
            IAPH.AreaPlantillaIAPH = Convert.ToDouble(txtPlantillaIAPH.Text);
            IAPH.AreaProduccionIAPH = Convert.ToDouble(txtAreaProduccionIAPH.Text);
            IAPH.NumeroCosechasIAPH = Convert.ToInt32(txtNumCosechasIAPH.Text);
            IAPH.ProduccionIAPH = Convert.ToDouble(txtProduccionIAPH.Text);
            IAPH.RendimientoIAPH = Convert.ToDouble(txtRendimientoIAPH.Text);
            IAPH.NorteIAPH = Convert.ToDouble(txtLatitudIAPH.Text);
            IAPH.OesteIAPH = Convert.ToDouble(txtLongitudIAPH.Text);
            MessageBox.Show("Datos capturados, de click al boton Ingresar para guardar la información");





        }

        private void btnGuardarIAPH_Click(object sender, EventArgs e)
        {
            string ingresarubicacionIAPH;
            string ingresarProductorIAPH;
            string ingresarexplotacionIAPH;
            string ingresardatoscultivosIAPH;

            ingresarubicacionIAPH = "insert into ProduccionesUbicaciones(IdProduccion, Departamento, Municipio, Canton)";
            ingresarubicacionIAPH += "VALUES (@IdProduccion, @Departamento, @Municipio, @Canton)";

            insertarUbicacionProduccion = new SqlCommand(ingresarubicacionIAPH, objCon.conexion);
            insertarUbicacionProduccion.Parameters.Add(new SqlParameter("@IdProduccion", SqlDbType.Char));
            insertarUbicacionProduccion.Parameters["@IdProduccion"].Value = IAPH.IdUbicacionProduccionIAPH;
            insertarUbicacionProduccion.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
            insertarUbicacionProduccion.Parameters["@Departamento"].Value = IAPH.DepartamentoIAPH;
            insertarUbicacionProduccion.Parameters.Add(new SqlParameter("@Municipio", SqlDbType.VarChar));
            insertarUbicacionProduccion.Parameters["@Municipio"].Value = IAPH.MunicipioIAPH;
            insertarUbicacionProduccion.Parameters.Add(new SqlParameter("@Canton", SqlDbType.VarChar));
            insertarUbicacionProduccion.Parameters["@Canton"].Value = IAPH.CantonIAPH;

            ingresarProductorIAPH = "insert into Productores(IdProductor, Nombre, Apellido, DUI)";
            ingresarProductorIAPH += "VALUES (@IdProductor, @Nombre, @Apellido, @DUI)";

            insertarProductores = new SqlCommand(ingresarProductorIAPH, objCon.conexion);
            insertarProductores.Parameters.Add(new SqlParameter("@IdProductor", SqlDbType.Int));
            insertarProductores.Parameters["@IdProductor"].Value = Convert.ToInt32(IAPH.IdProductorIAPH);
            insertarProductores.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            insertarProductores.Parameters["@Nombre"].Value = IAPH.ProductorIAPH;
            insertarProductores.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            insertarProductores.Parameters["@Apellido"].Value = IAPH.ApellidoProductorIAPH;
            insertarProductores.Parameters.Add(new SqlParameter("@DUI", SqlDbType.VarChar));
            insertarProductores.Parameters["@DUI"].Value = IAPH.DuiProductorIAPH;

            ingresarexplotacionIAPH = "insert into DetalleExplotacion(IdProductor, IdProduccion, DepartamentoExplotacion, MunicipioExplotacion)";
            ingresarexplotacionIAPH += "VALUES (@IdProductor, @IdProduccion, @DepartamentoExplotacion, @MunicipioExplotacion)";

            insertarUbicacionExplotacion = new SqlCommand(ingresarexplotacionIAPH, objCon.conexion);
            insertarUbicacionExplotacion.Parameters.Add(new SqlParameter("@IdProductor", SqlDbType.Int));
            insertarUbicacionExplotacion.Parameters["@IdProductor"].Value = Convert.ToInt32(IAPH.IdProductorIAPH);
            insertarUbicacionExplotacion.Parameters.Add(new SqlParameter("@IdProduccion", SqlDbType.Char));
            insertarUbicacionExplotacion.Parameters["@IdProduccion"].Value = IAPH.IdUbicacionProduccionIAPH;
            insertarUbicacionExplotacion.Parameters.Add(new SqlParameter("@DepartamentoExplotacion", SqlDbType.VarChar));
            insertarUbicacionExplotacion.Parameters["@DepartamentoExplotacion"].Value = IAPH.ExplotacionIAPH;
            insertarUbicacionExplotacion.Parameters.Add(new SqlParameter("@MunicipioExplotacion", SqlDbType.VarChar));
            insertarUbicacionExplotacion.Parameters["@MunicipioExplotacion"].Value = IAPH.MunicipioExplotacionIAPH;

            ingresardatoscultivosIAPH = "insert into Cultivos(IdCultivo, NombreCultivo, PlantillaCosecha, ProduccionCosecha, NumeroCosecha, Produccion, Rendimiento, Latitud, Longitud)";
            ingresardatoscultivosIAPH += "VALUES (@IdCultivo, @NombreCultivo, @PlantillaCosecha, @ProduccionCosecha, @NumeroCosecha, @Produccion, @Rendimiento, @Latitud, @Longitud)";

            insertarDatosCultivo = new SqlCommand(ingresardatoscultivosIAPH, objCon.conexion);
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@IdCultivo", SqlDbType.Char));
            insertarDatosCultivo.Parameters["@IdCultivo"].Value = IAPH.IdCultivoIAPH;
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@NombreCultivo", SqlDbType.VarChar));
            insertarDatosCultivo.Parameters["@NombreCultivo"].Value = IAPH.CultivoIAPH;
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@PlantillaCosecha", SqlDbType.Float));
            insertarDatosCultivo.Parameters["@PlantillaCosecha"].Value = IAPH.AreaPlantillaIAPH;
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@ProduccionCosecha", SqlDbType.Float));
            insertarDatosCultivo.Parameters["@ProduccionCosecha"].Value = IAPH.AreaProduccionIAPH;
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@NumeroCosecha", SqlDbType.Int));
            insertarDatosCultivo.Parameters["@NumeroCosecha"].Value = IAPH.NumeroCosechasIAPH;
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@Produccion", SqlDbType.Float));
            insertarDatosCultivo.Parameters["@Produccion"].Value = IAPH.ProduccionIAPH;
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@Rendimiento", SqlDbType.Float));
            insertarDatosCultivo.Parameters["@Rendimiento"].Value = IAPH.RendimientoIAPH;
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@Latitud", SqlDbType.Float));
            insertarDatosCultivo.Parameters["@Latitud"].Value = IAPH.NorteIAPH;
            insertarDatosCultivo.Parameters.Add(new SqlParameter("@Longitud", SqlDbType.Float));
            insertarDatosCultivo.Parameters["@Longitud"].Value = IAPH.OesteIAPH;


            objCon.conexion.Open();

            insertarUbicacionProduccion.ExecuteNonQuery();
            insertarProductores.ExecuteNonQuery();
            insertarUbicacionExplotacion.ExecuteNonQuery();
            insertarDatosCultivo.ExecuteNonQuery();

            MessageBox.Show("Registro Añadido");
            objCon.conexion.Close();


        }

        private void txtDuiProductorIAPH_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
