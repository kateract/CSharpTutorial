using System;

namespace Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tree with ints:");
            Tree<int> tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(8);
            tree.Add(6);
            tree.Add(7);
            foreach (int item in tree.Traverse())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Tree with Strings:");
            Tree<string> tree2 = new Tree<string>();
            tree2.Add("hello");
            tree2.Add("string");
            tree2.Add("foo");
            tree2.Add("bar");
            tree2.Add("apart");
            tree2.Add("Champ");
            tree2.Add("tick");
            tree2.Add("Nand");
            tree2.Add("None");
            tree2.Add("camp");
            foreach (string item in tree2.Traverse())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Tree Depth: {0}", tree2.Depth);
            tree2.Remove("Nand");
            Console.WriteLine("After Removal: ");
            foreach (string item in tree2.Traverse())
            {
                Console.WriteLine(item);
            }
        }

    }


}
