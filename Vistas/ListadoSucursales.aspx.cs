using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        NegocioSucursal negocioSucursal = new NegocioSucursal();
        Sucursal sucursal = new Sucursal();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (IsPostBack == false)
            {
                cargarGridView();
            }
        }

        public void cargarGridView()
        {
            DataTable dataTable = negocioSucursal.getTabla();
            gvSucursales.DataSource = dataTable;
            gvSucursales.DataBind();
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            cargarGridView();
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txtIdSucursal.Text = "";
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtIdSucursal.Text != "")
            {
                // 1. Cargar el ID en el objeto sucursal
                sucursal.setId_Sucursal(Convert.ToInt32(txtIdSucursal.Text));

                // 2. Llamar al negocio y obtener el resultado
                DataTable tablaFiltrada = negocioSucursal.ObtenerSucursalPorId(sucursal);

                // 3. Mostrar resultado en el GridView
                gvSucursales.DataSource = tablaFiltrada;
                gvSucursales.DataBind();

                LimpiarCampos();

            }
        }
    }
}