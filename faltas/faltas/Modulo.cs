using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faltas
{
    class Modulo
    {

        int id;
        string nombre;
        int horast;
        int horasf;

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

        public int Horast
        {
            get
            {
                return horast;
            }

            set
            {
                horast = value;
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
    }
}
