// See https://aka.ms/new-console-template for more information
string name = "sean";
string language = "C#";
Console.WriteLine($"{name} is learing a new programming language {language} which is awesome!");


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

