using System;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            fizzBuzz(30);
            fibbonachiLoop(100);
            watchface(Clocktype.DIGITAL);
            watchface(Clocktype.ANALOG);
        }

        public static void fizzBuzz(int max)
        {
            int a = 3;
            int b = 5;

            for (int i = 1; i <= max; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % a == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % b == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void fibbonachiLoop (int max) {
            int a = 0;
            int b = 1;
            int f = 0;
            do {
                Console.WriteLine(f);
                f = a + b;
                a = b;
                b = f;
                
            } while (f < max);

        }

        private enum Clocktype{
            ANALOG,
            DIGITAL
        }

        private static void watchface (Clocktype face){
            switch (face)
            {
                case Clocktype.ANALOG:
                    Console.WriteLine("I don't have hands!");
                    break;
                case Clocktype.DIGITAL: 
                    Console.WriteLine(DateTime.Now.ToShortTimeString());
                    break;
                default:
                    Console.WriteLine("You'll never see me but here!");
                    break;
            }
        }

    }
}
