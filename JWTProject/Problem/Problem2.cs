namespace JWTProject.Problem
{
    using System;

    class Problem2
    {
        static void Main()
        {
            // MathematicLogic Problem
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            while (n != 1)
            {
                Console.Write($"{n} -> ");
                n = GetSumOfSquares(n);
            }
            Console.WriteLine("1");
        }

        static int GetSumOfSquares(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit;
                num /= 10;
            }
            return sum;
        }
    }
}
