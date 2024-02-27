namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_RegistroEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RegistroEmpleados));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNaci = new System.Windows.Forms.Label();
            this.cBPuesto = new System.Windows.Forms.ComboBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBApellido1 = new System.Windows.Forms.TextBox();
            this.tBApellido2 = new System.Windows.Forms.TextBox();
            this.tBDNI = new System.Windows.Forms.TextBox();
            this.tBSS = new System.Windows.Forms.TextBox();
            this.tBTelefono = new System.Windows.Forms.TextBox();
            this.DTPfechaNaci = new System.Windows.Forms.DateTimePicker();
            this.lblSoloNumDNI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Location = new System.Drawing.Point(167, 416);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 33);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBorrar.Location = new System.Drawing.Point(167, 475);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(84, 33);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "BORRAR";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(12, 100);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(94, 13);
            this.lblApellido1.TabIndex = 19;
            this.lblApellido1.Text = "Primer apellido:";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(12, 147);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(105, 13);
            this.lblApellido2.TabIndex = 20;
            this.lblApellido2.Text = "Segundo apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(12, 196);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 13);
            this.lblDNI.TabIndex = 21;
            this.lblDNI.Text = "DNI:";
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSS.Location = new System.Drawing.Point(12, 242);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(125, 13);
            this.lblSS.TabIndex = 22;
            this.lblSS.Text = "Nº Seguridad Social:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(12, 284);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(50, 13);
            this.lblPuesto.TabIndex = 23;
            this.lblPuesto.Text = "Puesto:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(12, 329);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 13);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblFechaNaci
            // 
            this.lblFechaNaci.AutoSize = true;
            this.lblFechaNaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNaci.Location = new System.Drawing.Point(12, 371);
            this.lblFechaNaci.Name = "lblFechaNaci";
            this.lblFechaNaci.Size = new System.Drawing.Size(129, 13);
            this.lblFechaNaci.TabIndex = 25;
            this.lblFechaNaci.Text = "Fecha de nacimiento:";
            // 
            // cBPuesto
            // 
            this.cBPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPuesto.FormattingEnabled = true;
            this.cBPuesto.Items.AddRange(new object[] {
            "Anfitrión",
            "Mantenimiento",
            "Masajista",
            "Recepcionista"});
            this.cBPuesto.Location = new System.Drawing.Point(167, 276);
            this.cBPuesto.Name = "cBPuesto";
            this.cBPuesto.Size = new System.Drawing.Size(128, 21);
            this.cBPuesto.Sorted = true;
            this.cBPuesto.TabIndex = 6;
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(167, 42);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(200, 20);
            this.tBNombre.TabIndex = 1;
            // 
            // tBApellido1
            // 
            this.tBApellido1.Location = new System.Drawing.Point(167, 93);
            this.tBApellido1.Name = "tBApellido1";
            this.tBApellido1.Size = new System.Drawing.Size(200, 20);
            this.tBApellido1.TabIndex = 2;
            // 
            // tBApellido2
            // 
            this.tBApellido2.Location = new System.Drawing.Point(167, 140);
            this.tBApellido2.Name = "tBApellido2";
            this.tBApellido2.Size = new System.Drawing.Size(200, 20);
            this.tBApellido2.TabIndex = 3;
            // 
            // tBDNI
            // 
            this.tBDNI.Location = new System.Drawing.Point(167, 189);
            this.tBDNI.Name = "tBDNI";
            this.tBDNI.Size = new System.Drawing.Size(128, 20);
            this.tBDNI.TabIndex = 4;
            // 
            // tBSS
            // 
            this.tBSS.Location = new System.Drawing.Point(167, 235);
            this.tBSS.Name = "tBSS";
            this.tBSS.Size = new System.Drawing.Size(128, 20);
            this.tBSS.TabIndex = 5;
            // 
            // tBTelefono
            // 
            this.tBTelefono.Location = new System.Drawing.Point(167, 322);
            this.tBTelefono.Name = "tBTelefono";
            this.tBTelefono.Size = new System.Drawing.Size(128, 20);
            this.tBTelefono.TabIndex = 7;
            // 
            // DTPfechaNaci
            // 
            this.DTPfechaNaci.Location = new System.Drawing.Point(167, 364);
            this.DTPfechaNaci.Name = "DTPfechaNaci";
            this.DTPfechaNaci.Size = new System.Drawing.Size(200, 20);
            this.DTPfechaNaci.TabIndex = 8;
            this.DTPfechaNaci.Value = new System.DateTime(1990, 6, 13, 0, 0, 0, 0);
            // 
            // lblSoloNumDNI
            // 
            this.lblSoloNumDNI.AutoSize = true;
            this.lblSoloNumDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoloNumDNI.Location = new System.Drawing.Point(302, 195);
            this.lblSoloNumDNI.Name = "lblSoloNumDNI";
            this.lblSoloNumDNI.Size = new System.Drawing.Size(81, 13);
            this.lblSoloNumDNI.TabIndex = 34;
            this.lblSoloNumDNI.Text = "(*Sólo números)";
            // 
            // form_RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 543);
            this.Controls.Add(this.lblSoloNumDNI);
            this.Controls.Add(this.DTPfechaNaci);
            this.Controls.Add(this.tBTelefono);
            this.Controls.Add(this.tBSS);
            this.Controls.Add(this.tBDNI);
            this.Controls.Add(this.tBApellido2);
            this.Controls.Add(this.tBApellido1);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.cBPuesto);
            this.Controls.Add(this.lblFechaNaci);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btnConfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_RegistroEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_RegistroEmpleados_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNaci;
        private System.Windows.Forms.ComboBox cBPuesto;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBApellido1;
        private System.Windows.Forms.TextBox tBApellido2;
        private System.Windows.Forms.TextBox tBDNI;
        private System.Windows.Forms.TextBox tBSS;
        private System.Windows.Forms.TextBox tBTelefono;
        private System.Windows.Forms.DateTimePicker DTPfechaNaci;
        private System.Windows.Forms.Label lblSoloNumDNI;
    }
}