namespace DesignPatternsNet4.Factory {
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            this._carnivore = factory.CreateCarnivore();
            this._herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            this._carnivore.Eat(this._herbivore);
        }
    }
}