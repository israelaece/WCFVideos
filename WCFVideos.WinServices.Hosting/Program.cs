using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WCFVideos.WinServices.Hosting
{
    static class Program
    {
        static void Main()
        {
            ServiceBase.Run(new ServiceBase[] { new GestorDeCreditos() });
        }
    }
}