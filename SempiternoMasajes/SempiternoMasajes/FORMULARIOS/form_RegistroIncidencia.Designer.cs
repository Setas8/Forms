namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_RegistroIncidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RegistroIncidencia));
            this.cBConcepto = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBConcepto
            // 
            this.cBConcepto.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cBConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBConcepto.FormattingEnabled = true;
            this.cBConcepto.Items.AddRange(new object[] {
            "Climatización",
            "Electricidad",
            "Fontanería",
            "Mobiliario",
            "Reparación"});
            this.cBConcepto.Location = new System.Drawing.Point(179, 58);
            this.cBConcepto.Name = "cBConcepto";
            this.cBConcepto.Size = new System.Drawing.Size(128, 21);
            this.cBConcepto.Sorted = true;
            this.cBConcepto.TabIndex = 1;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(32, 58);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(65, 13);
            this.lblConcepto.TabIndex = 42;
            this.lblConcepto.Text = "Concepto:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(32, 143);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBorrar.Location = new System.Drawing.Point(179, 471);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(84, 33);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "BORRAR";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Location = new System.Drawing.Point(179, 412);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 33);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(179, 143);
            this.tbDescripcion.MaxLength = 500;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(200, 194);
            this.tbDescripcion.TabIndex = 2;
            this.tbDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.descripcion_Validating);
            // 
            // form_RegistroIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 543);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.cBConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btnConfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_RegistroIncidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva incidencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_RegistroIncidencia_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox tbDescripcion;
    }
}