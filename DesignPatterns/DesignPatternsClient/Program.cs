using System;

using DesignPatternsNet4.ChainOfResponsibility;
using DesignPatternsNet4.Composite;
using DesignPatternsNet4.Decorator;
using DesignPatternsNet4.Factory;
using DesignPatternsNet4.Proxy;
using DesignPatternsNet4.Singleton;

namespace DesignPatternsClient
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello there design patterns!");

            //TestSingleton();
            //TestProxy();
            //TestChainOfResponsibility();

            TestComposite();
            TestDecorator();
            TestFactory();

            Console.ReadLine();
        }

        private static void TestComposite()
        {
            // Create a tree structure 
            var root =
                new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            var comp =
                new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            var pe =
                new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);
        }

        private static void TestDecorator()
        {
            // Create book
            var book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            var video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            var borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();
        }

        private static void TestFactory()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }

        private static void TestSingleton()
        {
            Console.Write("Testing singleton...");
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;
            var singletonMessage = instance1 == instance2 ? "equal" : "not equal";
            Console.WriteLine($"Singleton instances are {singletonMessage}");
        }

        private static void TestProxy()
        {
            Console.WriteLine("Testing proxy");
            var proxyResult = new Proxy().DoAction("Test action");
            Console.WriteLine($"Message from proxy - {proxyResult}");
        }

        private static void TestChainOfResponsibility()
        {
            Console.WriteLine("Testing chain of responsibility");
            var handleIncidentResult = new Level1Support().HandleIncident(2);
            Console.WriteLine($"Request - {handleIncidentResult}");
        }
    }
}