using SimplePaint.Interfaces;
using SimplePaint.Properties;
using System.Drawing;

namespace SimplePaint.Implementation
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
