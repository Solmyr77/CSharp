using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Morze
{
    class Program
    {
        static List<morzeabc> listaabc = new List<morzeabc>();

        static List<morzetext> wordlist = new List<morzetext>();

        static Dictionary<string, string> dic = new Dictionary<string, string>();

        static void Main(string[] args)
        {

            StreamReader morzeabc = new StreamReader("morzeabc.txt");

            morzeabc.ReadLine();

            while (!morzeabc.EndOfStream)
            {
                morzeabc abcm = new morzeabc();
                string[] sor = morzeabc.ReadLine().Split('\t');
                abcm.characterm = sor[0];
                abcm.morzecode = sor[1];

                listaabc.Add(abcm);
            }

            morzeabc.Close();
            StreamReader morzeszoveg = new StreamReader("morze.txt");

            while (!morzeszoveg.EndOfStream)
            {
                morzetext szavak = new morzetext();
                szavak.words = morzeszoveg.ReadLine();
                wordlist.Add(szavak);
            }

            morzeszoveg.Close();

            foreach (var item in listaabc)
            {
                dic.Add(item.morzecode, item.characterm);
            }

            int spaces = 0;
            string szoveg = "";
            string karakter = "";
            string result;

            foreach (var item in wordlist)
            {
                foreach (char betu in item.words)
                {

                    if (betu != ' ' && betu != ';')
                    {
                        karakter += betu.ToString();
                    }

                    if (betu == ' ')
                    {
                        spaces++;
                    }
                    if (betu == ';')
                    {
                        szoveg += ":";
                    }

                    if (spaces == 3 && betu != ' ' && betu != ';')
                    {

                        karakter = "";

                        karakter += betu.ToString();
                        spaces = 0;

                    }

                    if (spaces == 7 && betu != ' ')
                    {
                        szoveg += " ";

                        spaces = 0;

                    }

                    if (spaces == 1)
                    {
                        if (dic.TryGetValue(karakter, out result))
                        {
                            szoveg += result;
                            result = "";
                            karakter = "";
                        }
                    }
                }

                if (dic.TryGetValue(karakter, out result))
                {
                    szoveg += result;

                    result = "";
                    karakter = "";
                }

                szoveg += "\n";
            }

            Console.WriteLine(szoveg);
            Console.ReadKey();
        }
    }
}
