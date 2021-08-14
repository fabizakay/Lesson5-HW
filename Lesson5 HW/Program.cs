using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumberName(3);


            Console.WriteLine(PrintNumbers(int.Parse(Console.ReadLine())));

            Console.WriteLine(IsPrime(7));
            int[] arrToCheckBigger1 = { 3, 6, 8, 11, 15, 21 };
            int[] arrToCheckBigger2 = { 5, 2, 6, 15, 222, 14 };
            int firstIsBigger = WhichArrayIsBigger(arrToCheckBigger1, arrToCheckBigger2);
            int[,] createdMatrix = CreateRandomMatrix();
            CheckIfNumberExist(createdMatrix, 15);

            int[] myArry = { 3, 10, 1, 15, -1 };
            int[] sortedArray = SortArray(myArry);
        }

        public static int[] SortArray(int[] arrToSort)
        {
            int min;
            for (int i = 0; i < arrToSort.Length-1; i++)
            {
                min = arrToSort[i];
                for (int j = i+1; j < arrToSort.Length; j++)
                {
                    if (arrToSort[j]< min)
                    {
                        min = arrToSort[j];
                    }
                }
                arrToSort[Array.IndexOf(arrToSort, min)] = arrToSort[i];
                arrToSort[i] = min;
            }
            return arrToSort;
        }
        public static int[,] CreateRandomMatrix()
        {
            int[,] matrix = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(20);
                }
            }
            return matrix;
        }
        public static bool CheckIfNumberExist(int[,] mtrx, int numToCheck)
        {

            
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if (mtrx[i,j]==numToCheck)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int sumOfArry1 = 0, sumOfArry2 = 0, currentNumber;
            for (int i = 0; i < arr1.Length; i++)
            {
                currentNumber = arr1[i];
                sumOfArry1+= currentNumber;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                currentNumber = arr2[i];
                sumOfArry2 += currentNumber;
            }
            return (sumOfArry1 > sumOfArry2 ? 1 : sumOfArry1 < sumOfArry2 ? -1 : 0);

        }
        public static int IsPrime(int number)
        {
            int a = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private static bool PrintNumbers(int num)
        {

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }

            return (num < 10);
        }

        public static void PrintNumberName(int num)
        {
            switch(num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                
            }
                
        }


    }
}
