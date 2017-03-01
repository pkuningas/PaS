namespace Logic
{
    public class Price : Money //Price täiendab klassi Money
    {
        public Money Money { get; set; }  //TODO: Vale, mõtle uuesti
        public Price(Money money)
        {
            this.Money = money;
        }

    }

    public class Money
    {
    }
}
