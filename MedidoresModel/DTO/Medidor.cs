using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Medidor
    {
        private string serialNumber;
        private string type;
        private Lectura lectura;

        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Type { get => type; set => type = value; }
        public Lectura Lectura { get => lectura; set => lectura = value; }
    }
}
