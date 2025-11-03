namespace ClasificadorNoticiasGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbModeloCategorias = new ComboBox();
            cmbModeloSentimientos = new ComboBox();
            tabPrincipal = new TabControl();
            tabClasificar = new TabPage();
            labelFiabilidadSentimientos = new Label();
            txtFiabilidadSentimiento = new TextBox();
            labelFiabilidadSentimiento = new Label();
            txtFiabilidadCategoria = new TextBox();
            btnReentrenarSentimientos = new Button();
            btnReentrenarCategorias = new Button();
            btnGuardar = new Button();
            btnClasificar = new Button();
            txtSentimiento = new TextBox();
            txtCategoria = new TextBox();
            txtTitular = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabDataset = new TabPage();
            labelModeloCat = new Label();
            labelModeloSent = new Label();
            label9 = new Label();
            label8 = new Label();
            txtLogLossSent = new TextBox();
            txtMicroAccuracySent = new TextBox();
            label6 = new Label();
            txtLogLoss = new TextBox();
            label7 = new Label();
            txtMicroAccuracy = new TextBox();
            btnReentrenarCategoriasDataset = new Button();
            btnReentrenarSentimientosDataset = new Button();
            btnReiniciarModeloSentimientos = new Button();
            btnReiniciarModeloCategorias = new Button();
            btnReiniciarDataset = new Button();
            btnActualizarDataset = new Button();
            btnCargarDatasetExcel = new Button();
            dgvDataset = new DataGridView();
            tabGraficas = new TabPage();
            btnActualizarGraficas = new Button();
            plotViewSentimientos = new OxyPlot.WindowsForms.PlotView();
            plotViewCategorias = new OxyPlot.WindowsForms.PlotView();
            tabComparador = new TabPage();
            dgvComparador = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnExportar = new Button();
            tabVisualizacion = new TabPage();
            label11 = new Label();
            label10 = new Label();
            plotViewSentimietos = new OxyPlot.WindowsForms.PlotView();
            plotViewCategoria = new OxyPlot.WindowsForms.PlotView();
            tabExcel = new TabPage();
            label5 = new Label();
            txtFiabilidadSentimientosExcel = new TextBox();
            label4 = new Label();
            txtFiabilidadCategoriaExcel = new TextBox();
            btnExportarResultados = new Button();
            dgvExcelResultados = new DataGridView();
            btnCargarExcel = new Button();
            btnReentrenarCategoriasExcel = new Button();
            btnReentrenarSentimientosExcel = new Button();
            labelTiempoClasificacion = new Label();
            txtTiempoClasificacion = new TextBox();
            labelMetricasClasificacion = new Label();
            txtMetricasClasificacion = new TextBox();
            tabGraficasExcel = new TabPage();
            btnActualizarGraficasExcel = new Button();
            plotViewExcelSentimientos = new OxyPlot.WindowsForms.PlotView();
            plotViewExcelCategorias = new OxyPlot.WindowsForms.PlotView();
            tabPrincipal.SuspendLayout();
            tabClasificar.SuspendLayout();
            tabDataset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataset).BeginInit();
            tabGraficas.SuspendLayout();
            tabComparador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComparador).BeginInit();
            tabVisualizacion.SuspendLayout();
            tabExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExcelResultados).BeginInit();
            tabGraficasExcel.SuspendLayout();
            SuspendLayout();
            // 
            // cmbModeloCategorias
            // 
            cmbModeloCategorias.FormattingEnabled = true;
            cmbModeloCategorias.Items.AddRange(new object[] { "SdcaMaximumEntropy (por defecto)", "LbfgsMaximumEntropy", "AveragedPerceptron", "FastTree", "LightGbm" });
            cmbModeloCategorias.Location = new Point(1194, 155);
            cmbModeloCategorias.Name = "cmbModeloCategorias";
            cmbModeloCategorias.Size = new Size(121, 25);
            cmbModeloCategorias.TabIndex = 26;
            cmbModeloCategorias.Tag = "";
            cmbModeloCategorias.SelectedIndexChanged += cmbModeloCategorias_SelectedIndexChanged;
            // 
            // cmbModeloSentimientos
            // 
            cmbModeloSentimientos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModeloSentimientos.FormattingEnabled = true;
            cmbModeloSentimientos.Items.AddRange(new object[] { "SdcaLogisticRegression (por defecto)", "LbfgsLogisticRegression", "AveragedPerceptron", "FastTree", "LightGbm" });
            cmbModeloSentimientos.Location = new Point(1194, 241);
            cmbModeloSentimientos.Name = "cmbModeloSentimientos";
            cmbModeloSentimientos.Size = new Size(121, 25);
            cmbModeloSentimientos.TabIndex = 27;
            cmbModeloSentimientos.SelectedIndexChanged += cmbModeloSentimientos_SelectedIndexChanged;
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabClasificar);
            tabPrincipal.Controls.Add(tabDataset);
            tabPrincipal.Controls.Add(tabGraficas);
            tabPrincipal.Controls.Add(tabComparador);
            tabPrincipal.Controls.Add(tabVisualizacion);
            tabPrincipal.Controls.Add(tabExcel);
            tabPrincipal.Controls.Add(tabGraficasExcel);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Font = new Font("Segoe UI", 10F);
            tabPrincipal.Location = new Point(0, 0);
            tabPrincipal.Margin = new Padding(10);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(1464, 794);
            tabPrincipal.TabIndex = 0;
            tabPrincipal.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabClasificar
            // 
            tabClasificar.Controls.Add(labelFiabilidadSentimientos);
            tabClasificar.Controls.Add(txtFiabilidadSentimiento);
            tabClasificar.Controls.Add(labelFiabilidadSentimiento);
            tabClasificar.Controls.Add(txtFiabilidadCategoria);
            tabClasificar.Controls.Add(btnReentrenarSentimientos);
            tabClasificar.Controls.Add(btnReentrenarCategorias);
            tabClasificar.Controls.Add(btnGuardar);
            tabClasificar.Controls.Add(btnClasificar);
            tabClasificar.Controls.Add(txtSentimiento);
            tabClasificar.Controls.Add(txtCategoria);
            tabClasificar.Controls.Add(txtTitular);
            tabClasificar.Controls.Add(label3);
            tabClasificar.Controls.Add(label2);
            tabClasificar.Controls.Add(label1);
            tabClasificar.Location = new Point(4, 26);
            tabClasificar.Name = "tabClasificar";
            tabClasificar.Padding = new Padding(3);
            tabClasificar.Size = new Size(1456, 764);
            tabClasificar.TabIndex = 0;
            tabClasificar.Text = "Clasificar titular";
            tabClasificar.UseVisualStyleBackColor = true;
            // 
            // labelFiabilidadSentimientos
            // 
            labelFiabilidadSentimientos.AutoSize = true;
            labelFiabilidadSentimientos.Location = new Point(20, 277);
            labelFiabilidadSentimientos.Name = "labelFiabilidadSentimientos";
            labelFiabilidadSentimientos.Size = new Size(149, 19);
            labelFiabilidadSentimientos.TabIndex = 15;
            labelFiabilidadSentimientos.Text = "Fiabilidad Sentimientos";
            // 
            // txtFiabilidadSentimiento
            // 
            txtFiabilidadSentimiento.Location = new Point(173, 274);
            txtFiabilidadSentimiento.Name = "txtFiabilidadSentimiento";
            txtFiabilidadSentimiento.ReadOnly = true;
            txtFiabilidadSentimiento.Size = new Size(130, 25);
            txtFiabilidadSentimiento.TabIndex = 14;
            // 
            // labelFiabilidadSentimiento
            // 
            labelFiabilidadSentimiento.AutoSize = true;
            labelFiabilidadSentimiento.Location = new Point(20, 229);
            labelFiabilidadSentimiento.Name = "labelFiabilidadSentimiento";
            labelFiabilidadSentimiento.Size = new Size(129, 19);
            labelFiabilidadSentimiento.TabIndex = 12;
            labelFiabilidadSentimiento.Text = "Fiabilidad Categoría";
            // 
            // txtFiabilidadCategoria
            // 
            txtFiabilidadCategoria.Location = new Point(173, 229);
            txtFiabilidadCategoria.Name = "txtFiabilidadCategoria";
            txtFiabilidadCategoria.ReadOnly = true;
            txtFiabilidadCategoria.Size = new Size(130, 25);
            txtFiabilidadCategoria.TabIndex = 13;
            // 
            // btnReentrenarSentimientos
            // 
            btnReentrenarSentimientos.Location = new Point(377, 225);
            btnReentrenarSentimientos.Name = "btnReentrenarSentimientos";
            btnReentrenarSentimientos.Size = new Size(193, 29);
            btnReentrenarSentimientos.TabIndex = 0;
            btnReentrenarSentimientos.Text = "Reentrenar Sentimientos";
            btnReentrenarSentimientos.Click += btnReentrenarSentimientos_Click;
            // 
            // btnReentrenarCategorias
            // 
            btnReentrenarCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReentrenarCategorias.Location = new Point(377, 277);
            btnReentrenarCategorias.Name = "btnReentrenarCategorias";
            btnReentrenarCategorias.Size = new Size(193, 30);
            btnReentrenarCategorias.TabIndex = 8;
            btnReentrenarCategorias.Text = "Reentrenar Categorias";
            btnReentrenarCategorias.UseVisualStyleBackColor = true;
            btnReentrenarCategorias.Click += btnReentrenarCategorias_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(620, 120);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 30);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnClasificar
            // 
            btnClasificar.Location = new Point(480, 120);
            btnClasificar.Name = "btnClasificar";
            btnClasificar.Size = new Size(120, 30);
            btnClasificar.TabIndex = 6;
            btnClasificar.Text = "Clasificar";
            btnClasificar.UseVisualStyleBackColor = true;
            btnClasificar.Click += btnClasificar_Click;
            // 
            // txtSentimiento
            // 
            txtSentimiento.Location = new Point(140, 170);
            txtSentimiento.Name = "txtSentimiento";
            txtSentimiento.Size = new Size(600, 25);
            txtSentimiento.TabIndex = 5;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(140, 130);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(300, 25);
            txtCategoria.TabIndex = 4;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(98, 28);
            txtTitular.Multiline = true;
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(720, 60);
            txtTitular.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 173);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 2;
            label3.Text = "Sentimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 133);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 1;
            label2.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 59);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 0;
            label1.Text = "Titular";
            // 
            // tabDataset
            // 
            tabDataset.Controls.Add(labelModeloCat);
            tabDataset.Controls.Add(labelModeloSent);
            tabDataset.Controls.Add(cmbModeloSentimientos);
            tabDataset.Controls.Add(cmbModeloCategorias);
            tabDataset.Controls.Add(label9);
            tabDataset.Controls.Add(label8);
            tabDataset.Controls.Add(txtLogLossSent);
            tabDataset.Controls.Add(txtMicroAccuracySent);
            tabDataset.Controls.Add(label6);
            tabDataset.Controls.Add(txtLogLoss);
            tabDataset.Controls.Add(label7);
            tabDataset.Controls.Add(txtMicroAccuracy);
            tabDataset.Controls.Add(btnReentrenarCategoriasDataset);
            tabDataset.Controls.Add(btnReentrenarSentimientosDataset);
            tabDataset.Controls.Add(btnReiniciarModeloSentimientos);
            tabDataset.Controls.Add(btnReiniciarModeloCategorias);
            tabDataset.Controls.Add(btnReiniciarDataset);
            tabDataset.Controls.Add(btnActualizarDataset);
            tabDataset.Controls.Add(btnCargarDatasetExcel);
            tabDataset.Controls.Add(dgvDataset);
            tabDataset.Location = new Point(4, 26);
            tabDataset.Name = "tabDataset";
            tabDataset.Padding = new Padding(3);
            tabDataset.Size = new Size(1456, 764);
            tabDataset.TabIndex = 1;
            tabDataset.Text = "Dataset actual";
            tabDataset.UseVisualStyleBackColor = true;
            // 
            // labelModeloCat
            // 
            labelModeloCat.AutoSize = true;
            labelModeloCat.Location = new Point(1194, 133);
            labelModeloCat.Name = "labelModeloCat";
            labelModeloCat.Size = new Size(125, 19);
            labelModeloCat.TabIndex = 29;
            labelModeloCat.Text = "Modelo Categorias";
            // 
            // labelModeloSent
            // 
            labelModeloSent.AutoSize = true;
            labelModeloSent.Location = new Point(1184, 219);
            labelModeloSent.Name = "labelModeloSent";
            labelModeloSent.Size = new Size(139, 19);
            labelModeloSent.TabIndex = 28;
            labelModeloSent.Text = "Modelo Sentimientos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1055, 679);
            label9.Name = "label9";
            label9.Size = new Size(142, 19);
            label9.TabIndex = 25;
            label9.Text = "LogLoss Sentimientos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1049, 636);
            label8.Name = "label8";
            label8.Size = new Size(181, 19);
            label8.TabIndex = 24;
            label8.Text = "MicroAccuracy Sentimientos";
            // 
            // txtLogLossSent
            // 
            txtLogLossSent.Location = new Point(1240, 673);
            txtLogLossSent.Name = "txtLogLossSent";
            txtLogLossSent.ReadOnly = true;
            txtLogLossSent.Size = new Size(130, 25);
            txtLogLossSent.TabIndex = 23;
            // 
            // txtMicroAccuracySent
            // 
            txtMicroAccuracySent.Location = new Point(1240, 630);
            txtMicroAccuracySent.Name = "txtMicroAccuracySent";
            txtMicroAccuracySent.ReadOnly = true;
            txtMicroAccuracySent.Size = new Size(130, 25);
            txtMicroAccuracySent.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(699, 670);
            label6.Name = "label6";
            label6.Size = new Size(128, 19);
            label6.TabIndex = 21;
            label6.Text = "LogLoss Categorias";
            // 
            // txtLogLoss
            // 
            txtLogLoss.Location = new Point(885, 667);
            txtLogLoss.Name = "txtLogLoss";
            txtLogLoss.ReadOnly = true;
            txtLogLoss.Size = new Size(130, 25);
            txtLogLoss.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(699, 636);
            label7.Name = "label7";
            label7.Size = new Size(167, 19);
            label7.TabIndex = 18;
            label7.Text = "MicroAccuracy Categorias";
            // 
            // txtMicroAccuracy
            // 
            txtMicroAccuracy.Location = new Point(885, 630);
            txtMicroAccuracy.Name = "txtMicroAccuracy";
            txtMicroAccuracy.ReadOnly = true;
            txtMicroAccuracy.Size = new Size(130, 25);
            txtMicroAccuracy.TabIndex = 19;
            // 
            // btnReentrenarCategoriasDataset
            // 
            btnReentrenarCategoriasDataset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReentrenarCategoriasDataset.Location = new Point(20, 681);
            btnReentrenarCategoriasDataset.Name = "btnReentrenarCategoriasDataset";
            btnReentrenarCategoriasDataset.Size = new Size(193, 30);
            btnReentrenarCategoriasDataset.TabIndex = 9;
            btnReentrenarCategoriasDataset.Text = "Reentrenar Categorias";
            btnReentrenarCategoriasDataset.UseVisualStyleBackColor = true;
            btnReentrenarCategoriasDataset.Click += btnReentrenarCategorias_Click;
            // 
            // btnReentrenarSentimientosDataset
            // 
            btnReentrenarSentimientosDataset.Location = new Point(20, 625);
            btnReentrenarSentimientosDataset.Name = "btnReentrenarSentimientosDataset";
            btnReentrenarSentimientosDataset.Size = new Size(193, 29);
            btnReentrenarSentimientosDataset.TabIndex = 6;
            btnReentrenarSentimientosDataset.Text = "Reentrenar Sentimientos";
            btnReentrenarSentimientosDataset.Click += btnReentrenarSentimientos_Click;
            // 
            // btnReiniciarModeloSentimientos
            // 
            btnReiniciarModeloSentimientos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReiniciarModeloSentimientos.Location = new Point(304, 643);
            btnReiniciarModeloSentimientos.Name = "btnReiniciarModeloSentimientos";
            btnReiniciarModeloSentimientos.Size = new Size(203, 30);
            btnReiniciarModeloSentimientos.TabIndex = 4;
            btnReiniciarModeloSentimientos.Text = "Reiniciar Modelo Sentimientos";
            btnReiniciarModeloSentimientos.UseVisualStyleBackColor = true;
            btnReiniciarModeloSentimientos.Click += btnReiniciarModeloSentimientos_Click;
            // 
            // btnReiniciarModeloCategorias
            // 
            btnReiniciarModeloCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReiniciarModeloCategorias.Location = new Point(304, 687);
            btnReiniciarModeloCategorias.Name = "btnReiniciarModeloCategorias";
            btnReiniciarModeloCategorias.Size = new Size(203, 30);
            btnReiniciarModeloCategorias.TabIndex = 3;
            btnReiniciarModeloCategorias.Text = "Reiniciar Modelo Categorias";
            btnReiniciarModeloCategorias.UseVisualStyleBackColor = true;
            btnReiniciarModeloCategorias.Click += btnReiniciarModeloCategorias_Click;
            // 
            // btnReiniciarDataset
            // 
            btnReiniciarDataset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReiniciarDataset.Location = new Point(551, 643);
            btnReiniciarDataset.Name = "btnReiniciarDataset";
            btnReiniciarDataset.Size = new Size(120, 30);
            btnReiniciarDataset.TabIndex = 3;
            btnReiniciarDataset.Text = "Reiniciar dataset";
            btnReiniciarDataset.UseVisualStyleBackColor = true;
            btnReiniciarDataset.Click += btnReiniciarDataset_Click;
            // 
            // btnActualizarDataset
            // 
            btnActualizarDataset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizarDataset.Location = new Point(551, 717);
            btnActualizarDataset.Name = "btnActualizarDataset";
            btnActualizarDataset.Size = new Size(120, 30);
            btnActualizarDataset.TabIndex = 1;
            btnActualizarDataset.Text = "Actualizar vista";
            btnActualizarDataset.UseVisualStyleBackColor = true;
            btnActualizarDataset.Click += btnActualizarDataset_Click;
            // 
            // btnCargarDatasetExcel
            // 
            btnCargarDatasetExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCargarDatasetExcel.Location = new Point(551, 681);
            btnCargarDatasetExcel.Name = "btnCargarDatasetExcel";
            btnCargarDatasetExcel.Size = new Size(140, 30);
            btnCargarDatasetExcel.TabIndex = 2;
            btnCargarDatasetExcel.Text = "Cargar desde Excel";
            btnCargarDatasetExcel.UseVisualStyleBackColor = true;
            btnCargarDatasetExcel.Click += btnCargarDatasetExcel_Click;
            // 
            // dgvDataset
            // 
            dgvDataset.Location = new Point(0, 4);
            dgvDataset.Name = "dgvDataset";
            dgvDataset.Size = new Size(1178, 608);
            dgvDataset.TabIndex = 5;
            // 
            // tabGraficas
            // 
            tabGraficas.Controls.Add(btnActualizarGraficas);
            tabGraficas.Controls.Add(plotViewSentimientos);
            tabGraficas.Controls.Add(plotViewCategorias);
            tabGraficas.Location = new Point(4, 26);
            tabGraficas.Name = "tabGraficas";
            tabGraficas.Size = new Size(1456, 764);
            tabGraficas.TabIndex = 3;
            tabGraficas.Text = "Gráficas Dataset";
            tabGraficas.UseVisualStyleBackColor = true;
            // 
            // btnActualizarGraficas
            // 
            btnActualizarGraficas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizarGraficas.Location = new Point(1048, 668);
            btnActualizarGraficas.Name = "btnActualizarGraficas";
            btnActualizarGraficas.Size = new Size(120, 30);
            btnActualizarGraficas.TabIndex = 2;
            btnActualizarGraficas.Text = "Actualizar";
            btnActualizarGraficas.UseVisualStyleBackColor = true;
            btnActualizarGraficas.Click += btnActualizarGraficas_Click;
            // 
            // plotViewSentimientos
            // 
            plotViewSentimientos.Location = new Point(10, 270);
            plotViewSentimientos.Name = "plotViewSentimientos";
            plotViewSentimientos.PanCursor = Cursors.Hand;
            plotViewSentimientos.Size = new Size(872, 250);
            plotViewSentimientos.TabIndex = 1;
            plotViewSentimientos.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewSentimientos.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewSentimientos.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewCategorias
            // 
            plotViewCategorias.Location = new Point(10, 10);
            plotViewCategorias.Name = "plotViewCategorias";
            plotViewCategorias.PanCursor = Cursors.Hand;
            plotViewCategorias.Size = new Size(872, 250);
            plotViewCategorias.TabIndex = 0;
            plotViewCategorias.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewCategorias.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewCategorias.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tabComparador
            // 
            tabComparador.Controls.Add(dgvComparador);
            tabComparador.Controls.Add(btnExportar);
            tabComparador.Location = new Point(4, 26);
            tabComparador.Name = "tabComparador";
            tabComparador.Padding = new Padding(3);
            tabComparador.Size = new Size(1456, 764);
            tabComparador.TabIndex = 5;
            tabComparador.Text = "Comparador de Modelos";
            tabComparador.UseVisualStyleBackColor = true;
            // 
            // dgvComparador
            // 
            dgvComparador.AllowUserToAddRows = false;
            dgvComparador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvComparador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvComparador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComparador.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvComparador.Dock = DockStyle.Fill;
            dgvComparador.Location = new Point(3, 3);
            dgvComparador.Name = "dgvComparador";
            dgvComparador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComparador.Size = new Size(1450, 718);
            dgvComparador.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Método";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "MicroAccuracy";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "MacroAccuracy";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "LogLoss";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(52, 152, 219);
            btnExportar.Dock = DockStyle.Bottom;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(3, 721);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(1450, 40);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Exportar Resultados a CSV";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // tabVisualizacion
            // 
            tabVisualizacion.Controls.Add(label11);
            tabVisualizacion.Controls.Add(label10);
            tabVisualizacion.Controls.Add(plotViewSentimietos);
            tabVisualizacion.Controls.Add(plotViewCategoria);
            tabVisualizacion.Location = new Point(4, 26);
            tabVisualizacion.Name = "tabVisualizacion";
            tabVisualizacion.Padding = new Padding(3);
            tabVisualizacion.Size = new Size(1456, 764);
            tabVisualizacion.TabIndex = 6;
            tabVisualizacion.Text = "Visualización de Métricas";
            tabVisualizacion.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 384);
            label11.Name = "label11";
            label11.Size = new Size(139, 19);
            label11.TabIndex = 3;
            label11.Text = "Modelo Sentimientos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 23);
            label10.Name = "label10";
            label10.Size = new Size(131, 19);
            label10.TabIndex = 2;
            label10.Text = "Modelos Categorias";
            // 
            // plotViewSentimietos
            // 
            plotViewSentimietos.Location = new Point(8, 422);
            plotViewSentimietos.Name = "plotViewSentimietos";
            plotViewSentimietos.PanCursor = Cursors.Hand;
            plotViewSentimietos.Size = new Size(1371, 334);
            plotViewSentimietos.TabIndex = 1;
            plotViewSentimietos.Text = "plotView1";
            plotViewSentimietos.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewSentimietos.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewSentimietos.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewCategoria
            // 
            plotViewCategoria.Location = new Point(8, 47);
            plotViewCategoria.Name = "plotViewCategoria";
            plotViewCategoria.PanCursor = Cursors.Hand;
            plotViewCategoria.Size = new Size(1371, 334);
            plotViewCategoria.TabIndex = 0;
            plotViewCategoria.Text = "plotView1";
            plotViewCategoria.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewCategoria.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewCategoria.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tabExcel
            // 
            tabExcel.Controls.Add(label5);
            tabExcel.Controls.Add(txtFiabilidadSentimientosExcel);
            tabExcel.Controls.Add(label4);
            tabExcel.Controls.Add(txtFiabilidadCategoriaExcel);
            tabExcel.Controls.Add(btnExportarResultados);
            tabExcel.Controls.Add(dgvExcelResultados);
            tabExcel.Controls.Add(btnCargarExcel);
            tabExcel.Controls.Add(btnReentrenarCategoriasExcel);
            tabExcel.Controls.Add(btnReentrenarSentimientosExcel);
            tabExcel.Controls.Add(labelTiempoClasificacion);
            tabExcel.Controls.Add(txtTiempoClasificacion);
            tabExcel.Controls.Add(labelMetricasClasificacion);
            tabExcel.Controls.Add(txtMetricasClasificacion);
            tabExcel.Location = new Point(4, 26);
            tabExcel.Name = "tabExcel";
            tabExcel.Size = new Size(1456, 764);
            tabExcel.TabIndex = 2;
            tabExcel.Text = "Clasificar desde Excel";
            tabExcel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 703);
            label5.Name = "label5";
            label5.Size = new Size(149, 19);
            label5.TabIndex = 17;
            label5.Text = "Fiabilidad Sentimientos";
            // 
            // txtFiabilidadSentimientosExcel
            // 
            txtFiabilidadSentimientosExcel.Location = new Point(433, 700);
            txtFiabilidadSentimientosExcel.Name = "txtFiabilidadSentimientosExcel";
            txtFiabilidadSentimientosExcel.ReadOnly = true;
            txtFiabilidadSentimientosExcel.Size = new Size(130, 25);
            txtFiabilidadSentimientosExcel.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 669);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 14;
            label4.Text = "Fiabilidad Categoría";
            // 
            // txtFiabilidadCategoriaExcel
            // 
            txtFiabilidadCategoriaExcel.Location = new Point(433, 666);
            txtFiabilidadCategoriaExcel.Name = "txtFiabilidadCategoriaExcel";
            txtFiabilidadCategoriaExcel.ReadOnly = true;
            txtFiabilidadCategoriaExcel.Size = new Size(130, 25);
            txtFiabilidadCategoriaExcel.TabIndex = 15;
            // 
            // btnExportarResultados
            // 
            btnExportarResultados.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportarResultados.Location = new Point(1048, 696);
            btnExportarResultados.Name = "btnExportarResultados";
            btnExportarResultados.Size = new Size(120, 30);
            btnExportarResultados.TabIndex = 2;
            btnExportarResultados.Text = "Exportar resultados";
            btnExportarResultados.UseVisualStyleBackColor = true;
            btnExportarResultados.Click += btnExportarResultados_Click;
            // 
            // dgvExcelResultados
            // 
            dgvExcelResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExcelResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExcelResultados.Location = new Point(0, 77);
            dgvExcelResultados.Name = "dgvExcelResultados";
            dgvExcelResultados.Size = new Size(1192, 575);
            dgvExcelResultados.TabIndex = 1;
            // 
            // btnCargarExcel
            // 
            btnCargarExcel.Location = new Point(25, 13);
            btnCargarExcel.Name = "btnCargarExcel";
            btnCargarExcel.Size = new Size(160, 30);
            btnCargarExcel.TabIndex = 0;
            btnCargarExcel.Text = "Cargar archivo Excel";
            btnCargarExcel.UseVisualStyleBackColor = true;
            btnCargarExcel.Click += btnCargarExcel_Click;
            // 
            // btnReentrenarCategoriasExcel
            // 
            btnReentrenarCategoriasExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReentrenarCategoriasExcel.Location = new Point(8, 694);
            btnReentrenarCategoriasExcel.Name = "btnReentrenarCategoriasExcel";
            btnReentrenarCategoriasExcel.Size = new Size(207, 30);
            btnReentrenarCategoriasExcel.TabIndex = 4;
            btnReentrenarCategoriasExcel.Text = "Reentrenar Categorías";
            btnReentrenarCategoriasExcel.UseVisualStyleBackColor = true;
            btnReentrenarCategoriasExcel.Visible = false;
            btnReentrenarCategoriasExcel.Click += btnReentrenarCategorias_Click;
            // 
            // btnReentrenarSentimientosExcel
            // 
            btnReentrenarSentimientosExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReentrenarSentimientosExcel.Location = new Point(8, 658);
            btnReentrenarSentimientosExcel.Name = "btnReentrenarSentimientosExcel";
            btnReentrenarSentimientosExcel.Size = new Size(207, 30);
            btnReentrenarSentimientosExcel.TabIndex = 5;
            btnReentrenarSentimientosExcel.Text = "Reentrenar Sentimientos";
            btnReentrenarSentimientosExcel.UseVisualStyleBackColor = true;
            btnReentrenarSentimientosExcel.Visible = false;
            btnReentrenarSentimientosExcel.Click += btnReentrenarSentimientos_Click;
            // 
            // labelTiempoClasificacion
            // 
            labelTiempoClasificacion.AutoSize = true;
            labelTiempoClasificacion.Location = new Point(214, 13);
            labelTiempoClasificacion.Name = "labelTiempoClasificacion";
            labelTiempoClasificacion.Size = new Size(147, 19);
            labelTiempoClasificacion.TabIndex = 10;
            labelTiempoClasificacion.Text = "Tiempo de clasificación";
            // 
            // txtTiempoClasificacion
            // 
            txtTiempoClasificacion.Location = new Point(367, 13);
            txtTiempoClasificacion.Name = "txtTiempoClasificacion";
            txtTiempoClasificacion.ReadOnly = true;
            txtTiempoClasificacion.Size = new Size(130, 25);
            txtTiempoClasificacion.TabIndex = 11;
            // 
            // labelMetricasClasificacion
            // 
            labelMetricasClasificacion.AutoSize = true;
            labelMetricasClasificacion.Location = new Point(537, 0);
            labelMetricasClasificacion.Name = "labelMetricasClasificacion";
            labelMetricasClasificacion.Size = new Size(154, 19);
            labelMetricasClasificacion.TabIndex = 12;
            labelMetricasClasificacion.Text = "Métricas de clasificación";
            // 
            // txtMetricasClasificacion
            // 
            txtMetricasClasificacion.Location = new Point(551, 22);
            txtMetricasClasificacion.Multiline = true;
            txtMetricasClasificacion.Name = "txtMetricasClasificacion";
            txtMetricasClasificacion.ReadOnly = true;
            txtMetricasClasificacion.ScrollBars = ScrollBars.Vertical;
            txtMetricasClasificacion.Size = new Size(317, 49);
            txtMetricasClasificacion.TabIndex = 13;
            // 
            // tabGraficasExcel
            // 
            tabGraficasExcel.Controls.Add(btnActualizarGraficasExcel);
            tabGraficasExcel.Controls.Add(plotViewExcelSentimientos);
            tabGraficasExcel.Controls.Add(plotViewExcelCategorias);
            tabGraficasExcel.Location = new Point(4, 26);
            tabGraficasExcel.Name = "tabGraficasExcel";
            tabGraficasExcel.Size = new Size(1456, 764);
            tabGraficasExcel.TabIndex = 4;
            tabGraficasExcel.Text = "Gráficas Clasificar Excel";
            tabGraficasExcel.UseVisualStyleBackColor = true;
            // 
            // btnActualizarGraficasExcel
            // 
            btnActualizarGraficasExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizarGraficasExcel.Location = new Point(740, 520);
            btnActualizarGraficasExcel.Name = "btnActualizarGraficasExcel";
            btnActualizarGraficasExcel.Size = new Size(120, 30);
            btnActualizarGraficasExcel.TabIndex = 2;
            btnActualizarGraficasExcel.Text = "Actualizar";
            btnActualizarGraficasExcel.UseVisualStyleBackColor = true;
            btnActualizarGraficasExcel.Click += btnActualizarGraficasExcel_Click;
            // 
            // plotViewExcelSentimientos
            // 
            plotViewExcelSentimientos.Location = new Point(10, 270);
            plotViewExcelSentimientos.Name = "plotViewExcelSentimientos";
            plotViewExcelSentimientos.PanCursor = Cursors.Hand;
            plotViewExcelSentimientos.Size = new Size(872, 250);
            plotViewExcelSentimientos.TabIndex = 1;
            plotViewExcelSentimientos.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewExcelSentimientos.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewExcelSentimientos.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotViewExcelCategorias
            // 
            plotViewExcelCategorias.Location = new Point(10, 10);
            plotViewExcelCategorias.Name = "plotViewExcelCategorias";
            plotViewExcelCategorias.PanCursor = Cursors.Hand;
            plotViewExcelCategorias.Size = new Size(872, 250);
            plotViewExcelCategorias.TabIndex = 0;
            plotViewExcelCategorias.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewExcelCategorias.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewExcelCategorias.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 794);
            Controls.Add(tabPrincipal);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clasificador de Noticias - GUI";
            tabPrincipal.ResumeLayout(false);
            tabClasificar.ResumeLayout(false);
            tabClasificar.PerformLayout();
            tabDataset.ResumeLayout(false);
            tabDataset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataset).EndInit();
            tabGraficas.ResumeLayout(false);
            tabComparador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComparador).EndInit();
            tabVisualizacion.ResumeLayout(false);
            tabVisualizacion.PerformLayout();
            tabExcel.ResumeLayout(false);
            tabExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExcelResultados).EndInit();
            tabGraficasExcel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabClasificar;
        private System.Windows.Forms.TabPage tabDataset;
        private System.Windows.Forms.TabPage tabExcel;
        private System.Windows.Forms.TabPage tabGraficas;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClasificar;
        private System.Windows.Forms.TextBox txtSentimiento;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnReentrenarCategorias;
        private System.Windows.Forms.Button btnActualizarDataset;
        private System.Windows.Forms.Button btnReiniciarDataset;
        private System.Windows.Forms.Button btnReiniciarModeloCategorias;
        private System.Windows.Forms.Button btnReiniciarModeloSentimientos;
        private System.Windows.Forms.DataGridView dgvDataset;
        private System.Windows.Forms.Button btnCargarDatasetExcel;
        private System.Windows.Forms.Button btnExportarResultados;
        private System.Windows.Forms.DataGridView dgvExcelResultados;
        private System.Windows.Forms.Button btnCargarExcel;
        private System.Windows.Forms.Button btnReentrenarCategoriasExcel;
        private System.Windows.Forms.Button btnReentrenarSentimientosExcel;
        private OxyPlot.WindowsForms.PlotView plotViewCategorias;
        private OxyPlot.WindowsForms.PlotView plotViewSentimientos;
        private System.Windows.Forms.Button btnActualizarGraficas;
        private System.Windows.Forms.Button btnReentrenarSentimientos;
        private System.Windows.Forms.TabPage tabGraficasExcel;
        private OxyPlot.WindowsForms.PlotView plotViewExcelCategorias;
        private OxyPlot.WindowsForms.PlotView plotViewExcelSentimientos;
        private System.Windows.Forms.Button btnActualizarGraficasExcel;
        private System.Windows.Forms.Label labelTiempoClasificacion;
        private System.Windows.Forms.TextBox txtTiempoClasificacion;
        private System.Windows.Forms.Label labelMetricasClasificacion;
        private System.Windows.Forms.TextBox txtMetricasClasificacion;
        private Label labelFiabilidadSentimiento;
        private TextBox txtFiabilidadCategoria;
        private Label labelFiabilidadSentimientos;
        private TextBox txtFiabilidadSentimiento;
        private Button btnReentrenarCategoriasDataset;
        private Button btnReentrenarSentimientosDataset;
        private Label label5;
        private TextBox txtFiabilidadSentimientosExcel;
        private Label label4;
        private TextBox txtFiabilidadCategoriaExcel;
        private Label label6;
        private TextBox txtLogLoss;
        private Label label7;
        private TextBox txtMicroAccuracy;
        private Label label9;
        private Label label8;
        private TextBox txtLogLossSent;
        private TextBox txtMicroAccuracySent;
        private Label labelCategoriaCBModelo;
        private Label labelSentimientoCBModelo;
        private ComboBox cmbModeloCategorias;
        private ComboBox cmbModeloSentimientos;
        private Label labelModeloCat;
        private Label labelModeloSent;
        private TabPage tabComparador;
        private DataGridView dgvComparador;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button btnExportar;
        private TabPage tabVisualizacion;
        private OxyPlot.WindowsForms.PlotView plotViewCategoria;
        private OxyPlot.WindowsForms.PlotView plotViewSentimietos;
        private Label label11;
        private Label label10;
    }
}
