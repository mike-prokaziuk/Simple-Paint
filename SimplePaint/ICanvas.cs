using System.Drawing;
using System.Windows.Forms;

namespace SimplePaint
{
    public interface ICanvas
    {
        Bitmap Snapshot { get; set; }
        Bitmap TempImage { get; set; }
        void Clear();
        void Fill(Bitmap image);
    }
}