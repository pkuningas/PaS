namespace Logic
{
    public class Price : Money //Price täiendab klassi Money
    {
        public Money Amount { get; set; }  //TODO: Vale, mõtle uuesti
        public Price() { }       
        public Price(Money amount)
        {
            this.Amount = amount;
        }
    }

    public class Money
    {
    }
}
