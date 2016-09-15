using System.Drawing;
using System.Windows.Forms;

namespace SimplePaint
{
    public interface ICanvas
    {
        Bitmap Snapshot { get; set; }
        Bitmap TempImage { get; set; }
        int LineWidth { get; set; }
        Color MainColor { get; set; }
        Color FillColor { get; set; }
        Graphics Graphic { get; set; }
    }
}