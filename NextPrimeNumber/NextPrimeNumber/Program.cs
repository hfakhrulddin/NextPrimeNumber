using System;

namespace NextPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Find the next prime number");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Calculation(number));
            }
        }

        public static int Calculation(int number)
        {
            while (true)
            {
                bool isPrime = true;
                //increment the number by 1 each time
                number = number + 1;

                int squaredNumber = (int)Math.Sqrt(number);

                //start at 2 and increment by 1 until it gets to the squared number
                for (int i = 2; i <= squaredNumber; i++)
                {
                    //how do I check all i's?
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                     
                    }
                }
                if (isPrime)
                    return number;
            }
        }
    }
}
