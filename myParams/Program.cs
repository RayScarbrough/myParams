using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.Write("How many random numbers do you want to generate? ");
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = r.Next(1, 100); 
        }

        Console.WriteLine("Generated numbers:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Total of the numbers array = {Add(numbers)}");
        Console.WriteLine($"Product of the numbers array = {Multiply(numbers)}");
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1; 
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}
