using SimplePaint.Interfaces;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SimplePaint.Implementation
{
    public class Painter : IPainter
    {
        private ICanvas _canvas;
        private Point _startPoint;
        private Point _currentPoint;
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
        #region Mouse event handlers
        public void MouseDownHandle(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _startPoint = new Point(e.X, e.Y);
            _canvas.SnapshotOfDrawingProcess = (Bitmap)_canvas.SnapshotOfCurrentState.Clone();
        }
        public void MouseUpHandle(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            _canvas.SnapshotOfCurrentState = (Bitmap)_canvas.SnapshotOfDrawingProcess.Clone();
        }
        public void MouseMoveHandle(object sender, MouseEventArgs e)
        {
            PictureBox panel = sender as PictureBox;
            if (_isMouseDown)
            {
                _currentPoint = new Point(e.X, e.Y);
                panel.Invalidate();
                panel.Update();
            }
        }
        #endregion

        #region Draw methods
        public void DrawLine(object sender, PaintEventArgs e)
        {
            _canvas.SnapshotOfDrawingProcess = (Bitmap)_canvas.SnapshotOfCurrentState.Clone();
            var imageWidth = _canvas.SnapshotOfDrawingProcess.Width;
            var imageHeigth = _canvas.SnapshotOfDrawingProcess.Height;
            Graphics g = Graphics.FromImage(_canvas.SnapshotOfDrawingProcess);
            Pen myPen = new Pen(MainColor, LineWidth);
            g.DrawLine(myPen, _startPoint, _currentPoint);
            e.Graphics.DrawImage(_canvas.SnapshotOfDrawingProcess, 0, 0,imageWidth, imageHeigth);
        }
        public void DrawRectangle(object sender, PaintEventArgs e)
        {
            _canvas.SnapshotOfDrawingProcess = (Bitmap)_canvas.SnapshotOfCurrentState.Clone();
            var figureWidth = _currentPoint.X - _startPoint.X;
            var figureHeigth = _currentPoint.Y - _startPoint.Y;
            var imageWidth = _canvas.SnapshotOfDrawingProcess.Width;
            var imageHeigth = _canvas.SnapshotOfDrawingProcess.Height;

            var g = Graphics.FromImage(_canvas.SnapshotOfDrawingProcess);
            if (FillColor != Color.Empty)
            {
                var brush = new SolidBrush(FillColor);
                g.FillRectangle(brush, _startPoint.X, _startPoint.Y, figureWidth, figureHeigth);
            }
            var myPen = new Pen(MainColor, LineWidth);
            g.DrawRectangle(myPen, _startPoint.X, _startPoint.Y, figureWidth, figureHeigth);
            e.Graphics.DrawImage(_canvas.SnapshotOfDrawingProcess, 0, 0, imageWidth, imageHeigth);
        }
        public void DrawWithPencil(object sender, PaintEventArgs e)
        {
            var g = Graphics.FromImage(_canvas.SnapshotOfDrawingProcess);
            var imageWidth = _canvas.SnapshotOfDrawingProcess.Width;
            var imageHeigth = _canvas.SnapshotOfDrawingProcess.Height;

            var myPen = new Pen(MainColor, LineWidth);
            g.DrawLine(myPen, _startPoint, _currentPoint);
            e.Graphics.DrawImage(_canvas.SnapshotOfDrawingProcess, 0, 0, imageWidth, imageHeigth);
            _startPoint = _currentPoint;
        }
        public void DrawCircle(object sender, PaintEventArgs e)
        {
            _canvas.SnapshotOfDrawingProcess = (Bitmap)_canvas.SnapshotOfCurrentState.Clone();
            var figureWidth = _currentPoint.X - _startPoint.X;
            var figureHeigth = _currentPoint.Y - _startPoint.Y;
            var imageWidth = _canvas.SnapshotOfDrawingProcess.Width;
            var imageHeigth = _canvas.SnapshotOfDrawingProcess.Height;
            var g = Graphics.FromImage(_canvas.SnapshotOfDrawingProcess);
            var myPen = new Pen(MainColor, LineWidth);
            if (FillColor != Color.Empty)
            {
                var brush = new SolidBrush(FillColor);
                g.FillEllipse(brush, _startPoint.X, _startPoint.Y, figureWidth, figureHeigth);
            }

            g.DrawEllipse(myPen, _startPoint.X, _startPoint.Y, figureWidth, figureHeigth);
            e.Graphics.DrawImage(_canvas.SnapshotOfDrawingProcess, 0, 0,imageWidth, imageHeigth);
        }
        #endregion

        #region Effects methods
        public Image Invert()
        {
            Thread.Sleep(2000);
            var bitmap = _canvas.SnapshotOfCurrentState;
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
        #endregion
    }
}
