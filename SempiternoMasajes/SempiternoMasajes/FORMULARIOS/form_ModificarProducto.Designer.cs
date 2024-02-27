namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_ModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ModificarProducto));
            this.lBoxProductos = new System.Windows.Forms.ListBox();
            this.lblPrecioNuevo = new System.Windows.Forms.Label();
            this.lblPrecioAntiguo = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.tbPrecioNuevo = new System.Windows.Forms.TextBox();
            this.tbPrecioAntiguo = new System.Windows.Forms.TextBox();
            this.lblTituloPrecio = new System.Windows.Forms.Label();
            this.lblTituloProd = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBoxProductos
            // 
            this.lBoxProductos.FormattingEnabled = true;
            this.lBoxProductos.Location = new System.Drawing.Point(46, 72);
            this.lBoxProductos.Name = "lBoxProductos";
            this.lBoxProductos.ScrollAlwaysVisible = true;
            this.lBoxProductos.Size = new System.Drawing.Size(385, 303);
            this.lBoxProductos.TabIndex = 3;
            // 
            // lblPrecioNuevo
            // 
            this.lblPrecioNuevo.AutoSize = true;
            this.lblPrecioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioNuevo.Location = new System.Drawing.Point(494, 191);
            this.lblPrecioNuevo.Name = "lblPrecioNuevo";
            this.lblPrecioNuevo.Size = new System.Drawing.Size(86, 13);
            this.lblPrecioNuevo.TabIndex = 10;
            this.lblPrecioNuevo.Text = "Precio nuevo:";
            // 
            // lblPrecioAntiguo
            // 
            this.lblPrecioAntiguo.AutoSize = true;
            this.lblPrecioAntiguo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioAntiguo.Location = new System.Drawing.Point(494, 135);
            this.lblPrecioAntiguo.Name = "lblPrecioAntiguo";
            this.lblPrecioAntiguo.Size = new System.Drawing.Size(86, 13);
            this.lblPrecioAntiguo.TabIndex = 9;
            this.lblPrecioAntiguo.Text = "Precio actual:";
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(592, 261);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 3;
            this.btModificar.Text = "MODIFICAR";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // tbPrecioNuevo
            // 
            this.tbPrecioNuevo.Location = new System.Drawing.Point(646, 184);
            this.tbPrecioNuevo.Name = "tbPrecioNuevo";
            this.tbPrecioNuevo.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioNuevo.TabIndex = 2;
            this.tbPrecioNuevo.TextChanged += new System.EventHandler(this.tbPrecioNuevo_TextChanged);
            // 
            // tbPrecioAntiguo
            // 
            this.tbPrecioAntiguo.Location = new System.Drawing.Point(646, 128);
            this.tbPrecioAntiguo.Name = "tbPrecioAntiguo";
            this.tbPrecioAntiguo.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioAntiguo.TabIndex = 1;
            // 
            // lblTituloPrecio
            // 
            this.lblTituloPrecio.AutoSize = true;
            this.lblTituloPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrecio.Location = new System.Drawing.Point(323, 53);
            this.lblTituloPrecio.Name = "lblTituloPrecio";
            this.lblTituloPrecio.Size = new System.Drawing.Size(63, 16);
            this.lblTituloPrecio.TabIndex = 12;
            this.lblTituloPrecio.Text = "PRECIO";
            // 
            // lblTituloProd
            // 
            this.lblTituloProd.AutoSize = true;
            this.lblTituloProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProd.Location = new System.Drawing.Point(88, 53);
            this.lblTituloProd.Name = "lblTituloProd";
            this.lblTituloProd.Size = new System.Drawing.Size(92, 16);
            this.lblTituloProd.TabIndex = 11;
            this.lblTituloProd.Text = "PRODUCTO";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(652, 82);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(0, 13);
            this.lblProducto.TabIndex = 13;
            this.lblProducto.Visible = false;
            // 
            // form_ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblTituloPrecio);
            this.Controls.Add(this.lblTituloProd);
            this.Controls.Add(this.lblPrecioNuevo);
            this.Controls.Add(this.lblPrecioAntiguo);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.tbPrecioNuevo);
            this.Controls.Add(this.tbPrecioAntiguo);
            this.Controls.Add(this.lBoxProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_ModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar producto";
            this.Load += new System.EventHandler(this.form_ModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lBoxProductos;
        private System.Windows.Forms.Label lblPrecioNuevo;
        private System.Windows.Forms.Label lblPrecioAntiguo;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox tbPrecioNuevo;
        private System.Windows.Forms.TextBox tbPrecioAntiguo;
        private System.Windows.Forms.Label lblTituloPrecio;
        private System.Windows.Forms.Label lblTituloProd;
        private System.Windows.Forms.Label lblProducto;
    }
}