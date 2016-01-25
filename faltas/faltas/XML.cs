using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace faltas
{
    class XML
    {
        XmlNode Raiz;
        XmlDocument Documento;
        

        public void inciarXML(string nomfich)
        {
            Documento = new XmlDocument();
            if (File.Exists(nomfich))
            {
                Documento.Load(nomfich);
                Raiz = Documento.DocumentElement;//Se situa en el nodo raiz
            }

        }
        public List<Modulo> cargaModulos()
        {
            List<Modulo> listaModulos = new List<Modulo>();
            FileStream fichero = File.Open("modulos.txt", FileMode.Open);
            StreamReader lector = new StreamReader(fichero);
            try
            {
                while (!lector.EndOfStream)
                {
                    string[] linea = lector.ReadLine().Split('\t');
                    Modulo modulo = new Modulo();
                    modulo.Id = Convert.ToInt16(linea[0]);
                    modulo.Nombre = linea[1];
                    modulo.Horast = Convert.ToInt16(linea[2]);
                    listaModulos.Add(modulo);

                }

                lector.Close();
            }
            catch (IOException ex) { }

            return listaModulos;

        }

        public bool CargrXML(string NomFichResp)
        {
            bool existe = false;
            Documento = new XmlDocument();

            if (File.Exists(NomFichResp))
            {
                Documento.Load(new StreamReader(NomFichResp, Encoding.Default));
                Raiz = Documento.DocumentElement; //Se sitúa en el nodo raiz
                existe = true;
            }

            return existe;
        }
        public List<Alumno> consultaNotas(int mod, string modulo, double ht)
        {
            List<Alumno> listaAlu = new List<Alumno>();

            if (CargrXML("Faltas.xml"))
            {

                XmlNodeList listaAlumnos = Documento.GetElementsByTagName("DatosAlumnos");
                foreach (XmlNode al in listaAlumnos[0].ChildNodes)
                {
                    Alumno alumno = new Alumno();
                    alumno.Horasf = 0;
                    alumno.Nombre = al.InnerText;
                    alumno.Modulo = modulo;
                    listaAlu.Add(alumno);
                }
                XmlNodeList listaFaltas = Documento.GetElementsByTagName("Falta");

                foreach (XmlNode falta in listaFaltas)
                {
                    int m = Convert.ToInt16(falta.Attributes["modulo"].Value);
                    if (m == mod)
                    {
                        int a = Convert.ToInt16(falta.Attributes["IdAlumno"].Value);
                        listaAlu[a - 1].Horasf++;
                        listaAlu[a - 1].Porcentajef = Math.Round((listaAlu[a - 1].Horasf * 100 / ht), 2);

                    }


                }

            }
            return listaAlu;
        }
        public void crearXml(List<Alumno> lista, string nombreXml)
        {
            Documento = new XmlDocument();
            XmlNode nodoRaiz = Documento.CreateElement("InformeFaltas");
            foreach (Alumno al in lista)
            {
                XmlNode nodo = Documento.CreateElement("Alumno");
                XmlAttribute atributo = Documento.CreateAttribute("HorasFaltadas");
                atributo.Value = Convert.ToString(al.Horasf);
                nodo.Attributes.Append(atributo);
                atributo = Documento.CreateAttribute("PorcentajeFaltas");
                atributo.Value = Convert.ToString(al.Porcentajef);
                nodo.Attributes.Append(atributo);
                XmlNode nodoNobre = Documento.CreateElement("Nombre");
                nodoNobre.InnerText = Convert.ToString(al.Nombre);
                nodo.AppendChild(nodoNobre);
                nodoRaiz.AppendChild(nodo);
            }
            Documento.AppendChild(nodoRaiz);
            Documento.Save(nombreXml);
        }






    }
}
