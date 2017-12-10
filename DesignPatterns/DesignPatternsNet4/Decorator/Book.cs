using System;

namespace DesignPatternsNet4.Decorator {
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class Book : LibraryItem
    {
        private string _author;
        private string _title;

        // Constructor
        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", this._author);
            Console.WriteLine(" Title: {0}", this._title);
            Console.WriteLine(" # Copies: {0}", this.NumCopies);
        }
    }
}