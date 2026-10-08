namespace EasyComponentsSample.Models
{
    public class TestModel0
    {
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Info { get; set; } = string.Empty;
        public bool Checked { get; set; }
    }

    public class TestModel1
    {
        public string Name_1 { get; set; } = string.Empty;
        public string Value_1 { get; set; } = string.Empty;
        public string Info_1 { get; set; } = string.Empty;
        public bool Checked_1 { get; set; }
    }
    public class TestModel2
    {
        public string Name_2 { get; set; } = string.Empty;
        public string Value_2 { get; set; } = string.Empty;
        public string Info_2 { get; set; } = string.Empty;
        public bool Checked_2 { get; set; }
    }


    public class TestModel
    {
        public List<TestModel0> List0 { get; set; } = new();
        public List<TestModel1> List1 { get; set; } = new();
        public List<TestModel2> List2 { get; set; } = new();
    }
}
