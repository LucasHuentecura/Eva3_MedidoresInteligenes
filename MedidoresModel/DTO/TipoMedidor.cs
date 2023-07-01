using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class TipoMedidor
    {
        private int idType;
        private string typeTxt;

        public int IdType { get => idType; set => idType = value; }
        public string TypeTxt { get => typeTxt; set => typeTxt = value; }

    }
}
