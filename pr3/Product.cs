using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    public class Product
    {
        protected string name_;
        protected float price_;
        protected int saled_;
        public virtual int GetDiscount()
        {
            return 0;
        }
        public string GetName() => name_;
        public void SetName(string name) => name_ = name;
        public float GetPrice() => price_ - price_* GetDiscount();
        public void SetPrice(float price) => price_ = price;
        public int GetSaled() => saled_;
        public void SetSaled(int saled) => saled_ = saled;
    }
}
