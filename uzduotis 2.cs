using System;
using System.Collections.Generic;

namespace Programuoju
{

    class Program2
    {
        static void Main(string[] args)

        {
            var januar = "januar" ;
            var februar = "februar" ;
            var marts = "marts";
            var april = "april" ;
            var maj = "maj";
            var juni = "juni";
            var juli = "july";
            var august = "august";
            var september = "september";
            var oktober = "oktober";
            var november = "november";
            var december = "december";


            var givennumber = (Console.ReadLine());

            switch (givennumber)
            {   
                case "1":
                Console.WriteLine(januar);
                break;

                case "2":
                Console.WriteLine(februar);
                break;

                case "3":
                Console.WriteLine(marts);
                break;

                case "4":
                Console.WriteLine(april);
                break;

                case "5":
                Console.WriteLine(maj);
                break;                                               

                case "6":
                Console.WriteLine(juni);
                break;

                case "7":
                Console.WriteLine(juli);
                break;   
                case "8":
                Console.WriteLine(august);
                break; 
                case "9":
                Console.WriteLine(september);
                break;
                case "10":
                Console.WriteLine(oktober);
                break; 
                case "11":
                Console.WriteLine(november);
                break;   
                case "12":
                Console.WriteLine(december);
                break;    
                                                                                                             
            }
        }




    }


    
}