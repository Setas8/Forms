using SempiternoMasajes.CLASES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SempiternoMasajes.CONTROLADORES
{
    public class ControladorServicio
    {
        public static List<Servicio> listaServicios = new List<Servicio>();

        //Leer de un archivo XML
        public static void leerServiciosXML()
        {
            try
            {
                string xml = File.ReadAllText("servicios.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaServicios.GetType());
                    listaServicios = (List<Servicio>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }
        //Escribir a un archivo XML
        public static void escribirServiciosXML()
        {
            try
            {
                using (var writer = new StreamWriter("servicios.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaServicios.GetType());
                    serializer.Serialize(writer, listaServicios, namespaces);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo xml " + e.Message);
            }
        }
    }
}
