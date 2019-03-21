using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Hilos.Clases
{
    class Transaccion
    {
        public string transaccion { get; set; }
        public string transmision { get; set; }
        public string marca { get; set; }
        public double monto { get; set; }

        public Transaccion(string _transmision, string _marca, string _transaccion,  double _monto)
        {
            transaccion = _transaccion;
            transmision = _transmision;
            marca = _marca;
            monto = _monto;
        }

    }
}
