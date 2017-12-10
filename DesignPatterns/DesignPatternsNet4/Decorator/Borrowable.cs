using System;
using System.Collections.Generic;

namespace DesignPatternsNet4.Decorator {
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        // Constructor
        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            this.borrowers.Add(name);
            this.libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            this.borrowers.Remove(name);
            this.libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in this.borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}