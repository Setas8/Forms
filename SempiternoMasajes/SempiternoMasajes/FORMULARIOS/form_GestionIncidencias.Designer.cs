namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_GestionIncidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_GestionIncidencias));
            this.gbIncidencias = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnObservaciones = new System.Windows.Forms.Button();
            this.panelObservaciones = new System.Windows.Forms.Panel();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.btnObserBorrar = new System.Windows.Forms.Button();
            this.btnObserConfirmar = new System.Windows.Forms.Button();
            this.panelObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIncidencias
            // 
            this.gbIncidencias.Location = new System.Drawing.Point(28, 35);
            this.gbIncidencias.Name = "gbIncidencias";
            this.gbIncidencias.Size = new System.Drawing.Size(741, 341);
            this.gbIncidencias.TabIndex = 0;
            this.gbIncidencias.TabStop = false;
            this.gbIncidencias.Text = "Incidencias Abiertas";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(360, 393);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 32);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(122, 403);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(180, 13);
            this.lblConfirmar.TabIndex = 2;
            this.lblConfirmar.Text = "Confirmar cierre de incidencia:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(675, 393);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(551, 428);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(218, 13);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.Text = "Imprimiendo detalles de la incidencia (ficticio)";
            this.lblAviso.Visible = false;
            // 
            // btnObservaciones
            // 
            this.btnObservaciones.Location = new System.Drawing.Point(473, 393);
            this.btnObservaciones.Name = "btnObservaciones";
            this.btnObservaciones.Size = new System.Drawing.Size(107, 32);
            this.btnObservaciones.TabIndex = 2;
            this.btnObservaciones.Text = "OBSERVACIONES";
            this.btnObservaciones.UseVisualStyleBackColor = true;
            this.btnObservaciones.Click += new System.EventHandler(this.btnObservaciones_Click);
            // 
            // panelObservaciones
            // 
            this.panelObservaciones.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelObservaciones.Controls.Add(this.tbObservaciones);
            this.panelObservaciones.Controls.Add(this.lblObservaciones);
            this.panelObservaciones.Controls.Add(this.btnObserBorrar);
            this.panelObservaciones.Controls.Add(this.btnObserConfirmar);
            this.panelObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObservaciones.Location = new System.Drawing.Point(0, 0);
            this.panelObservaciones.Name = "panelObservaciones";
            this.panelObservaciones.Size = new System.Drawing.Size(800, 450);
            this.panelObservaciones.TabIndex = 6;
            this.panelObservaciones.Visible = false;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(165, 54);
            this.tbObservaciones.MaxLength = 500;
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(474, 266);
            this.tbObservaciones.TabIndex = 38;
            this.tbObservaciones.Validating += new System.ComponentModel.CancelEventHandler(this.observaciones_Validating);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(18, 54);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(95, 13);
            this.lblObservaciones.TabIndex = 41;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // btnObserBorrar
            // 
            this.btnObserBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnObserBorrar.Location = new System.Drawing.Point(473, 343);
            this.btnObserBorrar.Name = "btnObserBorrar";
            this.btnObserBorrar.Size = new System.Drawing.Size(84, 33);
            this.btnObserBorrar.TabIndex = 2;
            this.btnObserBorrar.Text = "BORRAR";
            this.btnObserBorrar.UseVisualStyleBackColor = false;
            this.btnObserBorrar.Click += new System.EventHandler(this.btnObserBorrar_Click);
            // 
            // btnObserConfirmar
            // 
            this.btnObserConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnObserConfirmar.Location = new System.Drawing.Point(203, 343);
            this.btnObserConfirmar.Name = "btnObserConfirmar";
            this.btnObserConfirmar.Size = new System.Drawing.Size(84, 33);
            this.btnObserConfirmar.TabIndex = 1;
            this.btnObserConfirmar.Text = "CONFIRMAR";
            this.btnObserConfirmar.UseVisualStyleBackColor = false;
            this.btnObserConfirmar.Click += new System.EventHandler(this.btnObserConfirmar_Click);
            // 
            // form_GestionIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelObservaciones);
            this.Controls.Add(this.btnObservaciones);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbIncidencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_GestionIncidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Incidencias";
            this.Load += new System.EventHandler(this.form_GestionIncidencias_Load);
            this.panelObservaciones.ResumeLayout(false);
            this.panelObservaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIncidencias;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnObservaciones;
        private System.Windows.Forms.Panel panelObservaciones;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Button btnObserBorrar;
        private System.Windows.Forms.Button btnObserConfirmar;
    }
}