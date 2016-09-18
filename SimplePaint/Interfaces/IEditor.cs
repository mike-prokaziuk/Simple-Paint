using System.Drawing;

namespace SimplePaint.Interfaces
{
    public interface IEditor
    {
        bool IsCanvasSaved { get; set; }

        void SaveImageAs(string fileName);
        void LoadImage(Bitmap image);
        void ClearCanvas();
    }
}