using System;

class InvalidOperationCustomException : Exception
{
    public int StatusCode { get; private set; }

    public InvalidOperationCustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("first number: ");
            double number1 = ReadNumber();


            Console.Write("second number: ");
            double number2 = ReadNumber();


            Console.Write("fill operation (+, -, *, /): ");
            char operation = ReadOperation();


            double result = PerformOperation(number1, number2, operation);


            Console.WriteLine($"result: {number1} {operation} {number2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("error,fill valide value.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("you can't divide on 0 .");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"incorrect operation {ex.Message}");
        }
        catch (InvalidOperationCustomException ex)
        {
            Console.WriteLine($"system error: {ex.Message}. status: {ex.StatusCode}");
        }
        catch (Exception)
        {
            Console.WriteLine("please try again.");
        }
    }

    static double ReadNumber()
    {
        if (!double.TryParse(Console.ReadLine(), out double number))
        {
            throw new FormatException();
        }
        return number;
    }

    static char ReadOperation()
    {
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
        {
            throw new InvalidOperationException("only +, -, *, / operations are valid.");
        }
        return operation;
    }

    static double PerformOperation(double number1, double number2, char operation)
    {
        if (operation == '/' && number2 == 0)
        {
            throw new DivideByZeroException();
        }

        switch (operation)
        {
            case '+':
                return number1 + number2;
            case '-':
                return number1 - number2;
            case '*':
                return number1 * number2;
            case '/':
                return number1 / number2;
            default:
                throw new InvalidOperationCustomException("error", 400);
        }
    }
}