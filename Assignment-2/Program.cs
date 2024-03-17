class Program
{
    static void Main(string[] args)
    {
        int sumEven = 0;
        int sumOdd = 0;

        for (int nums = 0; nums < 10; nums++)
        {
            if (nums % 2 == 0)
            {
                Console.WriteLine($"{nums} is an Even Number");
                sumEven += nums;
                //sumEven = sumEven + nums;
            }
            else
            {
                Console.WriteLine($"{nums} is an Odd Number");
                sumOdd += nums;
                //sumOdd = sumOdd + nums;
            }
        }

        Console.WriteLine($"Total of even numbers: {sumEven}");
        Console.WriteLine($"Total of odd numbers: {sumOdd}");


        Console.ReadKey();
    }
}