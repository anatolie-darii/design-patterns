using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignPatternsNet4.ChainOfResponsibility;
using DesignPatternsNet4.Proxy;
using DesignPatternsNet4.Singleton;

namespace DesignPatternsClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there design patterns!");
            Console.Write("Testing singleton...");
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;
            var singletonMessage = instance1 == instance2 ? "equal" : "not equal";
            Console.WriteLine($"Singleton instances are {singletonMessage}");

            Console.WriteLine("Testing proxy");
            var proxyResult = new Proxy().DoAction("Test action");
            Console.WriteLine($"Message from proxy - {proxyResult}");

            Console.WriteLine("Testing chain of responsibility");
            var handleIncidentResult = new Level1Support().HandleIncident(2);
            Console.WriteLine($"Request - {handleIncidentResult}");
            Console.ReadLine();
        }
    }
}
