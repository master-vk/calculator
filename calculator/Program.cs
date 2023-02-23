// Declare variables and then initialize to zero.
using System;

int num1 = 0; int num2 = 0;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
// тут треба чітко по вимогам історії йти(+, -, / ...)
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");
try
{

}
catch (DivideByZeroException)
{
Console.WriteLine("На ноль делить нельзя");// добре, що знаєте про існування цієї конструкції, але ж ми ще не вчили цього по перше, по друге вона у поточній реалізації не відпрацьовує
}
    // Use a switch statement to do the math.
    switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "f":// ніколи не спрацює, бо очікуєте "f" алеж юзера просите ввести "d")))
        if (num2 == 0)
        {
            Console.WriteLine("na 0 nie dzelimy");
        }
        else
        {
            num2 = (num1 / num2);
            Console.WriteLine($"Your result: {num1}/{num2} = " + (num1 / num2));
        }
        break;
            // не бачю реалізації кейса "^" звести в ступень
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
