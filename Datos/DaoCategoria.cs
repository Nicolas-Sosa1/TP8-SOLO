using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoCategoria
    {
        Conexion conexion = new Conexion();

        public DataTable getTablaSucursal()
        {
            DataTable dataTable = conexion.ObtenerTabla("Sucursal", "SELECT * FROM Sucursal");
            return dataTable;
        }

        public DataTable getTablaProvincias()
        {
            DataTable dataTable = conexion.ObtenerTabla("Provincia", "SELECT * FROM Provincia");
            return dataTable;
        }

        private void ArmarParametrosBuscarCategoria(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            SqlParametros.Value = sucursal.getId_Sucursal();
           
        }
        private void ArmarParametrosCategoriaEliminar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            SqlParametros.Value = sucursal.getId_Sucursal();
        }

        private void ArmarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.getNombreSucursal();
            SqlParametros = Comando.Parameters.Add("@DescripcionSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.getDescripcionSucursal();
            SqlParametros = Comando.Parameters.Add("@Id_ProvinciaSucursal", SqlDbType.Int);
            SqlParametros.Value = sucursal.getId_ProvinciaSucursal();
            SqlParametros = Comando.Parameters.Add("@DireccionSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.getDireccionSucursal();

        }

        public int agregarSucursal(Sucursal sucursal)
        {

            sucursal.setId_Sucursal(conexion.ObtenerMaximo("SELECT max(Id_Sucursal) FROM Sucursal") + 1);
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, sucursal);
            return conexion.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }
        public DataTable BuscarSucursalPorId(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosBuscarCategoria(ref comando, sucursal);
            return conexion.ObtenerTablaBuscar(comando, "spBuscarIdSucursal");
        }
        public int EliminarSucursal(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosCategoriaEliminar(ref comando, sucursal);
            return conexion.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }

        /*
         CREATE PROCEDURE spBuscarIdSucursal
         @Id_Sucursal INT
         AS
         BEGIN
         SELECT * FROM Sucursal WHERE Id_Sucursal = @Id_Sucursal;
         END
         */



        /*
         CREATE PROCEDURE spEliminarSucursal
         @Id_Sucursal INT
         AS
         BEGIN
          DELETE FROM Sucursal WHERE Id_Sucursal = @Id_Sucursal;
         END
         */



        /*
        CREATE PROCEDURE spAgregarSucursal
        @NombreSucursal VARCHAR(50),
        @DescripcionSucursal VARCHAR(100),
        @DireccionSucursal VARCHAR(100),
        @Id_ProvinciaSucursal INT
        AS
        BEGIN
        INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, DireccionSucursal, Id_ProvinciaSucursal)
        VALUES (@NombreSucursal, @DescripcionSucursal, @DireccionSucursal, @Id_ProvinciaSucursal)
        END
         */



    }
}
