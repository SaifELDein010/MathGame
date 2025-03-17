
using System;

namespace Generic_Libraries
{
    class Read_Int_Input
    {

        public static bool IsNumber(string number)
        {

            return int.TryParse(number, out int i);

        }


        public static int ReadNumber(string errorMessage = "Not a vaild number, Enter a vaild number: ")
        {

            int number = 0;
            string textNumber = Console.ReadLine();

            while(!IsNumber(textNumber))
            {

                Console.Write(errorMessage);
                textNumber = Console.ReadLine();

            }

            number = Convert.ToInt32(textNumber);

            return number;

        }


        public static int ReadNumber(string message, string errorMessage = "Not a vaild number, Enter a vaild number: ")
        {

            Console.Write(message);
            return ReadNumber(errorMessage);

        }


        public static int ReadNumberBetweenRange(int from, int to, string errorMessage = "Out of range, Enter a vaild number: ")
        {

            int number = ReadNumber();

            while(!(number >= from && number <= to))
            {

                Console.Write(errorMessage);
                number = ReadNumber();

            }

            return number;

        }


        public static int ReadNumberBetweenRange(int from, int to, string message, string errorMessage = "Out of range, Enter a vaild number: ")
        {

            Console.Write(message);
            return ReadNumberBetweenRange(from, to, errorMessage);


        }


        public static int ReadNumberFrom(int from, string errorMessage = "Out of range, Enter a vaild number: ")
        {

            int number = ReadNumber();

            while (!(number >= from))
            {

                Console.Write(errorMessage);
                number = ReadNumber();

            }

            return number;

        }


        public static int ReadNumberFrom(int from, string message, string errorMessage = "Out of range, Enter a vaild number: ")
        {

            Console.Write(message);
            return ReadNumberFrom(from, errorMessage);

        }


        public static int ReadNumberTo(int to, string errorMessage = "Out of range, Enter a vaild number: ")
        {

            int number = ReadNumber();

            while (!(number <= to))
            {

                Console.Write(errorMessage);
                number = ReadNumber();

            }

            return number;


        }


        public static int ReadNumberTo(int to, string message, string errorMessage = "Out of range, Enter a vaild number: ")
        {

            Console.Write(message);
            return ReadNumberTo(to, errorMessage);

        }

    }
}
