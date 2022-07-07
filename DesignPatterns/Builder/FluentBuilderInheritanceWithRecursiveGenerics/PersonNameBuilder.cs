namespace Builder.FluentBuilderInheritanceWithRecursiveGenerics
{
    public class PersonNameBuilder<SELF> : PersonBuilder 
        where SELF : PersonNameBuilder<SELF>
    {
        public SELF AddName(string name)
        {
            person.Name = name;

            return (SELF)this;
        }
    }
}
