using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    public class Editor:IEditor
    {
        private ICanvas _canvas;
        public Editor(ICanvas canvas)
        {
            _canvas = canvas;
        }
        public void SaveImageAs(string fileName)
        {

        }
        public void LoadImage(string fileName)
        {

        }
        public void Exit()
        {

        }
        public void ClearCanvas()
        {
            _canvas.Clear();
        }
    }
}
