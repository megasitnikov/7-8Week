using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task1
{
    public static class StringExtension
    {
        public static string RegexIp(this string text)
        {
            Regex reg = new Regex(@"^(\d|[1-9]\d|1\d\d|2([0-4]\d|5[0-5]))\.(\d|[1-9]\d|1\d\d|2([0-4]\d|5[0-5]))\.(\d|[1-9]\d|1\d\d|2([0-4]\d|5[0-5]))\.(\d|[1-9]\d|1\d\d|2([0-4]\d|5[0-5]))$");
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
            string text1 = "127.0.0.1", text2 = "255.255.255.0", text3 = "1300.6.7.8", text4 = "abc.def.gha.bcd";
            string t1 = text1.RegexIp();
            string t2 = text2.RegexIp();
            string t3 = text3.RegexIp();
            string t4 = text4.RegexIp();
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
        }
    }
}
