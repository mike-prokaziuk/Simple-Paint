using System.Drawing;

namespace SimplePaint.Interfaces
{
    public interface ICanvas
    {
        Bitmap SnapshotOfCurrentState { get; set; }
        Bitmap SnapshotOfDrawingProcess { get; set; }
        void Clear();
        void Fill(Bitmap image);
    }
}