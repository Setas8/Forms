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
    public partial class form_RegistroIncidencia : Form
    {
        public form_RegistroIncidencia()
        {
            InitializeComponent();
        }
        
        bool guardar = false;
        bool crear = false;

        ErrorProvider errorProvider = new ErrorProvider();        
        private void descripcion_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbDescripcion.Text))
            {
                tbDescripcion.BackColor = Color.Red;
                errorProvider.SetError(tbDescripcion, "Debes rellenar una descripción de la avería");
            }
            else if (string.IsNullOrEmpty(cBConcepto.Text))
            {
                cBConcepto.BackColor = Color.Red;
            }
            else
            {
                errorProvider.Clear();
                crear = true;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {           
            if (crear)
            {
                
                Incidencia i = new Incidencia(cBConcepto.Text, DateTime.Now.Date, tbDescripcion.Text);

                ControladorIncidencia.listaIncidencias.Add(i);
                cBConcepto.ResetText();
                tbDescripcion.Clear();
                tbDescripcion.BackColor = Color.White;
                cBConcepto.BackColor = Color.White;
                MessageBox.Show("Incidencia creada con éxito");
                guardar = true;
            }
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            cBConcepto.ResetText();
            tbDescripcion.Clear();
            tbDescripcion.BackColor = Color.White;
        }
        private void form_RegistroIncidencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardar)
            {
                DialogResult diaRes2 = MessageBox.Show("¿Quieres guardar las incidencias?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes2 == DialogResult.Yes)
                {
                    ControladorIncidencia.escribirIncidenciasJSON();
                }
            }          
        }
    }
}
