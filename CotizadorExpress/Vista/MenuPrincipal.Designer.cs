
namespace CotizadorExpress
{
    partial class menuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.LinkLabel historial;
            this.nombreTienda = new System.Windows.Forms.Label();
            this.direccionTienda = new System.Windows.Forms.Label();
            this.vendedor = new System.Windows.Forms.Label();
            this.prendaBox = new System.Windows.Forms.GroupBox();
            this.checkChupin = new System.Windows.Forms.CheckBox();
            this.checkCuello = new System.Windows.Forms.CheckBox();
            this.checkManga = new System.Windows.Forms.CheckBox();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.prendaLine = new System.Windows.Forms.Label();
            this.calidadBox = new System.Windows.Forms.GroupBox();
            this.Premium = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.boxPrecioCantidad = new System.Windows.Forms.GroupBox();
            this.precioUnitario = new System.Windows.Forms.NumericUpDown();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dollarSign = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.dollarSignCotizacion = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            historial = new System.Windows.Forms.LinkLabel();
            this.prendaBox.SuspendLayout();
            this.calidadBox.SuspendLayout();
            this.boxPrecioCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // historial
            // 
            historial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            historial.Location = new System.Drawing.Point(358, 35);
            historial.Name = "historial";
            historial.Size = new System.Drawing.Size(110, 23);
            historial.TabIndex = 3;
            historial.TabStop = true;
            historial.Text = "Historial Cotizaciones";
            historial.TextAlign = System.Drawing.ContentAlignment.TopRight;
            historial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.historial_LinkClicked);
            // 
            // nombreTienda
            // 
            this.nombreTienda.AutoSize = true;
            this.nombreTienda.Location = new System.Drawing.Point(12, 9);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(80, 13);
            this.nombreTienda.TabIndex = 0;
            this.nombreTienda.Text = "Nombre Tienda";
            // 
            // direccionTienda
            // 
            this.direccionTienda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionTienda.Location = new System.Drawing.Point(98, 9);
            this.direccionTienda.Name = "direccionTienda";
            this.direccionTienda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.direccionTienda.Size = new System.Drawing.Size(373, 23);
            this.direccionTienda.TabIndex = 1;
            this.direccionTienda.Text = "Dirección de la Tienda";
            // 
            // vendedor
            // 
            this.vendedor.AutoSize = true;
            this.vendedor.Location = new System.Drawing.Point(12, 35);
            this.vendedor.Name = "vendedor";
            this.vendedor.Size = new System.Drawing.Size(231, 13);
            this.vendedor.TabIndex = 2;
            this.vendedor.Text = "Nombre y Apellido Vendedor | Código Vendedor";
            // 
            // prendaBox
            // 
            this.prendaBox.Controls.Add(this.checkChupin);
            this.prendaBox.Controls.Add(this.checkCuello);
            this.prendaBox.Controls.Add(this.checkManga);
            this.prendaBox.Controls.Add(this.radioPantalon);
            this.prendaBox.Controls.Add(this.radioCamisa);
            this.prendaBox.Controls.Add(this.prendaLine);
            this.prendaBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prendaBox.Location = new System.Drawing.Point(15, 77);
            this.prendaBox.Name = "prendaBox";
            this.prendaBox.Size = new System.Drawing.Size(444, 92);
            this.prendaBox.TabIndex = 5;
            this.prendaBox.TabStop = false;
            this.prendaBox.Text = "Prenda";
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Enabled = false;
            this.checkChupin.Location = new System.Drawing.Point(127, 61);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(61, 17);
            this.checkChupin.TabIndex = 5;
            this.checkChupin.Text = "Chupín";
            this.checkChupin.UseVisualStyleBackColor = true;
            this.checkChupin.CheckedChanged += new System.EventHandler(this.checkChupin_CheckedChanged);
            // 
            // checkCuello
            // 
            this.checkCuello.AutoSize = true;
            this.checkCuello.Location = new System.Drawing.Point(279, 25);
            this.checkCuello.Name = "checkCuello";
            this.checkCuello.Size = new System.Drawing.Size(79, 17);
            this.checkCuello.TabIndex = 4;
            this.checkCuello.Text = "Cuello Mao";
            this.checkCuello.UseVisualStyleBackColor = true;
            this.checkCuello.CheckedChanged += new System.EventHandler(this.checkCuello_CheckedChanged);
            // 
            // checkManga
            // 
            this.checkManga.AutoSize = true;
            this.checkManga.Location = new System.Drawing.Point(127, 26);
            this.checkManga.Name = "checkManga";
            this.checkManga.Size = new System.Drawing.Size(87, 17);
            this.checkManga.TabIndex = 3;
            this.checkManga.Text = "Manga Corta";
            this.checkManga.UseVisualStyleBackColor = true;
            this.checkManga.CheckedChanged += new System.EventHandler(this.checkManga_CheckedChanged);
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Location = new System.Drawing.Point(7, 60);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioPantalon.TabIndex = 2;
            this.radioPantalon.TabStop = true;
            this.radioPantalon.Text = "Pantalón";
            this.radioPantalon.UseVisualStyleBackColor = true;
            this.radioPantalon.CheckedChanged += new System.EventHandler(this.radioPantalon_CheckedChanged);
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Checked = true;
            this.radioCamisa.Location = new System.Drawing.Point(7, 25);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioCamisa.TabIndex = 1;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            this.radioCamisa.CheckedChanged += new System.EventHandler(this.radioCamisa_CheckedChanged);
            // 
            // prendaLine
            // 
            this.prendaLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prendaLine.Location = new System.Drawing.Point(7, 50);
            this.prendaLine.Name = "prendaLine";
            this.prendaLine.Size = new System.Drawing.Size(430, 2);
            this.prendaLine.TabIndex = 0;
            // 
            // calidadBox
            // 
            this.calidadBox.Controls.Add(this.Premium);
            this.calidadBox.Controls.Add(this.radioStandard);
            this.calidadBox.Location = new System.Drawing.Point(15, 225);
            this.calidadBox.Name = "calidadBox";
            this.calidadBox.Size = new System.Drawing.Size(158, 69);
            this.calidadBox.TabIndex = 6;
            this.calidadBox.TabStop = false;
            this.calidadBox.Text = "Calidad de Prenda";
            // 
            // Premium
            // 
            this.Premium.AutoSize = true;
            this.Premium.Location = new System.Drawing.Point(83, 30);
            this.Premium.Name = "Premium";
            this.Premium.Size = new System.Drawing.Size(65, 17);
            this.Premium.TabIndex = 1;
            this.Premium.TabStop = true;
            this.Premium.Text = "Premium";
            this.Premium.UseVisualStyleBackColor = true;
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Checked = true;
            this.radioStandard.Location = new System.Drawing.Point(9, 30);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(68, 17);
            this.radioStandard.TabIndex = 0;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(12, 189);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(110, 13);
            this.lblUnidades.TabIndex = 7;
            this.lblUnidades.Text = "Unidades disponibles:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(119, 189);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(19, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "__";
            // 
            // boxPrecioCantidad
            // 
            this.boxPrecioCantidad.Controls.Add(this.precioUnitario);
            this.boxPrecioCantidad.Controls.Add(this.cantidad);
            this.boxPrecioCantidad.Controls.Add(this.lblCantidad);
            this.boxPrecioCantidad.Controls.Add(this.dollarSign);
            this.boxPrecioCantidad.Location = new System.Drawing.Point(210, 225);
            this.boxPrecioCantidad.Name = "boxPrecioCantidad";
            this.boxPrecioCantidad.Size = new System.Drawing.Size(249, 69);
            this.boxPrecioCantidad.TabIndex = 9;
            this.boxPrecioCantidad.TabStop = false;
            this.boxPrecioCantidad.Text = "Precio y Cantidad";
            // 
            // precioUnitario
            // 
            this.precioUnitario.DecimalPlaces = 2;
            this.precioUnitario.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.precioUnitario.Location = new System.Drawing.Point(36, 30);
            this.precioUnitario.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.Size = new System.Drawing.Size(73, 20);
            this.precioUnitario.TabIndex = 13;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(173, 30);
            this.cantidad.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(54, 20);
            this.cantidad.TabIndex = 12;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(115, 34);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // dollarSign
            // 
            this.dollarSign.AutoSize = true;
            this.dollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarSign.Location = new System.Drawing.Point(12, 30);
            this.dollarSign.Name = "dollarSign";
            this.dollarSign.Size = new System.Drawing.Size(18, 20);
            this.dollarSign.TabIndex = 0;
            this.dollarSign.Text = "$";
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(63, 326);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 23);
            this.btnCotizar.TabIndex = 10;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // dollarSignCotizacion
            // 
            this.dollarSignCotizacion.AutoSize = true;
            this.dollarSignCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarSignCotizacion.Location = new System.Drawing.Point(184, 322);
            this.dollarSignCotizacion.Name = "dollarSignCotizacion";
            this.dollarSignCotizacion.Size = new System.Drawing.Size(24, 25);
            this.dollarSignCotizacion.TabIndex = 13;
            this.dollarSignCotizacion.Text = "$";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(205, 322);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(84, 25);
            this.lblCotizacion.TabIndex = 14;
            this.lblCotizacion.Text = "______";
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 375);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.dollarSignCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.boxPrecioCantidad);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.calidadBox);
            this.Controls.Add(this.prendaBox);
            this.Controls.Add(historial);
            this.Controls.Add(this.vendedor);
            this.Controls.Add(this.direccionTienda);
            this.Controls.Add(this.nombreTienda);
            this.Name = "menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CotizadorExpress";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.prendaBox.ResumeLayout(false);
            this.prendaBox.PerformLayout();
            this.calidadBox.ResumeLayout(false);
            this.calidadBox.PerformLayout();
            this.boxPrecioCantidad.ResumeLayout(false);
            this.boxPrecioCantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label nombreTienda;
        private System.Windows.Forms.Label direccionTienda;
        private System.Windows.Forms.Label vendedor;
        private System.Windows.Forms.GroupBox prendaBox;
        private System.Windows.Forms.Label prendaLine;
        private System.Windows.Forms.RadioButton radioPantalon;
        private System.Windows.Forms.RadioButton radioCamisa;
        private System.Windows.Forms.GroupBox calidadBox;
        private System.Windows.Forms.RadioButton Premium;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.CheckBox checkChupin;
        private System.Windows.Forms.CheckBox checkCuello;
        private System.Windows.Forms.CheckBox checkManga;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox boxPrecioCantidad;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label dollarSign;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label dollarSignCotizacion;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.NumericUpDown precioUnitario;
    }
}

