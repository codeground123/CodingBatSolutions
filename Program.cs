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
            bool res = makes10(9, 10);
                
            Console.WriteLine(res.ToString());
            Console.ReadLine();
        }


        public static bool makes10(int a, int b)
        {
            return ((a == 10 || b == 10) || (a + b == 10));

        }

        public static bool parrotTrouble(bool talking, int hour)
        {
            if (talking && (hour < 7 ||hour>20))
                return true;
            return false;
        }
        
        public static bool sleepIn(bool weekday, bool vacation)
        {
            if (vacation || !weekday)
                return true;
            return false;
        }

        public static bool monkeyTrouble(bool aSmile, bool bSmile)
        {
            return aSmile == bSmile;
        }

        public static int sumDouble(int a, int b)
        {
            int sum = a+b;
            if (a == b)
                return 2 * sum;
            return sum;
                
        }
    }
}
