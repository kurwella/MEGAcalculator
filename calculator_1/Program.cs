Console.WriteLine("Welcome!");
Thread.Sleep(1000);
Console.WriteLine("It is the greatest C# console calculator! Type 2 numbers first >>> ");
Thread.Sleep(1000);
Console.WriteLine("Number a >>> ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Number b >>> ");
double b = double.Parse(Console.ReadLine());
Thread.Sleep(1000);

Console.WriteLine("Great! Now choose the option u need");
Thread.Sleep(1000);
Console.WriteLine("\ta - add");
Thread.Sleep(200);
Console.WriteLine("\ts - substract");
Thread.Sleep(200);
Console.WriteLine("\tm - multiplie");
Thread.Sleep(200);
Console.WriteLine("\td - divide");
Thread.Sleep(200);
Console.Write("Type your opinion here: ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"{a} + {b} = " + (a+b));
        break;
    case "s":
        Console.WriteLine($"{a} - {b} = " + (a-b));
        break;
    case "m":
        Console.WriteLine($"{a} * {b} = " + (a*b));
        break;
    case "d":
        Console.WriteLine($"{a} / {b} = " + (a/b));
        break;
}