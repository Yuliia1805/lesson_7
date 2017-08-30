using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {

                /*int[] mas = { 1, 2, 3, 4, 5 };

                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i] + " ");   
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------");

                int[] masNew = new int[mas.Length];

                for (int i = 0; i < mas.Length; i++)
                {
                    masNew[i] = mas[mas.Length-1-i];
                } 
                for (int i = 0; i < masNew.Length; i++)
                {
                    Console.Write(masNew[i] + "");
                }
                Console.WriteLine();*/

                /*int n;
                Console.Write("Enter number of students: ");
                n = int.Parse(Console.ReadLine());

                int[] height = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter height of a {0} student:  ", i + 1);
                    height[i] = int.Parse(Console.ReadLine());
                }
                double avarage = 0;
                for(int i = 0; i < n; i++)
                {
                    avarage = avarage + height[i];
                }
                avarage = avarage / n;
                Console.WriteLine("Avarage height is: {0} ", avarage);*/

                int n = 6;
                int[,] matrix = new int[n, n];

                /*matrix[0, 0] = 1;
                matrix[1, 1] = 1;
                matrix[2, 2] = 1;*/

                for(int l = 0; l < n; l++)
                {
                    matrix[0 + l, 0 + l] = 1;
                }
                for(int j = 0; j < n; j++)
                {
                    for(int i = 0; i < n; i++)
                    {
                        Console.Write(matrix[j, i] + " ");
                    }
                    Console.WriteLine();
                }





                Console.ReadLine();
           }
       }
  }


