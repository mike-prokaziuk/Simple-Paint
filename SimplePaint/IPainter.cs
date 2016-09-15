using System.Drawing;
using System.Windows.Forms;

namespace SimplePaint
{
    public interface IPainter
    {
        ICanvas Canvas { get; }
        bool IsMouseDown { get;}
        void MouseDownHandle(object sender, MouseEventArgs e);
        void MouseUpHandle(object sender, MouseEventArgs e);
        void MouseMoveHandle(object sender, MouseEventArgs e);
        void DrawLine(object sender, PaintEventArgs e);
        void DrawRectangle(object sender, PaintEventArgs e);
        void DrawWithPencil(object sender, PaintEventArgs e);
    }
}