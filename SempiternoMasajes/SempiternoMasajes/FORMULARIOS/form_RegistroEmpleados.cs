using SempiternoMasajes.CLASES;
using SempiternoMasajes.CONTROLADORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SempiternoMasajes.FORMULARIOS
{
    public partial class form_RegistroEmpleados : Form
    {
        public form_RegistroEmpleados()
        {
            InitializeComponent();
        }
        //Variable para guardar posibles empleados
        bool guardar = false;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool crear = false;
            int i;//Comprobar si valor de string se puede parsear
            
            //Validar nombre
            if (string.IsNullOrWhiteSpace(tBNombre.Text))
            {
                tBNombre.BackColor = Color.Red;
            }
            //Validar apellido1
            else if (string.IsNullOrWhiteSpace(tBApellido1.Text))
            {
                tBApellido1.BackColor = Color.Red;
            }
            //Validar dni 
            else if (string.IsNullOrWhiteSpace(tBDNI.Text))
            {
                tBDNI.BackColor = Color.Red;
            }
            else if (!int.TryParse(tBDNI.Text, out i))
            {
                tBDNI.BackColor = Color.Red;
                MessageBox.Show("El DNI sólo debe tener caracteres numéricos");
            }
            else if (tBDNI.Text.Length != 8)
            {
                tBDNI.BackColor = Color.Red;
                MessageBox.Show("Dni no válido, debe tener 8 caracteres");
            }
            //Validar número SS
            else if (tBSS.Text.Length != 9)
            {
                tBSS.BackColor = Color.Red;
                MessageBox.Show("NºSS no válido, debe tener 9 caracteres");
            }
            else if (!int.TryParse(tBSS.Text, out i))
            {
                tBSS.BackColor = Color.Red;
                MessageBox.Show("El NºSS sólo debe tener caracteres numéricos");
            }
            //Validar teléfono           
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
                tBSS.BackColor = Color.White;
                tBTelefono.BackColor = Color.White;
                DTPfechaNaci.BackColor = Color.White;
                cBPuesto.BackColor = Color.White;

                crear = true;
            }  

            if (crear)
            {             
                //Validar DNI
                string dni = ControladorDni.calcularLetraNumDni(int.Parse(tBDNI.Text));

                Empleado em = new Empleado(dni, stringCaracteres(tBNombre.Text), stringCaracteres(tBApellido1.Text),
                                           stringCaracteres(tBApellido2.Text), stringCaracteres(cBPuesto.Text),
                                           int.Parse(tBTelefono.Text), long.Parse(tBSS.Text),
                                           Convert.ToDateTime(DTPfechaNaci.Value));

                ControladorEmpleado.listaEmpleados.Add(em);
                tBNombre.Clear();
                tBApellido1.Clear();
                tBApellido2.Clear();
                tBDNI.Clear();
                tBSS.Clear();
                tBTelefono.Clear();          
                cBPuesto.Text = "Masajista";
                MessageBox.Show("Empleado creado con éxito");
                guardar = true;
            }
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            tBNombre.Clear();
            tBApellido1.Clear();
            tBApellido2.Clear();
            tBDNI.Clear();
            tBSS.Clear();
            tBTelefono.Clear();
            DTPfechaNaci.ResetText();       
            cBPuesto.ResetText();
            tBNombre.BackColor = Color.White;
            tBApellido1.BackColor = Color.White;
            tBDNI.BackColor = Color.White;
            tBSS.BackColor = Color.White;
            tBTelefono.BackColor = Color.White;
            DTPfechaNaci.BackColor = Color.White;
            cBPuesto.BackColor = Color.White;
        }
        //Devolver una longitud determinada de caracteres
        public static string stringCaracteres(string palabra)
        {
            int tamanioCampo = 15;
            string str = "";
            int tamanioPalabra = palabra.Length;

            if (tamanioPalabra <= tamanioCampo)
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
        private void form_RegistroEmpleados_FormClosing(object sender, FormClosingEventArgs e)
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
                    DialogResult diaRes2 = MessageBox.Show("¿Quieres guardar los empleados nuevos?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes2 == DialogResult.Yes)
                    {
                        ControladorEmpleado.escribirEmpleadosXML();
                    }
                }
            }
        }
    }
}
