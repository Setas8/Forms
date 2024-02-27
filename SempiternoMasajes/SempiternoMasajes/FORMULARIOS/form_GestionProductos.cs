using SempiternoMasajes.CLASES;
using SempiternoMasajes.CONTROLADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SempiternoMasajes.FORMULARIOS
{
    public partial class form_GestionProductos : Form
    {
        public form_GestionProductos()
        {
            InitializeComponent();
        }
        private void form_GestionProductos_Load(object sender, EventArgs e)
        {
            ControladorProducto.leerProductosXML();
            mostrarProductosLista(ControladorProducto.listaProductos);
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;    
            btnModificar.Enabled = false;
            
        }
        //Variable para guardar posibles cambios
        bool guardar = false;
        
        private int posicionInicial;
        private int contadorNombres;

        void crearEtiquetaLista(Producto p)
        {
            RadioButton chBox1 = new System.Windows.Forms.RadioButton();
            chBox1.AutoSize = true;
            chBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)
            (0)));
            chBox1.Location = new System.Drawing.Point(40, this.posicionInicial);
            chBox1.Name = "lblProducto" + this.contadorNombres;
            chBox1.Size = new System.Drawing.Size(291, 20);
            chBox1.TabIndex = 1;
            chBox1.Text = p.Descripcion;
            chBox1.Tag = p;
            gBoxProductos.Controls.Add(chBox1);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }
        private void mostrarProductosLista(List<Producto> lista)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;
            foreach (Producto p in lista)
            {
                crearEtiquetaLista(p);
            }
        }     
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (RadioButton item in gBoxProductos.Controls)
            {
                if (item.Checked)
                {                   
                    int indice = ControladorProducto.listaProductos.FindIndex(p => p.Descripcion == item.Text);
                    ControladorProducto.listaProductos.RemoveAt(indice);
                }
            }          
            gBoxProductos.Controls.Clear();
            mostrarProductosLista(ControladorProducto.listaProductos);
            guardar = true;
        }
        private void TSMenuAltaProducto_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;        
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            gBoxProductos.Enabled = false;
        }
        private void TSMenuBajaProducto_Click(object sender, EventArgs e)
        {
            gBoxProductos.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            gBoxProductos.Enabled = true;
        }
        private void TSMenuModificarProducto_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            gBoxProductos.Enabled = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            form_RegistroProducto regProducto = new form_RegistroProducto();
            //Mantiene el inicio abierto pero no activo
            regProducto.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            form_ModificarProducto modProducto = new form_ModificarProducto();
            modProducto.ShowDialog();
        }         
        private void form_GestionProductos_FormClosing(object sender, FormClosingEventArgs e)
        {         
            if (guardar)
            {         
                DialogResult diaRes1 = MessageBox.Show("¿Quieres guardar las gestiones realizadas?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes1 == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    ControladorProducto.escribirProductosXML();
                }
            }
        }    
    }
}
