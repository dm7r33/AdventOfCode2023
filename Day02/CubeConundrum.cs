using System;
using System.Collections.Generic;
using System.Linq;
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
            List<string> text = ReadFile("C:\\Users\\Dimitri\\source\\repos\\AoC\\AoC\\Day02.txt");

            //index 0 - red; index 1 - green; index 2 - blue;
            int[] arrCubes = new int[3] { 12, 13, 14 };
            HighestNumberOfCubesPerColorAndLine(text);
        }

        public static List<string> ReadFile(string path)
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

        public static void HighestNumberOfCubesPerColorAndLine(List<string> textLines)
        {
            int game = 0;
            foreach (string line in textLines)
            {
                game++;
                Console.WriteLine("Game {0}:", game);
                //MatchCollection matchCollectionRed = Regex.Matches(line, "[1-9]+\\sred,");

                var arrRed = Regex.Matches(line, "[1-9]+\\sred").Cast<Match>().Select(m => m.Value).ToArray();

                foreach(var arr2 in arrRed)
                {
                    Console.WriteLine(arr2);
                }

                var arrGreen = Regex.Matches(line, "[1-9]+\\sgreen").Cast<Match>().Select(m => m.Value).ToArray();

                foreach (var arr2 in arrGreen)
                {
                    Console.WriteLine(arr2);
                }

                var arrBlue = Regex.Matches(line, "[1-9]+\\sblue").Cast<Match>().Select(m => m.Value).ToArray();

                foreach (var arr2 in arrBlue)
                {
                    Console.WriteLine(arr2);
                }

                Console.WriteLine();

            }
        }


    }
}
