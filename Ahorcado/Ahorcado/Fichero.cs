using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Ahorcado
{
    class Fichero
    {

        string ruta = @"C:\Users\elibo\Downloads\palabras.txt";
        string palabra;
        string oculta;
        public string clave = "cifrado";
        

        public string Palabra
        {
            get
            {
                return palabra;
            }

            set
            {
                palabra = value;
            }
        }

        public string Oculta
        {
            get
            {
                return oculta;
            }

            set
            {
                oculta = value;
            }
        }

        public void guardaPalabra() {
            FileStream fs = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            StreamWriter w = new StreamWriter(fs);
            string c = cifrar(palabra);
            if (!File.Exists(ruta))
            {
                File.Create(ruta);
                w.Write(c+Environment.NewLine);
                w.Close();
            }
           
            else
            {
                    w.Write(c+Environment.NewLine);
                    w.Close();
                }
            }
        

        public string cargaPalabra() {
            string p,l;
            StreamReader r = new StreamReader(ruta,Encoding.Default);
            Random rnd = new Random();
            List<string> lista = new List<string>();
            while ((l = r.ReadLine()) != null) {
                lista.Add(l);
            }
            r.Close();
            int i = rnd.Next(0,lista.Count());
            p = descifrar(lista[i]);
            return p;

        }
    


    public string cifrar(string cadena) // Función para cifrar una cadena.
        {
            byte[] llave; //Array donde guardaremos la llave para el cifrado 3DES.
            byte[] arreglo = UTF8Encoding.UTF8.GetBytes(cadena); //Array donde guardaremos la cadena a cifrar.
                                                                 // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateEncryptor(); // Iniciamos la conversión de la cadena
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length); //Arreglo de bytes donde guardaremos

            tripledes.Clear();
            return Convert.ToBase64String(resultado, 0, resultado.Length); // Convertimos la cadena y la regresamos.
        }


        public string descifrar(string cadena)
        {
            byte[] llave;
            byte[] arreglo = Convert.FromBase64String(cadena); // Arreay donde guardaremos la cadena descovertida.
                                                               // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.

            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave; tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;

            ICryptoTransform convertir = tripledes.CreateDecryptor();
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length); tripledes.Clear();
            string cadena_descifrada = UTF8Encoding.UTF8.GetString(resultado); // Obtenemos la cadena 
            return cadena_descifrada;
        }


        public void OcultarPalabra()
        {
            oculta = "";
            foreach(char i in palabra)
            {
                oculta += "*"; 
            }
        }




    }
}
 
