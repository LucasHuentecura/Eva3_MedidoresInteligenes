using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILectura
    {
        List<Lectura> ObtenerLecturas();    // Interfaz encargada de devolver la lista de Lecturas

        void AgregarLectura(Lectura lectura);  // Interfaz encargada de agregar una nueva lectura

    } // End ILectura
}
