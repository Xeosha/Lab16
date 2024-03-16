using Lab_10lib;

namespace Lab16.Methods
{
    public class EqualityComparerByName : IEqualityComparer<Goods>
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
