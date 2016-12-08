namespace DesignPatternsNet4.Proxy
{
    public class Proxy : ISubject
    {
        private readonly RealSubject realSubject = new RealSubject();

        public string DoAction(string message)
        {
            return this.realSubject.DoAction(message);
        }
    }
}