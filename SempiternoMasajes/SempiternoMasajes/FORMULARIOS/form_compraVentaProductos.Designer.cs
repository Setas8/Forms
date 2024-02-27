namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_compraVentaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_compraVentaProductos));
            this.btnDisponibles = new System.Windows.Forms.Button();
            this.btnNoDisponibles = new System.Windows.Forms.Button();
            this.lboxProductos = new System.Windows.Forms.ListBox();
            this.TSProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMTodosProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblTituloStock = new System.Windows.Forms.Label();
            this.lblTituloProd = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblStockNuevo = new System.Windows.Forms.Label();
            this.lblStockAntiguo = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.tbStockAntiguo = new System.Windows.Forms.TextBox();
            this.gBCompras = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.numUDStock = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.gBCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisponibles
            // 
            this.btnDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibles.Location = new System.Drawing.Point(69, 387);
            this.btnDisponibles.Name = "btnDisponibles";
            this.btnDisponibles.Size = new System.Drawing.Size(106, 52);
            this.btnDisponibles.TabIndex = 1;
            this.btnDisponibles.Text = "PRODUCTOS PARA VENDER";
            this.btnDisponibles.UseVisualStyleBackColor = true;
            this.btnDisponibles.Click += new System.EventHandler(this.btnDisponibles_Click);
            // 
            // btnNoDisponibles
            // 
            this.btnNoDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoDisponibles.Location = new System.Drawing.Point(258, 387);
            this.btnNoDisponibles.Name = "btnNoDisponibles";
            this.btnNoDisponibles.Size = new System.Drawing.Size(106, 52);
            this.btnNoDisponibles.TabIndex = 2;
            this.btnNoDisponibles.Text = "PRODUCTOS NO DISPONIBLES";
            this.btnNoDisponibles.UseVisualStyleBackColor = true;
            this.btnNoDisponibles.Click += new System.EventHandler(this.btnNoDisponibles_Click);
            // 
            // lboxProductos
            // 
            this.lboxProductos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lboxProductos.FormattingEnabled = true;
            this.lboxProductos.Location = new System.Drawing.Point(12, 52);
            this.lboxProductos.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.lboxProductos.Name = "lboxProductos";
            this.lboxProductos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lboxProductos.Size = new System.Drawing.Size(420, 329);
            this.lboxProductos.Sorted = true;
            this.lboxProductos.TabIndex = 17;
            // 
            // TSProductos
            // 
            this.TSProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMTodosProductos,
            this.TSMCompras});
            this.TSProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSProductos.Name = "TSProductos";
            this.TSProductos.Size = new System.Drawing.Size(91, 20);
            this.TSProductos.Text = "PRODUCTOS";
            // 
            // TSMTodosProductos
            // 
            this.TSMTodosProductos.Name = "TSMTodosProductos";
            this.TSMTodosProductos.Size = new System.Drawing.Size(237, 22);
            this.TSMTodosProductos.Text = "Productos";
            this.TSMTodosProductos.Click += new System.EventHandler(this.TSMTodosProductos_Click);
            // 
            // TSMCompras
            // 
            this.TSMCompras.Name = "TSMCompras";
            this.TSMCompras.Size = new System.Drawing.Size(237, 22);
            this.TSMCompras.Text = "Compra y venta de productos";
            this.TSMCompras.Click += new System.EventHandler(this.TSMCompras_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSProductos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblTituloStock
            // 
            this.lblTituloStock.AutoSize = true;
            this.lblTituloStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloStock.Location = new System.Drawing.Point(301, 33);
            this.lblTituloStock.Name = "lblTituloStock";
            this.lblTituloStock.Size = new System.Drawing.Size(57, 16);
            this.lblTituloStock.TabIndex = 19;
            this.lblTituloStock.Text = "STOCK";
            // 
            // lblTituloProd
            // 
            this.lblTituloProd.AutoSize = true;
            this.lblTituloProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProd.Location = new System.Drawing.Point(66, 33);
            this.lblTituloProd.Name = "lblTituloProd";
            this.lblTituloProd.Size = new System.Drawing.Size(92, 16);
            this.lblTituloProd.TabIndex = 18;
            this.lblTituloProd.Text = "PRODUCTO";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(114, 39);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(0, 13);
            this.lblProducto.TabIndex = 25;
            this.lblProducto.Visible = false;
            // 
            // lblStockNuevo
            // 
            this.lblStockNuevo.AutoSize = true;
            this.lblStockNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockNuevo.Location = new System.Drawing.Point(28, 142);
            this.lblStockNuevo.Name = "lblStockNuevo";
            this.lblStockNuevo.Size = new System.Drawing.Size(83, 13);
            this.lblStockNuevo.TabIndex = 24;
            this.lblStockNuevo.Text = "Stock nuevo:";
            // 
            // lblStockAntiguo
            // 
            this.lblStockAntiguo.AutoSize = true;
            this.lblStockAntiguo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAntiguo.Location = new System.Drawing.Point(28, 90);
            this.lblStockAntiguo.Name = "lblStockAntiguo";
            this.lblStockAntiguo.Size = new System.Drawing.Size(83, 13);
            this.lblStockAntiguo.TabIndex = 23;
            this.lblStockAntiguo.Text = "Stock actual:";
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(31, 212);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(83, 23);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // tbStockAntiguo
            // 
            this.tbStockAntiguo.Location = new System.Drawing.Point(161, 83);
            this.tbStockAntiguo.Name = "tbStockAntiguo";
            this.tbStockAntiguo.Size = new System.Drawing.Size(44, 20);
            this.tbStockAntiguo.TabIndex = 20;
            // 
            // gBCompras
            // 
            this.gBCompras.Controls.Add(this.lblAviso);
            this.gBCompras.Controls.Add(this.btnVender);
            this.gBCompras.Controls.Add(this.numUDStock);
            this.gBCompras.Controls.Add(this.lblProducto);
            this.gBCompras.Controls.Add(this.tbStockAntiguo);
            this.gBCompras.Controls.Add(this.lblStockNuevo);
            this.gBCompras.Controls.Add(this.btnComprar);
            this.gBCompras.Controls.Add(this.lblStockAntiguo);
            this.gBCompras.Location = new System.Drawing.Point(469, 86);
            this.gBCompras.Name = "gBCompras";
            this.gBCompras.Size = new System.Drawing.Size(287, 257);
            this.gBCompras.TabIndex = 26;
            this.gBCompras.TabStop = false;
            this.gBCompras.Text = "COMPRA-VENTA";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(28, 176);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(227, 13);
            this.lblAviso.TabIndex = 29;
            this.lblAviso.Text = "NO HAY TANTAS UNIDADES DISPONIBLES";
            this.lblAviso.Visible = false;
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(170, 212);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(83, 23);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // numUDStock
            // 
            this.numUDStock.Location = new System.Drawing.Point(161, 134);
            this.numUDStock.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUDStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDStock.Name = "numUDStock";
            this.numUDStock.ReadOnly = true;
            this.numUDStock.Size = new System.Drawing.Size(44, 20);
            this.numUDStock.TabIndex = 3;
            this.numUDStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // form_compraVentaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBCompras);
            this.Controls.Add(this.lblTituloStock);
            this.Controls.Add(this.lblTituloProd);
            this.Controls.Add(this.lboxProductos);
            this.Controls.Add(this.btnNoDisponibles);
            this.Controls.Add(this.btnDisponibles);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_compraVentaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra-Venta de productos";
            this.Load += new System.EventHandler(this.form_compraVentaProductos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBCompras.ResumeLayout(false);
            this.gBCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDisponibles;
        private System.Windows.Forms.Button btnNoDisponibles;
        private System.Windows.Forms.ListBox lboxProductos;
        private System.Windows.Forms.ToolStripMenuItem TSProductos;
        private System.Windows.Forms.ToolStripMenuItem TSMCompras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblTituloStock;
        private System.Windows.Forms.Label lblTituloProd;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblStockNuevo;
        private System.Windows.Forms.Label lblStockAntiguo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox tbStockAntiguo;
        private System.Windows.Forms.GroupBox gBCompras;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.NumericUpDown numUDStock;
        private System.Windows.Forms.ToolStripMenuItem TSMTodosProductos;
        private System.Windows.Forms.Label lblAviso;
    }
}