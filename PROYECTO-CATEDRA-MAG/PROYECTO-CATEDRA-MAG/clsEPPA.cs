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


namespace PROYECTO_CATEDRA_MAG
{
    public class clsEPPA: Conexion  {

        private int idDireccion;
        private string departamentoEPPA;
        private string municipioEPPA;
        private string cantonEPPA;

        private int codigoSupervisorEPPA;
        private string nombreSupervisorEPPA;
        private string apellidoSupervisorEPPA;
        private string duiSupervisorEPPA;

        private int codigoEncuestadorEPPA;
        private string nombreEncuestadorEPPA;
        private string apellidoEncuestadorEPPA;
        private string duiEncuestadorEPPA;

        private int idProductorEPPA;
        private string nombreProductorEPPA;
        private string apellidoProductorEPPA;
        private string duiProductorEPPA;
        private string nombreProductoEPPA;


        private int codigoProductoEPPA;

        private int codigoTipoProductoEPPA;
        private string nombreTipoProductoEPPA;


        private string canalVentaEPPA;


        private string idprecioEPPA;
        private int cantidadEPPA;
        private string unidadMedidaEPPA;

        private int idVentaEPPA;
        private string fechaVentaEPPA;
        private int añoCosechaEPPA;
      
        private string lugarVentaEPPA;
        private double precioEPPA;


        public int IdDireccion
        {
            get
            {
                return idDireccion;
            }

            set
            {
                idDireccion = value;
            }
        }

        public string DepartamentoEPPA
        {
            get
            {
                return departamentoEPPA;
            }

            set
            {
                departamentoEPPA = value;
            }
        }

        public string MunicipioEPPA
        {
            get
            {
                return municipioEPPA;
            }

            set
            {
                municipioEPPA = value;
            }
        }

        public string CantonEPPA
        {
            get
            {
                return cantonEPPA;
            }

            set
            {
                cantonEPPA = value;
            }
        }

        public string NombreSupervisorEPPA
        {
            get
            {
                return nombreSupervisorEPPA;
            }

            set
            {
                nombreSupervisorEPPA = value;
            }
        }

        public int CodigoSupervisorEPPA
        {
            get
            {
                return codigoSupervisorEPPA;
            }

            set
            {
                codigoSupervisorEPPA = value;
            }
        }

        public string ApellidoSupervisorEPPA
        {
            get
            {
                return apellidoSupervisorEPPA;
            }

            set
            {
                apellidoSupervisorEPPA = value;
            }
        }

        public string DuiSupervisorEPPA
        {
            get
            {
                return duiSupervisorEPPA;
            }

            set
            {
                duiSupervisorEPPA = value;
            }
        }

        public string NombreEncuestadorEPPA
        {
            get
            {
                return nombreEncuestadorEPPA;
            }

            set
            {
                nombreEncuestadorEPPA = value;
            }
        }

        public string ApellidoEncuestadorEPPA
        {
            get
            {
                return apellidoEncuestadorEPPA;
            }

            set
            {
                apellidoEncuestadorEPPA = value;
            }
        }

        public string DuiEncuestadorEPPA
        {
            get
            {
                return duiEncuestadorEPPA;
            }

            set
            {
                duiEncuestadorEPPA = value;
            }
        }

        public int CodigoEncuestadorEPPA
        {
            get
            {
                return codigoEncuestadorEPPA;
            }

            set
            {
                codigoEncuestadorEPPA = value;
            }
        }

        public int IdProductorEPPA
        {
            get
            {
                return idProductorEPPA;
            }

            set
            {
                idProductorEPPA = value;
            }
        }

        public string NombreProductorEPPA
        {
            get
            {
                return nombreProductorEPPA;
            }

            set
            {
                nombreProductorEPPA = value;
            }
        }

        public string ApellidoProductorEPPA
        {
            get
            {
                return apellidoProductorEPPA;
            }

            set
            {
                apellidoProductorEPPA = value;
            }
        }

        public string DuiProductorEPPA
        {
            get
            {
                return duiProductorEPPA;
            }

            set
            {
                duiProductorEPPA = value;
            }
        }

        public string NombreProductoEPPA
        {
            get
            {
                return nombreProductoEPPA;
            }

            set
            {
                nombreProductoEPPA = value;
            }
        }

        public int CodigoProductoEPPA
        {
            get
            {
                return codigoProductoEPPA;
            }

            set
            {
                codigoProductoEPPA = value;
            }
        }

        public string NombreTipoProductoEPPA
        {
            get
            {
                return nombreTipoProductoEPPA;
            }

            set
            {
                nombreTipoProductoEPPA = value;
            }
        }

        public int CodigoTipoProductoEPPA
        {
            get
            {
                return codigoTipoProductoEPPA;
            }

            set
            {
                codigoTipoProductoEPPA = value;
            }
        }

