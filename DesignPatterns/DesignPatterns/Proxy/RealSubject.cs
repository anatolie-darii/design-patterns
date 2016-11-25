namespace DesignPatterns.Proxy
{
    public class RealSubject : ISubject
    {
        public string DoAction(string message)
        {
            return "Message send by subject";
        }
    }
}