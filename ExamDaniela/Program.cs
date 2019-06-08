using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ExamDaniela
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            //GetMyInfo();

            //exercise 2
            //CountString();

            //exercise 3
            //EvenOrOdd();

            //exercise 4
            //PrintValues();

            //exercise 5
            //Calc2Number();

            //exercise 6
            //DayWeek();

            //exercise 7
            //IsPositive();

            //exercise 8
            //ArrayUPPER();


            //exercise 9
            //ArrayMerge();


            //exercise 10
             Factorial();
        }

        //exercise 1
        static void GetMyInfo ()
        {

            Console.WriteLine("Daniela" + " " + DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm tt"));

        }
        //exercise 2
        static void CountString()
        {
            string value;
            

            Console.WriteLine("Please enter your Value");
            value = Console.ReadLine();
            
            int valuelenght = value.Length;
            Console.WriteLine("The Text Contains :" + valuelenght);
        }


        //exercise 3

            static void EvenOrOdd()
        {

            int i;
            Console.WriteLine("Enter your number");
            while (int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine(i % 2 == 0 ? "even" : "odd");
                Console.WriteLine("Try another number again");
            }


        }


        //exercise 4
        static void PrintValues ()

        {

            for (int i = 1; i <= 10; i++)

            {
                System.Console.WriteLine("{0} ", i);

            }

        }
        //exrcise 5
        static void Calc2Number()

        {
            int num1;
            int num2;
            string operation;
            int result;

            Console.WriteLine("Please enter your First Value");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Second Value");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose the operation: ( * or + ) ");
            operation = Console.ReadLine();

            if (operation == "*")
            {
                result = (num1 * num2);
                Console.WriteLine("The operation result is : " + result);
            }

            if (operation == "+")
            {
                result = (num1 + num2);
                Console.WriteLine("The operation result is : " + result);
            }
        }
                 

        //exercise 6
        static void DayWeek ()

        {

            Console.WriteLine("Insert the Date (format: AAAA-MM-DD): ");
            Console.WriteLine("");            
            string weekDay = Console.ReadLine();
            DateTime parsedDate = DateTime.Parse(weekDay);
            Console.WriteLine("");
            Console.WriteLine("Week day is:" + " " + parsedDate.ToString("dddd"));
        }

        //excersice 7
        static void IsPositive()
        {
            int num1;

            Console.WriteLine("Please enter your  Value");
            num1 = int.Parse(Console.ReadLine());

            if (num1 < 0)
            {
                Console.WriteLine("Negative Number!");
            }
            else if (num1 == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive Number!");
            }
        }

        //exercise 8

        static void ArrayUPPER()
        {
            //string name = "this, is , an , array";
            //if (!string.IsNullOrEmpty(name))
            //{
            //    name =  name.ToUpper();
            //}
            //Console.WriteLine($"String uppercase: {name} ");


            string[] strinput = new string[] { "this", "is", "an","array" };
            Console.Write("Before converting to-upper: ");
            Array.ForEach<string>(strinput, delegate (string x) 
            {
                Console.Write(x + " ");
            }        
            );
            Console.WriteLine();

            string[] revArray = Array.ConvertAll<string, string>
                (strinput, delegate (string s) { return s.ToUpper(); });
            Console.Write("Converted to upper-case: ");
            Array.ForEach<string>(revArray, delegate (string x) { Console.Write(x + " "); });
            Console.WriteLine();

        }

        static void ArrayMerge()
        {

            int[] arr1 = { 1, 3, 6 };
            int[] arr2 = { 2, 5, 4 };

            // show array1

            Console.WriteLine("Array 1...");
            foreach (int element in arr1)
            {
                Console.WriteLine(element);
            }
            // show  array2
            Console.WriteLine("Array 2...");
            foreach (int element in arr2)
            {
                Console.WriteLine(element);
            }
            var myList = new List<int>();
            myList.AddRange(arr1);
            myList.AddRange(arr2);
            int[] arr3 = myList.ToArray();

            // Sort array in ascending order. 
            Array.Sort(arr3);

            Console.WriteLine("Combined elements..");
            foreach (int res in arr3)
            {

                Console.WriteLine(res);

            }
        }

        static void Factorial()

            
        {


            int[] arr1 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                
           



            }



        }
    }
}
