using SempiternoMasajes.FORMULADRIOS;
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
    public partial class form_Principal : Form
    {
        public form_Principal()
        {
            InitializeComponent();
        }
        private void TSMenuGestionProductos_Click(object sender, EventArgs e)
        {
            form_GestionProductos gesPro = new form_GestionProductos();
            //Mantiene el inicio abierto pero no activo
            gesPro.ShowDialog();
        }
        private void TSMenuCompraVentaProductos_Click(object sender, EventArgs e)
        {
            form_compraVentaProductos compraVenta = new form_compraVentaProductos();
            //Mantiene el inicio abierto pero no activo
            compraVenta.ShowDialog();
        }
        private void TSMenuConsultaProductos_Click(object sender, EventArgs e)
        {
            form_ConsultaProductos consulPro = new form_ConsultaProductos();
            //Mantiene el inicio abierto pero no activo
            consulPro.ShowDialog();
        }
        private void TSMenuEstadisticas_Click(object sender, EventArgs e)
        {
            form_Estadisticas estadisticas = new form_Estadisticas();
            //Mantiene el inicio abierto pero no activo
            estadisticas.ShowDialog();
        }
        private void TSMenuGestionEmpleados_Click(object sender, EventArgs e)
        {
            form_GestionEmpleados gesEmpleado = new form_GestionEmpleados();
            //Mantiene el inicio abierto pero no activo
            gesEmpleado.ShowDialog();
        }      
        private void TSMenuRegistroEmpleados_Click(object sender, EventArgs e)
        {          
            form_RegistroEmpleados regEmpleado = new form_RegistroEmpleados();
            //Mantiene el inicio abierto pero no activo
            regEmpleado.ShowDialog();
        }
        private void ToolSMClientes_Click(object sender, EventArgs e)
        {
            form_GestionClientes gesClientes = new form_GestionClientes();
            //Mantiene el inicio abierto pero no activo
            gesClientes.ShowDialog();
        }    
        private void TSMenuQuiromasaje_Click(object sender, EventArgs e)
        {
            form_GestionQuiromasaje quiro = new form_GestionQuiromasaje();
            //Mantiene el inicio abierto pero no activo
            quiro.ShowDialog();          
        }
        private void TSMenuReflexologia_Click(object sender, EventArgs e)
        {          
            form_GestionReflexologia refle = new form_GestionReflexologia();
            //Mantiene el inicio abierto pero no activo
            refle.ShowDialog();
        }
        private void TSMenuConsultaServicios_Click(object sender, EventArgs e)
        {
            form_ConsultaServicios servicios = new form_ConsultaServicios();
            //Mantiene el inicio abierto pero no activo
            servicios.ShowDialog();
        }
        private void TSMenuGestionIncidencias_Click(object sender, EventArgs e)
        {
            form_GestionIncidencias incidencias = new form_GestionIncidencias();
            //Mantiene el inicio abierto pero no activo
            incidencias.ShowDialog();
            
        }
        private void TSMenuRegistroIncidencia_Click(object sender, EventArgs e)
        {
            form_RegistroIncidencia regIncidencia = new form_RegistroIncidencia();
            //Mantiene el inicio abierto pero no activo
            regIncidencia.ShowDialog();           
        }
        private void TSMenuHistorialincidencia_Click(object sender, EventArgs e)
        {
            form_HistorialIncidencias historialInci = new form_HistorialIncidencias();
            //Mantiene el inicio abierto pero no activo
            historialInci.ShowDialog();           
        }
        private void TSMenuGestionUsuarios_Click(object sender, EventArgs e)
        {
            form_GestionUsuarios gestUsu = new form_GestionUsuarios();
            //Mantiene el inicio abierto pero no activo
            gestUsu.ShowDialog();
        }
        private void form_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("¿Estás seguro de cerrar?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = true;
            }
        }      
    }
}
