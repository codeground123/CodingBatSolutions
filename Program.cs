using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingBatSolutions
{
    class Program
    {
        // WarmUp-1
        static void Main(string[] args)
        {
            bool res = sleepIn(false, true);
            Console.WriteLine(res.ToString());
            Console.ReadLine();
        }
        //http://codingbat.com/prob/p187868
        public static bool sleepIn(bool weekday, bool vacation)
        {
            if (vacation || !weekday)
                return true;
            return false;
        }
    }
}
