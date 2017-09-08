using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    [Serializable]
    class ListaLocalizacion : ISerializable
    {
        private List<Localizacion> _items;
        public List<Localizacion> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("items", Items, typeof(List<Localizacion>));
        }
        public ListaLocalizacion(SerializationInfo info, StreamingContext context)
        {
            Items = (List<Localizacion>)info.GetValue("items", typeof(string));
        }

        public ListaLocalizacion()
        {

        }
    }
}
