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
        private string _productID;

        public Products(string category, string name, string color, int stock, string productID)
        {
            this._productCategory = category;
            this._productName = name;
            this._productColor = color;
            this._productStock = stock;
            this._productID = productID;
        }


        


    }
}
