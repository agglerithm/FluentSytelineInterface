namespace SytelineInterface
{
    public class SLConfiguration
    {
        public SLConfiguration(string config, string database)
        {
            Config = config;
            Database = database;
        }

        public string Database { get; private set; }
        public string Config { get; private set; }
    }
}
