using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace ClasificadorNoticiasGUI
{
    public class ResultadoModelo
    {
        public string TipoModelo { get; set; }       // "Categorías" o "Sentimientos"
        public string Metodo { get; set; }           // Nombre del método
        public double Accuracy { get; set; }
        public double MicroAccuracy { get; set; }
        public double MacroAccuracy { get; set; }
        public double LogLoss { get; set; }
        public List <double> TopKAccuracy { get; set; }
        public ConfusionMatrix ConfusyMatrix { get; set; }
        public double Precision { get; set; }
        public double Recall { get; set; }
        public double F1Score { get; set; }
        public double AUC { get; set; }


        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
