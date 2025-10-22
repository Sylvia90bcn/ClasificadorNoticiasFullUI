using Microsoft.ML.Data;

namespace ClasificadorNoticiasGUI
{
    public class Articulo
    {
        [LoadColumn(0)]
        public string Texto { get; set; } = string.Empty;

        [LoadColumn(1)]
        public string Categoria { get; set; } = string.Empty;
    }
}
