using System.Drawing;
using System.Windows.Forms;

namespace SimplePaint
{
    public interface ICanvas
    {
        Bitmap SnapshotOfCurrentState { get; set; }
        Bitmap SnapshotOfDrawingProcess { get; set; }
        void Clear();
        void Fill(Bitmap image);
    }
}