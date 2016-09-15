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
        public Bitmap Snapshot { get; set; }
        public Bitmap TempImage { get; set; }
        public int LineWidth { get; set; }
        public Color MainColor { get; set; }
        public Color FillColor { get; set; }
        public Graphics Graphic { get; set; }
        public Panel Panel { get; set; }
        public Canvas()
        {
            LineWidth = 1;
            MainColor = Color.Black;
            FillColor = Color.Empty;
        }
    }
}
