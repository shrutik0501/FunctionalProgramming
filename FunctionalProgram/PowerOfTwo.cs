﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public  class PowerOfTwo 
    {
        public void oftwo()
        {
            Console.WriteLine("Enter a value:");
            int n = int.Parse(Console.ReadLine());
            int p = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(p);
                p = p * 2;
            }
        }
    }
}

