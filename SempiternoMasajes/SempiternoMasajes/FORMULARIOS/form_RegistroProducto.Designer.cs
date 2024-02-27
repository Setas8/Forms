namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_RegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RegistroProducto));
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.numUDPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.borrarDatos = new System.Windows.Forms.Button();
            this.cBoxStock = new System.Windows.Forms.ComboBox();
            this.tBoxDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 72);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(129, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Nombre del producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 137);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(122, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio del producto:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(12, 201);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(134, 13);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Cantidad de unidades:";
            // 
            // numUDPrecio
            // 
            this.numUDPrecio.DecimalPlaces = 2;
            this.numUDPrecio.Increment = new decimal(new int[] {
            250,
            0,
            0,
            131072});
            this.numUDPrecio.Location = new System.Drawing.Point(182, 129);
            this.numUDPrecio.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUDPrecio.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDPrecio.Name = "numUDPrecio";
            this.numUDPrecio.ReadOnly = true;
            this.numUDPrecio.Size = new System.Drawing.Size(120, 20);
            this.numUDPrecio.TabIndex = 2;
            this.numUDPrecio.Value = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Location = new System.Drawing.Point(182, 265);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 33);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // borrarDatos
            // 
            this.borrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.borrarDatos.Location = new System.Drawing.Point(182, 323);
            this.borrarDatos.Name = "borrarDatos";
            this.borrarDatos.Size = new System.Drawing.Size(84, 33);
            this.borrarDatos.TabIndex = 5;
            this.borrarDatos.Text = "BORRAR";
            this.borrarDatos.UseVisualStyleBackColor = false;
            this.borrarDatos.Click += new System.EventHandler(this.borrarDatos_Click);
            // 
            // cBoxStock
            // 
            this.cBoxStock.FormattingEnabled = true;
            this.cBoxStock.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "50",
            "100",
            "150",
            "200"});
            this.cBoxStock.Location = new System.Drawing.Point(182, 193);
            this.cBoxStock.Name = "cBoxStock";
            this.cBoxStock.Size = new System.Drawing.Size(121, 21);
            this.cBoxStock.TabIndex = 3;
            this.cBoxStock.Text = "1";
            // 
            // tBoxDescripcion
            // 
            this.tBoxDescripcion.Location = new System.Drawing.Point(182, 64);
            this.tBoxDescripcion.Name = "tBoxDescripcion";
            this.tBoxDescripcion.Size = new System.Drawing.Size(193, 20);
            this.tBoxDescripcion.TabIndex = 1;
            // 
            // form_RegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 543);
            this.Controls.Add(this.tBoxDescripcion);
            this.Controls.Add(this.cBoxStock);
            this.Controls.Add(this.borrarDatos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.numUDPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_RegistroProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_RegistroProducto_FormClosing);
            this.Load += new System.EventHandler(this.form_RegistroProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numUDPrecio;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button borrarDatos;
        private System.Windows.Forms.ComboBox cBoxStock;
        private System.Windows.Forms.TextBox tBoxDescripcion;
    }
}