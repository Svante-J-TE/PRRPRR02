using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_labb
{
    class Products
    {
        private string _productCategory;
        private string _productName;
        private string _productColor;
        private int _productStock;
        private int _productPrice;

        public string _ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public string _ProductColor
        {
            get { return _productColor; }
            set { _productColor = value; }
        }

        public int _ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public Products(string category, string name, string color, int stock, int productPrice)
        {
            this._productCategory = category;
            this._productName = name;
            this._productColor = color;
            this._productStock = stock;
            this._productPrice = productPrice;
        }


        


    }
}
