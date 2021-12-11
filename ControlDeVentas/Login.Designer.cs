
namespace ControlDeVentas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.pbox_login = new System.Windows.Forms.PictureBox();
            this.txtpassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtuser = new Bunifu.Framework.UI.BunifuTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_link_restcontr = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 450);
            this.panel1.TabIndex = 0;
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenido.ForeColor = System.Drawing.Color.White;
            this.lbl_bienvenido.Location = new System.Drawing.Point(449, 21);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(273, 51);
            this.lbl_bienvenido.TabIndex = 1;
            this.lbl_bienvenido.Text = "BIENVENIDO";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(408, 104);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(103, 31);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_contraseña.Location = new System.Drawing.Point(408, 209);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(142, 31);
            this.lbl_contraseña.TabIndex = 3;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(400, 316);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(58, 17);
            this.lblerror.TabIndex = 8;
            this.lblerror.Text = "ERROR";
            // 
            // pbox_login
            // 
            this.pbox_login.Image = global::ControlDeVentas.Properties.Resources.login_32px;
            this.pbox_login.Location = new System.Drawing.Point(554, 331);
            this.pbox_login.Name = "pbox_login";
            this.pbox_login.Size = new System.Drawing.Size(66, 70);
            this.pbox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_login.TabIndex = 7;
            this.pbox_login.TabStop = false;
            this.pbox_login.Click += new System.EventHandler(this.pbox_login_Click_1);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Silver;
            this.txtpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpassword.BackgroundImage")));
            this.txtpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtpassword.Icon")));
            this.txtpassword.Location = new System.Drawing.Point(414, 243);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(332, 45);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.text = "";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Silver;
            this.txtuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtuser.BackgroundImage")));
            this.txtuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Icon = ((System.Drawing.Image)(resources.GetObject("txtuser.Icon")));
            this.txtuser.Location = new System.Drawing.Point(414, 153);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(332, 43);
            this.txtuser.TabIndex = 5;
            this.txtuser.text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlDeVentas.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(0, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 288);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_link_restcontr
            // 
            this.lbl_link_restcontr.AutoSize = true;
            this.lbl_link_restcontr.Location = new System.Drawing.Point(515, 404);
            this.lbl_link_restcontr.Name = "lbl_link_restcontr";
            this.lbl_link_restcontr.Size = new System.Drawing.Size(131, 13);
            this.lbl_link_restcontr.TabIndex = 4;
            this.lbl_link_restcontr.TabStop = true;
            this.lbl_link_restcontr.Text = "¿Olvidaste tu contraseña?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.pbox_login);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbl_link_restcontr);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_bienvenido);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_bienvenido;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private Bunifu.Framework.UI.BunifuTextbox txtuser;
        private Bunifu.Framework.UI.BunifuTextbox txtpassword;
        private System.Windows.Forms.PictureBox pbox_login;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbl_link_restcontr;
    }
}

