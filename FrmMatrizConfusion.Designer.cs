
namespace MiProyecto
{
    partial class FrmMatrizConfusion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMatriz;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(0, 0);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowTemplate.Height = 25;
            this.dgvMatriz.Size = new System.Drawing.Size(400, 300);
            this.dgvMatriz.TabIndex = 0;
            // 
            // FrmMatrizConfusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.dgvMatriz);
            this.Name = "FrmMatrizConfusion";
            this.Text = "FrmMatrizConfusion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
