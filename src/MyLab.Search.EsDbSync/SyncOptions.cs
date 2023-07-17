namespace MyLab.Search.EsDbSync
{
    class SyncOptions
    {
        public IndexNamingOptions IndexNaming { get; set; } = new();
        public string SeedPath { get; set; } = "/var/lib/es-db-sync/seeds";
        public string ScriptPath { get; set; } = "/etc/es-db-sync/scripts";
        public int SyncPageSize { get; set; } = 500;
    }

    class IndexNamingOptions
    {
        public string Prefix { get; set; }
        public string Suffix { get; set; }
    }
}
