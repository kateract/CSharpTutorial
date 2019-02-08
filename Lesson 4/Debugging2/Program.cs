using System;

namespace Debugging2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your Name: ");
            var name = Console.ReadLine();
            Console.Write("Input your Birth Year: ");
            var year = Console.ReadLine();
            Console.Write("Input your Birth Month: ");
            var month = Console.ReadLine();
            var age = CheckAge(year, month);
            if (age < 0)
            {
                Console.Write("Input your Birth Day");
                var day = Console.ReadLine();
                age = CheckAge(year, month, day);
            }

            Console.WriteLine($"Hello {name}, you are {age} years old!");
            Console.ReadLine();
        }

        public static int CheckAge(string year, string month, string day = "")
        {
            int age = 0;
            if (int.TryParse(year, out int y))
            {
                age = DateTime.Now.Year - y;
            } 
            else
            {
                return -1;
            }
            if (!int.TryParse(month, out int m))
            {
                switch (month.ToUpper())
                {
                    case "JAN":
                    case "JANUARY":
                        m = 1;
                        break;
                    case "FEB":
                    case "FEBUARY":
                        m = 2;
                        break;
                    case "MAR":
                    case "MARCH":
                        m = 3;
                        break;
                    case "APR":
                    case "APRIL":
                        m = 4;
                        break;
                    case "MAY":
                        m = 5;
                        break;
                    case "JUN":
                    case "JUNE":
                        m = 6;
                        break;
                    case "JUL":
                    case "JULY":
                        m = 7;
                        break;
                    case "AUG":
                    case "AUGUST":
                        m = 8;
                        break;
                    case "SEP":
                    case "SEPT":
                    case "SEPTEMBER":
                        m = 9;
                        break;
                    case "OCT":
                    case "OCTOBER":
                        m = 10;
                        break;
                    case "NOV":
                    case "NOVEMBER":
                        m = 11;
                        break;
                    case "DEC":
                    case "DECEMBER":
                        m = 12;
                        break;
                    default:
                        return -1;
                }
            }
            if (DateTime.Now.Month == m)
            {
                if (int.TryParse(day, out int d))
                {
                    return DateTime.Now.Day < d ? --age : age;
                }
                else
                {
                    return -1;
                }
            
                
            }
            else
            {
                return DateTime.Now.Month > m ? --age : age;
            }
        }
    }
}
