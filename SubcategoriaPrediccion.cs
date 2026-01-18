using Microsoft.ML.Data;

namespace ClasificadorNoticiasGUI
{
    public class SubcategoriaPrediccion
    {
        [ColumnName("PredictedLabel")]
        public string SubcategoriaPredicha { get; set; } = string.Empty;

        public float[]? Score { get; set; }
    }
}
