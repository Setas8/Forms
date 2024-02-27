using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SempiternoMasajes.CLASES
{
    public class Servicio //Público para poder usarlo en otros formularios
    {
        private string tipo;
        private string tiempo;
        private DateTime fecha;
        private string hora;
        private string cliente;
        private string masajista;
        public Servicio() { }

        public Servicio(string tipo, string tiempo, DateTime fecha,string hora, string cliente, string masajista)
        {
            this.Tipo = tipo;
            this.Tiempo = tiempo;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Cliente = cliente;
            this.Masajista = masajista;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Tiempo { get => tiempo; set => tiempo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Masajista { get => masajista; set => masajista = value; }
        public string Cliente { get => cliente; set => cliente = value; }
    }
}
