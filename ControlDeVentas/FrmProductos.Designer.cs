
namespace ControlDeVentas
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.dgb_Productos = new System.Windows.Forms.DataGridView();
            this.txtProveedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btneliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btneditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbproductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtalla = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtcantidad = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_Productos
            // 
            this.dgb_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Productos.Location = new System.Drawing.Point(28, 44);
            this.dgb_Productos.Name = "dgb_Productos";
            this.dgb_Productos.Size = new System.Drawing.Size(344, 415);
            this.dgb_Productos.TabIndex = 0;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedor.HintForeColor = System.Drawing.Color.Empty;
            this.txtProveedor.HintText = "";
            this.txtProveedor.isPassword = false;
            this.txtProveedor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProveedor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProveedor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProveedor.LineThickness = 3;
            this.txtProveedor.Location = new System.Drawing.Point(379, 127);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(226, 33);
            this.txtProveedor.TabIndex = 1;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "GUARDAR";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(429, 291);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(159, 41);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.ActiveBorderThickness = 1;
            this.btneliminar.ActiveCornerRadius = 20;
            this.btneliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btneliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btneliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btneliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.ButtonText = "ELIMINAR";
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btneliminar.IdleBorderThickness = 1;
            this.btneliminar.IdleCornerRadius = 20;
            this.btneliminar.IdleFillColor = System.Drawing.Color.White;
            this.btneliminar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btneliminar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btneliminar.Location = new System.Drawing.Point(429, 402);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(159, 41);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btneditar
            // 
            this.btneditar.ActiveBorderThickness = 1;
            this.btneditar.ActiveCornerRadius = 20;
            this.btneditar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btneditar.ActiveForecolor = System.Drawing.Color.White;
            this.btneditar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btneditar.BackColor = System.Drawing.SystemColors.Control;
            this.btneditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneditar.BackgroundImage")));
            this.btneditar.ButtonText = "EDITAR";
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btneditar.IdleBorderThickness = 1;
            this.btneditar.IdleCornerRadius = 20;
            this.btneditar.IdleFillColor = System.Drawing.Color.White;
            this.btneditar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btneditar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btneditar.Location = new System.Drawing.Point(429, 342);
            this.btneditar.Margin = new System.Windows.Forms.Padding(5);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(159, 41);
            this.btneditar.TabIndex = 5;
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbproductos
            // 
            this.cmbproductos.FormattingEnabled = true;
            this.cmbproductos.Location = new System.Drawing.Point(389, 68);
            this.cmbproductos.Name = "cmbproductos";
            this.cmbproductos.Size = new System.Drawing.Size(100, 21);
            this.cmbproductos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // cmbmarca
            // 
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Location = new System.Drawing.Point(515, 68);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(100, 21);
            this.cmbmarca.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proveedor";
            // 
            // cmbtalla
            // 
            this.cmbtalla.FormattingEnabled = true;
            this.cmbtalla.Location = new System.Drawing.Point(389, 188);
            this.cmbtalla.Name = "cmbtalla";
            this.cmbtalla.Size = new System.Drawing.Size(100, 21);
            this.cmbtalla.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Talla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtprecio.Location = new System.Drawing.Point(505, 188);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 13;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtcantidad.Location = new System.Drawing.Point(389, 245);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cantidad";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 489);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbtalla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbmarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbproductos);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.dgb_Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_Productos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProveedor;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btneliminar;
        private Bunifu.Framework.UI.BunifuThinButton2 btneditar;
        private System.Windows.Forms.ComboBox cmbproductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbtalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtprecio;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtcantidad;
        private System.Windows.Forms.Label label6;
    }
}