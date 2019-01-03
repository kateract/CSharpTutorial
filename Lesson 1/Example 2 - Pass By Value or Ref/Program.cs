using System;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            string hello = "Hello";
            string foo = "foo";

            Console.WriteLine("Before the function, x is {0}, y is {1}, hello is '{2}', foo is '{3}'",x, y, hello, foo);

            PassMe(x, y, hello, foo);
            
            Console.WriteLine("After the function, x is {0}, y is {1}, hello is '{2}', foo is '{3}'",x, y, hello, foo);
            
        }

        static void PassMe(int a, int b, string text, string text2) {
            a = a + b;
            b = 4;
            text += " World!";
            text2 = "bar";
            Console.WriteLine("Inside the function, a is {0}, b is {1}, text is '{2}', text2 is '{3}'", a, b, text, text2);
            
        }
    }
}
