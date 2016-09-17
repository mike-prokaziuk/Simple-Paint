using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public class Painter : IPainter
    {
        int z = 0;
        private Point prevPoint { get; set; }
        private Point currPoint { get; set; }
        public ICanvas Canvas { get; set; }
        public bool IsMouseDown { get; private set; }
        public Painter(ICanvas canvas)
        {
            Canvas = canvas;
        }
        public void MouseDownHandle(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            prevPoint = new Point(e.X, e.Y);
            Canvas.TempImage = (Bitmap)Canvas.Snapshot.Clone();
        }
        public void MouseUpHandle(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            Canvas.Snapshot = (Bitmap)Canvas.TempImage.Clone();
            //Canvas.Snapshot.Save($@"C:\111\{z}.jpg");
        }
        public void MouseMoveHandle(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            if (IsMouseDown)
            {
                currPoint = new Point(e.X, e.Y);
                panel.Invalidate();
                panel.Update();
            }
        }
        public void DrawLine(object sender, PaintEventArgs e)
        {
            if (Canvas.TempImage != null)
            {
                Canvas.TempImage = (Bitmap)Canvas.Snapshot.Clone();
                Graphics g = Graphics.FromImage(Canvas.TempImage);
                Pen myPen = new Pen(Canvas.MainColor, Canvas.LineWidth);
                g.DrawLine(myPen, prevPoint, currPoint);
                e.Graphics.DrawImageUnscaled(Canvas.TempImage, 0, 0);
            }
        }
        public void DrawRectangle(object sender, PaintEventArgs e)
        {
            if (Canvas.TempImage != null)
            {
                z++;
                Canvas.TempImage = (Bitmap)Canvas.Snapshot.Clone();
                var g = Graphics.FromImage(Canvas.TempImage);
                if (Canvas.FillColor != Color.Empty)
                {
                    var brush = new SolidBrush(Canvas.FillColor);
                    g.FillRectangle(brush, prevPoint.X, prevPoint.Y, currPoint.X - prevPoint.X, currPoint.Y - prevPoint.Y);
                }
                var myPen = new Pen(Canvas.MainColor, Canvas.LineWidth);
                g.DrawRectangle(myPen, prevPoint.X, prevPoint.Y, currPoint.X - prevPoint.X, currPoint.Y - prevPoint.Y);
                e.Graphics.DrawImageUnscaled(Canvas.TempImage, 0, 0);
            }
        }
        public void DrawWithPencil(object sender, PaintEventArgs e)
        {
            if (Canvas.TempImage != null)
            {
                var g = Graphics.FromImage(Canvas.TempImage);
                var myPen = new Pen(Canvas.MainColor, Canvas.LineWidth);
                g.DrawLine(myPen, prevPoint, currPoint);
                e.Graphics.DrawImageUnscaled(Canvas.TempImage, 0, 0);
                prevPoint = currPoint;
            }
        }
        public void DrawCircle(object sender, PaintEventArgs e)
        {
            if (Canvas.TempImage != null)
            {
                Canvas.TempImage = (Bitmap)Canvas.Snapshot.Clone();
                var g = Graphics.FromImage(Canvas.TempImage);
                if (Canvas.FillColor != Color.Empty)
                {
                    var brush = new SolidBrush(Canvas.FillColor);
                    g.FillEllipse(brush, prevPoint.X, prevPoint.Y, currPoint.X - prevPoint.X, currPoint.Y - prevPoint.Y);
                }
                var myPen = new Pen(Canvas.MainColor, Canvas.LineWidth);
                g.DrawEllipse(myPen, prevPoint.X, prevPoint.Y, currPoint.X - prevPoint.X, currPoint.Y - prevPoint.Y);
                e.Graphics.DrawImageUnscaled(Canvas.TempImage, 0, 0);
            }

        }
    }
}
