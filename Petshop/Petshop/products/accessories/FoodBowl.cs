using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.products.accessories
{
    class FoodBowl : Accessory
    {
        public override void Clean()
        {
            Console.WriteLine("You cleaned the bowl");
        }

        public override void Fix()
        {
            Console.WriteLine("You fixed the bowl");
        }

        public override void Use()
        {
            Console.WriteLine("Food bowl is in use");
        }
    }
}
