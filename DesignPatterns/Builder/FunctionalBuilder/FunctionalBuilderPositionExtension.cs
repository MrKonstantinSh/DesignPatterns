namespace Builder.FunctionalBuilder
{
    public static class FunctionalBuilderPositionExtension
    {
        public static FunctionalPersonBuilder AddPosition(this FunctionalPersonBuilder builder, string position) =>
            builder.Do(p => p.Position = position);
    }
}
