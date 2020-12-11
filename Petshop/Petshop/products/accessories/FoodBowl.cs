using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.products.accessories
{
    class FoodBowl : Accessory
    {
        public override void use()
        {
            Console.WriteLine("Food bowl is in use");
        }
    }
}
