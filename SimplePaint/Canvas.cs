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
        public Bitmap SnapshotOfCurrentState { get; set; }
        public Bitmap SnapshotOfDrawingProcess { get; set; }
        public Canvas()
        {
            Clear();
        }
        public void Clear()
        {
            SnapshotOfCurrentState = SnapshotOfDrawingProcess = Resources.WhiteBackground;
        }
        public void Fill(Bitmap image)
        {
            SnapshotOfCurrentState = SnapshotOfDrawingProcess = image;
        }

    }
}
