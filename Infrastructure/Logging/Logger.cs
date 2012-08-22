namespace CompatibleSoftware.Infrastructure.Logging
{
    public class Logger
    {
        private static readonly ILogger _instance = new Log4Net();

        public static ILogger Instance
        {
            get { return _instance; }
        }
    }
}
