using System;

class Program
{
    static void Main()
    {
        int num1, num2, num3;

        
        Console.Write("Please enter three numbers: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());

       
        Console.Write("numbers between " + num1 + " و " + num2 + " that the sum of their digits is equal to " + num3 + " Is: ");
        for (int i = num1 + 1; i < num2; i++)
        {
            if (SumOfDigits(i) == num3)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }

  
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }
        return sum;
    }
}