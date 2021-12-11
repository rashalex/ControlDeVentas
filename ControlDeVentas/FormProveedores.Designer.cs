
namespace ControlDeVentas
{
    partial class FormProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            this.dgv_proveedor = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_editar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproveedor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontacto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefono = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtciudad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpais = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_proveedor
            // 
            this.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedor.Location = new System.Drawing.Point(42, 23);
            this.dgv_proveedor.Name = "dgv_proveedor";
            this.dgv_proveedor.Size = new System.Drawing.Size(274, 250);
            this.dgv_proveedor.TabIndex = 0;
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
            this.btn_eliminar.Location = new System.Drawing.Point(84, 362);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(181, 41);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_editar.Location = new System.Drawing.Point(84, 322);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(181, 41);
            this.btn_editar.TabIndex = 19;
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.btn_guardar.Location = new System.Drawing.Point(84, 281);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(181, 41);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Proveedor:";
            // 
            // txtproveedor
            // 
            this.txtproveedor.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtproveedor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtproveedor.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtproveedor.BorderThickness = 3;
            this.txtproveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtproveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtproveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtproveedor.isPassword = false;
            this.txtproveedor.Location = new System.Drawing.Point(355, 50);
            this.txtproveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(184, 25);
            this.txtproveedor.TabIndex = 11;
            this.txtproveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contacto:";
            // 
            // txtcontacto
            // 
            this.txtcontacto.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtcontacto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontacto.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtcontacto.BorderThickness = 3;
            this.txtcontacto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontacto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcontacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontacto.isPassword = false;
            this.txtcontacto.Location = new System.Drawing.Point(355, 111);
            this.txtcontacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(184, 25);
            this.txtcontacto.TabIndex = 20;
            this.txtcontacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Teléfono:";
            // 
            // txttelefono
            // 
            this.txttelefono.BorderColorFocused = System.Drawing.Color.Blue;
            this.txttelefono.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttelefono.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txttelefono.BorderThickness = 3;
            this.txttelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttelefono.isPassword = false;
            this.txttelefono.Location = new System.Drawing.Point(355, 174);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(184, 25);
            this.txttelefono.TabIndex = 22;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dirección:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtdireccion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdireccion.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtdireccion.BorderThickness = 3;
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdireccion.isPassword = false;
            this.txtdireccion.Location = new System.Drawing.Point(355, 234);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(184, 25);
            this.txtdireccion.TabIndex = 24;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ciudad:";
            // 
            // txtciudad
            // 
            this.txtciudad.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtciudad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtciudad.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtciudad.BorderThickness = 3;
            this.txtciudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtciudad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtciudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtciudad.isPassword = false;
            this.txtciudad.Location = new System.Drawing.Point(355, 297);
            this.txtciudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(184, 25);
            this.txtciudad.TabIndex = 26;
            this.txtciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "País:";
            // 
            // txtpais
            // 
            this.txtpais.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtpais.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpais.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtpais.BorderThickness = 3;
            this.txtpais.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpais.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpais.isPassword = false;
            this.txtpais.Location = new System.Drawing.Point(358, 362);
            this.txtpais.Margin = new System.Windows.Forms.Padding(4);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(184, 25);
            this.txtpais.TabIndex = 28;
            this.txtpais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontacto);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.dgv_proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_proveedor;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_eliminar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_editar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtproveedor;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcontacto;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttelefono;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtdireccion;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtciudad;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpais;
    }
}