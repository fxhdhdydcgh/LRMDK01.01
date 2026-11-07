using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    public class Milk : Product
    {
        public override int GetDiscount()
        {
            if (saled_ >= 5 && saled_ < 10)
                return 15;
            if (saled_ >= 10)
                return 25;

            return base.GetDiscount();
        }
    }
}
