using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificadorNoticiasGUI
{
    public class EntradaExcel
    {
        public string Autor { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public string Titular { get; set; } = string.Empty;
        public string Sentimiento { get; set; } = string.Empty;
    }
}
