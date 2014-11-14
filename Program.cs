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
            string res = missingChar("kitten",1);
            Console.WriteLine(res.ToString());
            Console.ReadLine();
        }

        public static string missingChar(string str, int n)
        {
            string newStr = string.Empty;
            if (!string.IsNullOrEmpty(str))
            {
                newStr = str.Remove(n);

            }
            return newStr;

        }

        public static string notString(string str)
        {
            if (str.Length >= 3)
            {
                if (str.Substring(0, 3) == "not")
                    return str;

            }
            return "not " + str;

        }

        public static bool posNeg(int a, int b, bool negative)
        {
            if (negative)
            {
                return (a < 0 && b < 0);
            }
            else
            {
                return ((a < 0 && b > 0) || (a > 0 && b < 0));
            }
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
