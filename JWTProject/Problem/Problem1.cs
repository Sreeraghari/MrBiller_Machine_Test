namespace JWTProject.Problem
{
    using System;

    class Problem1
    {
        //Perfect Number Problem
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (IsPerfectNumber(num))
            {
                Console.WriteLine($"{num} is a Perfect Number.");
            }
            else
            {
                Console.WriteLine($"{num} is NOT a Perfect Number.");
            }
        }
    }

}
