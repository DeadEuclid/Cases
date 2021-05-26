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
            продажаToolStripMenuItem_Click(null, null);
            MockContext
        }
        SearchControl SC = new SearchControl { AutoSize = true };
        ReportsControl RC = new ReportsControl { AutoSize = true };
        private void продажаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(SC);

        }

        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(RC);
        }
    }
}
