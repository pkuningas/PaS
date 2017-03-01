using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PossiblePrice : Price
    {
        //lisasin, et ei oleks erroreid ja saaksin teste kontrollida!!!
        public PossiblePrice(Money money) : base(money)
        {
        }
    }
}
