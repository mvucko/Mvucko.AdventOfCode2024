// See https://aka.ms/new-console-template for more information
using Mvucko.AdventOfCode2024;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Mislav's AOC 2024!");
        Console.WriteLine("X for exit at any input!");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Input day to solve: ");
            var input = Console.ReadLine();
            if (input.ToUpper() == "X")
            {
                exit = true;
            }

            Console.WriteLine("Get result for task number: ");
            var key = Console.ReadLine();
            try
            {
                var number = Convert.ToInt32(input);
                Solve(number);
            }
            catch (Exception e)
            {
                Console.WriteLine("not a number :)");
            }
        }
    }


    private static void Solve(int input)
    {
        var handlers = AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(s => s.GetTypes())
                       .Where(p => typeof(ISolution).IsAssignableFrom(p) && p.IsClass);
        foreach (var handler in handlers)
        {
            var handlerInstance = (ISolution)Activator.CreateInstance(handler);
            if (handlerInstance.TaskNumber == input)
            {
                handlerInstance.Solve();
            }
        }

    }
}
