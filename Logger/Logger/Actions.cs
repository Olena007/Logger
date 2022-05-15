using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    internal class Actions
    {
        public Result StartMethod()
        {
            string line = string.Empty;
            Result result = new Result(true);
            var logger = Logger.GetInstance("Info");
            line = $"{DateTime.Now:H:mm:ss} {logger} {Environment.NewLine}";
            File.AppendAllText("log.txt", line);
            Console.WriteLine(line);
            return result;
        }

        public Result SkippedLogicInMethod()
        {
            string line = string.Empty;
            Result result = new Result(true);
            var logger = Logger.GetInstance("Warning");
            line = $"{DateTime.Now:H:mm:ss} {logger} {Environment.NewLine}";
            File.AppendAllText("log.txt", line);
            Console.WriteLine(line);
            return result;
        }

        public Result ErrorMethod()
        {
            string line = string.Empty;
            Result error = new Result(false);
            Logger log = new Logger();
            var logger = Logger.GetInstance("Error");
            line = $"{DateTime.Now:H:mm:ss} {logger} {log.Message} {log.MessageError} {Environment.NewLine}";
            File.AppendAllText("log.txt", line);
            Console.WriteLine(line);
            return error;
        }
    }
}
