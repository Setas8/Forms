using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SempiternoMasajes.CLASES
{
    public class Empleado //Público para poder usarlo en otros formularios
    {

        private string dni, nombre, apellido1, apellido2, puesto;
        private int telefono;
        private long numSS;
        private DateTime fechaNacimiento;
        private bool alta;

        
        public Empleado() { }

        public Empleado(string dni, string nombre, string apellido1, string apellido2, string puesto, int telefono, long numSS, DateTime fechaNacimiento)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Puesto = puesto;
            Telefono = telefono;
            NumSS = numSS;
            FechaNacimiento = fechaNacimiento;
            alta = true;        
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public long NumSS { get => numSS; set => numSS = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public bool Alta { get => alta; set => alta = value; }
    }
}
