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
    public partial class form_GestionUsuarios : Form
    {
        public form_GestionUsuarios()
        {
            InitializeComponent();
        }

        private void form_GestionUsuarios_Load(object sender, EventArgs e)
        {
            ControladorUsuario.leerUsuariosXML();
            mostrarUsuariosLista(ControladorUsuario.listaUsuarios);
            btnEliminar.Enabled = false;
            btnCambiarPswd.Enabled = false;
        }

        private bool guardar = false;
        private int posicionInicial;
        private int contadorNombres;

        void crearEtiquetaLista(Usuario u)
        {
            CheckBox chBox1 = new System.Windows.Forms.CheckBox();
            chBox1.AutoSize = true;
            chBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)
            (0)));
            chBox1.Location = new System.Drawing.Point(40, this.posicionInicial);
            chBox1.Name = "lblProducto" + this.contadorNombres;
            chBox1.Size = new System.Drawing.Size(291, 20);
            chBox1.TabIndex = 1;
            chBox1.Text = u.Id;
            chBox1.Tag = u;
            chBox1.CheckedChanged += CheckBox_CheckedChanged;
            gBoxUsuarios.Controls.Add(chBox1);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }

        private void mostrarUsuariosLista(List<Usuario> lista)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 15;
            foreach (Usuario u in lista)
            {
                crearEtiquetaLista(u);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {         
            //Recorrer los elementos del grupbox para acceder a sus propiedades
            foreach (CheckBox item in gBoxUsuarios.Controls)
            {

                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorUsuario.listaUsuarios.FindIndex(u => u == item.Tag);
                    ControladorUsuario.listaUsuarios.RemoveAt(indice);
                }
            }
               
            //Borrar elementos y cargarlos con los modificados
            gBoxUsuarios.Controls.Clear();
            mostrarUsuariosLista(ControladorUsuario.listaUsuarios);
            btnEliminar.Enabled = false;
            btnCambiarPswd.Enabled = false;
            guardar = true;
            
        }

        private void btnCambiarPswd_Click(object sender, EventArgs e)
        {
            //Recorrer los elementos del grupbox para acceder a sus propiedades
            foreach (CheckBox item in gBoxUsuarios.Controls)
            {

                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorUsuario.listaUsuarios.FindIndex(u => u == item.Tag);
                    MessageBox.Show("Se envió un correo electrónico de cambio de contraseña al usuario " +
                                     ControladorUsuario.listaUsuarios[indice].Id);
                }
                //Desmarcar los elementos seleccionados
                item.Checked = false;
            }

            btnEliminar.Enabled = false;
            btnCambiarPswd.Enabled = false;
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnCambiarPswd.Enabled = true;
        }
        private void form_GestionEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardar)
            {
                DialogResult diaRes1 = MessageBox.Show("¿Quieres guardar los cambios realizados?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes1 == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    ControladorUsuario.escribirUsuariosXML();
                }
            }
        }
    }
}
