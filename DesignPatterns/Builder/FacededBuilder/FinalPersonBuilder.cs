namespace Builder.FacededBuilder
{
    public class FinalPersonBuilder
    {
        protected FinalPerson finalPerson = new();

        public FinalPersonAddressBuilder AddressBuilder => new(finalPerson);
        public FinalPersonWorkBuilder WorkBuilder => new(finalPerson);

        public static implicit operator FinalPerson (FinalPersonBuilder finalPersonBuilder)
        {
            return finalPersonBuilder.finalPerson;
        }
    }
}
