namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_GestionReflexologia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_GestionReflexologia));
            this.btBorrar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMasajista = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.cbDuracion = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.iblHora = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBorrar.Location = new System.Drawing.Point(172, 458);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(84, 33);
            this.btBorrar.TabIndex = 7;
            this.btBorrar.Text = "BORRAR";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Location = new System.Drawing.Point(172, 399);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 33);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(58, 294);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 13);
            this.lblCliente.TabIndex = 13;
            this.lblCliente.Text = "Cliente:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(163, 193);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // lblMasajista
            // 
            this.lblMasajista.AutoSize = true;
            this.lblMasajista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasajista.Location = new System.Drawing.Point(56, 349);
            this.lblMasajista.Name = "lblMasajista";
            this.lblMasajista.Size = new System.Drawing.Size(64, 13);
            this.lblMasajista.TabIndex = 11;
            this.lblMasajista.Text = "Masajista:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(58, 199);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(138, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 25);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "REFLEXOLOGÍA";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(58, 132);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(62, 13);
            this.lblDuracion.TabIndex = 8;
            this.lblDuracion.Text = "Duración:";
            // 
            // cbDuracion
            // 
            this.cbDuracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuracion.FormattingEnabled = true;
            this.cbDuracion.Items.AddRange(new object[] {
            "30 min",
            "1 hora"});
            this.cbDuracion.Location = new System.Drawing.Point(163, 124);
            this.cbDuracion.Name = "cbDuracion";
            this.cbDuracion.Size = new System.Drawing.Size(93, 21);
            this.cbDuracion.TabIndex = 1;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(163, 341);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleado.TabIndex = 5;
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(163, 286);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 4;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(160, 177);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(188, 13);
            this.lblAviso.TabIndex = 19;
            this.lblAviso.Text = "La fecha debe ser posterior a la actual";
            this.lblAviso.UseWaitCursor = true;
            this.lblAviso.Visible = false;
            // 
            // iblHora
            // 
            this.iblHora.AutoSize = true;
            this.iblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblHora.Location = new System.Drawing.Point(58, 248);
            this.iblHora.Name = "iblHora";
            this.iblHora.Size = new System.Drawing.Size(38, 13);
            this.iblHora.TabIndex = 21;
            this.iblHora.Text = "Hora:";
            // 
            // cbHora
            // 
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "9:00 am",
            "10:00 am",
            "11:00 am",
            "12:00 am",
            "16:00 pm",
            "17:00 pm",
            "18:00 pm",
            "19:00 pm"});
            this.cbHora.Location = new System.Drawing.Point(163, 240);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(93, 21);
            this.cbHora.TabIndex = 3;
            // 
            // form_GestionReflexologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 543);
            this.Controls.Add(this.iblHora);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbDuracion);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblMasajista);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDuracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_GestionReflexologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de reflexología";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_RegistroReflexologia_FormClosing);
            this.Load += new System.EventHandler(this.form_GestionReflexologia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMasajista;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.ComboBox cbDuracion;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label iblHora;
        private System.Windows.Forms.ComboBox cbHora;
    }
}