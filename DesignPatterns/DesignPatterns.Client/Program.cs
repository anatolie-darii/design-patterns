using DesignPatterns.Singleton;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Design patterns are cool!");
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;

    }
}