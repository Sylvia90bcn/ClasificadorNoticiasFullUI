using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using ExcelDataReader;
using Microsoft.ML;

namespace ClasificadorNoticiasGUI
{
    public partial class Form1 : Form
    {
        static readonly string ModeloCategoriasPath = Path.Combine("Modelo", "modelo_categorias.zip");
        static readonly string ModeloSentimientosPath = Path.Combine("Modelo", "modelo_sentimientos.zip");
        static readonly string DatosCategoriasPath = Path.Combine("Datos", "datos.csv");
        static readonly string DatosSentimientosPath = Path.Combine("Datos", "sentimientos.csv");

        MLContext ml = new MLContext(seed: 1);
        ITransformer modeloCat = null, modeloSent = null;
        private Label lblProgreso;

        public Form1()
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.White;
            EnsureFolders();
            CargarModelosSiExisten();
            CargarDatasetEnGrilla();

            // Inicialización de lblProgreso
            lblProgreso = new Label
            {
                Name = "lblProgreso",
                Text = "",
                AutoSize = true,
                Location = new System.Drawing.Point(20, 420) // Ajusta la posición según tu diseño
            };
            Controls.Add(lblProgreso);
        }

        void EnsureFolders()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DatosCategoriasPath) ?? "Datos");
            Directory.CreateDirectory(Path.GetDirectoryName(ModeloCategoriasPath) ?? "Modelo");
        }

        void CargarModelosSiExisten()
        {
            // No entrenamos automáticamente; solo cargamos si el archivo existe, si no -> aviso
            if (!File.Exists(ModeloCategoriasPath))
                MessageBox.Show($"Falta el modelo de categorías: {ModeloCategoriasPath}\nPuedes crear o copiar el ZIP en la carpeta Modelo.", "Modelo faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else

                modeloCat = ml.Model.Load(ModeloCategoriasPath, out var _);

            if (!File.Exists(ModeloSentimientosPath))
                MessageBox.Show($"Falta el modelo de sentimientos: {ModeloSentimientosPath}\nPuedes crear o copiar el ZIP en la carpeta Modelo.", "Modelo faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                modeloSent = ml.Model.Load(ModeloSentimientosPath, out var _);
        }
        private void btnClasificar_Click(object sender, EventArgs e)
        {
            var texto = txtTitular.Text?.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Introduce un titular para clasificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (modeloCat == null || modeloSent == null)
            {
                MessageBox.Show("No hay modelos cargados. Coloca los ZIPs en la carpeta 'Modelo'.", "Modelos ausentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear motores de predicción
            var engineCat = ml.Model.CreatePredictionEngine<Articulo, Prediccion>(modeloCat);
            var engineSent = ml.Model.CreatePredictionEngine<Sentimiento, SentimientoPrediccion>(modeloSent);

            // Ejecutar predicciones
            var pred = engineCat.Predict(new Articulo { Texto = texto });
            var predSent = engineSent.Predict(new Sentimiento { Texto = texto });

            // Mostrar resultados en los TextBox
            txtCategoria.Text = pred.CategoriaPredicha;
            txtSentimiento.Text = predSent.SentimientoPredicho;

     
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var texto = txtTitular.Text?.Trim();
            if (string.IsNullOrWhiteSpace(texto)) return;
            var categoria = txtCategoria.Text?.Trim() ?? "";
            var sentimiento = txtSentimiento.Text?.Trim() ?? "";

            var ya = GuardarAlDataset(texto, categoria, sentimiento);
            if (ya) MessageBox.Show("Este titular ya existe en el dataset.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Titular guardado en dataset.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDatasetEnGrilla();
        }

        private void btnReentrenarCategorias_Click(object sender, EventArgs e)
        {
            EntrenarModeloCategorias(ml, guardar: true);
            MessageBox.Show("El modelo de categorías ha sido reentrenado exitosamente.", "Reentrenamiento Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarModelosSiExisten(); // Recargar el modelo después del reentrenamiento
        }

        private void btnReentrenarSentimientos_Click(object sender, EventArgs e)
        {
            EntrenarModeloSentimientos(ml, guardar: true);
            MessageBox.Show("El modelo de sentimientos ha sido reentrenado exitosamente.", "Reentrenamiento Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarModelosSiExisten(); // Recargar el modelo después del reentrenamiento
        }

        static ITransformer EntrenarModeloCategorias(MLContext ml, bool guardar = false)
        {
            Console.WriteLine("Entrenando modelo de categorías...");

            var datos = ml.Data.LoadFromTextFile<Articulo>(
                path: DatosCategoriasPath, hasHeader: true, separatorChar: ',');

            var pipeline = ml.Transforms.Conversion.MapValueToKey("Label", nameof(Articulo.Categoria))
                .Append(ml.Transforms.Text.FeaturizeText("Features", nameof(Articulo.Texto)))
                .Append(ml.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(ml.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var modelo = pipeline.Fit(datos);

            if (guardar)
            {
                Directory.CreateDirectory("Modelo");
                ml.Model.Save(modelo, datos.Schema, ModeloCategoriasPath);
                Console.WriteLine($"✅ Modelo de categorías guardado en {ModeloCategoriasPath}\n");
            }

            return modelo;
        }

        static ITransformer EntrenarModeloSentimientos(MLContext ml, bool guardar = false)
        {
            Console.WriteLine("Entrenando modelo de sentimientos...");

            var datos = ml.Data.LoadFromTextFile<Sentimiento>(
                path: DatosSentimientosPath, hasHeader: true, separatorChar: ',');

            var pipeline = ml.Transforms.Conversion.MapValueToKey("Label", nameof(Sentimiento.Label))
                .Append(ml.Transforms.Text.FeaturizeText("Features", nameof(Sentimiento.Texto)))
                .Append(ml.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(ml.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var modelo = pipeline.Fit(datos);

            if (guardar)
            {
                Directory.CreateDirectory("Modelo");
                ml.Model.Save(modelo, datos.Schema, ModeloSentimientosPath);
                Console.WriteLine($"✅ Modelo de sentimientos guardado en {ModeloSentimientosPath}\n");
            }

            return modelo;
        }


        private void btnActualizarDataset_Click(object sender, EventArgs e)
        {
            CargarDatasetEnGrilla();
        }

        private void btnCargarExcel_ClickOld(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            var path = ofd.FileName;
            var filas = LeerExcelTitulares(path);

            if (modeloCat == null || modeloSent == null)
            {
                MessageBox.Show("No hay modelos cargados. Coloca los ZIPs en la carpeta Modelo.", "Modelos ausentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var engine = ml.Model.CreatePredictionEngine<Articulo, Prediccion>(modeloCat);
            var engineSent = ml.Model.CreatePredictionEngine<Sentimiento, SentimientoPrediccion>(modeloSent);

            var resultados = new List<ResultadoExcel>();
            foreach (var t in filas)
            {
                var p = engine.Predict(new Articulo { Texto = t });
                var ps = engineSent.Predict(new Sentimiento { Texto = t });
                resultados.Add(new ResultadoExcel { Titular = t, Categoria = p.CategoriaPredicha, Sentimiento = ps.SentimientoPredicho });
            }

            dgvExcelResultados.DataSource = resultados;
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            // Abrir diálogo para seleccionar archivo
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            var path = ofd.FileName;

            // Leer titulares desde Excel
            List<string> filas;
            try
            {
                filas = LeerExcelTitulares(path); // Debes devolver solo los titulares
                if (filas.Count == 0)
                {
                    MessageBox.Show("No se encontraron titulares en el Excel.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que los modelos estén cargados
            if (modeloCat == null || modeloSent == null)
            {
                MessageBox.Show("No hay modelos cargados. Coloca los ZIPs en la carpeta Modelo.", "Modelos ausentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear motores de predicción
            var engineCat = ml.Model.CreatePredictionEngine<Articulo, Prediccion>(modeloCat);
            var engineSent = ml.Model.CreatePredictionEngine<Sentimiento, SentimientoPrediccion>(modeloSent);

            // Clasificar titulares
            var resultados = new List<ResultadoExcel>();
            int total = filas.Count;
            int i = 1;
            foreach (var titular in filas)
            {
                if (string.IsNullOrWhiteSpace(titular)) continue;

                // Predicción
                var predCat = engineCat.Predict(new Articulo { Texto = titular });
                var predSent = engineSent.Predict(new Sentimiento { Texto = titular });

                resultados.Add(new ResultadoExcel
                {
                    Titular = titular,
                    Categoria = predCat.CategoriaPredicha,
                    Sentimiento = predSent.SentimientoPredicho
                });

                // Opcional: mostrar progreso
                lblProgreso.Text = $"Clasificando {i}/{total}";
                Application.DoEvents(); // refresca UI
                i++;
            }

            // Mostrar resultados en DataGridView
            dgvExcelResultados.DataSource = resultados;

            // Ajustar columnas
            dgvExcelResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExcelResultados.Refresh();

            lblProgreso.Text = "Clasificación completada ✅";
        }

        
      


        private void btnExportarResultados_Click(object sender, EventArgs e)
        {
            if (dgvExcelResultados.DataSource == null) return;
            using var sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "ResultadosClasificacion.xlsx";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var list = (dgvExcelResultados.DataSource as IEnumerable<ResultadoExcel>)?.ToList() ?? new();
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Resultados");
            ws.Cell(1, 1).Value = "Titular";
            ws.Cell(1, 2).Value = "Categoria";
            ws.Cell(1, 3).Value = "Sentimiento";
            for (int i = 0; i < list.Count; i++)
            {
                ws.Cell(i + 2, 1).Value = list[i].Titular;
                ws.Cell(i + 2, 2).Value = list[i].Categoria;
                ws.Cell(i + 2, 3).Value = list[i].Sentimiento;
            }
            wb.SaveAs(sfd.FileName);
            MessageBox.Show($"Exportado: {sfd.FileName}");
        }

        // ----------------- Helpers -----------------
        bool GuardarAlDataset(string texto, string categoria, string sentimiento)
        {
            bool yaExistia = false;

            if (!File.Exists(DatosCategoriasPath))
            {
                File.WriteAllText(DatosCategoriasPath, "Texto,Categoria\n");
            }

            var lineasCategorias = File.ReadAllLines(DatosCategoriasPath).Skip(1);
            if (!lineasCategorias.Any(l => l.Split(',')[0].Trim().Equals(texto.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                File.AppendAllText(DatosCategoriasPath, EscapeCSV(texto) + "," + EscapeCSV(categoria) + "\n");
            }
            else
            {
                yaExistia = true;
            }

            if (!File.Exists(DatosSentimientosPath))
            {
                File.WriteAllText(DatosSentimientosPath, "Texto,Label\n");
            }

            var lineasSent = File.ReadAllLines(DatosSentimientosPath).Skip(1);
            if (!lineasSent.Any(l => l.Split(',')[0].Trim().Equals(texto.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                File.AppendAllText(DatosSentimientosPath, EscapeCSV(texto) + "," + EscapeCSV(sentimiento) + "\n");
            }

            return yaExistia;
        }

        static string EscapeCSV(string valor)
        {
            if (valor.Contains(',') || valor.Contains('"'))
            {
                valor = valor.Replace("\"", "\"\"");
                return $"\"{valor}\"";
            }
            return valor;
        }

        void CargarDatasetEnGrilla()
        {
            var lista = new List<(string Texto, string Categoria, string Sentimiento)>();

            if (File.Exists(DatosCategoriasPath))
            {
                var catLines = File.ReadAllLines(DatosCategoriasPath).Skip(1);
                foreach (var l in catLines)
                {
                    var parts = SplitCsvLine(l);
                    if (parts.Length >= 2)
                        lista.Add((parts[0], parts[1], ""));
                }
            }

            if (File.Exists(DatosSentimientosPath))
            {
                var senLines = File.ReadAllLines(DatosSentimientosPath).Skip(1);
                foreach (var l in senLines)
                {
                    var parts = SplitCsvLine(l);
                    if (parts.Length >= 2)
                    {
                        var idx = lista.FindIndex(x => x.Texto.Equals(parts[0], StringComparison.OrdinalIgnoreCase));
                        if (idx >= 0)
                            lista[idx] = (lista[idx].Texto, lista[idx].Categoria, parts[1]);
                        else
                            lista.Add((parts[0], "", parts[1]));
                    }
                }
            }

            var dt = lista.Select(x => new { Texto = x.Texto, Categoria = x.Categoria, Sentimiento = x.Sentimiento }).ToList();
            dgvDataset.DataSource = dt;
        }

        static string[] SplitCsvLine(string line)
        {
            // Simple CSV split that handles quotes
            var values = new List<string>();
            bool inQuotes = false;
            var cur = "";
            for (int i = 0; i < line.Length; i++)
            {
                var ch = line[i];
                if (ch == '"') { inQuotes = !inQuotes; continue; }
                if (ch == ',' && !inQuotes) { values.Add(cur); cur = ""; continue; }
                cur += ch;
            }
            values.Add(cur);
            return values.ToArray();
        }

        static List<string> LeerExcelTitularesOld(string ruta)
        {
            var lista = new List<string>();
            if (ruta.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                using var wb = new XLWorkbook(ruta);
                var ws = wb.Worksheets.First();
                var col = ws.Column(1).CellsUsed().Select(c => c.GetString()).ToList();
                // asumimos cabecera en la primera fila
                for (int i = 2; i <= ws.RowCount(); i++)
                {
                    var val = ws.Cell(i, 1).GetString().Trim();
                    if (!string.IsNullOrWhiteSpace(val)) lista.Add(val);
                }
            }
            else if (ruta.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using var stream = File.Open(ruta, FileMode.Open, FileAccess.Read);
                using var reader = ExcelReaderFactory.CreateReader(stream);
                var result = reader.AsDataSet();
                var table = result.Tables[0];
                for (int r = 1; r < table.Rows.Count; r++)
                {
                    var val = table.Rows[r][0]?.ToString()?.Trim();
                    if (!string.IsNullOrWhiteSpace(val)) lista.Add(val);
                }
            }
            return lista;
        }

        static List<string> LeerExcelTitulares(string ruta)
        {
            var lista = new List<string>();
            List<string> nombresColumnas = new();

            if (ruta.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                using var wb = new XLWorkbook(ruta);
                var ws = wb.Worksheets.First(); // podemos permitir seleccionar hoja después si quieres
                var rango = ws.RangeUsed();
                int totalFilas = rango.RowCount();
                int totalCols = rango.ColumnCount();

                // Leer encabezados
                for (int c = 1; c <= totalCols; c++)
                    nombresColumnas.Add(ws.Cell(1, c).GetString().Trim());

                // Buscar columna de titulares
                int colTitular = nombresColumnas.FindIndex(h =>
                    new[] { "titular", "título", "title", "headline" }
                    .Contains(h.ToLower()));

                if (colTitular == -1)
                    throw new Exception("No se encontró columna 'Titular' en el Excel.");

                // Leer filas
                for (int r = 2; r <= totalFilas; r++)
                {
                    var val = ws.Cell(r, colTitular + 1).GetString().Trim();
                    if (!string.IsNullOrWhiteSpace(val))
                        lista.Add(val);
                }
            }
            else if (ruta.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using var stream = File.Open(ruta, FileMode.Open, FileAccess.Read);
                using var reader = ExcelReaderFactory.CreateReader(stream);
                var result = reader.AsDataSet();
                var table = result.Tables[0]; // también se puede permitir seleccionar hoja

                // Leer encabezados
                for (int c = 0; c < table.Columns.Count; c++)
                    nombresColumnas.Add(table.Rows[0][c]?.ToString().Trim() ?? "");

                // Buscar columna de titulares
                int colTitular = nombresColumnas.FindIndex(h =>
                    new[] { "titular", "título", "title", "headline" }
                    .Contains(h.ToLower()));

                if (colTitular == -1)
                    throw new Exception("No se encontró columna 'Titular' en el Excel.");

                // Leer filas
                for (int r = 1; r < table.Rows.Count; r++)
                {
                    var val = table.Rows[r][colTitular]?.ToString().Trim();
                    if (!string.IsNullOrWhiteSpace(val))
                        lista.Add(val);
                }
            }

            return lista;
        }


    }
}
