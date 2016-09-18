using SimplePaint.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public class Canvas : ICanvas
    {
        public Bitmap Snapshot { get; set; }
        public Bitmap TempImage { get; set; }
        public Canvas()
        {
            Clear();
        }
        public void Clear()
        {
            Snapshot = TempImage = Resources.temp;
        }
        public void Fill(Bitmap image)
        {
            Snapshot = TempImage = image;
        }

    }
}
