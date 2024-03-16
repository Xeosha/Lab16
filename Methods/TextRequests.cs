using EventBinaryTree;
using Lab_10lib;

namespace Lab16.Methods
{
    public class TextRequests
    {
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
