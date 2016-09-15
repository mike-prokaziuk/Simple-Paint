using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void PointsTSMI_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem itm in lineWidthDDB.DropDownItems)
            {
                itm.Checked = false;
            }

            ToolStripMenuItem itmClicked = sender as ToolStripMenuItem;
            itmClicked.Checked = true;
        }
    }
}
