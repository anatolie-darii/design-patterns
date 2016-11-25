namespace DesignPatterns.ChainOfResponsibility
{
    public class Level2Support : ISupportDesk
    {
        private readonly Level3Support nextLevel;

        public Level2Support(Level3Support nextLevel)
        {
            this.nextLevel = nextLevel;
        }
        public string HandleIncident(int dificulty)
        {
            if (dificulty <= 2)
            {
                return "Handled by level 2 support";
            }
            return this.nextLevel.HandleIncident(dificulty);
        }
    }
}