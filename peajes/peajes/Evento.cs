using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peajes
{
    class Evento
    {
        private string fecha;
        private string matricula;
        private string puerta;
        private int precio;

        public string Fecha
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

        public string Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public string Puerta
        {
            get
            {
                return puerta;
            }

            set
            {
                puerta = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }

    
}