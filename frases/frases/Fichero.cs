using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace frases
{
    class Fichero
    {

       
        string autor;
        string frase;
        List<Fichero> f;
        Fichero a;
       

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string Frase
        {
            get
            {
                return frase;
            }

            set
            {
                frase = value;
            }
        }

        public List<Fichero> carga(string ruta) {
            
            f = new List<Fichero>();
            string l;
            StreamReader sr = new StreamReader(ruta, Encoding.Default);
            while ((l = sr.ReadLine()) != null)
            {
                string[] linea = l.Split('-');
                a = new Fichero();
                a.frase = linea[0];
                a.autor = linea[1];
                f.Add(a);
            }
            sr.Close();
            return f;
            
        }

        public void guardarxml(List<Fichero> lista , string ruta) {
            XmlDocument doc = new XmlDocument();
            XmlNode raiz = doc.CreateElement("Frases");
            foreach (Fichero fic in lista)
            {
                XmlNode nod = doc.CreateElement("Frase");
                XmlNode autor = doc.CreateElement("Autor");
                XmlNode cita = doc.CreateElement("Cita");
                cita.InnerText = fic.frase;
                autor.InnerText = fic.autor;
                nod.AppendChild(autor);
                nod.AppendChild(cita);
                raiz.AppendChild(nod);

            }
            doc.AppendChild(raiz);
            doc.Save(ruta);
            
          





        }

 
    }
}
