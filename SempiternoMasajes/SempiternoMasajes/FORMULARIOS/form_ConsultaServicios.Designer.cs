namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_ConsultaServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ConsultaServicios));
            this.lvServicios = new System.Windows.Forms.ListView();
            this.btnOrdenarTipo = new System.Windows.Forms.Button();
            this.btnOrdenarFecha = new System.Windows.Forms.Button();
            this.btnOrdenarHora = new System.Windows.Forms.Button();
            this.btnOrdenarMasajista = new System.Windows.Forms.Button();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvServicios
            // 
            this.lvServicios.HideSelection = false;
            this.lvServicios.Location = new System.Drawing.Point(24, 44);
            this.lvServicios.Name = "lvServicios";
            this.lvServicios.Size = new System.Drawing.Size(668, 376);
            this.lvServicios.TabIndex = 0;
            this.lvServicios.UseCompatibleStateImageBehavior = false;
            // 
            // btnOrdenarTipo
            // 
            this.btnOrdenarTipo.Location = new System.Drawing.Point(713, 135);
            this.btnOrdenarTipo.Name = "btnOrdenarTipo";
            this.btnOrdenarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarTipo.TabIndex = 1;
            this.btnOrdenarTipo.Text = "TIPO";
            this.btnOrdenarTipo.UseVisualStyleBackColor = true;
            this.btnOrdenarTipo.Click += new System.EventHandler(this.btnOrdenarTipo_Click);
            // 
            // btnOrdenarFecha
            // 
            this.btnOrdenarFecha.Location = new System.Drawing.Point(713, 189);
            this.btnOrdenarFecha.Name = "btnOrdenarFecha";
            this.btnOrdenarFecha.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarFecha.TabIndex = 2;
            this.btnOrdenarFecha.Text = "FECHA";
            this.btnOrdenarFecha.UseVisualStyleBackColor = true;
            this.btnOrdenarFecha.Click += new System.EventHandler(this.btnOrdenarFecha_Click);
            // 
            // btnOrdenarHora
            // 
            this.btnOrdenarHora.Location = new System.Drawing.Point(713, 243);
            this.btnOrdenarHora.Name = "btnOrdenarHora";
            this.btnOrdenarHora.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarHora.TabIndex = 3;
            this.btnOrdenarHora.Text = "HORA";
            this.btnOrdenarHora.UseVisualStyleBackColor = true;
            this.btnOrdenarHora.Click += new System.EventHandler(this.btnOrdenarHora_Click);
            // 
            // btnOrdenarMasajista
            // 
            this.btnOrdenarMasajista.Location = new System.Drawing.Point(713, 296);
            this.btnOrdenarMasajista.Name = "btnOrdenarMasajista";
            this.btnOrdenarMasajista.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarMasajista.TabIndex = 4;
            this.btnOrdenarMasajista.Text = "MASAJISTA";
            this.btnOrdenarMasajista.UseVisualStyleBackColor = true;
            this.btnOrdenarMasajista.Click += new System.EventHandler(this.btnOrdenarMasajista_Click);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.Location = new System.Drawing.Point(706, 80);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(82, 16);
            this.lblOrdenar.TabIndex = 5;
            this.lblOrdenar.Text = "ORDENAR";
            // 
            // form_ConsultaServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.btnOrdenarMasajista);
            this.Controls.Add(this.btnOrdenarHora);
            this.Controls.Add(this.btnOrdenarFecha);
            this.Controls.Add(this.btnOrdenarTipo);
            this.Controls.Add(this.lvServicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_ConsultaServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de servicios";
            this.Load += new System.EventHandler(this.form_ConsultaServicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvServicios;
        private System.Windows.Forms.Button btnOrdenarTipo;
        private System.Windows.Forms.Button btnOrdenarFecha;
        private System.Windows.Forms.Button btnOrdenarHora;
        private System.Windows.Forms.Button btnOrdenarMasajista;
        private System.Windows.Forms.Label lblOrdenar;
    }
}