using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprmirPdf
{
    public static class ContenidoHTML
    {
            public static string ObtenerContenidoHTML()
            {
                string encabezado = "Factura-Cliente";
                string contenidoHTML = $@"
            <html>
            <head>
                <link rel='stylesheet' type='text/css' href='estilos.css' media='all'>
            </head>
            <body>
                <h1>{encabezado}</h1>
                <div class=""Factura"">
                <p>Numero de factura:01</p>
                <button class=""boton""> boton </button>
                 </div>
            </body>
            </html>";

                return contenidoHTML;
            }
    }
}

