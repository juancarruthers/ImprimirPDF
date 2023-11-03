using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ImprmirPdf.ContenidoHTML;

namespace ImprmirPdf
{
    public partial class ImprimirPDF : Form
    {
        public ImprimirPDF()
        {
            InitializeComponent();
        }

        private void ImprimirPDF_Load(object sender, EventArgs e)
        {

        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            // Genera el contenido HTML y CSS
            string contenidoHTML = ContenidoHTML.ObtenerContenidoHTML();
            string estilosCSS = EstilosCSS.ObtenerEstilosCSS();

            try
            {
                // Crea un archivo temporal con extensión .html y escribe el contenido HTML
                string tempFilePath = Path.Combine(Path.GetTempPath(), "Factura-Cliente.html");
                File.WriteAllText(tempFilePath, contenidoHTML);
                File.WriteAllText(Path.Combine(Path.GetTempPath(), "estilos.css"), estilosCSS);

                // Abre el archivo HTML en el navegador web predeterminado
                Process.Start(new ProcessStartInfo(tempFilePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el contenido HTML en el navegador: " + ex.Message);
            }
        }

    }
}
