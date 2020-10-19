using System;

namespace Aplikacja1
{
    class Program
    {

        static void zadanie_2()
        {
            double wynik_1 = 3 + 5;
            double wynik_2 = 6 / 4;
            double wynik3_1 = (-1) + 4 * 6;
            double wynik3_2 = (35 + 5) % 7;
            double wynik3_3 = 14.0 + (-4.0) * 6.0 / 11.0;
            double wynik3_4 = 2.0 + 15.0 / 6.0 * 1.0 - 7.0 % 2.0;
            Console.WriteLine("3 + 5 = " + wynik_1 + ", 6/4 = " + wynik_2 + ", wynik 3_1 = " + wynik3_1 + ", wynik 3_2 = " + wynik3_2 + ", wynik 3_3 = " + wynik3_3 + ", wynik 3_4 = " + wynik3_4);

        }

        static void zadanie_3()
        {
            Console.WriteLine("Wpisz liczbę 5: ");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("wpisz liczbę 3: ");
            var second = int.Parse(Console.ReadLine());
            Console.WriteLine("Drugi numer: "+ second + " Pierwszy numer: "+first);


        }

        static void zadanie_4()
        {
            Console.WriteLine("Wpisz pierwszą liczbę: ");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("wpisz drugą liczbę: ");
            var second = int.Parse(Console.ReadLine());
            Console.WriteLine("wpisz trzecią liczbę: ");
            var third = int.Parse(Console.ReadLine());
            var result = first * second * third;
            Console.WriteLine("Iloczyn liczb: {0},{1},{2} wynosi: {3}",third, second, first, result);
        }
        static void zadanie_5()
        {
            Console.WriteLine("Wpisz liczbę: ");
            int number = int.Parse(Console.ReadLine());
            for(int i=0; i<6; i++)
            {
                if(i==0 || i==5)
                {
                    Console.WriteLine("{0}{0}{0}{0}", number);
                }
                else
                {
                    Console.WriteLine("{0}  {0}", number);
                }
            }
        }
        static void zadanie_6()
        {
            int ii = 75400;          
            double id = 7.54 ;
            string s1 = "Wartość int to " + ii.ToString() + ", a wartość double to " + id.ToString();            
            Console.WriteLine(s1);
            
            string s2 = String.Format("Wartość int to {0,-40}, a wartość double to {1,-40}", ii, id);
            string s3 = String.Format("Wartość int to {0,40}, a wartość double to {1,40}", ii, id);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            int iii = 57300;
            double idd= 5.73;
            Console.WriteLine(String.Format("Formaty dla liczby 57300:{0:c},{0:D},{0:E},{0:f}, {0:x}", iii)); //Operacje {0:r},{0:o} nie są dostępne dla typu int
            Console.WriteLine(String.Format("Formaty dla liczby 5.73: {0:c},{0:f},{0:r}", idd));//Operacje {0:d},{0:e},{0:o},{0:x} nie są dostępne dla typu double

            float flo = 220.022f;
            Console.WriteLine(String.Format("Formaty dla liczby 220.022f:{0:0.00000},{0:[#].(#)(##)},{0:0.0},{0:0,0}, {0:,.}, {0:0%}, {0:0e+0}", flo));

            double a = 123.4;
            double b = -1234;
            double c = 0;
            Console.WriteLine(String.Format("Format dla liczby 123.4:{0:#,##0.0; (#,##)Minus;Zero}", a));
            Console.WriteLine(String.Format("Format dla liczby -1234:{0:#,##0.0; (#,##)Minus;Zero}", b));
            Console.WriteLine(String.Format("Format dla liczby 0:{0:#,##0.0; (#,##)Minus;Zero}", c));

            DateTime d = System.DateTime.Now;
            Console.WriteLine(String.Format("Formaty dla czasu:{0:d}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:D}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:t}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:T}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:f}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:F}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:g}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:G}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:M}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:r}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:s}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:u}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:u}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:U}", d));
            Console.WriteLine(String.Format("Formaty dla czasu:{0:Y}", d));
        }
        static void zadanie_7()
        {
            Console.WriteLine("Podaj temperaturę w stopniach Celsjusza: ");
            double celsius = int.Parse(Console.ReadLine());
            double fahrenheit = celsius*18.0/10.0 + 32;
            double kelvin = celsius + 273;
            Console.WriteLine("Temperatura {0} stopni Celsjusza jest równa {1} stopni Fahrenheita oraz {2} stopni Kelvina", celsius, fahrenheit, kelvin);
        }

        static bool zadanie_8()
        {
            Console.WriteLine("Wpisz pierwszą liczbę: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("wpisz drugą liczbę: ");
            int second = int.Parse(Console.ReadLine());
            if ((first < 0 && second > 0) ||(first>0 && second<0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            zadanie_6();
            //Console.WriteLine(zadanie_8());

        }
    }
}
