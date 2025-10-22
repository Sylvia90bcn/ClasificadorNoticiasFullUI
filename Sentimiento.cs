using Microsoft.ML.Data;

namespace ClasificadorNoticiasGUI
{
    public class Sentimiento
    {
        [LoadColumn(0)]
        public string Texto { get; set; } = string.Empty;

        [LoadColumn(1)]
        public string Label { get; set; } = string.Empty;
    }
}
