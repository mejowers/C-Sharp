﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NumberArrays
{
    class Program
    {
        static int[] ints = new int[] {
    9879,5134,4662,6558,6951,6997,4634,9757,1691,8777,
    3996,4444,2508,8223,2205,5722,1026,6355,5487,6506,
    8748,5575,4434,3178,9094,6040,1669,5188,8927,3687,
    3767,2294,8467,4892,8657,2279,5424,9410,3492,4042,
    4919,5716,5858,2387,4218,7600,6063,9734,5282,1235,
    5527,8661,2139,5867,9729,4593,8522,5246,4329,8429,
    6919,5212,7215,3049,6722,2566,1834,2946,8306,6154,
    9542,7389,3825,3985,2385,5367,1393,7362,8701,5754,
    7453,5542,7657,6706,7116,4781,7050,3668,3812,6168,
    5035,1380,1164,4120,4146,7290,3518,7581,6727,5657
};
        static void Main(string[] args)
        {
            Dictionary<string, int> evenOdd = new Dictionary<string, int>();
            evenOdd.Add("Even", 0);
            evenOdd.Add("Odd", 0);

            foreach (var i in ints)
            {
                if (i % 2 == 0)
                {
                    evenOdd["Even"]++;
                }
                else
                {
                    evenOdd["Odd"]++;
                }

            }
            Console.WriteLine($"{evenOdd["Even"]} even, {evenOdd["Odd"]} odd.");
        }
    }
}
