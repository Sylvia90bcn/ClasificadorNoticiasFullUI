
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.ML.Data;

namespace MiProyecto
{
    public partial class FrmMatrizConfusion : Form
    {
        public FrmMatrizConfusion(ConfusionMatrix matrix)
        {
            InitializeComponent();
            CargarMatriz(matrix);
        }

        private void CargarMatriz(ConfusionMatrix matrix)
        {
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();
            if (matrix == null) return;

            int clases = matrix.NumberOfClasses;
            dgvMatriz.Columns.Add("Clase", "Clase");
            for (int j = 0; j < clases; j++)
                dgvMatriz.Columns.Add($"Pred_{j}", $"Pred {j}");

            for (int i = 0; i < clases; i++)
            {
                var row = new List<object> { $"Real {i}" };
                for (int j = 0; j < clases; j++)
                    row.Add(matrix.Counts[i][j]);
                dgvMatriz.Rows.Add(row.ToArray());
            }
        }
    }
}
