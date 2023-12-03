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
            List<string> srcTextList = ReadFileToList("C:\\Users\\Dimitri\\source\\repos\\AoC\\AoC\\Day02\\Day02.txt");
            //index 0 - red; index 1 - green; index 2 - blue;
            int[] arrCubes = new int[3] { 12, 13, 14 };

            List<string> finalTextList = RemoveInvalidLines(srcTextList);

            Console.WriteLine(SumOfIDs(finalTextList));

        }

        public static List<string> ReadFileToList(string path)
        {
            List<string> textLines = new();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //line = MakeStringEasierToParse(line);

                    textLines.Add(line);
                }
            }
            return textLines;
        }

        public static string MakeStringEasierToParse(string textLine)
        {

            textLine = Regex.Replace(textLine, "Game ", "");
            textLine = Regex.Replace(textLine, " red", "r");
            textLine = Regex.Replace(textLine, " green", "g");
            textLine = Regex.Replace(textLine, " blue", "b");

            return textLine;
        }


        public static List<string> RemoveInvalidLines(List<string> text)
        {
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].Contains("13r") == true | text[i].Contains("14r") == true | text[i].Contains("15r") == true | text[i].Contains("16r") == true | text[i].Contains("17r") == true | text[i].Contains("18r") == true | text[i].Contains("19r") == true | text[i].Contains("20r") == true)
                {
                    text.RemoveAt(i);
                    i--;
                }
                else if (text[i].Contains("14g") == true | text[i].Contains("15g") == true | text[i].Contains("16g") == true | text[i].Contains("17g") == true | text[i].Contains("18g") == true | text[i].Contains("19g") == true | text[i].Contains("20g") == true)
                {
                    text.RemoveAt(i);
                    i--;
                }
                else if (text[i].Contains("15b") == true | text[i].Contains("16b") == true | text[i].Contains("17b") == true | text[i].Contains("18b") == true | text[i].Contains("19b") == true | text[i].Contains("20b") == true)
                {
                    text.RemoveAt(i);
                    i--;
                }
            }
            return text;
        }

        public static int SumOfIDs(List<string> text)
        {
            int sum = 0;
            foreach (string s in text)
            {
                Match collectionIDs = Regex.Match(s, "^\\d{1,2}");
                string IDString = collectionIDs.ToString();
                int ID = Int32.Parse(IDString);
                sum += ID;
            }

            return sum;
        }
    }
}


