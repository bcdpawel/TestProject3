using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class WorkerProcess
    {
        private int _noThreads;

        public WorkerProcess(int noThreads)
        {
            _noThreads = noThreads;
        }

        public int StartThread()
        {
            return 0;
        }
    }
}
