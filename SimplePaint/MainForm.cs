using Autofac;
using SimplePaint.Infrastructure;
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
        public MainForm(IPainter painter,IEditor editor)
        {
            InitializeComponent();
            _painter = painter;
            _editor = editor;
            _painter.Canvas.GetGraphic(bufferedPanel.CreateGraphics());
         }
        private void PointsTSMI_Click(object sender, EventArgs e)
        {
            foreach (ValuedToolStripMenuItem itm in lineWidthDDB.DropDownItems)
            {
                itm.Checked = false;
            }

            var itmClicked = sender as ValuedToolStripMenuItem;
            itmClicked.Checked = true;
            _painter.Canvas.LineWidth = itmClicked.Value;
        }
        private void bufferedPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _painter.MouseDownHandle(sender, e);
        }
        private void bufferedPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _painter.MouseUpHandle(sender, e);
        }
        private void bufferedPanel_MouseMove(object sender, MouseEventArgs e)
        {
            _painter.MouseMoveHandle(sender,e);
        }
        private void changeFillColorTSMI_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _painter.Canvas.FillColor = colorDialog.Color;
                FillColorDDB.BackColor = colorDialog.Color;
                FillColorDDB.ForeColor = colorDialog.Color.GetBrightness() < 0.4 ? Color.White : Color.Black;
            }
        }
        private void changeToEmptyFillColorTSMI_Click(object sender, EventArgs e)
        {
            _painter.Canvas.FillColor = Color.Empty;
            FillColorDDB.BackColor = Color.Empty;
        }
        private void changeMainColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _painter.Canvas.MainColor = colorDialog.Color;
                changeMainColorBtn.BackColor = colorDialog.Color;
                changeMainColorBtn.ForeColor = colorDialog.Color.GetBrightness() < 0.4? Color.White : Color.Black;
            }
        }
        private void brushControls_Click(object sender,EventArgs e)
        {
            foreach (var item in ToolBar.Items)
            {
                var btn = item as ToolStripButton;
                if (btn!=null)
                {
                    btn.Checked = false;
                }
            }
            ToolStripButton btnClicked = sender as ToolStripButton;
            btnClicked.Checked = true;
            selectedTool = btnClicked.Name;
        }
        private void bufferedPanel_Paint(object sender, PaintEventArgs e)
        {
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

        private void clearTSMI_Click(object sender, EventArgs e)
        {
            _editor.ClearCanvas();

        }
    }
}
