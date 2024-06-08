using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace Service_homeiphon4
{
    public partial class Service_homeiphon4 : ServiceBase
    {
        private string logFilePath = @"C:\MyLog.txt";
        private int eventId = 1;
        public Service_homeiphon4()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            WriteLog("In OnStart.");
            Timer timer = new Timer
            {
                Interval = 60000 //1 minute interval
            };
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        protected override void OnStop()
        {
            WriteLog("In OnStop.");
        }
        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            WriteLog("Monitoring the System", eventId++);
        }
        protected override void OnContinue()
        {
            WriteLog("In OnContinue.");
        }

        private void WriteLog(string message, int eventId = 1)
        {
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.WriteLine($"{DateTime.Now} - Event ID: {eventId}, Message: {message}");
            }
        }
    }
}
