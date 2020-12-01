using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task6
{
    public static class StringExtension
    {
        public static string RegexPassword(this string text)
        {
            Regex reg = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{8,}$$", RegexOptions.IgnorePatternWhitespace);
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
            string text1 = "C00l_Pass", text2 = "SupperPas1", text3 = "Cool_pass", text4 = "C00l";
            string p = text1.RegexPassword();
            string a = text2.RegexPassword();
            string s = text3.RegexPassword();
            string w = text4.RegexPassword();
            Console.WriteLine(p);
            Console.WriteLine(a);
            Console.WriteLine(s);
            Console.WriteLine(w);
        }
    }
}
