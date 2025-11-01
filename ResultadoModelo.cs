using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificadorNoticiasGUI
{
    public class ResultadoModelo
    {
        public string TipoModelo { get; set; }       // "Categorías" o "Sentimientos"
        public string Metodo { get; set; }           // Nombre del método
        public double MicroAccuracy { get; set; }
        public double MacroAccuracy { get; set; }
        public double LogLoss { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
