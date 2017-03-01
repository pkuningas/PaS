namespace Logic
{
    public class Attribute
    {
        private string Category { get; set; }
        private string ConfirmedBy { get; set; }
        private string Value { get; set; }
        public Attribute() { }

        public Attribute(string category, string confirmedBy, string value)
        {
            this.Category = category;
            this.ConfirmedBy = confirmedBy;
            this.Value = value;
        }


    }
}
