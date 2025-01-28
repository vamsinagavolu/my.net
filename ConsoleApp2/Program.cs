Console.WriteLine("enter a number1");
int number1;
string userInput = Console.ReadLine();
number1 = int.Parse(userInput);
Console.WriteLine("enter a number2");
int number2;
string userInput1 = Console.ReadLine();
number2 = int.Parse(userInput);
int sum = number1 + number2;
// string concatenation
Console.WriteLine("sum of " + number1 + "and" + number2 + "is" + sum);
// string interpolation
Console.WriteLine($"sum of {number1} and {number2 } is {sum}");
Console.ReadKey();
