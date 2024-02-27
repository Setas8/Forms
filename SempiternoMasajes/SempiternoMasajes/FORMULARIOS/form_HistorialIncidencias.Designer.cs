namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_HistorialIncidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_HistorialIncidencias));
            this.lvHistorialIncidencias = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvHistorialIncidencias
            // 
            this.lvHistorialIncidencias.HideSelection = false;
            this.lvHistorialIncidencias.Location = new System.Drawing.Point(60, 53);
            this.lvHistorialIncidencias.Name = "lvHistorialIncidencias";
            this.lvHistorialIncidencias.Size = new System.Drawing.Size(644, 335);
            this.lvHistorialIncidencias.TabIndex = 0;
            this.lvHistorialIncidencias.UseCompatibleStateImageBehavior = false;
            // 
            // form_HistorialIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvHistorialIncidencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_HistorialIncidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de incidencias";
            this.Load += new System.EventHandler(this.form_HistorialIncidencias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHistorialIncidencias;
    }
}