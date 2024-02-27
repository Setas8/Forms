namespace SempiternoMasajes.FORMULARIOS
{
    partial class form_GestionEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_GestionEmpleados));
            this.gBEmpleados = new System.Windows.Forms.GroupBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vERTODOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBEmpleados
            // 
            this.gBEmpleados.Location = new System.Drawing.Point(33, 56);
            this.gBEmpleados.Name = "gBEmpleados";
            this.gBEmpleados.Size = new System.Drawing.Size(494, 369);
            this.gBEmpleados.TabIndex = 0;
            this.gBEmpleados.TabStop = false;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(568, 78);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(100, 42);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "ALTA LABORAL";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.Location = new System.Drawing.Point(568, 190);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(100, 42);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "BAJA LABORAL";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(568, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 42);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR EMPLEADO";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERTODOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vERTODOSToolStripMenuItem
            // 
            this.vERTODOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMTodos,
            this.TSMAlta,
            this.TSMBaja});
            this.vERTODOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vERTODOSToolStripMenuItem.Name = "vERTODOSToolStripMenuItem";
            this.vERTODOSToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.vERTODOSToolStripMenuItem.Text = "EMPLEADOS";
            // 
            // TSMTodos
            // 
            this.TSMTodos.Name = "TSMTodos";
            this.TSMTodos.Size = new System.Drawing.Size(215, 22);
            this.TSMTodos.Text = "Todos";
            this.TSMTodos.Click += new System.EventHandler(this.TSMTodos_Click);
            // 
            // TSMAlta
            // 
            this.TSMAlta.Name = "TSMAlta";
            this.TSMAlta.Size = new System.Drawing.Size(215, 22);
            this.TSMAlta.Text = "Empleados en alta laboral";
            this.TSMAlta.Click += new System.EventHandler(this.TSMAlta_Click);
            // 
            // TSMBaja
            // 
            this.TSMBaja.Name = "TSMBaja";
            this.TSMBaja.Size = new System.Drawing.Size(215, 22);
            this.TSMBaja.Text = "Empleados de baja laboral";
            this.TSMBaja.Click += new System.EventHandler(this.TSMBaja_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(203, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "TODOS LOS EMPLEADOS";
            // 
            // form_GestionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.gBEmpleados);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_GestionEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_GestionEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.form_GestionEmpleados_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBEmpleados;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vERTODOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMTodos;
        private System.Windows.Forms.ToolStripMenuItem TSMAlta;
        private System.Windows.Forms.ToolStripMenuItem TSMBaja;
        private System.Windows.Forms.Label lblTitulo;
    }
}