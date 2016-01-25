using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leyhont
{
    class Partido
    {

        private string nombre;
        private int votos;
        private int escaños;

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

        public int Votos
        {
            get
            {
                return votos;
            }

            set
            {
                votos = value;
            }
        }

        public int Escaños
        {
            get
            {
                return escaños;
            }

            set
            {
                escaños = value;
            }
        }

      
    }
}
