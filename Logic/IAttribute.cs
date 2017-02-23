using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class IAttribute
    {
        private string category { get; set; }
        private string confirmedBy { get; set; }
        private string value { get; set; }
        public IAttribute() { }

        public IAttribute(string category, string confirmedBy, string value)
        {
            this.category = category;
            this.confirmedBy = confirmedBy;
            this.value = value;
        }


    }
}
