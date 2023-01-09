using System;
namespace learnCSharpBasics
{
    enum Operation
    {
        SystemTest,
        Start,
        Stop,
        Reset
    }

    public class PatternMatching
    {
        record Order(int Items, decimal Cost);

        // type tests

        public static T MidPoint<T>(IEnumerable<T> sequence)
        {
            if (sequence is IList<T> list)
            {
                return list[list.Count / 2];
            }
            else if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
            }
            else
            {
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0) halfLength = 0;
                return sequence.Skip(halfLength).First();
            }
        }

        public static void run()
        {
            // null check
            // declaration pattern
            int? maybe = 12;

            if (maybe is int number)
            {
                Console.WriteLine($"The nullable int 'maybe' has the value {number}");
            }
            else
            {
                Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
            }

            // constant pattern
            string? message = "This is not the null string";

            if (message is not null)
            {
                Console.WriteLine(message);
            }

            // compare discrete value
            string PerformOperation(Operation command) =>
                command switch
                {
                    Operation.SystemTest => "SystemText",
                    Operation.Start => "Start",
                    Operation.Stop => "Stop",
                    Operation.Reset => "Reset",
                    // _ is discard pattern
                    _ => throw new ArgumentException("Invalid enum value for command", nameof(command))
                };

            // relational pattern
            string WaterState(int tempInFahrenheit) =>
                    tempInFahrenheit switch
                    {
                        (> 32) and (< 212) => "liquid",
                        < 32 => "solid",
                        > 212 => "gas",
                        32 => "solid/liquid transition",
                        212 => "liquid / gas transition",
                    };

            //multiple input
            decimal CalculateDiscount(Order order) =>
                    order switch
                    {
                        { Items: > 10, Cost: > 1000.00m } => 0.10m,
                        { Items: > 5, Cost: > 500.00m } => 0.05m,
                        { Cost: > 250.00m } => 0.02m,
                        null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
                        var someObject => 0m,
                    };

        }
    }
}

