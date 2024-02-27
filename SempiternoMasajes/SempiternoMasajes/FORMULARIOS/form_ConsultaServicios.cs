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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SempiternoMasajes.FORMULARIOS
{
    public partial class form_ConsultaServicios : Form
    {
        public form_ConsultaServicios()
        {
            InitializeComponent();         
        }

        private void form_ConsultaServicios_Load(object sender, EventArgs e)
        {
            ControladorServicio.leerServiciosXML();
            crearListView();
        }
        private void crearListView()
        {           
            lvServicios.View = View.Details;

            // Agrega columnas al ListView
            lvServicios.Columns.Add("TIPO", 110);
            lvServicios.Columns.Add("TIEMPO", 100);
            lvServicios.Columns.Add("FECHA SERVICIO", 140);
            lvServicios.Columns.Add("HORA", 80);
            lvServicios.Columns.Add("CLIENTE", 110);
            lvServicios.Columns.Add("MASAJISTA", 110);

            // Llena el ListView con datos de la lista
            foreach (Servicio ser in ControladorServicio.listaServicios)
            {
                ListViewItem item = new ListViewItem(ser.Tipo);
                item.SubItems.Add(ser.Tiempo);
                DateTime fIni = ser.Fecha;
                item.SubItems.Add(fIni.ToShortDateString());
                item.SubItems.Add(ser.Hora);
                item.SubItems.Add(ser.Cliente);
                item.SubItems.Add(ser.Masajista);

                lvServicios.Items.Add(item);
            }
        }            
        private void btnOrdenarTipo_Click(object sender, EventArgs e)
        {
            lvServicios.Items.Clear();
            lvServicios.Columns.Clear();
            ControladorServicio.listaServicios.Sort((e1, e2) => e1.Tipo.CompareTo(e2.Tipo));
            crearListView();
        }
        private void btnOrdenarHora_Click(object sender, EventArgs e)
        {
            lvServicios.Items.Clear();
            lvServicios.Columns.Clear();
            ControladorServicio.listaServicios.Sort((e1, e2) => e1.Hora.CompareTo(e2.Hora));
            crearListView();
        }
        private void btnOrdenarMasajista_Click(object sender, EventArgs e)
        {
            lvServicios.Items.Clear();
            lvServicios.Columns.Clear();
            ControladorServicio.listaServicios.Sort((e1, e2) => e1.Masajista.CompareTo(e2.Masajista));
            crearListView();
        }
        private void btnOrdenarFecha_Click(object sender, EventArgs e)
        {
            lvServicios.Items.Clear();
            lvServicios.Columns.Clear();
            ControladorServicio.listaServicios.Sort((e1, e2) => DateTime.Compare(e1.Fecha, e2.Fecha));
            crearListView();
        }
    }
}