        public string UnidadMedidaEPPA
        {
            get
            {
                return unidadMedidaEPPA;
            }

            set
            {
                unidadMedidaEPPA = value;
            }
        }

        public string CanalVentaEPPA
        {
            get
            {
                return canalVentaEPPA;
            }

            set
            {
                canalVentaEPPA = value;
            }
        }

        public string IdprecioEPPA
        {
            get
            {
                return idprecioEPPA;
            }

            set
            {
                idprecioEPPA = value;
            }
        }

        public int CantidadEPPA
        {
            get
            {
                return cantidadEPPA;
            }

            set
            {
                cantidadEPPA = value;
            }
        }

        public int IdVentaEPPA
        {
            get
            {
                return idVentaEPPA;
            }

            set
            {
                idVentaEPPA = value;
            }
        }

        public int AñoCosechaEPPA
        {
            get
            {
                return añoCosechaEPPA;
            }

            set
            {
                añoCosechaEPPA = value;
            }
        }

        public string FechaVentaEPPA
        {
            get
            {
                return fechaVentaEPPA;
            }

            set
            {
                fechaVentaEPPA = value;
            }
        }

        public string LugarVentaEPPA
        {
            get
            {
                return lugarVentaEPPA;
            }

            set
            {
                lugarVentaEPPA = value;
            }
        }

        public double PrecioEPPA
        {
            get
            {
                return precioEPPA;
            }

            set
            {
                precioEPPA = value;
            }
        }



        public bool InsertarDireccion()
        {
            try {
                string instruccion;
                instruccion = "INSERT INTO Direcciones(IdDireccion, Departamento, Municipio, Canton)";
                instruccion  += "VALUES (@Iddireccion, @Departamento, @Municipio, @Canton)";

                cmd= new SqlCommand(instruccion ,conexion);
                cmd.Parameters.Add(new SqlParameter("@IdDireccion", SqlDbType.Int));
                cmd.Parameters["@Iddireccion"].Value = idDireccion;
                cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
                cmd.Parameters["@Departamento"].Value = departamentoEPPA;
                cmd.Parameters.Add(new SqlParameter("@Municipio", SqlDbType.VarChar));
                cmd.Parameters["@Municipio"].Value = municipioEPPA;
                cmd.Parameters.Add(new SqlParameter("@Canton", SqlDbType.VarChar));
                cmd.Parameters["@Canton"].Value = cantonEPPA;
                conexion.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
             
                return false;
            }
        }

