namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Estadisticas));
            this.pBoxConstruccion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxConstruccion)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxConstruccion
            // 
            this.pBoxConstruccion.Image = ((System.Drawing.Image)(resources.GetObject("pBoxConstruccion.Image")));
            this.pBoxConstruccion.Location = new System.Drawing.Point(267, 112);
            this.pBoxConstruccion.Name = "pBoxConstruccion";
            this.pBoxConstruccion.Size = new System.Drawing.Size(259, 194);
            this.pBoxConstruccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxConstruccion.TabIndex = 0;
            this.pBoxConstruccion.TabStop = false;
            // 
            // form_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxConstruccion);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas de venta";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxConstruccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxConstruccion;
    }
}