namespace Builder.FacededBuilder
{
    public class FinalPersonWorkBuilder : FinalPersonBuilder
    {
        public FinalPersonWorkBuilder(FinalPerson finalPerson)
        {
            this.finalPerson = finalPerson;
        }

        public FinalPersonWorkBuilder At(string company)
        {
            finalPerson.Company = company;

            return this;
        }

        public FinalPersonWorkBuilder AsA(string position)
        {
            finalPerson.Position = position;

            return this;
        }
    }
}
