using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.Modelo
{
    class Vendedor
    {
        public string nombre;
        public string apellido;
        public string codigo;
        public List<Cotizacion> historial = new List<Cotizacion>();

        public decimal cotizar(decimal pUnitario, decimal cant, bool camisa, bool mangaCorta, bool cuelloMao, bool chupin, bool premium)
        {
            decimal resultado = pUnitario * cant;
            if (camisa) {                                               // Camisa
                if (mangaCorta) {                                       // Manga Corta -10%
                    resultado = resultado - (resultado * 10) / 100;
                }
                if (cuelloMao) {                                        // Cuello Mao +3%
                    resultado = resultado + (resultado * 3) / 100;
                }
            } else {                                                    // Pantalón
                if (chupin) {                                           // Chupín -12%
                    resultado = resultado - (resultado * 12) / 100;
                }
            }
            if (premium) {                                              // Premium +30%
                resultado = resultado + (resultado * 30) / 100;
            }

            historial.Add(new Cotizacion(DateTime.Today, codigo, camisa ? "Camisa" : "Pantalón", Convert.ToInt32(cant), resultado));
            return resultado;
        }
    }

}
