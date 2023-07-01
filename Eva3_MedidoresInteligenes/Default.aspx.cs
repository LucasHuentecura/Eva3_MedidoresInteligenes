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
                this.typeList.DataValueField = "typeTxt";
                this.typeList.DataBind();
            } // End if
        } // End Page_Load

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            if (!validateData()) return;
            // Obtener datos del formulario
            string serialNumber = this.serialNumberTxt.Text.Trim();    // Número de série
            string type = this.typeList.SelectedValue;

            // Crear el Objeto Medidor
            Medidor medidor = new Medidor()
            {
                SerialNumber = serialNumber,
                Type = type
            };

            // Llamar al DAL 
            medidorDAL.AgregarMedidores(medidor);

            // Redireccionar
            Response.Redirect("VerMedidores.aspx");

        } // End agregarBtn_Click

        private bool validateData()
        {
            // Validar Número de Série
            if (this.serialNumberTxt.Text == "")
            {
                this.mensajesLbl.Text = "Ingrese un número de Série";
                return false;
            }

            // Validar tipo de medidor
            if (typeList.SelectedValue.Equals("Seleccione una opción"))
            {
                this.mensajesLbl.Text = "Seleccione el tipo de medidor";
                return false;
            }
            return true;
        }
    }
}