namespace DesignPatterns.ChainOfResponsibility
{
    public class Level2Support : ISupportDesk
    {
        private readonly Level3Support nextLevel = new Level3Support();

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