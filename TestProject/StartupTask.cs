using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace TestProject
{
    public sealed class StartupTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            Init();

            // TO DO: implement
        }

        private void Init()
        {
            // Space for init task
            WorkerProcess wp = new WorkerProcess(1);
        }
    }
}
