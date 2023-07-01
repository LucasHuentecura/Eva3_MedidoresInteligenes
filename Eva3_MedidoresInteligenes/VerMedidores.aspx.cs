using MedidoresModel;
using MedidoresModel.DAL;
using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva3_MedidoresInteligenes
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidoresDALObjeto();
        private ITipoMedidorDAL tipoMedidorDAL = new TipoMedidorDALObjeto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            } // End if
        } // End Page_load

        private void cargarGrilla()
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.grillaMedidor.DataSource = medidores;
            this.grillaMedidor.DataBind();
        } // End cargarGrilla

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        } // End GridView1_RowCommand

        protected void ingresarLectura_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresarLectura.aspx");
        }

        protected void ingreseMedidor_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}