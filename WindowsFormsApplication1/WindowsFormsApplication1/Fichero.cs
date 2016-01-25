using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Fichero
    {

        
        string ruta;
        

        public string Ruta
        {
            get
            {
                return ruta;
            }

            set
            {
                ruta = value;
            }
        }

     

        public bool abrirFichero(string ruta) {

          
            if (File.Exists(ruta)) {
                return true;
            }
            else
                return false;
          
        }

        public List<string> lineaLinea(string ruta) {
            StreamReader reader = new StreamReader(ruta,Encoding.Default);
            List<string> lista = new List<string>();
            string linea;
            if (abrirFichero(ruta))
            {
                while ((linea=reader.ReadLine()) != null)
                {
                    lista.Add(linea);
                }
            }
            reader.Close();
            return lista;

        }

        public void leefinal(string ruta) {
            StreamReader r = new StreamReader(ruta, Encoding.Default);
            if (File.Exists(ruta))
            {
                string texto = r.ReadToEnd();
                r.Close();
            }

        }

        public void añadeLinea(string ruta,string linea) {
            FileStream fs = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            if (File.Exists(ruta)) {
                if (!String.IsNullOrEmpty(linea)) {
                    StreamWriter w = new StreamWriter(fs, Encoding.Default);
                    w.Write(linea);
                    w.Close();
                }
            }
        }

        public List<string> buscAutor(string autor) {
            List<string> l=lineaLinea(ruta);
            List<string> a = l.FindAll(x => x.Contains(autor));
            return a;

        }








    }
}
