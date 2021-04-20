using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cases
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var pageControls = tabControl1.TabPages[0].Controls;
            if (pageControls.Count != 0)
            {
                pageControls.Clear();
                pageControls.Add(new ReportsControl());
            }
        }

        private void продажаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
