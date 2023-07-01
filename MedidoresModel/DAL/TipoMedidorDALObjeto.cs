using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class TipoMedidorDALObjeto : ITipoMedidorDAL
    {

        public List<TipoMedidor> getMedidores()
        {
            return new List<TipoMedidor> {
                new TipoMedidor(){
                    IdType = 1,
                    TypeTxt = "Casa Particular"
                },
                new TipoMedidor()
                {
                    IdType = 2,
                    TypeTxt = "Empresa"
                }
            };
        }
    }
}
