using Autofac;
using SimplePaint.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutofacDIContainer.AddBindings(); // registration all Autofac bindings
            var painter = AutofacDIContainer.Container.Resolve<IPainter>(); // 

            Application.Run(new MainForm(painter));
        }
    }
}
