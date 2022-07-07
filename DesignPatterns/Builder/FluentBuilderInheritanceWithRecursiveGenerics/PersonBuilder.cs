﻿namespace Builder.FluentBuilderInheritanceWithRecursiveGenerics
{
    public abstract class PersonBuilder
    {
        protected Person person = new();

        public Person Build()
        {
            return person;
        }
    }
}
