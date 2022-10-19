// See https://aka.ms/new-console-template for more information
string myName = "sean";
string language = "C#";
Console.WriteLine($"{myName} is learing a new programming language {language} which is awesome!");


string stringWithSpace = "       Angular          ";
Console.WriteLine($"****{stringWithSpace.Trim()}****");

int number1 = 32;
int number2 = 8;

Console.WriteLine(number1 + number2);
Console.WriteLine(number1 - number2);
Console.WriteLine(number1 * number2);
Console.WriteLine(number1 / number2);
Console.WriteLine(number1 % number2);

int max = int.MaxValue;
int min = int.MinValue;

Console.WriteLine(max);
Console.WriteLine(min);

Console.WriteLine($"ingeter overflow {max + 3}");

double number3 = 9;
double number4 = 2;
double number5 = number3 / number4;
Console.WriteLine(number5);

double maxd = double.MaxValue;
double mind = double.MinValue;
Console.WriteLine(maxd);
Console.WriteLine(mind);

Console.WriteLine(Math.PI);

Console.WriteLine("mac os");

for(int i = 0; i < 10; i++)
{
    for(int j = 0; j < 10; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

var names = new List<string> { "sean", "jobs", "elon", "bruce" };
foreach (string name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}


var fibonacciNumbers = new List<int>{1, 1};

for (var i = 0; i < 18; i++)
{
    var lastOne = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var secondLast = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(lastOne + secondLast);
}

foreach(int num in fibonacciNumbers)
{
    Console.WriteLine(num);
}