using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        ArrayList arrayList = new ArrayList();
        arrayList.Add("First");
        arrayList.Add("Second");
        arrayList.Insert(1, "Inserted");
        arrayList.Remove("Second");
        Console.WriteLine("\nArrayList elements:");
        foreach (var item in arrayList)
            Console.WriteLine(item);

        
        List<int> list = new List<int> { 1, 2, 3 };
        list.AddRange(new int[] { 4, 5 });
        list.Sort();
        Console.WriteLine("\nList elements:");
        foreach (var item in list)
            Console.WriteLine(item);

        
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "One", 1 },
            { "Two", 2 },
            { "Three", 3 }
        };
        dictionary.Remove("Two");
        Console.WriteLine("\nDictionary elements:");
        foreach (var key in dictionary.Keys)
            Console.WriteLine($"{key}: {dictionary[key]}");

        
        SortedList<int, string> sortedList = new SortedList<int, string>
        {
            { 3, "Third" },
            { 1, "First" },
            { 2, "Second" }
        };
        sortedList.RemoveAt(1);
        Console.WriteLine("\nSortedList elements:");
        foreach (var key in sortedList.Keys)
            Console.WriteLine($"{key}: {sortedList[key]}");

        
        Stack<string> stack = new Stack<string>();
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");
        Console.WriteLine($"\nStack Peek: {stack.Peek()}");
        stack.Pop();
        Console.WriteLine("Stack elements:");
        foreach (var item in stack)
            Console.WriteLine(item);

       
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Console.WriteLine($"\nQueue Peek: {queue.Peek()}");
        queue.Dequeue();
        Console.WriteLine("Queue elements:");
        foreach (var item in queue)
            Console.WriteLine(item);

        
        SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>
        {
            { "Zebra", 10 },
            { "Apple", 20 },
            { "Lemon", 30 }
        };
        sortedDictionary.Remove("Apple");
        Console.WriteLine("\nSortedDictionary elements:");
        foreach (var key in sortedDictionary.Keys)
            Console.WriteLine($"{key}: {sortedDictionary[key]}");

        
        HashSet<int> hashSet = new HashSet<int> { 1, 2, 3 };
        hashSet.Add(2); 
        hashSet.Add(4);
        hashSet.UnionWith(new int[] { 5, 6 });
        Console.WriteLine("\nHashSet elements:");
        foreach (var item in hashSet)
            Console.WriteLine(item);
    }
}