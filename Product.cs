using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Modules
{
    internal class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private int _discountPercentage;

        //Seters
        public void SetId(int id)
        {
            _id = id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetPrice(int price)
        {
            _price = price;
        }
        public void SetDiscount(int discountPercentage)
        {
            _discountPercentage = discountPercentage;
        }

        //Geters
        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetPrice()
        {
            return _price;
        }
        public int GetDiscout()
        {
            return _discountPercentage;
        }
        //To calculate Final price after discount
        public float FinalPriceAfterDiscount()
        {
            return _price - _discountPercentage / 100F * _price;
        }


    }
}
