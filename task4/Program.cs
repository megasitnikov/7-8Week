using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4
{
    public static class StringExtension
    {
        public static string RegexDate(this string text)
        {
            Regex reg = new Regex(@"((0[1-9]|1\d|2[0-8])/(0[1-9]|1[0-2])/\d{4})|((29/(0[1-9]|1[0-2])/ ([02468][048]00|[13579][26]00|\d\d0[48]|\d\d[2468][048]|\d\d[13579][26])
                                    )|(29/(0[13-9]|1[0-2])/\d{3}[1235679]))|(30/(0[13-9]|1[0-2])/\d{4})|(31/(0[13578]|10|12)/\d{4})", RegexOptions.IgnorePatternWhitespace);
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
            string text1 = "29/02/2000", text2 = "30/04/2003", text3 = "01/01/2003", text4 = "29/02/2001", text5 = "30-04-2003", text6 = "1/1/1899";
            string d = text1.RegexDate();
            string a = text2.RegexDate();
            string t = text3.RegexDate();
            string e = text4.RegexDate();
            string m = text5.RegexDate();
            string c = text6.RegexDate();
            Console.WriteLine(d);
            Console.WriteLine(a);
            Console.WriteLine(t);
            Console.WriteLine(e);
            Console.WriteLine(m);
            Console.WriteLine(c);
        }
    }
}

