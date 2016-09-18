using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class Editor:IEditor
    {
        private ICanvas _canvas;
        public bool IsCanvasSaved { get; set; }
        public Editor(ICanvas canvas)
        {
            _canvas = canvas;
        }
        public void SaveImageAs(string fileName)
        {
            _canvas.SnapshotOfCurrentState.Save(fileName);
        }
        public void LoadImage(Bitmap image)
        {
            _canvas.Fill(image);
        }
        public void ClearCanvas()
        {
            _canvas.Clear();
        }
    }
}
