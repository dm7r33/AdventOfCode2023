﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Day02
{
    internal class CubeConundrumPart2
    {
        public static void Start()
        {
            string path = "C:\\Users\\Dimitri\\source\\repos\\AoC\\AoC\\Day02\\Day02.txt";

            string[] lineArr = File.ReadAllLines(path);

            Dictionary<string, int> DictForValues = new Dictionary<string, int>();

            int sum = 0;

            for (int i = 0; i < lineArr.Length; i++)
            {
                string[] gameSplit = lineArr[i].Split(':');

                for (int j = 1; j < gameSplit.Length; j = j + 2)
                {
                    string[] setSplit = gameSplit[j].Split(";");

                    for (int k = 0; k < setSplit.Length; k++)
                    {
                        string[] drawSplit = setSplit[k].Split(",");

                        for(int l = 0; l < drawSplit.Length; l++)
                        {
                            string[] cubeSplit = drawSplit[l].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                            if (DictForValues.ContainsKey(cubeSplit[1]) == false)
                            {
                                DictForValues.Add(cubeSplit[1], Int32.Parse(cubeSplit[0]));
                            } else
                            {
                                if(Int32.Parse(cubeSplit[0]) > DictForValues[cubeSplit[1]])
                                {
                                    DictForValues[cubeSplit[1]] = Int32.Parse(cubeSplit[0]);
                                } 
                            }
                        }

                    }

                    int product = 1;

                    foreach (int value in DictForValues.Values)
                    {
                        product *= value;
                    }

                    sum += product;

                    DictForValues.Clear();
                }
            }

            Console.WriteLine(sum);
        }
    }
}
