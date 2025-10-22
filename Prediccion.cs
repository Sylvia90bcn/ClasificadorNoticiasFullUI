using Microsoft.ML.Data;

namespace ClasificadorNoticiasGUI
{
    public class Prediccion
    {
        [ColumnName("PredictedLabel")]
        public string CategoriaPredicha { get; set; } = string.Empty;

        public float[]? Score { get; set; }
    }
}
