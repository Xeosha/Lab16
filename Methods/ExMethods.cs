using EventBinaryTree;
using Lab_10lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab16.Methods
{
    public static class ExMethods
    {
        public static IEnumerable<Product> FilterProducts(this BinaryTreeEvent<Goods> tree)
        {
            return tree.Where(item => item is Product).Cast<Product>();
        }

        public static IEnumerable<Toy> FilterToys(this BinaryTreeEvent<Goods> tree)
        {
            return tree.Where(item => item is Toy).Cast<Toy>();
        }

        public static IEnumerable<MilkProduct> FilterMilkProducts(this BinaryTreeEvent<Goods> tree)
        {
            return tree.Where(item => item is MilkProduct).Cast<MilkProduct>();
        }

    }
}
