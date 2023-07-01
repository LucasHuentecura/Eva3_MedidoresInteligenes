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
    public partial class Default : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidoresDALObjeto();
        private ITipoMedidorDAL tipoMedidorDAL = new TipoMedidorDALObjeto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar la lista con los tipos de medidores
                List<TipoMedidor> tipoMedidores = tipoMedidorDAL.getMedidores();
                this.typeList.DataSource = tipoMedidores;
                this.typeList.DataTextField = "typeTxt";
                this.typeList.DataValueField = "idType";
                this.typeList.DataBind();
            } // End if
        } // End Page_Load

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string serialNumber = this.serialNumberTxt.Text.Trim();    // Número de série
            int type = (int)Convert.ToUInt32(this.typeList.SelectedItem.Value);    // Id del tipo de medidor

            // Crear el Objeto Medidor
            Medidor medidor = new Medidor()
            {
                SerialNumber = serialNumber,
                Type = type
            };

            // Llamar al DAL 
            medidorDAL.AgregarMedidores(medidor);

            // Mostrar mensaje
            this.mensajesLbl.Text = "Medidor Guardado Correctamente";

            // Redireccionar
            Response.Redirect("VerMedidores.aspx");

        } // End agregarBtn_Click
    }
}