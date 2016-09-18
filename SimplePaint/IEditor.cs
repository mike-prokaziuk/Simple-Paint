using System.Drawing;

namespace SimplePaint
{
    public interface IEditor
    {
        bool IsCanvasSaved { get; set; }

        void SaveImageAs(string fileName);
        void LoadImage(Bitmap image);
        void ClearCanvas();
    }
}