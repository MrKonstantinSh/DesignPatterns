namespace Builder.FunctionalBuilder
{
    public sealed class FunctionalPersonBuilder : FunctionalBuilder<AnotherPerson, FunctionalPersonBuilder>
    {
        public FunctionalPersonBuilder AddName(string name) => Do(p => p.Name = name);
    }
}
