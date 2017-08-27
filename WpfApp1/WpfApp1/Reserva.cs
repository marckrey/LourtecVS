using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public struct Reserva
    {
        private Localizacion Destino;
        private Localizacion Salida;
        private DateTime fecha;
    }

    public Localizacion Destino {
        get;set;
    }
    public Localizacion Salida {
        get;set;
    }
}
