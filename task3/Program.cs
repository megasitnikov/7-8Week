using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task3
{
    public static class StringExtension
    {
        public static string RegexUrl(this string text)
        {
            Regex reg = new Regex(@"^(https?:\/\/)?([\w\.]{3,})\.([a-z]{2,6}\.?)(\/[\w\.]*)*\/?$");
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
            string text1 = "http://www.example.com", text2 = "http://example.com", text3 = "Just Text", text4 = "http://a.com";
            string m = text1.RegexUrl();
            string a = text2.RegexUrl();
            string i = text3.RegexUrl();
            string l = text4.RegexUrl();
            Console.WriteLine(m);
            Console.WriteLine(a);
            Console.WriteLine(i);
            Console.WriteLine(l);
        }
    }
}
