namespace Builder.FluentBuilderInheritanceWithRecursiveGenerics
{
    public class Person
    {
        public static Builder Builder => new();

        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}";
        }
    }
}
