using System;
using System.Collections.Generic;

namespace Programuoju
{
    class Program3
    {
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            string strrev = "";

            foreach (var word in str.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp + "";
            }
            Console.WriteLine(strrev); 
        }





    }

    
























}