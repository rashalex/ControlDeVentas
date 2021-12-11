
namespace ControlDeVentas
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.btnproductos = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnprecio = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btncategoria = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_editar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_eliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Location = new System.Drawing.Point(40, 28);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.Size = new System.Drawing.Size(293, 383);
            this.dgv_ventas.TabIndex = 0;
            // 
            // btnproductos
            // 
            this.btnproductos.BorderColorFocused = System.Drawing.Color.Blue;
            this.btnproductos.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnproductos.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.btnproductos.BorderThickness = 3;
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnproductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnproductos.isPassword = false;
            this.btnproductos.Location = new System.Drawing.Point(355, 56);
            this.btnproductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(184, 25);
            this.btnproductos.TabIndex = 2;
            this.btnproductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnprecio
            // 
            this.btnprecio.BorderColorFocused = System.Drawing.Color.Blue;
            this.btnprecio.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprecio.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.btnprecio.BorderThickness = 3;
            this.btnprecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnprecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnprecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprecio.isPassword = false;
            this.btnprecio.Location = new System.Drawing.Point(355, 118);
            this.btnprecio.Margin = new System.Windows.Forms.Padding(4);
            this.btnprecio.Name = "btnprecio";
            this.btnprecio.Size = new System.Drawing.Size(184, 25);
            this.btnprecio.TabIndex = 3;
            this.btnprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btncategoria
            // 
            this.btncategoria.BorderColorFocused = System.Drawing.Color.Blue;
            this.btncategoria.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncategoria.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.btncategoria.BorderThickness = 3;
            this.btncategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btncategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btncategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncategoria.isPassword = false;
            this.btncategoria.Location = new System.Drawing.Point(355, 187);
            this.btncategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(184, 25);
            this.btncategoria.TabIndex = 4;
            this.btncategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.ActiveBorderThickness = 1;
            this.btn_guardar.ActiveCornerRadius = 20;
            this.btn_guardar.ActiveFillColor = System.Drawing.Color.White;
            this.btn_guardar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_guardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.ButtonText = "Guardar";
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_guardar.IdleBorderThickness = 1;
            this.btn_guardar.IdleCornerRadius = 20;
            this.btn_guardar.IdleFillColor = System.Drawing.Color.White;
            this.btn_guardar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_guardar.IdleLineColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(358, 239);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(181, 41);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_editar
            // 
            this.btn_editar.ActiveBorderThickness = 1;
            this.btn_editar.ActiveCornerRadius = 20;
            this.btn_editar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_editar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_editar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_editar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.ButtonText = "Editar";
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_editar.IdleBorderThickness = 1;
            this.btn_editar.IdleCornerRadius = 20;
            this.btn_editar.IdleFillColor = System.Drawing.Color.White;
            this.btn_editar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_editar.IdleLineColor = System.Drawing.Color.Black;
            this.btn_editar.Location = new System.Drawing.Point(358, 290);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(181, 41);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.ActiveBorderThickness = 1;
            this.btn_eliminar.ActiveCornerRadius = 20;
            this.btn_eliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_eliminar.ActiveForecolor = System.Drawing.Color.Thistle;
            this.btn_eliminar.ActiveLineColor = System.Drawing.Color.MediumPurple;
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.ButtonText = "Eliminar";
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_eliminar.IdleBorderThickness = 1;
            this.btn_eliminar.IdleCornerRadius = 20;
            this.btn_eliminar.IdleFillColor = System.Drawing.Color.White;
            this.btn_eliminar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_eliminar.IdleLineColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(358, 341);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(181, 41);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 489);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncategoria);
            this.Controls.Add(this.btnprecio);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.dgv_ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ventas;
        private Bunifu.Framework.UI.BunifuMetroTextbox btnproductos;
        private Bunifu.Framework.UI.BunifuMetroTextbox btnprecio;
        private Bunifu.Framework.UI.BunifuMetroTextbox btncategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_guardar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_editar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_eliminar;
    }
}