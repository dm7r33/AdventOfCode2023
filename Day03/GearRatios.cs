using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC.Day03
{
    /*
     * part missing
     * add up part numbers from engineschematic
     * schematic is visual representation of engine
     * any number adjacent to a symbol is a partnumber
     */
    internal class GearRatios
    {
        public static void Start()
        {
            string engineSchematicExample = "467..114..\r\n...*......\r\n..35..633.\r\n......#...\r\n617*......\r\n.....+.58.\r\n..592.....\r\n......755.\r\n...$.*....\r\n.664.598..";

            string engineSchematicClean = Regex.Replace(engineSchematicExample, "\r", "");

            //number of rows
            int rows = Regex.Count(engineSchematicClean, "\\n") + 1;

            //number of columns
            int columns = engineSchematicClean.Split('\n').Count();

            string[][] engineSchematicArr = Fill2DArrayForSchematics(Create2DArrayForSchematic(engineSchematicExample, rows, columns), engineSchematicClean);

            foreach (string[] arr in engineSchematicArr)
            {
                foreach (string s in arr)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (int[] arr in FindSpecialCharacteres(engineSchematicArr))
            {
                foreach (int i in arr)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public static string[][] Create2DArrayForSchematic(string schematic, int rows, int columns)
        { 

            string[][] arrSchematics = new string[rows][];

            for(int i = 0; i < arrSchematics.Length; i++)
            {
                arrSchematics[i] = new string[columns];
            }

            return arrSchematics;
        }

        public static string[][] Fill2DArrayForSchematics(string[][] arr, string text)
        {
            string[] arrText = text.Split('\n');



            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = arrText[i][j].ToString();
                }
            }

            return arr;
        }

        public static int[][] FindSpecialCharacteres(string[][] arr)
        {
            int[][] intArr = create2DIntArr(arr.Length, 2);



            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0;j < arr[i].Length; j++)
                {
                    if (Regex.IsMatch(arr[i][j], "[^.0-9]"))
                    {
                        intArr[i][0] = i;
                        intArr[i][1] = j;
                    }
                }
            }

            return intArr;
        }

        public static int[][] create2DIntArr(int row, int column)
        {
            int[][] arrInt = new int[row][];

            for(int i = 0; i < arrInt.Length; i++) 
            {
                arrInt[i] = new int[column];
            }
            return arrInt;
        }
    }
}
