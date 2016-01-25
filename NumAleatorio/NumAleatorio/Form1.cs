using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumAleatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ManejarCliente(TcpClient cli)
        {
            string data;
            Random r = new Random();
            int ran = r.Next(0, 100);
            int intentos = 0;
            NetworkStream ns = cli.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            sw.WriteLine("Bienvenido, intenta adivinar mi numero");
            sw.Flush();
            while (true)
            {
                try
                {
                    data = sr.ReadLine();

                    Console.WriteLine(data); //para depuración es server
                    if (data.Equals(ran.ToString()))
                    {
                        sw.WriteLine("Adivinado");
                        sw.Flush();
                        break;
                    }
                    else if (data.Equals("exit"))
                    {
                        break;
                    }
                    else if (ran > Int32.Parse(data))
                    {
                        intentos++;
                        sw.WriteLine(intentos.ToString());
                        sw.WriteLine("Es un numero mayor");
                        sw.Flush();
                    }
                    else if (ran < Int32.Parse(data))
                    {
                        intentos++;
                        sw.WriteLine(intentos.ToString());
                        sw.WriteLine("Es un numero menor");
                        sw.Flush();
                    }

                }
                catch (Exception error)
                {
                    Console.WriteLine("Error: {0}", error.ToString());
                }
            }
            ns.Close();
            cli.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TcpListener newsock = new TcpListener(IPAddress.Any, 2000);
            newsock.Start();

            Console.WriteLine("Esperando por cliente");

            while (true)
            {
                TcpClient cliente = newsock.AcceptTcpClient(); 
                Thread t = new Thread(() => this.ManejarCliente(cliente));
                
                t.Start();
            }
        }
    }
}
