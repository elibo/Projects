using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class Modulo
    {

        int id;
        string nmodulo;
        int horastotales;
        int horasfaltadas;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nmodulo
        {
            get
            {
                return nmodulo;
            }

            set
            {
                nmodulo = value;
            }
        }



        public int Horastotales
        {
            get
            {
                return horastotales;
            }

            set
            {
                horastotales = value;
            }
        }

        public int Horasfaltadas
        {
            get
            {
                return horasfaltadas;
            }

            set
            {
                horasfaltadas = value;
            }
        }

  
    }
}
