using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesca
{
    class Pesca
    {

        string especie;
        string valor;
        string habitat;
        string nciencia;
        string cmin;
        List<string> notas;

        public string Especie
        {
            get
            {
                return especie;
            }

            set
            {
                especie = value;
            }
        }

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string Habitat
        {
            get
            {
                return habitat;
            }

            set
            {
                habitat = value;
            }
        }

        public string Nciencia
        {
            get
            {
                return nciencia;
            }

            set
            {
                nciencia = value;
            }
        }

        public string Cmin
        {
            get
            {
                return cmin;
            }

            set
            {
                cmin = value;
            }
        }

        public List<string> Notas
        {
            get
            {
                return notas;
            }

            set
            {
                notas = value;
            }
        }
    }
}
