using SempiternoMasajes.CLASES;
using SempiternoMasajes.CONTROLADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SempiternoMasajes.FORMULARIOS
{
    public partial class form_RegistroCliente : Form
    {
        public form_RegistroCliente()
        {
            InitializeComponent();
        }

        //Variable para guardar posibles clientes
        bool guardar = false;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool crear = false;
            int i;//Comprobar si valor de string se puede parsear
      
            if (string.IsNullOrWhiteSpace(tBNombre.Text))
            {
                tBNombre.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(tBApellido1.Text))
            {
                tBApellido1.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(tBDNI.Text))
            {
                tBDNI.BackColor = Color.Red;
            }
            else if (tBDNI.Text.Length != 9)
            {
                tBDNI.BackColor = Color.Red;
                MessageBox.Show("Dni no válido, debe tener 9 caracteres");
            }         
            else if (!new EmailAddressAttribute().IsValid(tBmail.Text))
            {
                tBmail.BackColor = Color.Red;
                MessageBox.Show("Dni no válido, Ej.: loquesea@sea");
            }        
            else if (!int.TryParse(tBTelefono.Text, out i))
            {
                tBTelefono.BackColor = Color.Red;
                MessageBox.Show("El teléfono sólo debe tener caracteres numéricos");
            }
            else if (tBTelefono.Text.Length != 9)
            {
                tBTelefono.BackColor = Color.Red;
                MessageBox.Show("NºTeléfono no válido, debe tener 9 caracteres");
            }
            else
            {
                tBNombre.BackColor = Color.White;
                tBApellido1.BackColor = Color.White;
                tBDNI.BackColor = Color.White;
                tBmail.BackColor = Color.White;
                tBTelefono.BackColor = Color.White;
                DTPfechaNaci.BackColor = Color.White;
                tBmail.BackColor = Color.White;

                crear = true;
            }

            if (crear)
            {

                Cliente c = new Cliente(stringCaracteres(tBDNI.Text), stringCaracteres(tBNombre.Text),
                                        stringCaracteres(tBApellido1.Text), tBApellido2.Text, stringCaracteres(tBmail.Text),
                                        int.Parse(tBTelefono.Text), Convert.ToDateTime(DTPfechaNaci.Value));

                ControladorCliente.listaClientes.Add(c);
                tBNombre.Clear();
                tBApellido1.Clear();
                tBApellido2.Clear();
                tBDNI.Clear();
                tBmail.Clear();
                tBTelefono.Clear();             
                MessageBox.Show("Cliente creado con éxito");
                guardar = true;
            }
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            tBNombre.Clear();
            tBApellido1.Clear();
            tBApellido2.Clear();
            tBDNI.Clear();
            tBmail.Clear();
            tBTelefono.Clear();
            DTPfechaNaci.ResetText();           
            tBNombre.BackColor = Color.White;
            tBApellido1.BackColor = Color.White;
            tBDNI.BackColor = Color.White;
            tBmail.BackColor = Color.White;
            tBTelefono.BackColor = Color.White;
            DTPfechaNaci.BackColor = Color.White;         
        }
        //Devolver una longitud determinada de caracteres
        public static string stringCaracteres(string palabra)
        {

            int tamanioCampo = 12;
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
        private void form_RegistroClientes_FormClosing(object sender, FormClosingEventArgs e)
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
                    DialogResult diaRes2 = MessageBox.Show("¿Quieres guardar los clientes nuevos?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes2 == DialogResult.Yes)
                    {
                        ControladorCliente.escribirBinario();
                    }
                }
            }
        }
    }
}
