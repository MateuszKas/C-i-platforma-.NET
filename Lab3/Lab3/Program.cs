using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    
    class Program
    {
        public enum WeekDay
        {
            Monday,
            Tuesday,
            Wendesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum Size
        {
            Small,
            Medium, 
            Large
        }
        static void Zadanie2()
        {
            Point2D point_1 = new Point2D(2, 2);
            point_1.ToString();
            Console.WriteLine(point_1);
        }

        static void Zadanie3()
        {
            int int_ = 0;
            int string_=0;
            int float_=0;
            var read = Console.ReadLine();
            while (!read.Contains("-1"))
            {
                try
                {
                    int.Parse(read);
                    int_ += 1;
                }
                catch
                {
                    Console.WriteLine("Nie można przekonwertować na zmienną int");
                }
                finally
                {
                    try
                    {
                        read.ToString();
                        string_ += 1;
                    }
                    catch
                    {
                        Console.WriteLine("Nie można przekonwertować na zmienną string");
                    }
                    finally
                    {
                        try
                        {
                            float.Parse(read);
                            float_ += 1;
                        }
                        catch
                        {
                            Console.WriteLine("Nie można przekonwertować na zmienną float");
                        }
                    }
                }
                Console.WriteLine("Int: {0}, String = {1}, Float = {2}",int_,string_,float_);
                read = Console.ReadLine();
            }
        }

        static void Zadanie4_1()
        {
            Console.WriteLine("Give me number of the day");
            var day = Console.ReadLine();
            var name = (WeekDay)(int.Parse(day)-1);
            Console.WriteLine(name);
        }
        static void Zadanie4_2()
        {
            Console.WriteLine("Give me number");
            var number = int.Parse(Console.ReadLine());
            
            if (number < 10)
            {
                Console.WriteLine((Size)0);
            }
            else if (number>=10 && number < 100)
            {
                Console.WriteLine((Size)1);
            }
            else if (number>=100 && number < 1000)
            {
                Console.WriteLine((Size)2);
            }           
        }
        static void Zadanie5()
        {
            Console.WriteLine("Give me a character");
            var character = Console.ReadKey().KeyChar;
            if ("aąeęioóuyAĄEĘIOÓUY".IndexOf(character)>=0)
                Console.WriteLine("\nVowel");
            else if (char.IsDigit(character))
                Console.WriteLine("\nDigit");
            else 
                Console.WriteLine("\nNeither Vowel or Digit");

        }
        static void Zadanie6()
        {
            Console.WriteLine("Give me a string");
            string string_0 = Console.ReadLine();
            char[] string_1 = string_0.ToCharArray();
            Console.WriteLine(string.Join(" ",string_1));
        }
        static int Zadanie7()
        {
            int z = 0;
            int a = int.MaxValue;
            try
            {
                z = checked(a + 10);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + ex.ToString());
            }
            return z;
        }
        static void Fun1(Point p)
        {
            p.x = 7;
            p.y = 7;
            
        }
        static void Fun2(Coords c)
        {
            c.x = 6;
            c.y = 6;
            
        }
        static void Zadanie8()
        {
            Point p1 = new Point(1, 1);
            Coords c1 = new Coords(1, 1);
            Point p2 = new Point(2, 2);
            Coords c2 = new Coords(2, 2);
            Console.WriteLine("Object.Equals(c1,c2)"+ Object.Equals(c1,c2));
            Console.WriteLine("c1.Equals(p2):"+ c1.Equals(p2));
            Console.WriteLine("p1.Equals(c2):"+ p1.Equals(c2));
            Console.WriteLine("Object.ReferenceEquals(c2,c2)"+ Object.ReferenceEquals(c2, c2));
        }
        static void Zadanie9()
        {
            Console.WriteLine("Write the statement");
            var input = Console.ReadLine();
            var val = new DataTable().Compute(input, null).ToString();
            Console.WriteLine("Result: {0}", val);
        }

        static void Main(string[] args)
        {
            Zadanie9();
        }


    }
    public struct Coords
    {
        public int x, y;
        public Coords(int p1,int p2)
        {
            x = p1;
            y = p2;
        }
            
    }
    public class Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        public void print()
        {
            Console.WriteLine("X: {0}, Y: {1}", x, y);
        }
    }
    public class Point2D
    {
        private double x { get; set; }
        private double y { get; set; }
        
        public Point2D(double x_, double y_)
        {
            this.x = x_;
            this.y = y_;
        }
        public void Reset()
        {
            x = 0;
            y = 0;
        }
        public void IncrX(double dx)
        {
            x = x + dx;
        }
        public void IncrY(double dy)
        {
            y = y + dy;
        }
        public void Print2DPoint()
        {
            Console.WriteLine("Współrzędna x to {0} a współrzędna y to {1}",x, y);
        }
        public double Dist(Point2D Point)
        {
            return Math.Sqrt(Math.Pow(Point.x - x, 2) + Math.Pow(Point.y - y, 2));
        }
    }

    
}
