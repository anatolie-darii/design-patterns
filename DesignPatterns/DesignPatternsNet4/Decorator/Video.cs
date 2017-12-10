using System;

namespace DesignPatternsNet4.Decorator {
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;

        // Constructor
        public Video(string director, string title,
                     int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", this._director);
            Console.WriteLine(" Title: {0}", this._title);
            Console.WriteLine(" # Copies: {0}", this.NumCopies);
            Console.WriteLine(" Playtime: {0}\n", this._playTime);
        }
    }
}