using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SempiternoMasajes.CLASES
{
    public class Producto //Público para poder usarlo en otros formularios
    {

        private int codigo;
        static private int incrementoCod = 1;
        private string descripcion;
        private float precio;
        private int cantidad;

        public Producto(string descripcion, float precio, int cantidad)
        {
            codigo = incrementoCod;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            incrementoCod++;
        }


        //Constructor vacío para XML
        public Producto() { }


        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }    
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}

