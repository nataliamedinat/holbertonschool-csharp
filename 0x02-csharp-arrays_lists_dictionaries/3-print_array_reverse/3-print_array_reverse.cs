﻿using System;

    class Array
    {
        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("");
                return ;
            }

            for (int value = array.Length -1; value >= 0; value--)
            {  
                if (value == 0)
                {
                    Console.WriteLine(array[value]);
                    break;
                }
                 Console.Write (array[value] + " ");
            }
        }
    }