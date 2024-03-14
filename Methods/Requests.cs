using BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBinaryTree;
using Lab_10lib;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lab16.Methods
{
    public class Requests
    {
        static readonly Random rnd = new();

        public static Goods[] GenerateRandomProductArray(int size, IEqualityComparer<Goods> comparer)
        {
            Goods[] products = new Goods[size];
            var count = 0;

            while(count != size)
            {
                int item = rnd.Next(1, 5);
                var product = CreateProduct(item);
                if (products.Contains(product, comparer))
                    continue;

                products[count++] = product;
            }
            return products;
        }

        public static Goods CreateProduct(int itemType)
        {
            return itemType switch
            {
                1 => new Goods(),
                2 => new Toy(),
                3 => new Product(),
                4 => new MilkProduct(),
                _ => throw new ArgumentException("Неизвестный тип!"),
            };
        }

        public static Goods[] CreateRandomProductArray(IEqualityComparer<Goods> comparer)
        {
            int size = EnterPositiveIntegerMenu("Введите количество товаров: ");
            return GenerateRandomProductArray(size, comparer);
        }

        static int EnterPositiveIntegerMenu(string InputMessage)
        {
            var flag = true;
            int count = 0;

            while (flag)
            {
                var result = Microsoft.VisualBasic.Interaction.InputBox(InputMessage);

                flag = !(Int32.TryParse(result, out count) && count > 0);

                if (flag)
                {
                    MessageBox.Show("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО!");
                }
            }
            return count;
        }

        private static string GetTextIEnumerable(IEnumerable<Goods> lst, string row = "", string Empty = "Пусто")
        {
            var result = row;
            foreach (var item in lst)
                result += item.ToString() + "\n";
            return result == row ? Empty : result;
        }
        public static string GetTextSortTree(BinaryTreeEvent<Goods> tree)
        {
            var result = GetTextIEnumerable(tree, "\tОтсортированное дерево:\n", "Дерево пустое");
            return result;
        }

        public static string GetTextFilterByProducts(BinaryTreeEvent<Goods> tree)
        {
            var lst = tree.FilterProducts();

            var result = GetTextIEnumerable(lst, "\tПродукты:\n", "Продуктов нет.");

            return result;

        }
        public static string GetTextFilterByToys(BinaryTreeEvent<Goods> tree)
        {
            var lst = tree.FilterToys();

            var result = GetTextIEnumerable(lst, "\tИгрушки:\n", "Игрушек нет.");

            return result;
        }
        public static string GetTextFilterByMilkProducts(BinaryTreeEvent<Goods> tree)
        {
            var lst = tree.FilterMilkProducts();

            var result = GetTextIEnumerable(lst, "\tМолочные продукты:\n", "Молочных продуктов нет.");

            return result;
        }
    }
}
