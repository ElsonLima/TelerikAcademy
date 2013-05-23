﻿using System;
using Wintellect.PowerCollections;

class Program
{
    static void Main()
    {
        OrderedBag<int> numbers = new OrderedBag<int>();

        for (string line = null; (line = Console.ReadLine()) != string.Empty; )
            numbers.Add(int.Parse(line));

        Console.WriteLine(string.Join(" ", numbers));
    }
}
