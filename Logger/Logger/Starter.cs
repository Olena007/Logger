using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Starter
    {
        public void Run()
        {
            Random random = new Random();
            Actions actions = new Actions();
            for (int i = 0; i <= 100; i++)
            {
                int nxt = random.Next(1, 4);
                if (nxt == 1)
                {
                    actions.StartMethod();
                }
                else if (nxt == 2)
                {
                    actions.SkippedLogicInMethod();
                }
                else if (nxt == 3)
                {
                    actions.ErrorMethod();
                }
            }
        }
    }
}
