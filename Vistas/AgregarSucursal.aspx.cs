using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        NegocioSucursal negocioSucursal = new NegocioSucursal();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (IsPostBack == false)
            {
                cargarProvincias();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            Sucursal suc = new Sucursal();
            suc.setNombreSucursal(txtNombreSucursal.Text);
            suc.setDescripcionSucursal(txtDescripcion.Text);
            suc.setDireccionSucursal(txtDireccion.Text);
            suc.setId_ProvinciaSucursal(Convert.ToInt32(ddlProvincia.SelectedValue));

            int resultado = negocioSucursal.agregarSucursal(suc);

            if (resultado > 0)
            {
                lblMensaje.Text = "Sucursal agregada con éxito.";
                lblMensaje.ForeColor = Color.Green;
            }
            else
            {
                lblMensaje.Text = "Ocurrió un error al agregar la sucursal.";
                lblMensaje.ForeColor = Color.Red;
            }
            limpiarCampos();



        }

        private void limpiarCampos()
        {
            txtNombreSucursal.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
        }

        private void cargarProvincias()
        {
            DataTable dataTable = negocioSucursal.getTablaProvincias();
            ddlProvincia.DataSource = dataTable;
            ddlProvincia.DataTextField = "DescripcionProvincia";  
            ddlProvincia.DataValueField = "Id_Provincia";     
            ddlProvincia.DataBind();

            ddlProvincia.Items.Insert(0, new ListItem("--Seleccionar provincia--", "0"));

        }
    }
}