        public bool InsertarSupervisor() {
            try
            {
                string instruccion;
            
               instruccion= "INSERT INTO Usuarios(IdUsuario, Nombre, Apellido, DUI, TipoUsuario)";
               instruccion  += "VALUES (@IdUsuario, @Nombre, @Apellido, @DUI, @TipoUsuario)";

                cmd = new SqlCommand(instruccion, conexion);
                cmd.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int));
                cmd.Parameters["@IdUsuario"].Value = codigoSupervisorEPPA;
                cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                cmd.Parameters["@Nombre"].Value = nombreSupervisorEPPA;
                cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                cmd.Parameters["@Apellido"].Value = apellidoSupervisorEPPA;
                cmd.Parameters.Add(new SqlParameter("@DUI", SqlDbType.VarChar));
                cmd.Parameters["@DUI"].Value = duiSupervisorEPPA;
                cmd.Parameters.Add(new SqlParameter("@TipoUsuario", SqlDbType.VarChar));
                cmd.Parameters["@TipoUsuario"].Value = "S";
                conexion.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool InsertarEncuestador() {
            try {
                string instruccion;

                instruccion = "INSERT INTO Usuarios(IdUsuario, Nombre, Apellido, DUI, TipoUsuario)";
                instruccion += "VALUES (@IdUsuario, @Nombre, @Apellido, @DUI, @TipoUsuario)";

                cmd = new SqlCommand(instruccion,conexion);
                cmd.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int));
                cmd.Parameters["@IdUsuario"].Value = codigoEncuestadorEPPA;
                cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                cmd.Parameters["@Nombre"].Value = nombreEncuestadorEPPA;
                cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                cmd.Parameters["@Apellido"].Value = apellidoEncuestadorEPPA;
                cmd.Parameters.Add(new SqlParameter("@DUI", SqlDbType.VarChar));
                cmd.Parameters["@DUI"].Value = duiEncuestadorEPPA;
                cmd.Parameters.Add(new SqlParameter("@TipoUsuario", SqlDbType.VarChar));
                cmd.Parameters["@TipoUsuario"].Value = "E";
                conexion.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool InsertarProductor()
        {
            try
            {
                string instruccion;
                instruccion = "INSERT into Productores(IdProductor, Nombre, Apellido, DUI)";
                instruccion += "VALUES (@IdProductor, @Nombre, @Apellido, @DUI)";
               cmd = new SqlCommand(instruccion, conexion);
               cmd.Parameters.Add(new SqlParameter("@IdProductor", SqlDbType.Int));
                cmd.Parameters["@IdProductor"].Value = -idProductorEPPA;
               cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
               cmd.Parameters["@Nombre"].Value = nombreProductorEPPA;
               cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
               cmd.Parameters["@Apellido"].Value = apellidoProductorEPPA;
               cmd.Parameters.Add(new SqlParameter("@DUI", SqlDbType.VarChar));
               cmd.Parameters["@DUI"].Value = duiProductorEPPA;
               conexion.Open();
               cmd.ExecuteNonQuery();
               cmd.Parameters.Clear();
               conexion.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool InsertarProducto()
        {
            try {
                string instruccion;
               instruccion = "INSERT INTO Productos(IdProducto, Nombre)";
               instruccion += "VALUES (@IdProducto, @Nombre)";
               cmd = new SqlCommand(instruccion, conexion);
               cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int));
               cmd.Parameters["@IdProducto"].Value = codigoProductoEPPA;
               cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
               cmd.Parameters["@Nombre"].Value = nombreProductoEPPA;
               conexion.Open();
               cmd.ExecuteNonQuery();
               cmd.Parameters.Clear();
               conexion.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool InsertarCategoria()
        {
            try {
               string instruccion;
               instruccion = "INSERT INTO Categorias(IdCategoria, Clasificacion)";
               instruccion += "VALUES (@IdCategoria, @Clasificacion)";
               cmd = new SqlCommand(instruccion, conexion);
               cmd.Parameters.Add(new SqlParameter("@IdCategoria", SqlDbType.Int));
               cmd.Parameters["@IdCategoria"].Value = codigoTipoProductoEPPA;
               cmd.Parameters.Add(new SqlParameter("@Clasificacion", SqlDbType.VarChar));
               cmd.Parameters["@Clasificacion"].Value = nombreTipoProductoEPPA;
               conexion.Open();
               cmd.ExecuteNonQuery();
               cmd.Parameters.Clear();
               conexion.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool InsertarPrecio()
        {
            try
            {
                string instruccion;

                instruccion = "insert into Precios(IdPrecio, IdProducto, Unidad, Precio, Cantidad)";
                instruccion += "VALUES (@IdPrecio, @IdProducto, @Unidad, @Precio, @Cantidad)";

                cmd = new SqlCommand(instruccion,conexion);
                cmd.Parameters.Add(new SqlParameter("@IdPrecio", SqlDbType.Char));
                cmd.Parameters["@IdPrecio"].Value = idprecioEPPA;
                cmd.Parameters.Add(new SqlParameter("@IdProducto", SqlDbType.Int));
                cmd.Parameters["@IdProducto"].Value =codigoProductoEPPA;
                cmd.Parameters.Add(new SqlParameter("@Unidad", SqlDbType.VarChar));
                cmd.Parameters["@Unidad"].Value = unidadMedidaEPPA;
                cmd.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Float));
                cmd.Parameters["@Precio"].Value = precioEPPA;
                cmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int));
                cmd.Parameters["@Cantidad"].Value = cantidadEPPA;
                conexion.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool InsertarVenta()
        {
            try
            {
                string instruccion;

                instruccion = "insert into Ventas (IdVenta, Fecha, FechaCosecha, IdPrecio, LugarVenta, Canal)";
                instruccion += "VALUES (@IdVenta, @Fecha, @FechaCosecha, @IdPrecio, @LugarVenta, @Canal)";
               cmd = new SqlCommand(instruccion, conexion);
               cmd.Parameters.Add(new SqlParameter("@IdVenta", SqlDbType.Int));
               cmd.Parameters["@IdVenta"].Value = idVentaEPPA;
               cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.VarChar));
               cmd.Parameters["@Fecha"].Value = fechaVentaEPPA;
               cmd.Parameters.Add(new SqlParameter("@FechaCosecha", SqlDbType.Int));
               cmd.Parameters["@FechaCosecha"].Value = añoCosechaEPPA;
               cmd.Parameters.Add(new SqlParameter("@IdPrecio", SqlDbType.Char));
               cmd.Parameters["@IdPrecio"].Value = idprecioEPPA;
               cmd.Parameters.Add(new SqlParameter("@LugarVenta", SqlDbType.VarChar));
               cmd.Parameters["@LugarVenta"].Value = lugarVentaEPPA;
               cmd.Parameters.Add(new SqlParameter("@Canal", SqlDbType.VarChar));
               cmd.Parameters["@Canal"].Value = canalVentaEPPA;
               conexion.Open();
               cmd.ExecuteNonQuery();
               cmd.Parameters.Clear();
               conexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
