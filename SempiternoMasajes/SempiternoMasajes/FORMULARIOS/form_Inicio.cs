using SempiternoMasajes.CLASES;
using SempiternoMasajes.CONTROLADORES;
using SempiternoMasajes.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SempiternoMasajes.FORMULADRIOS
{
    public partial class form_Inicio : Form
    {
        public form_Inicio()
        {
            InitializeComponent();
        }

        private void form_Inicio_Load(object sender, EventArgs e)
        {
            ControladorUsuario.leerUsuariosXML();
        }

        private void LinkLblAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://learn.microsoft.com/es-es/dotnet/desktop/winforms/overview/?view=netdesktop-7.0");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            btnRegistro.Enabled = false;
            gbInicio.Visible = true;
            lbUser.Visible = true;
            lbPswd.Visible = true;
            tbUser.Visible = true;
            tbPswd.Visible = true;
            btnAceptar.Visible = true;
            btnVolver.Visible = true;
            
        }
        const int INTENTOS = 3;
        int cont = 1;
        //Control para terminar la app sin preguntar
        bool salir = false; 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cont < INTENTOS)
            {
               
                if (!validarLoginLista(tbUser.Text, tbPswd.Text))
                {
                    MessageBox.Show("Datos incorrectos");
                    tbUser.Clear();
                    tbPswd.Clear();
                    tbUser.Focus();
                    cont++;
                    return;
                }

                else
                {
                    tbUser.Clear();
                    tbPswd.Clear();
                    form_Principal principal = new form_Principal();
                    //Mantiene el inicio abierto pero no activo
                    principal.ShowDialog();
                   
                }
            }
            else
            {
                MessageBox.Show("Se acabaron los intentos");
                salir = true;
                Application.Exit();
                
            }
        }
        private bool validarLoginLista(string usuario, string clave)
        {
            int posicion = ControladorUsuario.listaUsuarios.FindIndex(x => x.Id == usuario.ToLower());

            return ((posicion != -1) && (ControladorUsuario.listaUsuarios[posicion].Clave == clave)) ? true : false;
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            form_RegistroUsuario regUsu = new form_RegistroUsuario();
            //Mantiene el inicio abierto pero no activo
            regUsu.ShowDialog();                    
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnRegistro.Enabled = true;
            gbInicio.Visible = false;
            lbUser.Visible = false;
            lbPswd.Visible = false;
            tbUser.Visible = false;
            tbPswd.Visible = false;
            btnAceptar.Visible = false;
            btnVolver.Visible = false;
        }
        private void form_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!salir)
            {
                DialogResult diaRes = MessageBox.Show("¿Estás seguro de salir del programa?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    MessageBox.Show("Hasta pronto!!!");
                }
            }
        }
        private void form_Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {           
            Application.Exit();
        }
    }
}