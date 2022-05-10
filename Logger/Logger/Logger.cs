using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Logger
    {
        private static string _instance;
        public string Message { get; } = "I broke the logic";
        public string MessageError { get; } = "Action failed by a reason";
        public static string GetInstance(string message)
        {
            _instance = message;
            return _instance;
        }
    }
}
