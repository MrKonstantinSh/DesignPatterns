namespace Builder.FacededBuilder
{
    public class FinalPerson
    {
        // Address
        public string City { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }

        // Work
        public string Company { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"City: {City}, Street: {Street}, Postcode: {Postcode}," +
                $" Compamy: {Company}, Position: {Position}";
        }
    }
}
