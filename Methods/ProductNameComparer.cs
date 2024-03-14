using Lab_10lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16.Methods
{
    public class ProductNameComparer : IEqualityComparer<Goods>
    {
        public bool Equals(Goods? x, Goods? y)
        {
            return x?.Name == y?.Name;
        }

        public int GetHashCode(Goods obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
