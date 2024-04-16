using EventBinaryTree;
using Lab_10lib;
using Lab16.Methods;

namespace Lab16
{
    public class MainModel
    {
        public BinaryTreeEvent<Goods> binaryTree;

        public MainModel()
        {
            binaryTree = new BinaryTreeEvent<Goods>();
        }

        public void Clear()
            => binaryTree.Clear();

        public void Add(IEnumerable<Goods> collection)
        {
            binaryTree.Add(collection);
        }

        public void CreateRandomTree(int size)
            => binaryTree.Add(CreateArrayProducts.GenerateRandomProductArray(size, new EqualityComparerByName()));

        public override string ToString()
            => binaryTree.ToString();

        public string GetTextFilterByProducts()
            => TextRequests.GetTextFilterByProducts(binaryTree);

        public string GetTextFilterByMilkProducts()
            => TextRequests.GetTextFilterByMilkProducts(binaryTree);

        public string GetTextFilterByToys()
            => TextRequests.GetTextFilterByToys(binaryTree);

        public string GetTextSortTree()
            => TextRequests.GetTextSortTree(binaryTree);

        public void Add(string name, double price, double weight)
        {
            var product = new Goods(name, price, weight);

            binaryTree.Add(product);
        }

        public void Modify(string name, double price, double weight)
        {
            var product = new Goods(name, price, weight);

            binaryTree[product.Name] = new Goods("не изменится, это ключ", price, weight);
        }

        public bool Delete(string name)
        {
            var product = new Goods(name, 1, 1);

            if (binaryTree.Remove(product))
                return true;

            return false;
        }

    }
}
