using Microsoft.ML.Data;

namespace ClasificadorNoticiasGUI
{
    /// <summary>
    /// Minimal row used to train/predict subcategories.
    /// CSV format expected: Texto,Subcategoria
    /// </summary>
    public class SubcategoriaArticulo
    {
        [LoadColumn(0)]
        public string Texto { get; set; } = string.Empty;

        [LoadColumn(1)]
        public string Subcategoria { get; set; } = string.Empty;
    }
}
