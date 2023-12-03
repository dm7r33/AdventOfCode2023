using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC.Day02
{
    internal class CubeConundrum
    {
        /* cubes red green or blue
         * secret number of cubes
         * find the number of cubes
         * elve will show you handful of random cubes a few times per game
         * you will play several games and record the information
         * each game has a id with a semicolon seperated list of subsets of cubes
         * which games would have been possible if the bag contained 12 red, 13 gree, 14 blue
         * sum of the ids
         */
        public static void Start()
        {
            List<string> text = ReadFileToList("C:\\Users\\Dimitri\\source\\repos\\AoC\\AoC\\Day02\\Day02.txt");

            //index 0 - red; index 1 - green; index 2 - blue;
            int[] arrCubes = new int[3] { 12, 13, 14 };
            //HighestNumberOfCubesPerColorAndLine(text);


            Console.WriteLine(text.Count);

            Console.WriteLine(SumOfIndexesOfList(text));

        }

        public static List<string> ReadFileToList(string path)
        {
            List<string> textLines = new();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    textLines.Add(line);
                }
            }
            return textLines;
        }

        //public static void HighestNumberOfCubesPerColorAndLine(List<string> textLines)
        //{

        //    for(int i = 0; i < textLines.Count; i++)
        //    {

        //        var arrRed = Regex.Matches(line, "[1-9]+\\sred").Cast<Match>().Select(m => m.Value).ToArray();

        //        var arrGreen = Regex.Matches(line, "[1-9]+\\sgreen").Cast<Match>().Select(m => m.Value).ToArray();

        //        var arrBlue = Regex.Matches(line, "[1-9]+\\sblue").Cast<Match>().Select(m => m.Value).ToArray();
        //    }
        //}



        public static int SumOfIndexesOfList(List<string> text)
        {
            int count = 0;
            for (int i = 1; i <= text.Count; i++)
            {
                count += i;
            }

            return count;
        }
    }
}
