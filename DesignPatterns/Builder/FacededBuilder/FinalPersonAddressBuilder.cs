namespace Builder.FacededBuilder
{
    public class FinalPersonAddressBuilder : FinalPersonBuilder
    {
        public FinalPersonAddressBuilder(FinalPerson finalPerson)
        {
            this.finalPerson = finalPerson;
        }

        public FinalPersonAddressBuilder In(string city)
        {
            finalPerson.City = city;

            return this;
        }

        public FinalPersonAddressBuilder At(string street)
        {
            finalPerson.Street = street;

            return this;
        }

        public FinalPersonAddressBuilder WithPostcode(string postcode)
        {
            finalPerson.Postcode = postcode;

            return this;
        }
    }
}
