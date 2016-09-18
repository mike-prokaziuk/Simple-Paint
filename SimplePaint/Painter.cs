using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public class Painter : IPainter
    {
        private ICanvas _canvas;
        private Point _prevPoint;
        private Point _currPoint;
        private bool _isMouseDown;
        public int LineWidth { get; set; }
        public Color MainColor { get; set; }
        public Color FillColor { get; set; }
        public Painter(ICanvas canvas)
        {
            _canvas = canvas;
            LineWidth = 1;
            MainColor = Color.Black;
            FillColor = Color.Empty;
        }
        public void MouseDownHandle(object sender, MouseEventArgs e)
        {
            //_canvas.Snapshot.Save($@"C:\111\snap.jpg");
            //_canvas.TempImage.Save($@"C:\111\temp.jpg");
            _isMouseDown = true;
            _prevPoint = new Point(e.X, e.Y);
            _canvas.TempImage = (Bitmap)_canvas.Snapshot.Clone();
        }
        public void MouseUpHandle(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            _canvas.Snapshot = (Bitmap)_canvas.TempImage.Clone();
        }
        public void MouseMoveHandle(object sender, MouseEventArgs e)
        {
            PictureBox panel = sender as PictureBox;
            if (_isMouseDown)
            {
                _currPoint = new Point(e.X, e.Y);
                panel.Invalidate();
                panel.Update();
            }
        }
        public void DrawLine(object sender, PaintEventArgs e)
        {
            _canvas.TempImage = (Bitmap)_canvas.Snapshot.Clone();
            Graphics g = Graphics.FromImage(_canvas.TempImage);
            Pen myPen = new Pen(MainColor, LineWidth);
            g.DrawLine(myPen, _prevPoint, _currPoint);
            e.Graphics.DrawImage(_canvas.TempImage, 0, 0,_canvas.TempImage.Width, _canvas.TempImage.Height);
        }
        public void DrawRectangle(object sender, PaintEventArgs e)
        {
            _canvas.TempImage = (Bitmap)_canvas.Snapshot.Clone();
            var g = Graphics.FromImage(_canvas.TempImage);
            if (FillColor != Color.Empty)
            {
                var brush = new SolidBrush(FillColor);
                g.FillRectangle(brush, _prevPoint.X, _prevPoint.Y, _currPoint.X - _prevPoint.X, _currPoint.Y - _prevPoint.Y);
            }
            var myPen = new Pen(MainColor, LineWidth);
            g.DrawRectangle(myPen, _prevPoint.X, _prevPoint.Y, _currPoint.X - _prevPoint.X, _currPoint.Y - _prevPoint.Y);
            e.Graphics.DrawImage(_canvas.TempImage, 0, 0, _canvas.TempImage.Width, _canvas.TempImage.Height);
        }
        public void DrawWithPencil(object sender, PaintEventArgs e)
        {
            var g = Graphics.FromImage(_canvas.TempImage);
            var myPen = new Pen(MainColor, LineWidth);
            g.DrawLine(myPen, _prevPoint, _currPoint);
            e.Graphics.DrawImage(_canvas.TempImage, 0, 0, _canvas.TempImage.Width, _canvas.TempImage.Height);
            _prevPoint = _currPoint;
        }
        public void DrawCircle(object sender, PaintEventArgs e)
        {
            _canvas.TempImage = (Bitmap)_canvas.Snapshot.Clone();
            var g = Graphics.FromImage(_canvas.TempImage);
            if (FillColor != Color.Empty)
            {
                var brush = new SolidBrush(FillColor);
                g.FillEllipse(brush, _prevPoint.X, _prevPoint.Y, _currPoint.X - _prevPoint.X, _currPoint.Y - _prevPoint.Y);
            }
            var myPen = new Pen(MainColor, LineWidth);
            g.DrawEllipse(myPen, _prevPoint.X, _prevPoint.Y, _currPoint.X - _prevPoint.X, _currPoint.Y - _prevPoint.Y);
            e.Graphics.DrawImage(_canvas.TempImage, 0, 0,_canvas.TempImage.Width,_canvas.TempImage.Height);
        }
        public Image Invert()
        {
            Thread.Sleep(2000);
            var bitmap = _canvas.Snapshot;
            for (int x = 0; x <=bitmap.Width-1 ; x++)
            {
                for (int y = 0; y < bitmap.Height; y+=1)
                {
                    Color oldColor = bitmap.GetPixel(x, y);
                    Color newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            _canvas.Fill(bitmap);
            return bitmap;
        }
    }
}
