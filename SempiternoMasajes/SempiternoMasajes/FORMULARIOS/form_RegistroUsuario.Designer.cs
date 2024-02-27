namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RegistroUsuario));
            this.picbMono = new System.Windows.Forms.PictureBox();
            this.tbPswd = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbPswd = new System.Windows.Forms.Label();
            this.lbUsu = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbMono)).BeginInit();
            this.SuspendLayout();
            // 
            // picbMono
            // 
            this.picbMono.Image = ((System.Drawing.Image)(resources.GetObject("picbMono.Image")));
            this.picbMono.Location = new System.Drawing.Point(249, 25);
            this.picbMono.Name = "picbMono";
            this.picbMono.Size = new System.Drawing.Size(257, 196);
            this.picbMono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbMono.TabIndex = 0;
            this.picbMono.TabStop = false;
            // 
            // tbPswd
            // 
            this.tbPswd.Location = new System.Drawing.Point(412, 308);
            this.tbPswd.Name = "tbPswd";
            this.tbPswd.PasswordChar = '*';
            this.tbPswd.Size = new System.Drawing.Size(140, 20);
            this.tbPswd.TabIndex = 2;
            this.tbPswd.Validating += new System.ComponentModel.CancelEventHandler(this.pswd_Validating);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(412, 262);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(140, 20);
            this.tbUser.TabIndex = 1;
            this.tbUser.Validating += new System.ComponentModel.CancelEventHandler(this.user_Validating);
            // 
            // lbPswd
            // 
            this.lbPswd.AutoSize = true;
            this.lbPswd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPswd.Location = new System.Drawing.Point(143, 309);
            this.lbPswd.Name = "lbPswd";
            this.lbPswd.Size = new System.Drawing.Size(194, 19);
            this.lbPswd.TabIndex = 5;
            this.lbPswd.Text = "Introduzca clave acceso";
            // 
            // lbUsu
            // 
            this.lbUsu.AutoSize = true;
            this.lbUsu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsu.Location = new System.Drawing.Point(143, 261);
            this.lbUsu.Name = "lbUsu";
            this.lbUsu.Size = new System.Drawing.Size(205, 19);
            this.lbUsu.TabIndex = 4;
            this.lbUsu.Text = "Introduzca nuevo usuario";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(412, 388);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 32);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(527, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(412, 351);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(200, 20);
            this.tbMail.TabIndex = 3;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(143, 350);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(234, 19);
            this.lbMail.TabIndex = 18;
            this.lbMail.Text = "Introduzca correo electrónico";
            // 
            // form_RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbPswd);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbPswd);
            this.Controls.Add(this.lbUsu);
            this.Controls.Add(this.picbMono);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_RegistroUsuario_FormClosing);
            this.Load += new System.EventHandler(this.form_RegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbMono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbMono;
        private System.Windows.Forms.TextBox tbPswd;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lbPswd;
        private System.Windows.Forms.Label lbUsu;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
    }
}