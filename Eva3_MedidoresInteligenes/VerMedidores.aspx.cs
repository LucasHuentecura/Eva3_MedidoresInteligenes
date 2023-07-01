using MedidoresModel;
using MedidoresModel.DAL;
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
            if (e.CommandName == "ingresarLectura")
            {
                string serialNumber = Convert.ToString(e.CommandArgument);

                Medidor medidor = medidorDAL.ObtenerMedidores().Find(m => m.SerialNumber == serialNumber);
            }
        } // End GridView1_RowCommand
    }
}