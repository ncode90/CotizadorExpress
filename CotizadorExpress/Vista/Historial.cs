using CotizadorExpress.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorExpress.Vista
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        internal void cargarDatos(List<Cotizacion> historial)
        {
            dataGridHistorial.AutoGenerateColumns = true;
            dataGridHistorial.DataSource = historial;
        }
    }
}
