using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    [Serializable]
    public class Localizacion : ISerializable
    {
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Estacion { get; set; }

        public override string ToString()
        {
            return $"{Estacion} - {Ciudad}, { Estado}, {Pais}";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("estado", Estado, typeof(string));
            info.AddValue("ciudad", Ciudad, typeof(string));
            info.AddValue("pais", Pais, typeof(string));
            info.AddValue("estacion", Estacion, typeof(string));
        }
        public Localizacion(SerializationInfo info, StreamingContext context)
        {
            Estado = (string)info.GetValue("estado", typeof(string));
            Ciudad = (string)info.GetValue("ciudad", typeof(string));
            Pais = (string)info.GetValue("pais", typeof(string));
            Estacion = (string)info.GetValue("estacion", typeof(string));
        }

        public Localizacion()
        {

        }
    }
}
