namespace Logic
{
    public class Attribute
    {
        public string Category { get; set; }
        public string ConfirmedBy { get; set; }
        public double Value { get; set; }
        public Attribute() { }

        public Attribute(string category, string confirmedBy, double value)
        {
            this.Category = category;
            this.ConfirmedBy = confirmedBy;
            this.Value = value;
        }


    }
}
