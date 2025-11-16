using System;
using Microsoft.ML.Data;

public class Predicciones
{
    [ColumnName("PredictedLabel")]
    public uint PredictedLabel { get; set; }  // Key type

    [ColumnName("Score")]
    public float[] Scores { get; set; }

    [ColumnName("Label")]
    public uint LabelIndex { get; set; } // la etiqueta original como índice
}