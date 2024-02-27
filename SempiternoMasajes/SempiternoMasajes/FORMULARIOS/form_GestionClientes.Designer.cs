namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_GestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_GestionClientes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMenuRegistroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.lBClientes = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.BtnFechaNacimiento = new System.Windows.Forms.RadioButton();
            this.btnDNI = new System.Windows.Forms.RadioButton();
            this.btnNombre = new System.Windows.Forms.RadioButton();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuRegistroCliente});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMenuRegistroCliente
            // 
            this.TSMenuRegistroCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMenuRegistroCliente.Name = "TSMenuRegistroCliente";
            this.TSMenuRegistroCliente.Size = new System.Drawing.Size(82, 20);
            this.TSMenuRegistroCliente.Text = "Alta cliente";
            this.TSMenuRegistroCliente.Click += new System.EventHandler(this.TSMenuRegistroCliente_Click);
            // 
            // lBClientes
            // 
            this.lBClientes.FormattingEnabled = true;
            this.lBClientes.Location = new System.Drawing.Point(34, 58);
            this.lBClientes.Name = "lBClientes";
            this.lBClientes.ScrollAlwaysVisible = true;
            this.lBClientes.Size = new System.Drawing.Size(717, 212);
            this.lBClientes.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(332, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "ToString(\"dd/MM/yy\")";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.Location = new System.Drawing.Point(47, 61);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(123, 25);
            this.lblOrdenar.TabIndex = 13;
            this.lblOrdenar.Text = "ORDENAR";
            // 
            // BtnFechaNacimiento
            // 
            this.BtnFechaNacimiento.AutoSize = true;
            this.BtnFechaNacimiento.Location = new System.Drawing.Point(215, 68);
            this.BtnFechaNacimiento.Name = "BtnFechaNacimiento";
            this.BtnFechaNacimiento.Size = new System.Drawing.Size(124, 17);
            this.BtnFechaNacimiento.TabIndex = 2;
            this.BtnFechaNacimiento.TabStop = true;
            this.BtnFechaNacimiento.Text = "Fecha de nacimiento";
            this.BtnFechaNacimiento.UseVisualStyleBackColor = true;
            this.BtnFechaNacimiento.CheckedChanged += new System.EventHandler(this.BtnFechaNacimiento_CheckedChanged);
            // 
            // btnDNI
            // 
            this.btnDNI.AutoSize = true;
            this.btnDNI.Location = new System.Drawing.Point(215, 92);
            this.btnDNI.Name = "btnDNI";
            this.btnDNI.Size = new System.Drawing.Size(44, 17);
            this.btnDNI.TabIndex = 3;
            this.btnDNI.TabStop = true;
            this.btnDNI.Text = "DNI";
            this.btnDNI.UseVisualStyleBackColor = true;
            this.btnDNI.CheckedChanged += new System.EventHandler(this.btnDNI_CheckedChanged);
            // 
            // btnNombre
            // 
            this.btnNombre.AutoSize = true;
            this.btnNombre.Location = new System.Drawing.Point(215, 45);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(62, 17);
            this.btnNombre.TabIndex = 1;
            this.btnNombre.TabStop = true;
            this.btnNombre.Text = "Nombre";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.CheckedChanged += new System.EventHandler(this.btnNombre_CheckedChanged);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.BtnFechaNacimiento);
            this.gbFiltrar.Controls.Add(this.lblOrdenar);
            this.gbFiltrar.Controls.Add(this.btnNombre);
            this.gbFiltrar.Controls.Add(this.btnDNI);
            this.gbFiltrar.Location = new System.Drawing.Point(190, 291);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(388, 147);
            this.gbFiltrar.TabIndex = 14;
            this.gbFiltrar.TabStop = false;
            // 
            // form_GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFiltrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lBClientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_GestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de clientes";
            this.Activated += new System.EventHandler(this.form_GestionClientes_Load);
            this.Load += new System.EventHandler(this.form_GestionClientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenuRegistroCliente;
        private System.Windows.Forms.ListBox lBClientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.RadioButton BtnFechaNacimiento;
        private System.Windows.Forms.RadioButton btnDNI;
        private System.Windows.Forms.RadioButton btnNombre;
        private System.Windows.Forms.GroupBox gbFiltrar;
    }
}