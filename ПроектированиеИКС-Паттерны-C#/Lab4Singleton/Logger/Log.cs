using System;
using System.IO;

namespace Lab4Singleton.Logger
{
    internal class Log
    {
        private static Lazy<Log> log = new(() => new Log());

        private Log()
        {
        }

        public static Log GetLog => log.Value;

        public void ExecuteLog(string message)
        {
            using var w = File.AppendText("log.txt");
            MakeLog(message, w);
            w.Close();
        }

        public static void MakeLog(string logMessage, TextWriter textWriter)
        {
            textWriter.Write("\r\nLog Entry : ");
            textWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            textWriter.WriteLine("Action: {0}", logMessage);
            textWriter.WriteLine("-------------------------------");
        }
    }
}