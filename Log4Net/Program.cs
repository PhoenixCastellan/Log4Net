using log4net;
using log4net.Config;
using log4net.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            LogLog.InternalDebugging = true;
            XmlConfigurator.Configure(new FileInfo("Log4Net.config"));

            ILog log = LogManager.GetLogger("lvrh");
            int i = 0;
            while (true)
            {
                log.Info(i++);
            }
        }
    }
}
