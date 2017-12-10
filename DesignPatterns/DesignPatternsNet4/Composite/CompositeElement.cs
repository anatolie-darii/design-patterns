using System;
using System.Collections.Generic;

namespace DesignPatternsNet4.Composite {
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class CompositeElement : DrawingElement
    {
        private readonly List<DrawingElement> childElements = new List<DrawingElement>();

        // Constructor
        public CompositeElement(string name)
            : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            this.childElements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            this.childElements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + "+ " + this.Name);

            // Display each child element on this node
            foreach (var element in this.childElements)
            {
                element.Display(indent + 2);
            }
        }
    }
}