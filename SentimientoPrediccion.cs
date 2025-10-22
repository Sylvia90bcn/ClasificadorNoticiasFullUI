using Microsoft.ML.Data;

namespace ClasificadorNoticiasGUI
{
    public class SentimientoPrediccion
    {
        [ColumnName("PredictedLabel")]
        public string SentimientoPredicho { get; set; } = string.Empty;

        public float[]? Score { get; set; }
    }
}
