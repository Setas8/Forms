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
    public partial class form_GestionIncidencias : Form
    {
        public form_GestionIncidencias()
        {
            InitializeComponent();
        }
        private void form_GestionIncidencias_Load(object sender, EventArgs e)
        {
            ControladorIncidencia.leerIncidenciasJSON();
            mostrarIncidenciasAbiertas(ControladorIncidencia.listaIncidencias);
            btnConfirmar.Enabled = false;
            btnObservaciones.Enabled = false;   
            btnImprimir.Enabled = false;
        }

        private int posicionInicial;
        private int contadorNombres;
        private void mostrarIncidenciasAbiertas(List<Incidencia> lista)
        {
            gbIncidencias.Controls.Clear();
            this.contadorNombres = 1;
            this.posicionInicial = 40;
            foreach (Incidencia inc in lista)
            {             
                crearEtiquetaLista(inc);              
            }
        }
        void crearEtiquetaLista(Incidencia inc)
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
            rb.Text = inc.Id + "   " + inc.Concepto + "      " + inc.FechaInicio.ToShortDateString();
            rb.Tag = inc;
            rb.CheckedChanged += RadioButton_CheckedChanged;
            gbIncidencias.Controls.Add(rb);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            lblAviso.Visible = false;
            // Maneja el evento CheckedChanged
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Obtiene el objeto asociado al RadioButton
                Incidencia inc = (Incidencia)radioButton.Tag;

                btnConfirmar.Enabled = true;
                btnObservaciones.Enabled = true;
                btnImprimir.Enabled = true;                
            }

        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lblAviso.Visible = true;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
            
            //Recorrer los elementos del grupbox para acceder a sus propiedades
            foreach (RadioButton item in gbIncidencias.Controls)
            {
                if (item.Checked)
                {
                    //Guardar el índice Si la descripción del producto es igual a la descripción del elemento
                    int indice = ControladorIncidencia.listaIncidencias.FindIndex(match: inc => inc == item.Tag);
                
                    Incidencia inci = ControladorIncidencia.listaIncidencias[indice];

                    ControladorIncidencia.listaIncidencias[indice].FechaFin = DateTime.Now.Date;
                    ControladorIncidencia.historialIncidencias.Add(inci);
                    ControladorIncidencia.listaIncidencias.Remove((Incidencia)item.Tag);


                    ControladorIncidencia.escribirIncidenciasJSON();
                    ControladorIncidencia.escribirHistorialIncidenciasJSON();
                    mostrarIncidenciasAbiertas(ControladorIncidencia.listaIncidencias);
                    btnConfirmar.Enabled = false;
                    btnObservaciones.Enabled = false;
                    btnImprimir.Enabled = false;
                }
            }
        }
        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            panelObservaciones.Visible = true;
        }

        bool guardar = false;
        private void observaciones_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbObservaciones.Text))
            {
                tbObservaciones.BackColor = Color.Red;
                errorProvider.SetError(tbObservaciones, "Debes rellenar una observación de la avería");
            }
            else
            {
                errorProvider.Clear();
                guardar = true;
            }
        }
        private void btnObserConfirmar_Click(object sender, EventArgs e)
        {
            if (guardar)
            {
                //Recorrer los elementos del grupbox para acceder a sus propiedades
                foreach (RadioButton item in gbIncidencias.Controls)
                {
                    if (item.Checked)
                    {
                        int indice = ControladorIncidencia.listaIncidencias.FindIndex(match: inc => inc == item.Tag);

                        Incidencia inci = ControladorIncidencia.listaIncidencias[indice];

                        ControladorIncidencia.listaIncidencias[indice].Observaciones = tbObservaciones.Text;

                        ControladorIncidencia.escribirIncidenciasJSON();
                        panelObservaciones.Visible = false;
                        btnConfirmar.Enabled = false;
                        btnObservaciones.Enabled = false;
                        btnImprimir.Enabled = false;
                    }
                }
                panelObservaciones.Visible = false;
            }            
        }
        
        ErrorProvider errorProvider = new ErrorProvider();      
        private void btnObserBorrar_Click(object sender, EventArgs e)
        {
            tbObservaciones.Clear();
            tbObservaciones.BackColor = Color.White;
        }
    }
}
