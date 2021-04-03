// Class PriceComparer
using System.Collections.Generic;

namespace ConsoleApp1
{
 class PriceComparer : IComparer<Furniture>
    {
        public int Compare(Furniture x , Furniture y)
        {
            if (x.Price < y.Price)
            {
                return -1;
            }
            else if (x.Price > y.Price)
            {
                return 1;
            }
            else
                return 0;
        }
    }
}
