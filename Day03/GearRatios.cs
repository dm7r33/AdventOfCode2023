﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
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
            //string engineSchematicExample = "467..114..\r\n...*......\r\n..35..633.\r\n......#...\r\n617*......\r\n.....+.58.\r\n..592.....\r\n......755.\r\n...$.*....\r\n.664.598..";

            //string engineSchematicExample = "12.......*..\r\n+.........34\r\n.......-12..\r\n..78........\r\n..*....60...\r\n78.........9\r\n.5.....23..$\r\n8...90*12...\r\n............\r\n2.2......12.\r\n.*.........*\r\n1.1..503+.56";

            //string engineSchematicClean = Regex.Replace(engineSchematicExample, "\r", "");

            ////number of rows
            //int rows = Regex.Count(engineSchematicClean, "\\n") + 1;

            ////number of columns
            //int columns = engineSchematicClean.Split('\n').Count();

            //char[][] engineSchematicArr = Fill2DArrayForSchematics(Create2DArrayForSchematic(rows, columns), engineSchematicClean);

            //foreach (char[] arr in engineSchematicArr)
            //{
            //    foreach (char s in arr)
            //    {
            //        Console.Write(s);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //foreach (int[] arr in FindSpecialCharacteres(engineSchematicArr))
            //{
            //    foreach (int i in arr)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //foreach(KeyValuePair<int, bool> number in findNumber(engineSchematicArr))
            //{
            //    Console.WriteLine("{0} {1}", number.Key, number.Value);
            //}

            string engineSchematic = "..224.....487...................718.....................378............................................284........310......313..........311.\r\n....*..............................*744....486*485......*......741......@...359.#666...439................*925....*......$..+........@......\r\n.235................758..440...........................251....*......262.....*..........*......................752......774.......515.......\r\n.........705%..@746........+..942*591.347.470...#..257.........637...........793.......299..../.....813....509......464......&.........688..\r\n.....82................................*.../..901.....*..................836.....&............814...*........*..............80...17*....*...\r\n.../...*...679.661.....299...........222.............875.....213...161............964...894.........998.....310....258.85...........735.586.\r\n.650..23..#......*.......................................760*........@./........................202...................*.....339.............\r\n..............598......#.....536....702*.........705..........793......957............./........*...935...........965.......................\r\n..................*.357...+.....@.......242.......*......283..*...=956.......118.......959...184...*..............*....401*527.....348...161\r\n.63=...955.523..77......978.846....849..........699..........790........=911.*.....87...............486.........914..............=..........\r\n.........*.........842......*.......*..................*127....................844...*....946.......................235...209@...710.735....\r\n...........@.........*.....144....226....298........560.....253.........431......*...586.......723..../...482.......&...................*...\r\n...........871../918........................+....................329*......%.....906.............*...350.....@...............365.......361..\r\n......................536............................+..793..........664.....739................507......289.....256%...73..*...............\r\n.356..834..............*.........96.939..............28.+....=..............*...........................*................$.553..........526.\r\n...*...*.............501..746....*..-.......=.................890.....+...701..............807........447......97$..%...........58......$...\r\n.891....346...699...........*.421......+....666......198*791......340.433............#...%...*.......................316........*.....%.....\r\n..............%........81.984...........462....................../..........116...711....963...$................380.......745...85....224...\r\n.........370......923..@.....................563...........188+.........326*...................67.815..............*582.....................\r\n.........*........-........#530.........489........59...................................................#.....57.........100.*.......441*161\r\n.637*....961...........118...........21*...........@..216+.........................+....432*.*309..64....992.......81......=.781.644........\r\n.....324.........126......*166...............&...................385*..............233............*................*..436...........*517....\r\n.88*.........390*................355..335...372....+254..............294...$589........&..803/.....38..-...........56..$....................\r\n....235.-.........+196...948....*........-................359.........................398.............608..../.................145..346.....\r\n........915.................-.485.945.................936*................114.............118...............490.536..............*.%........\r\n.663........61.......856..........+....343....859...............*345.......*...=862............711.............................313.....606..\r\n........23...$.....@..................*......................316.....529.362.............49......................307*791....................\r\n225...............281...#..222.....@..283..............675............*.........911*90..-.....914..%39....509...............................\r\n.......797*....$........23..../...895.............67.......164.896.....554.....................*............=..............460........181...\r\n...........211.474...............................@...........*....*201..........911.717.#....192.75..679...........$.........*.........=....\r\n....355.........................&.....................678.650......................*.....128.....*.....*.........925..230...105.............\r\n....*.......409#.......*897.....698....427.........+....*.......*...............................313...670..521.......*....&.............*308\r\n...838..335.................367........-..........325....233...224...950......688.....199.774.........................793.108........501....\r\n...........*..102..924.349...+..595....................................*................&..............395+.....................753.........\r\n.........318...*......*........*....676...759.154...................524...........908.........694.211................173...........*214..424\r\n....458........403...........958.98....*........*..............688......957...488..+...........*.../....................................*...\r\n.......*.............591...............218.....203.....196$.......+....*........*......................765......971......./....927*741..227.\r\n......592..%60.$.....*.....885/....287...............................474.........409......226.174.......@........*.....230..................\r\n...............162.169.................510..962..............17......................32@..*...*.................225....................-....\r\n.....880...................201.....823*........*...914.724.........89...&.......267=.....717.54.436..........60...............&.........69..\r\n710........601....306.287.....+.........65...308....&...=.../......*.....926..................................*........278.415......-.......\r\n..............*..*......&..........241.%...................827../.265.............662.678......@...#......@.....$......-............734.144.\r\n.............424..434.....701.....*........380*731.............24.................*...&........973..741....728..357.........................\r\n........304.................*...881................238.....740.........947........587...22...........................271*........603....@...\r\n...................266.....918....................*..........+.519.617..*...826..........*............./268..974.........486.376....*.295...\r\n...939.........363.*...............378..........302....586........*....740...=..........380........931...........................12.........\r\n...*..........-.....387...............*..588..............*..../...............315...................-...712..491.........956.....#.........\r\n.180.454...................104..661...91...*.............811....370......471...-....419....804..........*...................*...............\r\n.....*.......@../464........%..*............243.....578...................&..........*...........604..250.....784....750....998.............\r\n.....245....165.................771...................&.......#.691...768....654....261.........................*.......*............566....\r\n441..................91.....194.......643...932*............379.#....$.......*.................86.............940..263.638...........*......\r\n...+.............%.../.......#.........*........344...795..................991..........544....*..................*..........767...266......\r\n.......-..708..727.....191$......*.....698....=...................990................+.....*....308.......@......325.........*.........44...\r\n...18.397....=.....93.........649.900.........62....-........322.....*.......@......339....619..........404..........540........./....*.....\r\n..../...............%............................742............*...........196................874.205........96#..............203.224......\r\n.........704...727.................496.......*........135....769........./.................%....&....*.../..=.........757...................\r\n........*........*..424..........&........714.5........*...........@....884...............114.......674.144..83..........*302...........%...\r\n........29....179..*............104..................531....629.455..................473......300....................254..............640...\r\n..................296.......................................................1........*.......%..............548........*.....103............\r\n....381...........................365#..713.282.......%744....................../....709...#...=...431...$.*......*.....837.....*9.....*....\r\n......*.90.....347.179#...................%.......359..........92............304...*.....923.446.......385.699.....749..............193.206.\r\n....922.+.......*.......-197.....................*.......128........273....@.....758..............439...................650*54.736#.........\r\n................817..-..........152..594..949..807.......$...224...*.....124............889.......=...................................625...\r\n....139....667......239........*...........*.......387........%..806........../...........*..788....632...........=8......584-......*.%.....\r\n...........*.................280...........11.........*726............181......761..-....66.....%....-................64...........14.......\r\n............742.736.725..........708.667..........332.......828*750......-.........425.......................944.....*...................926\r\n.719...110...........*.....348...=..........121......*........................................*.......961.....*.......971...........+.......\r\n..../.....*629........830..*............91....&..241..491...930............561................889....*....710.333..............163...311....\r\n......%...................252.../..................*...........*270.......................165.....208.......*..................../.......694\r\n...914...126...267.183........952..$645......414.822................................69.......-..........=..112.464..267....359..........*...\r\n.............7*..........................806.../.....931.....*.....355..............*....928...........854.........-..............*993...101\r\n439.897...........%...........8......381...*........*....748..987....*............437.......*....954.......................*................\r\n.......*595....783........49.....110.$...675...8...60.....=........981........&..........730....*.............336.......120.790..........386\r\n............90..............*212...*..........*.......985.....153........*..12...912*383......665.....754.....-.....................950.....\r\n......790#.*........896@.........773....777..581..514*....910.....5.....579.............................=.......#.....................*.....\r\n...&.......496...........347..............*...............*...................../............................790..............334......912..\r\n692............609....&.......694..........693...213....620......695......871..385.......82..........785.......................*..163.......\r\n.........#....*......984.........*.................=............*.......................................*.545...-............978.....*......\r\n......971...477.............465......196*313..........447.......766......49.......126*480.............798......792..359*193...........837...\r\n................157...........+..................773.=..............752$....................447*565..........................*53............\r\n.384%..........@.........449............470..749...@.........@792..............138..527.......................339.....299.505...........287.\r\n......691........700........@......96..........*........721*.....................@....*...942......845........*......-.........713..........\r\n.....*......260/...*...........................491..452.....336.......................73....+..960..........238...........163$..&...=.@.....\r\n....689.............831...282....709.960.............=.............204............................#..............59...97..........199..111..\r\n........................$........../........-....498......................557....&...........972............450.............................\r\n.............653........476...398.........619...*.....*280..923..............*31..691.........*........=...*.....67......782................\r\n..............*....%..........*.........+......268...........&........428....................408....740....576....*.......*.........$.......\r\n....-../...734......317.114.332...795...743.........................-..=..908...........381.......................914...420.*647....528.....\r\n..284.825...............*......................721/.=929.........324.....*....167.561...*.....815*466.......................................\r\n..............389..304.480.......851..@....585..............942%......#.496....*....-.53................170....938*..........518............\r\n........368..*.....@..............*....941..+.......*...............930.........364.......522......................59.........+....$....652.\r\n...........+.963...................949...........828.784......860............*......420.....*..................*......548...........310.*...\r\n.....476...............*...............=...94.+..................&........589.833....*..426.940.....&.....959.993.&88....................398\r\n.......*................624....917...838..*...664.......721........................833...$.......672......$............19...................\r\n....350.......................&....=..............333.................707....................................240..336....=...746.263..$463..\r\n.........................-.........220.....663...../.............*849..#..631.....712....=.../...308.580.............*..........*...........\r\n.78@......../..........422....444.............*...............281............*...*....447..37.......*................814....................\r\n........./...788...810.........&..............369..985....-................92................................684...............74...........\r\n......279.........*......128/....464........#...../......944........978...............163..984*5.@............+.......165......*....285.....\r\n..................889.............*.......969........................%.......5......&....$........272....................*......374.........\r\n.........&..............@948..*..13.358........796.............632............*....789........91*..............*66........152...............\r\n........508...+..............3...........544.....$.517.....703....*774.......434............/....794........932.............................\r\n...$...........241.....74...........974..*...954............*.......................375..772...........218.........414...........*366....252\r\n.501..566...............*..........*....599.....#........256.....468@..942.101.........*..........156...*.............*.......998...........\r\n...../.............263.312....+..767..............#.........................*...&95..838.162=.....+....130.........583..544.......176.......\r\n............................936......826.......421.......-139.......982...893.......................*..................*........./..........\r\n.284.....=724...................661.$....694........85..........438.............51...............616.698.*36.....262......357+........224...\r\n....@..........491........+........................@......193......*596...........%../844...387.................$.....132.........%.........\r\n.......84..............362.................................*..98..........&................*....14....394..........$..............56........\r\n.........*432.....512................704......424.............*............74........196%..875...*.....*............132.......229...........\r\n..............723*.........568........*..108........672......55.172...217.........................289.427........................*..........\r\n.........#795.........214....*.336...94....*....988................%..&.............*86......*...............838&.......540.......902.......\r\n.922...........288........719.....*........845...&..558......#...................524......195.704.....................................77....\r\n...*....842....../...166........883...-................*503..451..305../....600............................900..280.....*169...586..........\r\n751....*.........../.*......944......116....416.........................877....*....418...194........644..*....=.....244..........#.....354.\r\n.......118......208...................................788...................826........$....$...207.....@..152...........893*608.......&....\r\n..948.......................203../....206.............*....341./977.916.........49...#........@....-............+385........................\r\n...*......266.................*...607...@.990......964..............-..........*.....340...697........62..............526.....-.............\r\n..675.....*..........612....604.............*..............492.884...........212...............*157....*...679.........*....706...716%.518..\r\n......103.749..989...*...................739..............$......=..=..................212..684.....35.......*.........785..............+...\r\n..343*......../.......680.....................*423.................476....&....420..............241..*......532.....+.......864$.....&......\r\n..................826........403..311...60.451.............+...........562....../.......306.......*..............420..................321...\r\n...241..............*...........+..=....@......*240.......845....@.........740.................968..389.177*...................640..........\r\n......*82...........963...211%...............38...............901.....404.........&..253..............-.....37.........218.501...*....320...\r\n....*...........................#215...264......298........................*970..801....*....569...............3.......*......%..859.*......\r\n.136.818...212...........91*72........*.........-...750.....775*728.29.270...............984.&...371..........*.........639..........670....\r\n...........*.../959................438.....524......*...943.........*................755...................162.................446#.........\r\n..........290.............751................*.....557..*...483.............421.........*............189.%................/.................\r\n....................9.786..-......835.......978........445.%..........350........860..662.......#...*....354........*.....682...............\r\n.117..57+....441...*....+............................................../............*.........88....142..........%.927......................\r\n...*...........*..402....................874.....734.926$../...............*633......219.84/............662...205...................334.....\r\n...981........367........338...332/.........=......*......119....375#.334.......146..............%.....$................384.............-511\r\n........165................=....................666.....................#..614.....-..%744..617.887.......848*..............................\r\n...........*.203.593...158....*..........152..............+817.....866.......&...............*......../.......904........701.165.80.........\r\n404..977.93..*....*....*...396.281......*....953....*................*.........116..97.70=..179....107..338................$...*....622.....\r\n......=.....445........................382.....*...672................859......*...%....................&..........-.571......717....*......\r\n..................240............175..........808..............225..........988............/604..............232.448..*..651......769.......\r\n.........569*....*........975*.....*....968..............585.....*................26.................................394....@.142...........\r\n......*......498..969.........360.666...%.........................919.......360........-.*.........%...................................484..\r\n...407................886...................................84......................933...101....58........839..425.........................";

            string engineSchematicClean = Regex.Replace(engineSchematic, "\r", "");

            //number of rows
            int rows = Regex.Count(engineSchematicClean, "\\n") + 1;


            //number of columns
            int columns = engineSchematicClean.Split('\n').Count();

            char[][] engineSchematicArr = Fill2DArrayForSchematics(Create2DArrayForSchematic(rows, columns), engineSchematicClean);

            int count = 0;

            foreach (char[] charArr in engineSchematicArr)
            {
                Console.Write(count + " ");
                count++;
                foreach (char myChar in charArr)
                {
                    Console.Write(myChar);

                }
                Console.WriteLine();
            }

            Console.WriteLine(SumPartNumbers(findNumber(engineSchematicArr)));
        }

        public static char[][] Create2DArrayForSchematic(int rows, int columns)
        {

            char[][] arrSchematics = new char[rows][];

            for (int i = 0; i < arrSchematics.Length; i++)
            {
                arrSchematics[i] = new char[columns];
            }

            return arrSchematics;
        }

        public static char[][] Fill2DArrayForSchematics(char[][] arr, string text)
        {
            string[] arrText = text.Split('\n');



            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = arrText[i][j];
                }
            }

            return arr;
        }

        //public static int[][] FindSpecialCharacteres(char[][] arr)
        //{
        //    int[][] intArr = create2DIntArr(arr.Length, 2);



        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr[i].Length; j++)
        //        {
        //            if (Regex.IsMatch(arr[i][j].ToString(), "[^.0-9]"))
        //            {
        //                intArr[i][0] = i;
        //                intArr[i][1] = j;
        //            }
        //        }
        //    }

        //    return intArr;
        //}

        public static int[][] create2DIntArr(int row, int column)
        {
            int[][] arrInt = new int[row][];

            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = new int[column];
            }
            return arrInt;
        }

        public static List<int> findNumber(char[][] arr)
        {
            List<int> dictNumbers = new List<int>();

            string? number = null;
            string index = null;

            int sum = 0;

            //int count = 0;

            bool isPartNumber = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (Regex.IsMatch(arr[i][j].ToString(), "[0-9]"))
                    {
                        number += arr[i][j];
                        //Console.Write("{0}, {1}, {2}: {3}; ", i, j, checkForSpecialChar(i, j, arr), arr[i][j]);
                        //Console.WriteLine();
                        if (checkForSpecialChar(i, j, arr) && !isPartNumber)
                        {
                            isPartNumber = true;
                        }
                    }
                    else if (Regex.IsMatch(arr[i][j].ToString(), "[^0-9]") && number != null)
                    {
                        if (isPartNumber)
                        {
                            dictNumbers.Add(Int32.Parse(number));
                            sum += Int32.Parse(number);
                            Console.WriteLine(number);
                        }
                        number = null;
                        isPartNumber = false;
                    } 

                    if(j == arr[i].Length - 1)
                    {
                        if (isPartNumber)
                        {
                            dictNumbers.Add(Int32.Parse(number));
                            sum += Int32.Parse(number);
                            Console.WriteLine(number);
                        }
                        number = null;
                        isPartNumber = false;
                    }
                }
                //count++;
            }

            return dictNumbers;
        }

        public static bool checkForSpecialChar(int row, int column, char[][] arr)
        {

            if (row != 0 && column != 0 && Regex.IsMatch(arr[row - 1][column - 1].ToString(), "[^.0-9]"))
            {
                return true;
            } 
            else if (row != 0 && Regex.IsMatch(arr[row - 1][column].ToString(), "[^.0-9]"))
            {
                return true;
            }
            else if (row != 0 && column != arr[row].Length - 1 && Regex.IsMatch(arr[row - 1][column + 1].ToString(), "[^.0-9]"))
            {
                return true;
            }
            else if (column != 0 && Regex. IsMatch(arr[row][column - 1].ToString(), "[^.0-9]"))
            {
                return true;
            }
            else if (column != arr[row].Length - 1 && Regex.IsMatch(arr[row][column + 1].ToString(), "[^.0-9]"))
            {
                return true;
            }
            else if (row != arr.Length - 1 && column != 0 && Regex.IsMatch(arr[row + 1][column - 1].ToString(), "[^.0-9]"))
            {
                return true;
            }
            else if (row != arr.Length - 1 && Regex.IsMatch(arr[row + 1][column].ToString(), "[^.0-9]"))
            {
                return true;
            }
            else if (row != arr.Length - 1 && column != arr[row].Length - 1 && Regex.IsMatch(arr[row + 1][column + 1].ToString(), "[^.0-9]"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SumPartNumbers(List<int> listPartNumbers)
        {
            int sumParts = 0;

            foreach(int number in listPartNumbers) 
            {
                sumParts += number;
            }

            return sumParts;
        }


    }
}
