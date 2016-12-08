namespace DesignPatternsNet4.ChainOfResponsibility
{
    internal class Level3Support : ISupportDesk
    {
        public string HandleIncident(int dificulty)
        {
            return "Handled by level 3 support";
        }
    }
}