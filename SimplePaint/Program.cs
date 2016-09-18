using Autofac;
using SimplePaint.Infrastructure;
using SimplePaint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutofacDIContainer.AddBindings(); // registration all Autofac bindings
            var painter = AutofacDIContainer.Container.Resolve<IPainter>(); 
            var editor = AutofacDIContainer.Container.Resolve<IEditor>();
            Application.Run(new MainForm(painter,editor));
        }
    }
}
