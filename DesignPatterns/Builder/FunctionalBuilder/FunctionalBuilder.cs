namespace Builder.FunctionalBuilder
{
    public abstract class FunctionalBuilder<TSubject, TSelf>
        where TSubject : new()
        where TSelf : FunctionalBuilder<TSubject, TSelf>
    {
        private readonly List<Func<TSubject, TSubject>> _actions = new();

        public TSubject Build() => _actions.Aggregate(new TSubject(), (p, f) => f(p));

        public TSelf Do(Action<TSubject> action) => AddAction(action);

        private TSelf AddAction(Action<TSubject> action)
        {
            _actions.Add(p =>
            {
                action(p);
                return p;
            });

            return (TSelf)this;
        }
    }
}
