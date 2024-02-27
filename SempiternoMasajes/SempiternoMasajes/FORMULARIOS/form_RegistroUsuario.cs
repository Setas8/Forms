using SempiternoMasajes.CLASES;
using SempiternoMasajes.CONTROLADORES;
using SempiternoMasajes.FORMULADRIOS;
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
    public partial class form_RegistroUsuario : Form
    {
        public form_RegistroUsuario()
        {
            InitializeComponent();
        }
        private void form_RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
        //Variable para guardar posibles usuarios
        bool guardar = false;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool crear = false;

            if (string.IsNullOrWhiteSpace(tbUser.Text))
            {
                tbUser.BackColor = Color.Red;
            }
            else if (string.IsNullOrWhiteSpace(tbPswd.Text))
            {
                tbPswd.BackColor = Color.Red;
            }
            else if (tbUser.Text.Length > 10)
            {
                tbUser.BackColor = Color.Red;
                MessageBox.Show("El id debe tener menos de 10 caracteres");
            }
            else if (tbPswd.Text.Length > 10)
            {
                tbPswd.BackColor = Color.Red;
                MessageBox.Show("La contraseña debe tener menos de 10 caracteres");
            }
            else if (!new EmailAddressAttribute().IsValid(tbMail.Text))
            {
                tbMail.BackColor = Color.Red;
                MessageBox.Show("Dni no válido, Ej.: loquesea@sea.sea");
            }
            else
            {
                tbUser.BackColor = Color.White;
                tbPswd.BackColor = Color.White;
                tbMail.BackColor= Color.White; 


                crear = true;
            }

            if (crear)
            {
                Usuario u = new Usuario(tbUser.Text.ToString(), tbPswd.Text.ToString(), tbMail.Text.ToString());

                ControladorUsuario.listaUsuarios.Add(u);
                MessageBox.Show("Usuario creado con éxito");
                guardar = true;
                tbUser.Clear();
                tbPswd.Clear();
                tbMail.Clear();
                tbUser.BackColor = Color.White;
                tbPswd.BackColor = Color.White;
                tbMail.BackColor = Color.White;

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUser.Clear();
            tbPswd.Clear();
            tbMail.Clear();
            tbUser.BackColor = Color.White;
            tbPswd.BackColor = Color.White;
            tbMail.BackColor = Color.White;
        }            
        private void form_RegistroUsuario_FormClosing(object sender, FormClosingEventArgs e)
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
                    DialogResult diaRes2 = MessageBox.Show("¿Quieres guardar los nuevos usuarios?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (diaRes2 == DialogResult.Yes)
                    {
                        MessageBox.Show("Se envió un mensaje a su mail, verifícalo en 48 horas (ficticio)");
                        ControladorUsuario.escribirUsuariosXML();
                    }
                }
            }          
        }
        ErrorProvider errorProvider1 = new ErrorProvider();
        ErrorProvider errorProvider2 = new ErrorProvider();
        private void user_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbUser.Text))
            {
                errorProvider1.SetError(tbUser, "El campo nuevo usuario se debe rellenar");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void pswd_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPswd.Text))
            {
                errorProvider2.SetError(tbPswd, "El campo contraseña se debe rellenar");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}
