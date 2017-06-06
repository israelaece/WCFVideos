using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using WCFVides.Servico;

namespace WCFVideos.WinServices.Hosting
{
    partial class GestorDeCreditos : ServiceBase
    {
        private ServiceHost _host;

        public GestorDeCreditos()
        {
            InitializeComponent();

            this._host = new ServiceHost(typeof(ServicoDeGestaoDeCredito), new Uri[] { });
        }

        protected override void OnStart(string[] args)
        {
            this._host.Open();
        }

        protected override void OnStop()
        {
            this._host.Close();
        }
    }
}