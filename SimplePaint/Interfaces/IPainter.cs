using System.Drawing;
using System.Windows.Forms;

namespace SimplePaint.Interfaces
{
    public interface IPainter
    {
        int LineWidth { get; set; }
        Color MainColor { get; set; }
        Color FillColor { get; set; }
        void MouseDownHandle(object sender, MouseEventArgs e);
        void MouseUpHandle(object sender, MouseEventArgs e);
        void MouseMoveHandle(object sender, MouseEventArgs e);
        void DrawLine(object sender, PaintEventArgs e);
        void DrawRectangle(object sender, PaintEventArgs e);
        void DrawWithPencil(object sender, PaintEventArgs e);
        void DrawCircle(object sender, PaintEventArgs e);
        Image Invert();
    }
}