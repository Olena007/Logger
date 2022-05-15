using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Result
    {
        public bool Status { get; set; }
        public Result()
        {
        }

        public Result(bool status)
        {
            Status = status;
        }
    }
}
