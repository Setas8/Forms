using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SempiternoMasajes.CLASES
{
    public class Incidencia
    {
        private string id; 
        static private int incremento = 1;
        private string concepto;
        private string descripcion;
        private string observaciones;
        private DateTime fechaInicio;
        private DateTime fechaFin;       


        public Incidencia() { }
        public Incidencia(string concepto, DateTime fechaInicio, string descripcion)
        {
            this.id = "Incidencia-" + incremento + concepto.Substring(0, 4);
            this.Concepto = concepto;
            this.Descripcion = descripcion;    
            this.fechaInicio = fechaInicio;
            incremento++;
        }
        public string Id { get => id; set => id = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        

    }
}

