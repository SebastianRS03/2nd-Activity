using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Activity
{
    internal class Run
    {
        private static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            DateOnly dt = DateOnly.FromDateTime(d);
            Console.WriteLine(dt);

        }
    }
}
