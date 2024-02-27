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
    public class ControladorProducto
    {
        public static List<Producto> listaProductos = new List<Producto>();


        public static void leerProductosXML()
        {
            try
            {
                string xml = File.ReadAllText("productos.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaProductos.GetType());
                    listaProductos = (List<Producto>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }
        //Escribir a un archivo XML
        public static void escribirProductosXML()
        {
            try
            {
                using (var writer = new StreamWriter("productos.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaProductos.GetType());
                    serializer.Serialize(writer, listaProductos, namespaces);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo xml " + e.Message);
            }
        }

       
    }
}
