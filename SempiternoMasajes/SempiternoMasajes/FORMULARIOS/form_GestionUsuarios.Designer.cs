namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_GestionUsuarios));
            this.gBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.btnCambiarPswd = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gBoxUsuarios
            // 
            this.gBoxUsuarios.Location = new System.Drawing.Point(50, 32);
            this.gBoxUsuarios.Name = "gBoxUsuarios";
            this.gBoxUsuarios.Size = new System.Drawing.Size(291, 363);
            this.gBoxUsuarios.TabIndex = 3;
            this.gBoxUsuarios.TabStop = false;
            this.gBoxUsuarios.Text = "USUARIOS DEL SISTEMA";
            // 
            // btnCambiarPswd
            // 
            this.btnCambiarPswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCambiarPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPswd.Location = new System.Drawing.Point(215, 437);
            this.btnCambiarPswd.Name = "btnCambiarPswd";
            this.btnCambiarPswd.Size = new System.Drawing.Size(100, 42);
            this.btnCambiarPswd.TabIndex = 2;
            this.btnCambiarPswd.Text = "CAMBIAR CONTRASEÑA";
            this.btnCambiarPswd.UseVisualStyleBackColor = false;
            this.btnCambiarPswd.Click += new System.EventHandler(this.btnCambiarPswd_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(71, 437);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 42);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // form_GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 543);
            this.Controls.Add(this.btnCambiarPswd);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gBoxUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_GestionEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.form_GestionUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxUsuarios;
        private System.Windows.Forms.Button btnCambiarPswd;
        private System.Windows.Forms.Button btnEliminar;
    }
}