using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class MedidoresDALObjeto : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();  // Lista de medidores

        public void AgregarMedidores(Medidor medidor)
        {
            medidores.Add(medidor); // Agregar medidor a la lista
        } // End AgregarMedidores

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;   // Devolver lista de medidores
        } // End ObtenerMedidores

    } // End MedidorDALObjeto
}
