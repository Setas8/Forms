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
    public partial class form_compraVentaProductos : Form
    {
        public form_compraVentaProductos()
        {
            InitializeComponent();
        }
        private void form_compraVentaProductos_Load(object sender, EventArgs e)
        {
            ControladorProducto.leerProductosXML();
            mostrarProductosLista(ControladorProducto.listaProductos);
            tbStockAntiguo.Enabled = false;
            numUDStock.Enabled = false;
            btnComprar.Enabled = false;
            btnVender.Enabled = false;
        }
        private int posicionInicial;
        private int contadorNombres;
        private void mostrarProductosLista(List<Producto> lista)
        {
            lboxProductos.Controls.Clear();
            this.contadorNombres = 1; 
            this.posicionInicial = 40;
            foreach (Producto p in lista)
            {
                crearEtiquetaLista(p, p.Descripcion);
            }
        }
        private void mostrarProductosDisponibles(List<Producto> lista)
        {
            lboxProductos.Controls.Clear();
            this.contadorNombres = 1;
            this.posicionInicial = 40;
            foreach (Producto p in lista)
            {
                if (p.Cantidad > 0)
                {
                    crearEtiquetaLista(p, p.Descripcion);
                }
            }
        }
        private void mostrarProductosNoDisponibles(List<Producto> lista)
        {
            lboxProductos.Controls.Clear();          
            this.contadorNombres = 1;
            this.posicionInicial = 40;
            foreach (Producto p in lista)
            {
                if (p.Cantidad == 0)
                {
                    crearEtiquetaLista(p, p.Descripcion);
                }
            }
        }
        void crearEtiquetaLista(Producto p, string nombre)
        {
            RadioButton rb = new RadioButton();
            rb.AutoSize = true;
            rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)
            (0)));
            rb.Location = new System.Drawing.Point(40, this.posicionInicial);
            rb.Name = "lblProductos" + this.contadorNombres;
            rb.Size = new System.Drawing.Size(291, 20);
            rb.TabIndex = 1;
            rb.Text = nombre + "    " + p.Cantidad;
            rb.Tag = p;
            rb.CheckedChanged += RadioButton_CheckedChanged;
            lboxProductos.Controls.Add(rb);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }                                                 
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {      
            lblAviso.Visible = false;
            // Maneja el evento CheckedChanged
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Obtiene el objeto asociado al RadioButton
                Producto p = (Producto)radioButton.Tag;
                        
                lblProducto.Visible = true;
                tbStockAntiguo.Text = p.Cantidad.ToString();
                lblProducto.Text = p.Descripcion.ToString();
            }         
        }     
        private void btnDisponibles_Click(object sender, EventArgs e)
        {
            mostrarProductosDisponibles(ControladorProducto.listaProductos);
        }
        private void btnNoDisponibles_Click(object sender, EventArgs e)
        {
            mostrarProductosNoDisponibles(ControladorProducto.listaProductos);
        }    
        private void TSMCompras_Click(object sender, EventArgs e)
        {          
            mostrarProductosLista(ControladorProducto.listaProductos);
            gBCompras.Enabled = true;
            gBCompras.Visible = true;                    
            btnNoDisponibles.Enabled = false;
            btnDisponibles.Enabled = false;
            lblProducto.Visible = true;
            tbStockAntiguo.Enabled = true;
            numUDStock.Enabled = true;
            btnComprar.Enabled = true;
            btnVender.Enabled = true;
        }
        private void TSMTodosProductos_Click(object sender, EventArgs e)
        {
            mostrarProductosLista(ControladorProducto.listaProductos);
            gBCompras.Enabled = false;
            gBCompras.Visible = false;  
            btnNoDisponibles.Enabled = true;
            btnDisponibles.Enabled = true;           
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            gBCompras.Enabled = true;
            gBCompras.Visible = true;
            //Recorrer los elementos del grupbox para acceder a sus propiedades
            foreach (RadioButton item in lboxProductos.Controls)
            {
                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorProducto.listaProductos.FindIndex(match: p => p == item.Tag);

                    int stock = (int)numUDStock.Value;

                    Producto pro = ControladorProducto.listaProductos[indice];
                 
                    ControladorProducto.listaProductos[indice].Cantidad += stock;                    
                    ControladorProducto.escribirProductosXML();
                    mostrarProductosLista(ControladorProducto.listaProductos);                                    
                }
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            gBCompras.Enabled = true;
            gBCompras.Visible = true;
            //Recorrer los elementos del grupbox para acceder a sus propiedades
            foreach (RadioButton item in lboxProductos.Controls)
            {
                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorProducto.listaProductos.FindIndex(match: p => p == item.Tag);
                    
                    int stock = (int)numUDStock.Value;               
                    Producto pro = ControladorProducto.listaProductos[indice];

                    if (stock > pro.Cantidad)
                    {
                        lblAviso.Visible = true;
                    }
                    else
                    {
                        ControladorProducto.listaProductos[indice].Cantidad -= stock;                    
                        lblAviso.Visible = false;
                        ControladorProducto.escribirProductosXML();
                        mostrarProductosLista(ControladorProducto.listaProductos);
                    }
                }
            }
        }
    }
}
