using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturasDALObjeto : ILecturaDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();    // Lista de lecturas

        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);  // Agregar lectura a la lista
        } // End AgregarLectura

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;    // Devolver lista de lecturas
        } // End ObtenerLecturas

    } // End LecturasDALObjeto
}
