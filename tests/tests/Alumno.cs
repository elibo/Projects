using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Alumno
    {

        private string nombre;
        private List<Pregunta> listarespuestas;
        private int acertadas;
        private int falladas;
        private int blanco;
        private int nota;

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

        internal List<Pregunta> Listarespuestas
        {
            get
            {
                return listarespuestas;
            }

            set
            {
                listarespuestas = value;
            }
        }

        public int Acertadas
        {
            get
            {
                return acertadas;
            }

            set
            {
                acertadas = value;
            }
        }

        public int Falladas
        {
            get
            {
                return falladas;
            }

            set
            {
                falladas = value;
            }
        }

        public int Blanco
        {
            get
            {
                return blanco;
            }

            set
            {
                blanco = value;
            }
        }

        public int Nota
        {
            get
            {
                return nota;
            }

            set
            {
                nota = value;
            }
        }
    }
}
