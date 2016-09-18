using Autofac;
using SimplePaint.Infrastructure;
using SimplePaint.Properties;
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
        IPainter _painter;
        IEditor _editor;
        string selectedTool;

        public MainForm(IPainter painter, IEditor editor)
        {
            InitializeComponent();
            _painter = painter;
            _editor = editor;
        }
        private void PointsTSMI_Click(object sender, EventArgs e)
        {
            foreach (ValuedToolStripMenuItem itm in lineWidthDDB.DropDownItems)
            {
                itm.Checked = false;
            }

            var itmClicked = sender as ValuedToolStripMenuItem;
            itmClicked.Checked = true;
            _painter.LineWidth = itmClicked.Value;
        }
        private void changeFillColorTSMI_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _painter.FillColor = colorDialog.Color;
                FillColorDDB.BackColor = colorDialog.Color;
                FillColorDDB.ForeColor = colorDialog.Color.GetBrightness() < 0.4 ? Color.White : Color.Black;
            }
        }
        private void changeToEmptyFillColorTSMI_Click(object sender, EventArgs e)
        {
            _painter.FillColor = Color.Empty;
            FillColorDDB.BackColor = Color.Empty;
        }
        private void changeMainColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _painter.MainColor = colorDialog.Color;
                changeMainColorBtn.BackColor = colorDialog.Color;
                changeMainColorBtn.ForeColor = colorDialog.Color.GetBrightness() < 0.4 ? Color.White : Color.Black;
            }
        }
        private void brushControls_Click(object sender, EventArgs e)
        {
            foreach (var item in ToolBar.Items)
            {
                var btn = item as ToolStripButton;
                if (btn != null)
                {
                    btn.Checked = false;
                }
            }
            ToolStripButton btnClicked = sender as ToolStripButton;
            btnClicked.Checked = true;
            selectedTool = btnClicked.Name;
        }
        private void clearTSMI_Click(object sender, EventArgs e)
        {
            selectedTool = "";
            CanvasControl.Image = Resources.temp;
            _editor.ClearCanvas();
        }

        private void loadTSMI_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = new Bitmap(openFileDialog.FileName);
                CanvasControl.Image = image;
                selectedTool = "";
                _editor.LoadImage(image);
            }
        }
        private void CanvasControl_Paint(object sender, PaintEventArgs e)
        {
            _editor.IsCanvasSaved = false;
            switch (selectedTool)
            {
                case "Line":
                    _painter.DrawLine(sender, e);
                    break;
                case "Rectangle":
                    _painter.DrawRectangle(sender, e);
                    break;
                case "Pencil":
                    _painter.DrawWithPencil(sender, e);
                    break;
                case "Circle":
                    _painter.DrawCircle(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void CanvasControl_MouseMove(object sender, MouseEventArgs e)
        {
            _painter.MouseMoveHandle(sender, e);

        }
        private void CanvasControl_MouseDown(object sender, MouseEventArgs e)
        {
            _painter.MouseDownHandle(sender, e);
        }
        private void CanvasControl_MouseUp(object sender, MouseEventArgs e)
        {
            _painter.MouseUpHandle(sender, e);
        }
        private void saveTSMI_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _editor.SaveImageAs(saveFileDialog.FileName);
                _editor.IsCanvasSaved = true;
            }
        }
        private void exitTSMI_Click(object sender, EventArgs e)
        {
            if (!_editor.IsCanvasSaved)
            {
                var result = MessageBox.Show("Do you want to save this image?", "Simple Paint", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveTSMI_Click(null, null);
                }
            }
            Environment.Exit(0);
        }
        private void invertTSMI_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            selectedTool = "";
            backgroundWorker.RunWorkerAsync();
            
        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(95);
            e.Result = _painter.Invert();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value += e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CanvasControl.Image = (Image)e.Result;
            ProgressBar.Value = 0;
        }

        private void ToolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
