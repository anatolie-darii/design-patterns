namespace DesignPatternsNet4.Decorator {
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class LibraryItem
    {
        private int _numCopies;

        // Property
        public int NumCopies
        {
            get { return this._numCopies; }
            set { this._numCopies = value; }
        }

        public abstract void Display();
    }
}