using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class Alumno
    {

        string nombre;
        string modulo;
        int horasfaltadas;
        double porcentaje;

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

        public double Porcentaje
        {
            get
            {
                return porcentaje;
            }

            set
            {
                porcentaje = value;
            }
        }
    }
}
