using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Lab4
{
    class Program
    {
        static void Fun1(in int i)
        {

        }
        static void Fun2(out int i)
        {
            i = 1;
        }
        static void Fun3(ref int i)
        {
            i = 1;
        }
        static void Fun4(int i)
        {
            i = 1;
        }
        static void Fun5(Point p)
        {
            Point p1 = new Point(1, 1);
            p = p1;
        }
        static void Fun6(ref Point p)
        {
            Point p1 = new Point(2, 2);
            p = p1;
        }
        static void Zadanie1_1()
        {
            int a1 = 2;
            int a2 = 2;
            int a3 = 2;
            int a4 = 2;
            Console.WriteLine("Przed: {0},{1},{2},{3}", a1, a2, a3, a4);
            Fun1(a1);
            Fun2(out a2);
            Fun3(ref a3);
            Fun4(a4);
            Console.WriteLine("Po: {0},{1},{2},{3}", a1, a2, a3, a4);
        }
        static void Zadanie1_2()
        {
            Point base_ = null;
            Console.WriteLine("Przed Fun5: x: {0}, y: {1}", base_.x, base_.y);
            Fun5(base_);
            Console.WriteLine("Po Fun5: x: {0}, y: {1}", base_.x, base_.y);
            Fun6(ref base_);
            Console.WriteLine("Po Fun6: x: {0}, y: {1}", base_.x, base_.y);
        }
        static public unsafe void swap(int* p, int *q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
        static unsafe void Zadanie2_2()
        {
            int p1 = 1;
            int q1 = 5;
            Console.WriteLine("Before p: {0}, q: {1}", p1, q1);
            swap(&p1, &q1);
            Console.WriteLine("After p: {0}, q: {1}", p1, q1);
        }
        static unsafe void Zadanie2_3()
        {
            int[] int_ = new int[1024];
            fixed (int* ptr = int_)
            {
                for (int i = 0; i < 1024; i++)
                {
                    Console.WriteLine("Wartość[{0}]={1}", i, *(ptr + i));
                }
            } 
            Console.ReadKey();
        }
        static void Zadanie3()
        {
            int[] tab = new int[10];
            int[] new_tab = new int[10];
            for (int i=0;i<10;i++)
            {
                tab[i] = i+1;
                Console.Write(tab[i]+" ");
            }
            Console.WriteLine("\nGive me number: ");
            int number = int.Parse(Console.ReadLine());
            new_tab[0] = number;
            Console.Write(new_tab[0] + " ");
            for (int j = 1; j < 10; j++)
            {
                new_tab[j] = tab[j - 1]; ;
                Console.Write(new_tab[j] + " ");
            }
        }
        static void Zadanie4()
        {
            int[] tab = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Give me number {0}",i+1);
                tab[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 4; j >= 0; j--)
            {
                Console.Write(tab[j] + " ");
            }
        }
        static void Zadanie5()
        {
            int[] tab = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Give me number {0}", i + 1);
                tab[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            Dictionary<int, int> temp = new Dictionary<int, int>();
            foreach (int element in tab)
            {
                if(temp.ContainsKey(element))
                {
                    temp[element]++;
                  
                }
                else
                {
                    temp[element]=1;
                }
            }
            foreach (KeyValuePair<int, int> it in temp)
            {
                Console.WriteLine("Number of item {0}: {1}", it.Key, it.Value);
            }
            
        }
        static void Zadanie6()
        {
            int[][] tab1 = new int[5][];
            tab1[0] =new int[5] { 1, 2, 3, 5, 7 };
            tab1[1] = new int[5] { 1, 2, 3, 5, 7 };
            tab1[2] = new int[5] { 3, 5, 3, 5, 2 };
            tab1[3] = new int[5] { 1, 2, 3, 1, 7 };
            tab1[4] = new int[5] { 1, 7, 3, 5, 7 };

            int[][] tab2 = new int[5][];
            tab2[0] = new int[5] { 1, 6, 3, 2, 9 };
            tab2[1] = new int[5] { 1, 2, 5, 5, 7 };
            tab2[2] = new int[5] { 5, 5, 2, 5, 2 };
            tab2[3] = new int[5] { 8, 4, 3, 1, 8 };
            tab2[4] = new int[5] { 1, 7, 2, 3, 7 };

            int[][] tab3 = new int[5][];
            tab3[0] = new int[5] { 0, 0, 0, 0, 0 };
            tab3[1] = new int[5] { 0, 0, 0, 0, 0 };
            tab3[2] = new int[5] { 0, 0, 0, 0, 0 };
            tab3[3] = new int[5] { 0, 0, 0, 0, 0 };
            tab3[4] = new int[5] { 0, 0, 0, 0, 0 };

            Console.WriteLine("First tab");
            foreach (int[] row1 in tab1)
            {
                foreach (int i1 in row1)
                    Console.Write(i1 + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("Secoind tab");
            foreach (int[] row2 in tab2)
            {
                foreach (int i2 in row2)
                    Console.Write(i2 + "\t");
                Console.WriteLine();
            }
            for (int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    tab3[i][j] = tab2[i][j] + tab1[i][j];
                }
            }
            Console.WriteLine("Third tab");
            foreach (int[] row3 in tab3)
            {
                foreach (int i3 in row3)
                    Console.Write(i3 + "\t");
                Console.WriteLine();
            }

            Console.WriteLine("Length {0}", tab3.Length);
            Console.WriteLine("LongLength {0}", tab3.LongLength);
            Console.WriteLine("Rank {0}", tab3.Rank);


        }
        static void Zadanie7()
        {
            int[,] matrix = new int[3,3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 0;
            matrix[0, 2] = -1;
            matrix[1, 0] = 0;
            matrix[1, 1] = 0;
            matrix[1, 2] = 1;
            matrix[2, 0] = -1;
            matrix[2, 1] = -1;
            matrix[2, 2] = 0;
            Double determinant = (matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[0, 2] * matrix[1, 0] * matrix[2, 1]) - 
                (matrix[2, 1] * matrix[1, 1] * matrix[0, 2] + matrix[2, 1] * matrix[1, 2] * matrix[0, 0] + matrix[2, 2] * matrix[1, 0] * matrix[0, 1]);
            Console.WriteLine("Determinant={0}",determinant);

        }
        static void Zadanie8()
        {
            int[][] tab1 = new int[5][];
            tab1[0] = new int[3] { 1, 2, 3};
            tab1[1] = new int[6] { 4,5,6,7,8,9};
            tab1[2] = new int[4] { 10, 11, 12, 13 };
            tab1[3] = new int[5] { 14, 15, 16, 17, 18 };
            tab1[4] = new int[3] { 19, 20, 21 };

            Console.WriteLine("First way");
            foreach (int[] row1 in tab1)
            {
                foreach (int i1 in row1)
                    Console.Write(i1 + "\t");
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Zadanie8();
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
    }

    /*class TestPointer
    {
        public unsafe static void Main()
        {
            int[] list = { 10, 100, 200 };
            fixed(int *ptr = list)

            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Adres[{0}]={1}", i, (int)(ptr + i));
                Console.WriteLine("Wartość[{0}]={1}", i, *(ptr + i));
            }
            Console.ReadKey();
        }
    }*/

}
