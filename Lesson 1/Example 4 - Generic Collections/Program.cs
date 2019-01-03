using System;
using System.Collections.Generic;

namespace Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOREACH LOOP
            var intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            
            int sum = 0;

            foreach (var item in intList) {
                sum += item;
            }
            
            Console.WriteLine("The sum is {0}", sum);


            // STRING JOIN
            string[] stringArray = {"Hello", "World", "!"};

            var stringList = new List<string>(stringArray);

            var together = String.Join(' ', stringList.ToArray());
            Console.WriteLine(together);
            Console.WriteLine(stringList[1]);
            Console.WriteLine(stringList.Count);

            // DICTIONARY TYPE
            var processDefs = new Dictionary<int, string>();
            processDefs.Add(1, "Invoice");
            processDefs.Add(2, "BOL");

            Console.WriteLine("Process def 1 is {0}", processDefs[1]);
            Console.WriteLine("Process def 2 is {0}", processDefs[2]);

            // DICTIONARY OF LISTS
            var complexType = new Dictionary<string, List<string>>();
            complexType.Add("Brian", new List<string>());
            complexType["Brian"].Add("Chocolate");
            complexType["Brian"].Add("Mint Chip");
            complexType["Brian"].Add("Pistachio Almond");

            complexType["Mary"] = new List<string>();
            complexType["Mary"].Add("Peppermint");
            complexType["Mary"].Add("Peaches and Homemade Vanilla");
            complexType["Mary"].Add("Moolineum Crunch");

            foreach (var item in complexType) {
                Console.WriteLine("{0} likes {1}", item.Key, String.Join(", ", item.Value));
            }

            // STACK
            var intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            Console.WriteLine("Peek: {0}", intStack.Peek());
            Console.WriteLine("Pop: {0}", intStack.Pop());
            Console.WriteLine("Peek: {0}", intStack.Peek());
            Console.WriteLine("Pop: {0}", intStack.Pop());
            Console.WriteLine("Peek: {0}", intStack.Peek());
        }
    }
}
