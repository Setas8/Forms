namespace SempiternoMasajes.FORMULADRIOS
{
    partial class form_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.LinkLblAyuda = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPswd = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPswd = new System.Windows.Forms.Label();
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO DE SESIÓN";
            // 
            // LinkLblAyuda
            // 
            this.LinkLblAyuda.AutoSize = true;
            this.LinkLblAyuda.Location = new System.Drawing.Point(695, 417);
            this.LinkLblAyuda.Name = "LinkLblAyuda";
            this.LinkLblAyuda.Size = new System.Drawing.Size(83, 13);
            this.LinkLblAyuda.TabIndex = 7;
            this.LinkLblAyuda.TabStop = true;
            this.LinkLblAyuda.Text = "Ayuda Microsoft";
            this.LinkLblAyuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblAyuda_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "REGISTRO";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Silver;
            this.btnInicio.Location = new System.Drawing.Point(172, 125);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Silver;
            this.btnRegistro.Location = new System.Drawing.Point(502, 125);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "REGISTRO";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(125, 28);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(140, 20);
            this.tbUser.TabIndex = 3;
            this.tbUser.Text = "admin";
            this.tbUser.Visible = false;
            // 
            // tbPswd
            // 
            this.tbPswd.Location = new System.Drawing.Point(125, 91);
            this.tbPswd.Name = "tbPswd";
            this.tbPswd.PasswordChar = '*';
            this.tbPswd.Size = new System.Drawing.Size(140, 20);
            this.tbPswd.TabIndex = 4;
            this.tbPswd.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(149, 131);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(21, 32);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(65, 16);
            this.lbUser.TabIndex = 9;
            this.lbUser.Text = "Usuario:";
            this.lbUser.Visible = false;
            // 
            // lbPswd
            // 
            this.lbPswd.AutoSize = true;
            this.lbPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPswd.Location = new System.Drawing.Point(21, 95);
            this.lbPswd.Name = "lbPswd";
            this.lbPswd.Size = new System.Drawing.Size(90, 16);
            this.lbPswd.TabIndex = 10;
            this.lbPswd.Text = "Contraseña:";
            this.lbPswd.Visible = false;
            // 
            // gbInicio
            // 
            this.gbInicio.Controls.Add(this.btnVolver);
            this.gbInicio.Controls.Add(this.lbUser);
            this.gbInicio.Controls.Add(this.lbPswd);
            this.gbInicio.Controls.Add(this.tbUser);
            this.gbInicio.Controls.Add(this.tbPswd);
            this.gbInicio.Controls.Add(this.btnAceptar);
            this.gbInicio.Location = new System.Drawing.Point(74, 180);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(284, 203);
            this.gbInicio.TabIndex = 11;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio";
            this.gbInicio.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(214, 181);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(70, 22);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbInicio);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkLblAyuda);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Inicio_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Inicio_FormClosed);
            this.Load += new System.EventHandler(this.form_Inicio_Load);
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkLblAyuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPswd;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPswd;
        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Button btnVolver;
    }
}