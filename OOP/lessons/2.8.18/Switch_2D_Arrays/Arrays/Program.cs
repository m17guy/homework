using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDArrays();
        }

        static void TwoDArrays()
        {
            /*
             Jagged Array - an array of arrays.

            int[] //array of integers
            int[][] //array of arrays of integers
            int[][][] //array of arrays of arrays of integers

            1D char array
            ['a', 'b', 'c']

            2D int array
            ja -> [ [1, 2, 3], [4, 5, 6], [7, 8, 9, 10] ]

            ja[0] == [1, 2, 3]
            ja[1] == [4, 5, 6]

            ja[0][0] == 1
            ja[2][1] == 8

            matrix - like jagged array but simetric (rectangle shaped)
            
            int [ , ] //2D matrix
            int [ , , ] //3D matrix
            
            mat -> [[1,2,3], [4,5,6], [7,8,9]]
             */

            //jagged array
            string[][] ja1 = new string[2][];
            ja1[0] = new string[] { "bubu", "groot", "deadpool" };
            ja1[1] = new string[] { "asd", "asd" };

            int[][] ja2 = {
                new int[] {1, 2, 3 },
                new int[] {4, 5, 6 },
                new int[] {7, 8, 9, 10 }
            };

            Console.WriteLine(ja2[2][3]);

            //matrix
            int[,] mat1 = new int[2, 5];
            mat1[0, 3] = 19;

            int[,] mat2 = { { 1, 2, 3, 4, 5, 6 }, { 12, 13, 14, 15, 16, 17 } };
            Console.WriteLine(mat2[1, 3]);
        }

        /*
         * static int[][] Create2DArray(), return an array : [ [1,1,1] , [1...10], [100,95,90....5,0] ]
         * static void Arr2(), create an 2D arr of strings,  and put values in it
         */

        static int[][] Create2DArray()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 1, 1 };
            arr[1] = new int[100];
            arr[2] = new int[21];

            for (int i = 0; i < arr[1].Length; i++)
            {
                arr[1][i] = i + 1;
            }

            int num = 100;
            for (int i = 0; i < arr[2].Length; i++)
            {
                arr[2][i] = num;
                num -= 5;
            }

            return arr;
        }

        static void PrintArr2()
        {
            string[][] names = new string[2][];

            names[0] = new string[]{ "Bubu","Groot"};
            names[1] = new string[4];

            names[1][0] = "Vlad";
            names[1][1] = "Yuval";
            names[1][2] = "Rehuven";
            names[1][3] = "Angelika";

            //for omri
            for(int i = 0; i < names.Length; i++)
            {
                for(int j = 0; j < names[i].Length; j++)
                {
                    Console.WriteLine(names[i][j]);
                }
            }
        }
    }
}
