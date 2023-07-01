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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidoresDALObjeto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarMedidores();
                configurarASPCalendar();
                cargarHora();
                cargarMinutos();
            } // End if
        } // End Page_Load

        private void cargarMedidores()
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.medidoresList.DataSource = medidores;
            this.medidoresList.DataTextField = "serialNumber";
            this.medidoresList.DataTextField = "serialNumber";
            this.medidoresList.DataBind();
        } // End cargarMedidores

        private void configurarASPCalendar()
        {
            this.Calendar1.VisibleDate = DateTime.Today;
            this.Calendar1.SelectedDate = DateTime.Today;
            this.Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Blue;
        }

        private void cargarHora()
        {
            // Agrega las horas al DropDownList de horas
            for (int i = 0; i < 24; i++)
            {
                this.horaList.Items.Add(new ListItem(i.ToString("00"), i.ToString()));
            }
        } // End cargarHora

        private void cargarMinutos()
        {
            // Agrega los minutos al DropDownList de minutos
            for (int i = 0; i < 60; i++)
            {
                this.minutosList.Items.Add(new ListItem(i.ToString("00"), i.ToString()));
            }
        } // End cargarMinutos

        protected void guardarLectura_Click(object sender, EventArgs e)
        {
            if (!validateData()) return;

            Medidor medidor = medidorDAL.ObtenerMedidores().Find(m => m.SerialNumber == this.medidoresList.SelectedItem.Value);

            string hora = horaList.SelectedItem.Text;
            int horaSeleccionada;
            if (int.TryParse(hora, out horaSeleccionada))
            {
            }

            string minuto = minutosList.SelectedItem.Text;
            int minutoSeleccionado;
            if (int.TryParse(minuto, out minutoSeleccionado))
            {
            }

            Lectura lectura = new Lectura()
            {
                
            };

            medidor.Lectura = lectura;

            Response.Redirect("VerMedidores.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private bool validateData()
        {
            // Validar medidor
            if (medidoresList.SelectedValue.Equals("Seleccione un medidor"))
            {
                this.mensajesLbl.Text = "Seleccione un medidor";
                return false;
            }
            this.mensajesLbl.Text = "";

            double consumo;
            // Validar consumo
            if (!double.TryParse(this.consumoTxt.Text, out consumo))
            {
                this.mensajeConsumo.Text = "Ingrese un consumo Válido";
                return false;
            }
            this.consumoTxt.Text = "";


            return true;
        }
    }
}