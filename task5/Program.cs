using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task5
{
    public static class StringExtension
    {
        public static string RegexPercent(this string text)
        {
            Regex reg = new Regex(@"(^[1-9]+|^[0-9]+\.{1,1}[0-9]{1,2})\sруб\.", RegexOptions.IgnorePatternWhitespace);
            MatchCollection matches = reg.Matches(text);
            foreach (Match mat in matches)
            {
                return (mat.Value);
            }
            return "0";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "20.78 руб.", text2 = "22 р., 0.002 руб.";
            string r = text.RegexPercent();
            string u = text2.RegexPercent();
            Console.WriteLine(r);
            Console.WriteLine(u);
        }
    }
}

