using SimplePaint.Interfaces;
using SimplePaint.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
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
            selectedTool = btnClicked.Text;
        }
        private void canvasControl_Paint(object sender, PaintEventArgs e)
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

        #region Handlers for configuration of canvas
        private void changeOfWidthLineMI_Click(object sender, EventArgs e)
        {
            foreach (ValuedToolStripMenuItem itm in lineWidthDDB.DropDownItems)
            {
                itm.Checked = false;
            }

            var itmClicked = sender as ValuedToolStripMenuItem;
            itmClicked.Checked = true;
            _painter.LineWidth = itmClicked.Value;
        }
        private void changeFillColorMI_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _painter.FillColor = colorDialog.Color;
                FillColorDDB.BackColor = colorDialog.Color;
                FillColorDDB.ForeColor = colorDialog.Color.GetBrightness() < 0.4 ? Color.White : Color.Black;
            }
        }
        private void changeToEmptyFillColorMI_Click(object sender, EventArgs e)
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
        #endregion

        #region Mouse event handlers
        private void canvasControl_MouseMove(object sender, MouseEventArgs e)
        {
            _painter.MouseMoveHandle(sender, e);

        }
        private void canvasControl_MouseDown(object sender, MouseEventArgs e)
        {
            _painter.MouseDownHandle(sender, e);
        }
        private void canvasControl_MouseUp(object sender, MouseEventArgs e)
        {
            _painter.MouseUpHandle(sender, e);
        }
        #endregion

        #region Handlers of Menu items "File"
        private void clearMI_Click(object sender, EventArgs e)
        {
            var currentMenuItem = sender as ToolStripMenuItem;
            selectedTool = currentMenuItem.Text;

            CanvasControl.Image = Resources.WhiteBackground;
            _editor.ClearCanvas();
        }
        private void loadMI_Click(object sender, EventArgs e)
        {
            var currentMenuItem = sender as ToolStripMenuItem;
            selectedTool = currentMenuItem.Text;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = new Bitmap(openFileDialog.FileName);
                CanvasControl.Image = image;
                _editor.LoadImage(image);
            }
        }
        private void saveMI_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _editor.SaveImageAs(saveFileDialog.FileName);
                _editor.IsCanvasSaved = true;
            }
        }
        private void exitMI_Click(object sender, EventArgs e)
        {
            if (!_editor.IsCanvasSaved)
            {
                var result = MessageBox.Show("Do you want to save this image?", "Simple Paint", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveMI_Click(null, null);
                }
            }
            Environment.Exit(0);
        }
        #endregion

        #region Handlers of Menu items "Effects"
        private void invertMI_Click(object sender, EventArgs e)
        {
            var currentMenuItem = sender as ToolStripMenuItem;
            selectedTool = currentMenuItem.Text;

            ProgressBar.Value = 0;
            backgroundWorker.RunWorkerAsync();
        }
        #endregion

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

    }
}
