namespace Builder.FunctionalBuilder
{
    public class AnotherPerson
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}";
        }
    }
}
