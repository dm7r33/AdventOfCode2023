using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC.Day01
{
    internal class Test
    {
        public static void STart()
        {
            string lotofns = "nnnn";

            MatchCollection matches = Regex.Matches(lotofns, "(?=(nn))");

            Console.WriteLine(matches.Count);
        }
    }
}
