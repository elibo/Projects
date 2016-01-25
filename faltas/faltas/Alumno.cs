using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faltas
{
    class Alumno
    {

        string nombre;
        string modulo;
        int horasf;
        double porcentajef;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Modulo
        {
            get
            {
                return modulo;
            }

            set
            {
                modulo = value;
            }
        }

        public int Horasf
        {
            get
            {
                return horasf;
            }

            set
            {
                horasf = value;
            }
        }

        public double Porcentajef
        {
            get
            {
                return porcentajef;
            }

            set
            {
                porcentajef = value;
            }
        }
    }
}
