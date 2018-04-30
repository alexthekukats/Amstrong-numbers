using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer asd = new Timer(TimerCallback2, null, 0, 1000);
            DateTime begin = DateTime.Now;
            as22d();

            int sz = 0;
            for (int i = 10; ; i++)
            {
                string stri = Convert.ToString(i);
                int hossz = stri.Length;
                double szum = 0;
                for (int j = 0; j < hossz; j++)
                {
                    szum += Math.Pow(Convert.ToInt32(stri.Substring(j, 1)), hossz);
                }
                if (szum == i)
                {
                    Console.WriteLine(i);
                    sz++;
                }
                if (sz == 15)
                {
                    //TimerCallback(asd);
                    DateTime end = DateTime.Now;

                    Console.WriteLine(end - begin);
                    Console.ReadKey();

                }
            }
        }

        private static void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }

        private static void TimerCallback2(Object o)
        {

        }


        static void as22d()
        {
            DateTime begin = DateTime.Now;
            int r;
            int num = 100000000, i, sum = 0, temp;
            int sz = 0;

            for (i = 1; i <= num; i++)
            {
                temp = i;
                while (temp != 0)
                {
                    r = temp % 10;
                    sum = sum + r * r * r;
                    temp = temp / 10;
                }

                if (i == sum)
                {
                    Console.WriteLine(i);
                    sum = 0;
                    sz++;
                }

                if (sz == 15)
                {
                    DateTime end = DateTime.Now;

                    Console.WriteLine(end - begin);
                    Console.ReadKey();
                }
            }




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