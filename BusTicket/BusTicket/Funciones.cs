using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using BusTicket.Models;
using System.Xml.Serialization;

namespace BusTicket
{
    public class Funciones
    {
        public List<Localizacion> XmlDeserializar(string filepath)
        {
            List<Localizacion> objEntity = new List<Localizacion>();
            // Necesita la referencia System.Runtime.Serialization.Formatter.Soap
            IFormatter formatter = new SoapFormatter();
            var fs = new FileStream(filepath, FileMode.Open);
            objEntity = (List<Localizacion>)formatter.Deserialize(fs);
            fs.Close();
            return objEntity;
        }

        public void XmlSerializarObjeto(string filepath)
        {
            IFormatter formatter = new SoapFormatter();

            Localizacion ListDat = new Localizacion() { Estado = "Lima", Ciudad = "Lima Central", Pais = "Perú", Estacion = "Perú 1" };

            /*
            List<Localizacion> ListDat = new List<Localizacion>();
            ListDat.Add(new Localizacion() { Estado = "Lima", Ciudad = "Lima Central", Pais = "Perú", Estacion = "Perú 1" });
            ListDat.Add(new Localizacion() { Estado = "Trujillo", Ciudad = "Central Trujillo", Pais = "Perú", Estacion = "Perú 2" });
            ListDat.Add(new Localizacion() { Estado = "Cajamarca", Ciudad = "Cajamarca Central", Pais = "Perú", Estacion = "Perú 3" });
            ListDat.Add(new Localizacion() { Estado = "Sullana", Ciudad = "Sullana Central", Pais = "Perú", Estacion = "Perú 4" });
            ListDat.Add(new Localizacion() { Estado = "Piura", Ciudad = "Piura Central", Pais = "Perú", Estacion = "Perú 5" });
            ListDat.Add(new Localizacion() { Estado = "Chiclayo", Ciudad = "Chiclayo Central", Pais = "Perú", Estacion = "Perú 6" });
            */
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
            formatter.Serialize(fs, ListDat);
            fs.Close();
        }

        public void XmlSerializarLista(string filepath)
        {
            IFormatter formatter = new SoapFormatter();

            List<Localizacion> ListDat = new List<Localizacion>();
            ListDat.Add(new Localizacion() { Estado = "Lima", Ciudad = "Lima Central", Pais = "Perú", Estacion = "Perú 1" });
            ListDat.Add(new Localizacion() { Estado = "Trujillo", Ciudad = "Central Trujillo", Pais = "Perú", Estacion = "Perú 2" });
            ListDat.Add(new Localizacion() { Estado = "Cajamarca", Ciudad = "Cajamarca Central", Pais = "Perú", Estacion = "Perú 3" });
            ListDat.Add(new Localizacion() { Estado = "Sullana", Ciudad = "Sullana Central", Pais = "Perú", Estacion = "Perú 4" });
            ListDat.Add(new Localizacion() { Estado = "Piura", Ciudad = "Piura Central", Pais = "Perú", Estacion = "Perú 5" });
            ListDat.Add(new Localizacion() { Estado = "Chiclayo", Ciudad = "Chiclayo Central", Pais = "Perú", Estacion = "Perú 6" });

            //ListaLocalizacion lista = new ListaLocalizacion() { Items = ListDat };
            //XmlSerializer lista = new XmlSerializer(typeof(List<Localizacion>));
            ListaLocalizacion lista = new ListaLocalizacion() { Items = ListDat};

            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
            formatter.Serialize(fs, lista);
            fs.Close();
        }
    }
}
