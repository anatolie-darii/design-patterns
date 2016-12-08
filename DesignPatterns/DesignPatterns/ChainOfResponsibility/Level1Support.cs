namespace DesignPatterns.ChainOfResponsibility
{
    public class Level1Support : ISupportDesk
    {
        private readonly Level2Support nextLevel = new Level2Support();

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