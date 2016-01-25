using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace examen
{
    class XML
    {
        XmlDocument doc;
        XmlNode raiz;
        

    public List<Modulo> cargartxt()
        {
            List<Modulo> modulos = new List<Modulo>();
            StreamReader reader = new StreamReader("modulos.txt", Encoding.Default);
            while (!reader.EndOfStream) {
                string[] l = reader.ReadLine().Split('\t');
                Modulo m = new Modulo();
                m.Id = Int32.Parse(l[0]);
                m.Nmodulo = l[1];
                m.Horastotales = Int32.Parse(l[2]);
                modulos.Add(m);

            }
            reader.Close();


            return modulos;
        }

        public bool cargarxml(string fichero) {
            doc = new XmlDocument();
            if (File.Exists(fichero)) {
                doc.Load(new StreamReader(fichero, Encoding.Default));
                raiz = doc.DocumentElement;
            }
            return false;
        }

        public List<Alumno> cargar() {
            List<Alumno> alu = new List<Alumno>();
            if (cargarxml("alumnos.xml"))
            {
                XmlNodeList lista = doc.GetElementsByTagName("Alumno");
                foreach (XmlNode a in lista)
                {
                    Alumno alum = new Alumno();
                    alum.Nombre = a.Attributes["nombre"].Value;
                    alum.Modulo = a["Modulo"].InnerText;
                    alum.Horasfaltadas =Int32.Parse( a["Horas"].InnerText);
                    alum.Porcentaje = Double.Parse(a["Porcentaje"].InnerText);
                    alu.Add(alum);
                }


            }

            return alu;
        }
        public void crearxml(List<Alumno> alu, string fichero) {
            doc = new XmlDocument();
            XmlNode raiz = doc.CreateElement("Alumnos");
            foreach (Alumno a in alu)
            {
                XmlNode nodo = doc.CreateElement("Alumno");
                XmlAttribute at = doc.CreateAttribute("nombre");
                at.Value = a.Nombre;
                nodo.Attributes.Append(at);
                XmlNode modulo = doc.CreateElement("Modulo");
                modulo.InnerText = a.Modulo;
                XmlNode horas = doc.CreateElement("Horas");
                horas.InnerText = a.Horasfaltadas.ToString();
                XmlNode porcentaje = doc.CreateElement("Porcentaje");
                porcentaje.InnerText = a.Porcentaje.ToString();
                nodo.AppendChild(modulo);
                nodo.AppendChild(horas);
                nodo.AppendChild(porcentaje);
                raiz.AppendChild(nodo);


            }
            doc.AppendChild(raiz);
            doc.Save(fichero);

        }
            

    }
}
