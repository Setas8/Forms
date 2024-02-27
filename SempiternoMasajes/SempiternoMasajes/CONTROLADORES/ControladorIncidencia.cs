using SempiternoMasajes.CLASES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SempiternoMasajes.CONTROLADORES
{
    public class ControladorIncidencia
    {
        public static List<Incidencia> listaIncidencias = new List<Incidencia>();
        public static List<Incidencia> historialIncidencias = new List<Incidencia>();

       
       public static void leerIncidenciasJSON()
       {
           try
           {
               if (File.Exists("incidencias.json"))
               {
                   string jsonString = File.ReadAllText("incidencias.json");
                    listaIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(jsonString);
               }
           }
           catch (Exception e)
           {
               Console.WriteLine("Error leyendo json " + e.Message);
           }

       }
       public static void escribirIncidenciasJSON()
       {
           try
           {
               if (File.Exists("incidencias.json"))
               {
                   string jsonString = JsonSerializer.Serialize(listaIncidencias);
                   File.WriteAllText("incidencias.json", jsonString);
               }
           }
           catch (Exception e)
           {
               Console.WriteLine("Error escribiendo json " + e.Message);
           }
       }
        public static void leerHistorialIncidenciasJSON()
        {
            try
            {
                if (File.Exists("historialIncidencias.json"))
                {
                    string jsonString = File.ReadAllText("historialIncidencias.json");
                    historialIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(jsonString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo json " + e.Message);
            }

        }
        public static void escribirHistorialIncidenciasJSON()
        {
            try
            {
                if (File.Exists("historialIncidencias.json"))
                {
                    string jsonString = JsonSerializer.Serialize(historialIncidencias);
                    File.WriteAllText("historialIncidencias.json", jsonString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo json " + e.Message);
            }
        }

    }
}
