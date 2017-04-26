﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());
            string[] l = Console.ReadLine().Split(' ');

            int[] arr = new int[100001];
            for (int i = 0; i < 100001; i++) arr[i] = 0;

            for (int i = 0; i < n; i++)
                arr[Convert.ToInt32(l[i])]++;

            int bestr = 0;
            for (int i = 2; i <= 100000; i++)
            {
                int r = 0;
                for (int j = 0; j <= 100000; j = j + i)
                {
                    r = r + arr[j];
                }
                bestr = Math.Max(bestr, r);
            }

            if (bestr == 0) bestr = 1;
            Console.WriteLine(bestr);
        }




    }
}