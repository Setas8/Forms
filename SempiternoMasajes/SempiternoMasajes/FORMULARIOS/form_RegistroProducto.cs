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
    public partial class form_RegistroProducto : Form
    {
        public form_RegistroProducto()
        {
            InitializeComponent();
        }

        private void form_RegistroProducto_Load(object sender, EventArgs e)
        {
            ControladorProducto.leerProductosXML();
        }
        private void borrarDatos_Click(object sender, EventArgs e)
        {

            tBoxDescripcion.Clear();
            numUDPrecio.Value = 0;
            cBoxStock.ResetText();
            tBoxDescripcion.BackColor = Color.White;
            numUDPrecio.BackColor = Color.White;
            cBoxStock.BackColor = Color.White;

        }
        //Variable para guardar posibles productos
        bool guardar = false;
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool crear = false;
            //Comprobar si valor de string se puede parsear
            int i;
            float f;
            if (string.IsNullOrWhiteSpace(tBoxDescripcion.Text))
            {
                tBoxDescripcion.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(numUDPrecio.Text))
            {
                numUDPrecio.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cBoxStock.Text))
            {
                cBoxStock.BackColor = Color.Red;
            }
            else if (!float.TryParse(numUDPrecio.Text, out f))
            {
                numUDPrecio.BackColor = Color.Red;
                MessageBox.Show("El precio sólo debe contener caracteres numéricos");
            }
            else if (!int.TryParse(cBoxStock.Text, out i))
            {
                cBoxStock.BackColor = Color.Red;
                MessageBox.Show("El stock sólo debe contener caracteres numéricos");
            }
            else
            {
                tBoxDescripcion.BackColor = Color.White;
                numUDPrecio.BackColor = Color.White;
                cBoxStock.BackColor = Color.White;

                crear = true;
            }

            if (crear)
            {
                Producto p = new Producto(stringCaracteres(tBoxDescripcion.Text), float.Parse(numUDPrecio.Value.ToString()),
                                         int.Parse(cBoxStock.Text));

                ControladorProducto.listaProductos.Add(p);
                tBoxDescripcion.Clear();
                cBoxStock.Text = "1";
               
                MessageBox.Show("Producto creado con éxito");
                guardar = true;
            }
        }
        //Devolver una longitud determinada de caracteres
        public static string stringCaracteres(string palabra)
        {

            int tamanioCampo = 25;
            string str = "";
            int tamanioPalabra = palabra.Length;

            if (tamanioPalabra < tamanioCampo)
            {
                for (int i = tamanioPalabra; i <= tamanioCampo; i++)
                {
                    palabra += " ";
                }
                str = palabra;
            }
            else if (tamanioPalabra > tamanioCampo)
            {
                str = palabra.Substring(0, tamanioCampo);
            }
            else
                str = palabra;

            return str;
        }
        private void form_RegistroProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes1 = MessageBox.Show("¿Estás seguro de cerrar?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes1 == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (guardar)
                {
                    DialogResult diaRes2 = MessageBox.Show("¿Quieres guardar los productos nuevos?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes2 == DialogResult.Yes)
                    {
                        ControladorProducto.escribirProductosXML();                                         
                    }
                }
            }
        }
    }  
}
