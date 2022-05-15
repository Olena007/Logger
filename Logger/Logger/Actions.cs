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
        private string _line = string.Empty;
        public Result StartMethod()
        {
            Result result = new Result(true);
            var logger = Logger.GetInstance("Info");
            _line = $"{DateTime.Now:H:mm:ss} {logger} {Environment.NewLine}";
            File.AppendAllText("log.txt", _line);
            Console.WriteLine(_line);
            return result;
        }

        public Result SkippedLogicInMethod()
        {
            Result result = new Result(true);
            var logger = Logger.GetInstance("Warning");
            _line = $"{DateTime.Now:H:mm:ss} {logger} {Environment.NewLine}";
            File.AppendAllText("log.txt", _line);
            Console.WriteLine(_line);
            return result;
        }

        public Result ErrorMethod()
        {
            Result error = new Result(false);
            Logger log = new Logger();
            var logger = Logger.GetInstance("Error");
            _line = $"{DateTime.Now:H:mm:ss} {logger} {log.Message} {log.MessageError} {Environment.NewLine}";
            File.AppendAllText("log.txt", _line);
            Console.WriteLine(_line);
            return error;
        }
    }
}
