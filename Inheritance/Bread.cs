using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    public class Bread : Product
    {
        public override int GetDiscount()
        {
            if(base.saled_ >= 20 && base.saled_ < 150)
                return 10;
            if (base.saled_ >= 150 && base.saled_ < 200)
                return 30;
            if (base.saled_ >= 300)
                return 50;
            return base.GetDiscount();
        }
    }
}
