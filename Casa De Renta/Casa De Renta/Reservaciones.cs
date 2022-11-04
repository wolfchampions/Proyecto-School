using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Casa_De_Renta
{
    [Serializable]
    public abstract class Reservaciones
    {
        protected string nombre;
        protected string carnet;
        protected bool vip;
        DateTime fecha;
        DateTime fecha2;
        protected int dinero;
        

        public string Nombre
        {
            get
            {
                return nombre;
            }

        }

        public string Carnet
        {
            get
            {
                return carnet;
            }
        }

        public bool Vip
        {
            get
            {
                return vip;
            }

        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public DateTime Fecha2
        {
            get
            {
                return fecha2;
            }

            set
            {
                fecha2 = value;
            }
        }

        public int Dinero
        {
            get
            {
                return dinero;
            }
        }

        public Reservaciones(string nombre, string carnet, bool vip, DateTime fecha, DateTime fecha2, int dinero)
        {
            this.nombre = nombre;
            this.carnet = carnet;
            this.vip = vip;
            this.fecha = fecha;
            this.fecha2 = fecha2;
            this.dinero = dinero;
        }


    }
}
