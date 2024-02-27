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

namespace SempiternoMasajes.FORMULARIOS
{
    public partial class form_GestionClientes : Form
    {
        public form_GestionClientes()
        {
            InitializeComponent();
        }
        private void form_GestionClientes_Load(object sender, EventArgs e)
        {
            ControladorCliente.leerBinario();
            mostrarClientesLista(ControladorCliente.listaClientes);

        }
        private void TSMenuRegistroCliente_Click(object sender, EventArgs e)
        {
            form_RegistroCliente regCliente = new form_RegistroCliente();
            //Mantiene el inicio abierto pero no activo
            regCliente.ShowDialog();
        }
        private void mostrarClientesLista(List<Cliente> lista)
        {
            this.contadorNombres = 1;
            this.posicionInicial = 40;
            foreach (Cliente c in lista)
            {

                crearEtiquetaLista(c.toString());

            }
        }
        private int posicionInicial;
        private int contadorNombres;
        void crearEtiquetaLista(string nombre)
        {
            Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)
            (0)));
            GrupoLbl.Location = new System.Drawing.Point(1, this.posicionInicial);
            GrupoLbl.Name = "lblClientes" + this.contadorNombres;
            GrupoLbl.Size = new System.Drawing.Size(291, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Text = nombre;
            lBClientes.Controls.Add(GrupoLbl);
            this.posicionInicial += 20;
            this.contadorNombres++;
        }

        private void btnNombre_CheckedChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = "LISTA CLIENTES (nombre)";
            lBClientes.Controls.Clear();
            ControladorCliente.listaClientes.Sort((c1, c2) => c1.Nombre.CompareTo(c2.Nombre));
            mostrarClientesLista(ControladorCliente.listaClientes);
        }

        private void BtnFechaNacimiento_CheckedChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = "LISTA CLIENTES (fecha de nacimiento)";
            lBClientes.Controls.Clear();
            //listaProyectos.Sort((x, y) => x.FechaInicio.CompareTo(y.FechaInicio));
            ControladorCliente.listaClientes.Sort((c1, c2) => DateTime.Compare(c1.FechaNacimiento, c2.FechaNacimiento));
            mostrarClientesLista(ControladorCliente.listaClientes);
        }

        private void btnDNI_CheckedChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = "LISTA CLIENTES (dni)";
            lBClientes.Controls.Clear();
            ControladorCliente.listaClientes.Sort((c1, c2) => c1.Dni.CompareTo(c2.Dni));
            mostrarClientesLista(ControladorCliente.listaClientes);
        }       
    }
}
