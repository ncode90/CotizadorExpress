using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorExpress
{
    public partial class menuPrincipal : Form
    {
        Controlador.ClaseControladora claseControladora = new Controlador.ClaseControladora();
        public menuPrincipal()
        {
            InitializeComponent();
            claseControladora.inicializarTienda();
            claseControladora.inicializarVendedor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nombreTienda.Text = claseControladora.getNombreTienda();
            direccionTienda.Text = claseControladora.getDireccionTienda();
            vendedor.Text = claseControladora.getVendedor();
            actualizarStock();
        }

        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            actualizarStock();
            checkManga.Enabled = true;
            checkCuello.Enabled = true;
            checkChupin.Enabled = false;
        }
        private void radioPantalon_CheckedChanged(object sender, EventArgs e)
        {
            actualizarStock();
            checkManga.Enabled = false;
            checkCuello.Enabled = false;
            checkChupin.Enabled = true;
        }
        private void checkManga_CheckedChanged(object sender, EventArgs e)
        {
            actualizarStock();
        }

        private void checkCuello_CheckedChanged(object sender, EventArgs e)
        {
            actualizarStock();
        }

        private void checkChupin_CheckedChanged(object sender, EventArgs e)
        {
            actualizarStock();
        }
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cantidad.Value) < Int32.Parse(lblStock.Text)) {
                lblCotizacion.Text = claseControladora.iniciarCotizacion(precioUnitario.Value, cantidad.Value, radioCamisa.Checked, checkManga.Checked, checkCuello.Checked, checkChupin.Checked, Premium.Checked).ToString();
            } else {
                MessageBox.Show("No se puede realizar una cotización sobre una cantidad de stock no disponible", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void actualizarStock() {
            int stockReal;
            if (radioCamisa.Checked) {              //Camisa
                if (checkManga.Checked) {           //Manga Corta
                    if (checkCuello.Checked) {      //Cuello mao
                        stockReal = 100;
                    } else {                        //Cuello común
                        stockReal = 150;
                    }
                } else {                            //Manga Larga
                    if (checkCuello.Checked) {      //Cuello mao
                        stockReal = 75;
                    } else {                        //Cuello común
                        stockReal = 175;
                    }
                }
            } else {                                //Pantalon
                if (checkChupin.Checked) {          //Chupín
                    stockReal = 750;
                } else {                            //Común
                    stockReal = 250;
                }
            }
            lblStock.Text = stockReal.ToString();
        }
    }
}
