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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SempiternoMasajes.FORMULARIOS
{
    public partial class form_HistorialIncidencias : Form
    {
        public form_HistorialIncidencias()
        {
            InitializeComponent();
        }

        private void form_HistorialIncidencias_Load(object sender, EventArgs e)
        {
            ControladorIncidencia.leerHistorialIncidenciasJSON();
            crearListView();
        }
        private void crearListView()
        {
            // Establece el modo de visualización del ListView
            lvHistorialIncidencias.View = View.Details;

            // Agrega columnas al ListView
            lvHistorialIncidencias.Columns.Add("ID", 150);
            lvHistorialIncidencias.Columns.Add("ÁREA", 100);
            lvHistorialIncidencias.Columns.Add("FECHA INICIO INCIDENCIA", 150);
            lvHistorialIncidencias.Columns.Add("FECHA CIERRE INCIDENCIA", 150);

            // Llena el ListView con datos de la lista
            foreach (Incidencia inci in ControladorIncidencia.historialIncidencias)
            {
                ListViewItem item = new ListViewItem(inci.Id);
                item.SubItems.Add(inci.Concepto);
                DateTime fIni = inci.FechaInicio;
                item.SubItems.Add(fIni.ToShortDateString());
                DateTime fCierre = inci.FechaFin;
                item.SubItems.Add(fCierre.ToShortDateString());

                lvHistorialIncidencias.Items.Add(item);
                
            }
        }
    }
}
