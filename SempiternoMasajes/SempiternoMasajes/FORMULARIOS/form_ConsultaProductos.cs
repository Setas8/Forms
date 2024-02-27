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
    public partial class form_ConsultaProductos : Form
    {
        public form_ConsultaProductos()
        {
            InitializeComponent();
        }
        private void form_ConsultaProductos_Load(object sender, EventArgs e)
        {
            ControladorProducto.leerProductosXML();
            mostrarProductos();
        }
        private void mostrarProductos()
        {          
            lBoxProductos.Items.Clear();

            lBoxProductos.Items.Add("PRODUCTO" + "\t\tCÓDIGO" + "\t PRECIO");

            foreach (Producto p in ControladorProducto.listaProductos)
            {
                lBoxProductos.Items.Add(p.Descripcion + "\t" + p.Codigo + "\t" + p.Precio + "€");
            }

            lBoxProductos.Show();
        }
        private void rBtnDescripcion_CheckedChanged(object sender, EventArgs e)
        {         
            ControladorProducto.listaProductos.Sort((p1, p2) => p1.Descripcion.CompareTo(p2.Descripcion));
            mostrarProductos();
        }
        private void rBtnPrecio_CheckedChanged(object sender, EventArgs e)
        {
            ControladorProducto.listaProductos.Sort((p1, p2) => p1.Precio.CompareTo(p2.Precio));
            mostrarProductos();
        }
        private void rBtnCodigo_CheckedChanged(object sender, EventArgs e)
        {
            ControladorProducto.listaProductos.Sort((p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            mostrarProductos();
        }      
    }
}
