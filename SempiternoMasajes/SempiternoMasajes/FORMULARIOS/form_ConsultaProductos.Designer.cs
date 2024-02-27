namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_ConsultaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ConsultaProductos));
            this.lBoxProductos = new System.Windows.Forms.ListBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.rBtnDescripcion = new System.Windows.Forms.RadioButton();
            this.rBtnPrecio = new System.Windows.Forms.RadioButton();
            this.rBtnCodigo = new System.Windows.Forms.RadioButton();
            this.gBFiltrar = new System.Windows.Forms.GroupBox();
            this.gBFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxProductos
            // 
            this.lBoxProductos.FormattingEnabled = true;
            this.lBoxProductos.Location = new System.Drawing.Point(25, 18);
            this.lBoxProductos.Name = "lBoxProductos";
            this.lBoxProductos.ScrollAlwaysVisible = true;
            this.lBoxProductos.Size = new System.Drawing.Size(361, 329);
            this.lBoxProductos.TabIndex = 0;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.Location = new System.Drawing.Point(39, 74);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(123, 25);
            this.lblOrdenar.TabIndex = 10;
            this.lblOrdenar.Text = "ORDENAR";
            // 
            // rBtnDescripcion
            // 
            this.rBtnDescripcion.AutoSize = true;
            this.rBtnDescripcion.Location = new System.Drawing.Point(193, 50);
            this.rBtnDescripcion.Name = "rBtnDescripcion";
            this.rBtnDescripcion.Size = new System.Drawing.Size(62, 17);
            this.rBtnDescripcion.TabIndex = 1;
            this.rBtnDescripcion.TabStop = true;
            this.rBtnDescripcion.Text = "Nombre";
            this.rBtnDescripcion.UseVisualStyleBackColor = true;
            this.rBtnDescripcion.CheckedChanged += new System.EventHandler(this.rBtnDescripcion_CheckedChanged);
            // 
            // rBtnPrecio
            // 
            this.rBtnPrecio.AutoSize = true;
            this.rBtnPrecio.Location = new System.Drawing.Point(193, 82);
            this.rBtnPrecio.Name = "rBtnPrecio";
            this.rBtnPrecio.Size = new System.Drawing.Size(55, 17);
            this.rBtnPrecio.TabIndex = 2;
            this.rBtnPrecio.TabStop = true;
            this.rBtnPrecio.Text = "Precio";
            this.rBtnPrecio.UseVisualStyleBackColor = true;
            this.rBtnPrecio.CheckedChanged += new System.EventHandler(this.rBtnPrecio_CheckedChanged);
            // 
            // rBtnCodigo
            // 
            this.rBtnCodigo.AutoSize = true;
            this.rBtnCodigo.Location = new System.Drawing.Point(193, 116);
            this.rBtnCodigo.Name = "rBtnCodigo";
            this.rBtnCodigo.Size = new System.Drawing.Size(58, 17);
            this.rBtnCodigo.TabIndex = 3;
            this.rBtnCodigo.TabStop = true;
            this.rBtnCodigo.Text = "Código";
            this.rBtnCodigo.UseVisualStyleBackColor = true;
            this.rBtnCodigo.CheckedChanged += new System.EventHandler(this.rBtnCodigo_CheckedChanged);
            // 
            // gBFiltrar
            // 
            this.gBFiltrar.Controls.Add(this.lblOrdenar);
            this.gBFiltrar.Controls.Add(this.rBtnCodigo);
            this.gBFiltrar.Controls.Add(this.rBtnDescripcion);
            this.gBFiltrar.Controls.Add(this.rBtnPrecio);
            this.gBFiltrar.Location = new System.Drawing.Point(443, 83);
            this.gBFiltrar.Name = "gBFiltrar";
            this.gBFiltrar.Size = new System.Drawing.Size(297, 186);
            this.gBFiltrar.TabIndex = 14;
            this.gBFiltrar.TabStop = false;
            // 
            // form_ConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBFiltrar);
            this.Controls.Add(this.lBoxProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_ConsultaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de productos";
            this.Activated += new System.EventHandler(this.form_ConsultaProductos_Load);
            this.Load += new System.EventHandler(this.form_ConsultaProductos_Load);
            this.gBFiltrar.ResumeLayout(false);
            this.gBFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxProductos;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.RadioButton rBtnDescripcion;
        private System.Windows.Forms.RadioButton rBtnPrecio;
        private System.Windows.Forms.RadioButton rBtnCodigo;
        private System.Windows.Forms.GroupBox gBFiltrar;
    }
}