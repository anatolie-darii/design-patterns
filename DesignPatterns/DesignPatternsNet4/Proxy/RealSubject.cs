namespace DesignPatternsNet4.Proxy
{
    internal class RealSubject : ISubject
    {
        public string DoAction(string message)
        {
            return "Message send by subject";
        }
    }
}