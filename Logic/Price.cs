namespace Logic
{
    public class Price : Money
    {
        public Money Money { get; set; }
        public Price(Money money)
        {
            this.Money = money;
        }

    }

    public class Money
    {
    }
}
