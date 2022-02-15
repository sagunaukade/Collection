using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the collection programs");
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
            Console.ReadKey();
        }

        public static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Saguna");
            dictionary.Add(101, "Amruta");
            dictionary.Add(102, "Vaishnavi");

            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);

            Console.WriteLine("\nIterating Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + " & Value =" + element.Value);
            }
        }
        public static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");

            var set = new HashSet<string>();
            set.Add("Saguna");
            set.Add("Amruta");
            set.Add("Saguna");
            set.Add("Vaishnavi");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");

            //Creating Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Saguna ukade");
            queue.Enqueue("Amruta Kulkrni");
            queue.Enqueue("Vaishnavi");
            queue.Enqueue("Raghav");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");

            // Iterating Queue elements  
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:" + dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element:");
            // Iterating Queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            //Creating Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Saguna");
            stack.Push("Archna");
            stack.Push("Pallavi");
            stack.Push("Jayshri");
            stack.Push("Rupali");
            string pop = stack.Pop();

            // Iterating stack elements  
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: " + pop);
        }
        public static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            //Creating List
            List<string> list = new List<string>();
            //Adding object to the list
            list.Add("Saguna");
            list.Add("Amruta");
            list.Add("Saguna");
            list.Add("Vaishnavi");

            // Iterating list elements  
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}



