using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int q = 0; ; q++)
            {
                int[] tomb = new int[10];
                string alma = "1444444";
                int _alma = Convert.ToInt32(alma);
                int x = 0;
                double ertek = 0;

                /*for (int z = 1; z < 10; z++)
                {
                    tomb[z] = alma.IndexOf(Convert.ToString(z)); // hány db van "i" a számból, az kerül be
                    // i-edik fakkba
                }*/

                tomb[4] = alma.IndexOf("4");

                int sz = 0;

                //for (int j = 0; j < 20; j++)
                //{
                    for (int i = 0; i < tomb[sz]; i++)
                    {
                        if (tomb[sz] == 0)
                        {
                            //int asdf = tomb[sz];
                            ertek += Math.Pow(tomb[sz], 3);
                        }
                    }
                    sz++;
                //}

                if (_alma == ertek)
                {
                    Console.WriteLine("{0}", ertek);
                }

                _alma++;
                alma = Convert.ToString(_alma);

            }

            Console.WriteLine("Vége!");
            Console.ReadKey();

        }
    }
}











/*switch (tomb[i])
              {
                  case 1:
                      szamok[x] = i;
                      x++;
                      break;

                  case 2:
                      szamok[x] = i;
                      x += 2;
                      break;

                  case 3:
                      szamok[x] = i;
                      x += 3;
                      break;

                  case 4:
                      szamok[x] = i;
                      x += 4;
                      break;

                  case 5:
                      szamok[x] = i;
                      x += 5;
                      break;

                  case 6:
                      szamok[x] = i;
                      x += 6;
                      break;

                  case 7:
                      szamok[x] = i;
                      x += 7;
                      break;

                  case 8:
                      szamok[x] = i;
                      x += 8;
                      break;

                  case 9:
                      szamok[x] = i;
                      x += 9;
                      break;

                  case 10:
                      szamok[x] = i;
                      x += 10;
                      break;
              }*/