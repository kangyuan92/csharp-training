// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Globalization;

namespace Exercise03
{ 
    public class Program{
        public static void Main(String[] args)
        {
            //1. FizzBuzz
            Console.WriteLine("******** 1.FizzBuss ********");
            for (int i = 0; i < 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("/fizzbuzz/");
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine("/fizz/");
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("/buzz/");
                }
            }

            //int max = 500;
            //for(byte i=0;i< max; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // The loop won't be terminated because max byte is 255, which is alwats less than 500.

            //2.Print a Pyramid

            Console.WriteLine("******** 2. Print a Pyramid ********");
            int height = 5;
            for(int i = 0; i < height; i++)
            {
                for(int j = 1; j < height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //3.
            Console.WriteLine("******** 3.Guess Number ********");
            int correctNumber = new Random().Next(3)+1;
            int guessedNumber = -1;

            while(guessedNumber != correctNumber)
            {
                guessedNumber = int.Parse(Console.ReadLine());

                if(guessedNumber > correctNumber)
                {
                    Console.WriteLine("high");
                }else if(guessedNumber < correctNumber)
                {
                    Console.WriteLine("low");
                }
            }

            Console.WriteLine("Correct!");

            //4.
            Console.WriteLine("******** 4.Age in days ********");
            int year = 2001;
            int month = 07;
            int day = 01;
            DateTime birthday = new DateTime(year, month, day);
            DateTime now = DateTime.Today;

            double ageInDays = (now - birthday).TotalDays;
            Console.WriteLine("totoaldays" + ageInDays);

            int daysToNextAnniversary = 10000 - ((int) ageInDays % 10000);
            DateTime nextAnnieversary = now.AddDays(daysToNextAnniversary);

            Console.WriteLine("nextAnnieversary" + nextAnnieversary.ToString());


            //5.greetings
            Console.WriteLine("******** 5.Greets ********");
            DateTime currentTime = DateTime.Now;

            int hour = currentTime.Hour;

            if (hour >= 6 && hour < 12) Console.WriteLine("Good Morning");
            if (hour >= 12 && hour < 18) Console.WriteLine("Good AfterNoon");
            if (hour >= 18 && hour < 21) Console.WriteLine("Good Evening");
            if (hour >= 21 || hour < 6) Console.WriteLine("Good Night");


            //6.
            Console.WriteLine("******** 6.Count ********");
            for(int i = 1; i <= 4; i++)
            {
                String output = "0";
                for(int j = 1; j <= 24; j++)
                {
                    if (j % i == 0) output += "," + j;
                }
               Console.WriteLine(output);
            }
        }
    }
}
