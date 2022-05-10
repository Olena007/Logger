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
#pragma warning disable SA1201 // Elements should appear in the correct order
        public Result()
#pragma warning restore SA1201 // Elements should appear in the correct order
        {
        }

        public Result(bool status)
        {
            Status = status;
        }
    }
}
