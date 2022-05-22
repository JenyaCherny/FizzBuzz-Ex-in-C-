// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i + " Is Divisible by 2 and 5");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(i + " Is Divisible by 5");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine(i + " Is Even");
            }
            else
            {
                Console.WriteLine(i);
            }
            // Console.ReadKey();
        }
    }
}
