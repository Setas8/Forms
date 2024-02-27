using SempiternoMasajes.CLASES;
using SempiternoMasajes.CONTROLADORES;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SempiternoMasajes.FORMULARIOS
{
    public partial class form_GestionQuiromasaje : Form
    {
        public form_GestionQuiromasaje()
        {
            InitializeComponent();
        }
        private void form_GestionQuiromasaje_Load(object sender, EventArgs e)
        {
            ControladorCliente.leerBinario();
            ControladorEmpleado.leerEmpleadosXML();
            seleccionarCliente(ControladorCliente.listaClientes);
            seleccionarMasajista(ControladorEmpleado.listaEmpleados);
        }
        private void seleccionarCliente(List<Cliente> lista)
        {
            foreach (Cliente c in lista)
            {                           
                cbCliente.Items.Add(c.Nombre);
            }
        }
        private void seleccionarMasajista(List<Empleado> lista)
        {
            foreach (Empleado e in lista)
            {              
                if (e.Puesto.Equals("Masajista    "))
                {
                    cbEmpleado.Items.Add(e.Nombre);
                }
                    
            }
        }
        bool guardar = false;   
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool crear = false;
            if (string.IsNullOrWhiteSpace(cbDuracion.Text))
            {
                cbDuracion.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(dtpFecha.Text))
            {
                dtpFecha.BackColor = Color.Red;
            }
            else if ((DateTime.Compare(Convert.ToDateTime(dtpFecha.Value), DateTime.Now)) <= 0)
            {
                dtpFecha.BackColor = Color.Red;
                lblAviso.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(cbHora.Text))
            {
                cbHora.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(cbCliente.Text))
            {
                cbCliente.BackColor = Color.Red;
            }
            else if(string.IsNullOrWhiteSpace(cbEmpleado.Text))
            {
                cbEmpleado.BackColor = Color.Red;
            }
            else
            {
                cbDuracion.BackColor = Color.White;
                cbHora.BackColor = Color.White;
                cbCliente.BackColor = Color.White;
                cbEmpleado.BackColor = Color.White;
                lblAviso.Visible = false;
                crear = true;
            }               

            if  (crear)
            {
                Servicio s = new Servicio(stringCaracteres("Quiromasaje"), stringCaracteres(cbDuracion.Text),
                                       Convert.ToDateTime(dtpFecha.Value), stringCaracteres(cbHora.Text),
                                       stringCaracteres(cbCliente.Text), stringCaracteres(cbEmpleado.Text));


                ControladorServicio.listaServicios.Add(s);
                cbDuracion.ResetText();
                cbHora.ResetText();
                cbCliente.ResetText();
                cbEmpleado.ResetText();
                MessageBox.Show("Servicio creado con éxito");
                guardar = true;
            }           
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            cbDuracion.ResetText();
            cbHora.ResetText();
            cbCliente.ResetText();
            cbEmpleado.ResetText();
            dtpFecha.ResetText();
        }
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
        private void form_RegistroQuiromasaje_FormClosing(object sender, FormClosingEventArgs e)
        {          
            if (guardar)
            {
                DialogResult diaRes = MessageBox.Show("¿Quieres guardar los servicios nuevos?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes == DialogResult.Yes)
                {
                    ControladorServicio.escribirServiciosXML();
                }
            }           
        }
    }
}
