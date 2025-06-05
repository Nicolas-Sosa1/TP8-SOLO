using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NegocioSucursal
    {
        public DataTable getTabla()
        {
            DaoCategoria dao = new DaoCategoria();
            return dao.getTablaSucursal();
        }

        public DataTable getTablaProvincias()
        {
            DaoCategoria dao = new DaoCategoria();
            return dao.getTablaProvincias();
        }

        public DataTable ObtenerSucursalPorId(Sucursal sucursal)
        {
            DaoCategoria dao = new DaoCategoria();
            return dao.BuscarSucursalPorId(sucursal);
        }

        public bool eliminarCategoria(int id)
        {
            //Validar id existente 
            DaoCategoria dao = new DaoCategoria();
            Sucursal sucursal = new Sucursal();
            sucursal.setId_Sucursal(id);
            int op = dao.EliminarSucursal(sucursal);
            if (op == 1)
                return true;
            else
                return false;
        }

        public int agregarSucursal(Sucursal suc)
        {
            DaoCategoria dao = new DaoCategoria();
            return dao.agregarSucursal(suc);
        }
    }
}
