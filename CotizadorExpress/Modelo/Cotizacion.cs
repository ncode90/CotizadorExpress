using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.Modelo
{
    class Cotizacion
    {
        static int idCount = 0;
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public String codigoVendedor { get; set; }
        public String prenda { get; set; }
        public int cantidad { get; set; }
        public decimal resultado { get; set; }

        public Cotizacion(DateTime fecha, string codigoVendedor, string prenda, int cantidad, decimal resultado)
        {
            this.id = idCount++;
            this.fecha = fecha;
            this.codigoVendedor = codigoVendedor;
            this.prenda = prenda;
            this.cantidad = cantidad;
            this.resultado = resultado;
        }
    }
}
