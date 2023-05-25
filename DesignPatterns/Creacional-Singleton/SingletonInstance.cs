namespace DesignPatterns.Singleton
{
    public sealed class SingletonInstance
    {
        private SingletonInstance()
        { }

        private static SingletonInstance _instance;

        public static SingletonInstance GetInstance()
        {
            if(_instance == null)
                _instance = new SingletonInstance();

            return _instance;
        }
    }
}
