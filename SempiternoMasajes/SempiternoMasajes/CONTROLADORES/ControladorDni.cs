using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SempiternoMasajes.CONTROLADORES
{
    public class ControladorDni
    {
        

        public static readonly string LETRAS_DNI = "TRWAGMYFPDXBNJZSQVHLCKE";

        public static string calcularLetraNumDni(int dni)
        {
            char letra;
            letra = LETRAS_DNI[dni % 23];
                

            return ""+dni+letra;
        }
        

    }
}
