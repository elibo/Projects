using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicciones
{
    class Viento
    {

        string categoria;
        string denominacion;
        int velocidad;
        string etierra;
        string emar;
        int olas;

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public string Denominacion
        {
            get
            {
                return denominacion;
            }

            set
            {
                denominacion = value;
            }
        }

        public int Velocidad
        {
            get
            {
                return velocidad;
            }

            set
            {
                velocidad = value;
            }
        }

        public string Etierra
        {
            get
            {
                return etierra;
            }

            set
            {
                etierra = value;
            }
        }

        public string Emar
        {
            get
            {
                return emar;
            }

            set
            {
                emar = value;
            }
        }

        public int Olas
        {
            get
            {
                return olas;
            }

            set
            {
                olas = value;
            }
        }
    }
}
