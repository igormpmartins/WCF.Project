using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MultiplicationServiceLibrary;
using System.ServiceModel;

namespace MyWindowsService
{
    public partial class MyWCFService : ServiceBase
    {
        private ServiceHost serviceHost;

        public MyWCFService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var address = "net.tcp://localhost:9001/MyService";
            serviceHost = new ServiceHost(typeof(MultiplicationService), new Uri(address));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost!= null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
