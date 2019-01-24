using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LambdaFunctionTest(Operations.MODULUS, 6, 8));
        }

        // Full list of operators:
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/

        static double Add (double a, double b)
        {
            return a + b;
        }

        static double Subtract (double a, double b)
        {
            return a - b;
        }

        static double Multiply (double a, double b)
        {
            return a * b;
        }

        static double Divide (double a, double b)
        {
            return a / b;
        }

        static int Modulus (int a, int b)
        {
            return a % b;
        }

        static object NullCoalescing (object a, object b)
        {
            return a ?? b ;
        }

        static int Conditional (bool test, int valueIfTrue, int valueIfFalse) 
        {
            return test ? valueIfTrue : valueIfFalse; 
        }

        enum Operations
        {
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE,
            MODULUS
        }
        
        delegate int IntegerCalculationFunction( int a, int b);
        static IntegerCalculationFunction LambdaFunction (Operations functionNumber) 
        {
            switch (functionNumber)
            {
                case Operations.ADD:
                    return (int a, int b) => { return a + b; };
                case Operations.SUBTRACT:
                    return (int a, int b) => { return a - b; };
                case Operations.MULTIPLY:
                    return (int a, int b) => { return a * b; };
                case Operations.DIVIDE:
                    return (int a, int b) => { return a / b; };
                case Operations.MODULUS:
                    return Modulus;
                default:
                    throw new InvalidOperationException("An invalid operation was specified or the specified operation is not yet implemented.");
            }
        }

        static int LambdaFunctionTest (Operations operation, int a, int b)
        {
            return LambdaFunction(operation)(a, b);
        }
    }
}
