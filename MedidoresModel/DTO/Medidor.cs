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
        private int type;
        private List<Lectura> lectura;

        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public int Type { get => type; set => type = value; }
        public List<Lectura> Lectura1 { get => lectura; set => lectura = value; }
    }
}
