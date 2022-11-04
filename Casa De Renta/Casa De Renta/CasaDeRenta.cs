using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Casa_De_Renta
{
    [Serializable]
    public class CasaDeRenta
    {
        private List<Reservaciones> reservaciones;

        public List<Reservaciones> Reservaciones
        {
            get
            {
                return reservaciones;
            }

            set
            {
                reservaciones = value;
            }
        }

        public CasaDeRenta()
        {
            reservaciones = new List<Reservaciones>();
        }

        public void AddReserv(Reservaciones r)
        {
           
           reservaciones.Add(r);
            
        }

        public bool OcupadaCuarto1(DateTime fecha)
        {

            for (int i = 0; i < reservaciones.Count; i++)
            {
                if (reservaciones[i] is Cuarto1)
                {

                    if (fecha >= (reservaciones[i] as Cuarto1).Fecha && fecha <= (reservaciones[i] as Cuarto1).Fecha2)
                    {
                        return true;
                    }

                }
            }return false;
        }

        public bool OcupadaCuarto2(DateTime fecha)
            {

            for (int i = 0; i < reservaciones.Count; i++)
            {
                if (reservaciones[i] is Cuarto2)
                {

                    if (fecha >= (reservaciones[i] as Cuarto2).Fecha && fecha <= (reservaciones[i] as Cuarto2).Fecha2)
                    {
                        return true;
                    }

                }
            }

            return false;
        }


        public void DeleteReserv(int p)
        {
            reservaciones.RemoveAt(p);
        }

        public List<Reservaciones> BuscarPorCi(string ci)
        {
            List<Reservaciones> pe = new List<Casa_De_Renta.Reservaciones>();
            foreach (Reservaciones r in reservaciones)
            {
                if (r.Carnet==ci)
                {
                    pe.Add(r);
                }
            }
            return pe;
        }

        public List<Reservaciones> BuscarPorNombre(string nombre)
        {
            List<Reservaciones> pe = new List<Casa_De_Renta.Reservaciones>();
            foreach (Reservaciones r in reservaciones)
            {
                if (r.Nombre == nombre)
                {
                    pe.Add(r);
                }
            }
            return pe;
        }

    }
}
