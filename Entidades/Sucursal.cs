using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int Id_Sucursal;
        private string NombreSucursal;
        private string DescripcionSucursal;
        private int Id_ProvinciaSucursal;
        private string DireccionSucursal;

        public Sucursal(){

        }
        //setters
        public void setId_Sucursal(int id_Sucursal)
        {
            Id_Sucursal = id_Sucursal;
        }
        public void setNombreSucursal(string nombreSucursal)
        {
            NombreSucursal = nombreSucursal;
        }
        public void setDescripcionSucursal(string descripcionSucursal)
        {
            DescripcionSucursal = descripcionSucursal;
        }
        public void setId_ProvinciaSucursal(int id_ProvinciaSucursal)
        {
            Id_ProvinciaSucursal = id_ProvinciaSucursal;
        }
        public void setDireccionSucursal(string direccionSucursal)
        {
            DireccionSucursal = direccionSucursal;
        }

        //getters
        public int getId_Sucursal()
        {
            return Id_Sucursal;
        }
        public string getNombreSucursal()
        {
            return NombreSucursal;
        }
        public string getDescripcionSucursal()
        {
            return DescripcionSucursal;
        }
        public int getId_ProvinciaSucursal()
        {
            return Id_ProvinciaSucursal; 
        }
        public string getDireccionSucursal()
        {
            return DireccionSucursal;
        }

    }
}

