using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();   // Interfaz encargada de devolver lista de medidores

        void AgregarMedidores(Medidor medidor);    // Interfaz encargada de agregar un nuevo medidor

    } // End IMedidorDAL
}
