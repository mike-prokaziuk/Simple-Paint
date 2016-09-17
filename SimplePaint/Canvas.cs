using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public class Canvas:ICanvas
    {
        private int Width { get; set; }
        private int Height { get; set; }
        public Bitmap Snapshot { get; set; }
        public Bitmap TempImage { get; set; }
        public int LineWidth { get; set; }
        public Color MainColor { get; set; }
        public Color FillColor { get; set; }
        public Graphics Graphic { get; private set; }
        public Canvas()
        {
            Width = 640;
            Height = 480;
            LineWidth = 1;
            MainColor = Color.Black;
            FillColor = Color.Empty;
            Snapshot = new Bitmap(Width, Height); 
        }
        public void Clear()
        {
            Graphic.FillRectangle(new SolidBrush(Color.White), 0, 0, Width, Height);
            Snapshot = new Bitmap(Width, Height);
        }
        public void GetGraphic(Graphics graph)
        {
            Graphic = graph;
        }
    }
}
