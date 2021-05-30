namespace QueryViewer
{
    public class Configuration
    {
        public Query[] Queries { get; set; }
    }

    public class Query
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ConnectionString { get; set; }
    }
}
