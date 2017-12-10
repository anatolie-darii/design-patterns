namespace DesignPatternsNet4.Composite {
    /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    public abstract class DrawingElement
    {
        protected readonly string Name;

        // Constructor
        public DrawingElement(string name)
        {
            this.Name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}