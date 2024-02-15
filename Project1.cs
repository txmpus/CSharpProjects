using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            Write("Write lenght of the field: ");
            int[] arr = new int[int.Parse(ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1000);
                Write(arr[i]+", ");
            }
            ReadLine();


        }
    }
}

/* User enteres a number which will be the lenght of the field. Into the feels it generates random sequence of numbers */
