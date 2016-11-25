namespace DesignPatterns.ChainOfResponsibility
{
    public class Level1Support : ISupportDesk
    {
        private readonly Level2Support nextLevel;

        public Level1Support(Level2Support nextLevel)
        {
            this.nextLevel = nextLevel;
        }
        public string HandleIncident(int dificulty)
        {
            if (dificulty <= 1)
            {
                return "Handled by level 1 support";
            }
            return this.nextLevel.HandleIncident(dificulty);
        }
    }
}