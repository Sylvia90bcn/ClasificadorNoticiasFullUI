
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiProyecto
{
    public partial class FrmTopKViewer : Form
    {
        public FrmTopKViewer(List<double> topK)
        {
            InitializeComponent();
            if (topK != null)
            {
                foreach (double v in topK)
                    listBox1.Items.Add(v.ToString("F4"));
            }
        }
    }
}
