namespace DesignPatternsNet4.Singleton
{
    public class Singleton
    {
        private static readonly object lockObj = new object();
        private static Singleton instance;

        private Singleton() {}

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}