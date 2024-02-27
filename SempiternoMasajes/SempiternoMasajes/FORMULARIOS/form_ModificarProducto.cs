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
    public partial class form_ModificarProducto : Form
    {
        public form_ModificarProducto()
        {
            InitializeComponent();
        }
        private void form_ModificarProducto_Load(object sender, EventArgs e)
        {          
            ControladorProducto.leerProductosXML();
            mostrarProductosLista(ControladorProducto.listaProductos);
            tbPrecioAntiguo.Enabled = false;
            tbPrecioNuevo.Enabled = false;
            btModificar.Enabled = false;
        }
        private int posicionInicial;
        private int contadorNombres;
        private void mostrarProductosLista(List<Producto> lista)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;
            foreach (Producto p in lista)
            {
                crearEtiquetaLista(p);
            }
        }       
        void crearEtiquetaLista(Producto p)
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
            rb.Text = p.Descripcion + p.Precio + "€";
            rb.Tag = p;
            rb.CheckedChanged += RadioButton_CheckedChanged;
            lBoxProductos.Controls.Add(rb);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Maneja el evento CheckedChanged
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Obtiene el objeto asociado al RadioButton
                Producto p = (Producto)radioButton.Tag;

                lblProducto.Visible = true;
                tbPrecioAntiguo.Text = p.Precio.ToString();
                lblProducto.Text = p.Descripcion.ToString();
            }

            lblProducto.Visible = true;
            tbPrecioNuevo.Enabled = true;
            btModificar.Enabled = true;
        }
        private void tbPrecioNuevo_TextChanged(object sender, EventArgs e)
        {
            float f;
            if (!float.TryParse(tbPrecioNuevo.Text, out f))
            {
                tbPrecioNuevo.BackColor = Color.Red;
                MessageBox.Show("El precio sólo debe contener caracteres numéricos");
            }
        }
        private void btModificar_Click(object sender, EventArgs e)
        {

            //Recorrer los elementos del grupbox para acceder a sus propiedades
            foreach (RadioButton item in lBoxProductos.Controls)
            {
                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorProducto.listaProductos.FindIndex(match: p => p == item.Tag);

                    ControladorProducto.listaProductos[indice].Precio = float.Parse(tbPrecioNuevo.Text);
                }
            }
            ControladorProducto.escribirProductosXML();
            //Borrar elementos y cargarlos con los modificados
            lBoxProductos.Controls.Clear();
            ControladorProducto.leerProductosXML();
            mostrarProductosLista(ControladorProducto.listaProductos);
            tbPrecioAntiguo.Clear();
            tbPrecioNuevo.Clear();
            tbPrecioAntiguo.Enabled = false;
            tbPrecioNuevo.Enabled = false;
            tbPrecioAntiguo.Clear();
            btModificar.Enabled = false;
        }
    }
}
