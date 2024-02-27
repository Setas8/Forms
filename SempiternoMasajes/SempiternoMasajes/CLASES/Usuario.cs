using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SempiternoMasajes.CLASES
{
    public class Usuario //Público para poder usarlo en otros formularios
    {
        private string id;
        private string clave;
        private string mail;


        //Constructor vacío para XML
        public Usuario() { }

        public Usuario (string id, string clave, string mail)
        {
            this.Id = id;
            this.Clave = clave;
            this.Mail = mail;
        }

        public string Id { get => id; set => id = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
