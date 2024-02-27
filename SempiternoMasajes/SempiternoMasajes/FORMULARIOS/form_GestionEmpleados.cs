using SempiternoMasajes.CLASES;
using SempiternoMasajes.CONTROLADORES;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace SempiternoMasajes.FORMULARIOS
{
    public partial class form_GestionEmpleados : Form
    {
        public form_GestionEmpleados()
        {
            InitializeComponent();
        }       
        private void form_GestionEmpleados_Load(object sender, EventArgs e)
        {
            ControladorEmpleado.leerEmpleadosXML();
            mostrarEmpleadosLista(ControladorEmpleado.listaEmpleados);
            btnEliminar.Enabled = false;
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
        }
        //Variable para guardar posibles cambios
        bool guardar = false;
        private int posicionInicial;
        private int contadorNombres;
        private void TSMTodos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "TODOS LOS EMPLEADOS";
            gBEmpleados.Controls.Clear();
            mostrarEmpleadosLista(ControladorEmpleado.listaEmpleados);
            btnEliminar.Enabled = false;
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
        }
        private void TSMAlta_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "EMPLEADOS EN ALTA LABORAL";
            gBEmpleados.Controls.Clear();
            mostrarEmpleadosAlta(ControladorEmpleado.listaEmpleados);
            btnEliminar.Enabled = false;
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
        }
        private void TSMBaja_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "EMPLEADOS EN BAJA LABORAL";
            gBEmpleados.Controls.Clear();
            mostrarEmpleadosBaja(ControladorEmpleado.listaEmpleados);
            btnEliminar.Enabled = false;
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            foreach (CheckBox item in gBEmpleados.Controls)
            {

                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorEmpleado.listaEmpleados.FindIndex(p => p == item.Tag);
                    ControladorEmpleado.listaEmpleados[indice].Alta = true;
                }
            }
            ControladorEmpleado.escribirEmpleadosXML();
            //Borrar elementos y cargarlos con los modificados
            gBEmpleados.Controls.Clear();
            mostrarEmpleadosBaja(ControladorEmpleado.listaEmpleados);          
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            foreach (CheckBox item in gBEmpleados.Controls)
            {

                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorEmpleado.listaEmpleados.FindIndex(p => p == item.Tag);
                    ControladorEmpleado.listaEmpleados[indice].Alta = false;
                }
            }
            ControladorEmpleado.escribirEmpleadosXML();
            //Borrar elementos y cargarlos con los modificados
            gBEmpleados.Controls.Clear();
            mostrarEmpleadosAlta(ControladorEmpleado.listaEmpleados);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {         
            //Recorrer los elementos del grupbox para acceder a sus propiedades
            foreach (CheckBox item in gBEmpleados.Controls)
            {

                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorEmpleado.listaEmpleados.FindIndex(p => p == item.Tag);
                    ControladorEmpleado.listaEmpleados.RemoveAt(indice);
                }
            }               
            gBEmpleados.Controls.Clear();
            mostrarEmpleadosLista(ControladorEmpleado.listaEmpleados);
            guardar = true;
        }       
        void crearEtiquetaLista(Empleado e)
        {
            CheckBox chBox1 = new System.Windows.Forms.CheckBox();
            chBox1.AutoSize = true;
            chBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)
            (0)));
            chBox1.Location = new System.Drawing.Point(40, this.posicionInicial);
            chBox1.Name = "lblEmpleados" + this.contadorNombres;
            chBox1.Size = new System.Drawing.Size(291, 20);
            chBox1.TabIndex = 1;
            chBox1.Text = e.Nombre + " " + e.Apellido1 + " " +
                          e.Apellido2 + " " + e.Dni;
            chBox1.Tag = e;
            chBox1.CheckedChanged += CheckBox_CheckedChanged;
            gBEmpleados.Controls.Add(chBox1);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }

        private void mostrarEmpleadosLista(List<Empleado> lista)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;
            foreach (Empleado e in lista)
            {
                crearEtiquetaLista(e);
            }
        }
        private void mostrarEmpleadosAlta(List<Empleado> lista)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;
            foreach (Empleado e in lista)
            {
                if (e.Alta)
                {
                    crearEtiquetaLista(e);
                }
            }
        }
        private void mostrarEmpleadosBaja(List<Empleado> lista)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;
            foreach (Empleado e in lista)
            {
                if (!e.Alta)
                {
                    crearEtiquetaLista(e);
                }
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {         
            btnEliminar.Enabled = true;
            btnAlta.Enabled = true;
            btnBaja.Enabled = true;
            mostrarEmpleadosLista(ControladorEmpleado.listaEmpleados);
        }
        private void form_GestionEmpleados_FormClosing(object sender, FormClosingEventArgs e)
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
                    ControladorEmpleado.escribirEmpleadosXML();
                }
            }
        }
    }
}
