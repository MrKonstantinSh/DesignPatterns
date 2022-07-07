namespace Builder.FluentBuilderInheritanceWithRecursiveGenerics
{
    public class PersonPositionBuilder<SELF> : PersonNameBuilder<PersonPositionBuilder<SELF>> 
        where SELF : PersonPositionBuilder<SELF>
    {
        public SELF AddPosition(string position)
        {
            person.Position = position;

            return (SELF)this;
        }
    }
}
