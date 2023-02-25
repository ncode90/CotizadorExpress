using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorExpress.Controlador
{

    class ClaseControladora
    {
        Modelo.Tienda tienda = new Modelo.Tienda();
        Modelo.Vendedor vendedor = new Modelo.Vendedor();
        public ClaseControladora()
        {

        }

        // Crea el objeto Tienda con datos ficticios
        public void inicializarTienda()
        {
            tienda.nombre = "El chanchito feliz";
            tienda.direccion = "Calle Wallaby, 42, Sidney";
            //tienda.listado.Add();
        }

        // Crea el objeto Vendedor con datos ficticios
        public void inicializarVendedor()
        {
            vendedor.nombre = "James";
            vendedor.apellido = "Bond";
            vendedor.codigo = "007";
        }

        // Devuelve datos necesarios para cargar el Menu Principal
        internal String getNombreTienda() {return (tienda.nombre); }
        internal string getDireccionTienda() { return (tienda.direccion); }
        internal string getVendedor() { return (vendedor.nombre + " " + vendedor.apellido + " | " + vendedor.codigo); }

        public decimal iniciarCotizacion(decimal pUnitario, decimal cant, bool camisa, bool mangaCorta, bool cuelloMao, bool chupin, bool premium)
        {
            return vendedor.cotizar(pUnitario, cant, camisa, mangaCorta, cuelloMao, chupin, premium);
        }
    }
}
