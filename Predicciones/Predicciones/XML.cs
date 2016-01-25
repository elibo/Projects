using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Predicciones
{
    class XML
    {

        public async void descargarxml() {
            {
                string url =
                "http://www2.meteogalicia.es/galego/observacion/estacions/contidos/DatosHistoricosXML_dezminutal.asp?est=10155&param=2542,2548,2540,2541,2547,2545&data1=16/11/2015&data2=17/11/2015&idprov=2&red=102";

                HttpClient client = new HttpClient();
                Stream respuesta = await client.GetStreamAsync(url);
                StreamReader reader = new StreamReader(respuesta, System.Text.Encoding.ASCII, false);




            }

            



        }



    }
}
