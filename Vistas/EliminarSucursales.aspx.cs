using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idSucursal = Convert.ToInt32(txtIdSucursal.Text);

            NegocioSucursal negocio = new NegocioSucursal();

            bool eliminado = negocio.eliminarCategoria(idSucursal);

            if (eliminado == true)
            {
                lblMensaje.Text = "La sucursal se ha eliminado con éxito.";
                LimpiarCampos();
                lblMensaje.ForeColor = Color.Green;
            }

            else
            {
                lblMensaje.Text = "No se encontró una sucursal con ese ID.";
                lblMensaje.ForeColor = Color.Red;
            }

            
        }

        public void LimpiarCampos()
        {
            txtIdSucursal.Text = "";
        }
    }
}