using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Casa_De_Renta
{
    [Serializable]
    public class Cuarto2 : Reservaciones
    {
        public Cuarto2(string nombre, string carnet, bool vip, DateTime fecha, DateTime fecha2, int dinero): base(nombre,  carnet,  vip,  fecha,  fecha2, dinero)
        {
            
        }
    }
}
