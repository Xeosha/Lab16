using Lab_10lib;

namespace Lab16.Methods
{
    public class CreateArrayProducts
    {
        static readonly Random rnd = new();

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

        public static Goods[] CreateRandomProductArray(IEqualityComparer<Goods> comparer)
        {
            int size = EnterPositiveIntegerMenu("Введите количество товаров: ");
            return GenerateRandomProductArray(size, comparer);
        }

        public static Goods[] GenerateRandomProductArray(int size, IEqualityComparer<Goods> comparer)
        {
            Goods[] products = new Goods[size];
            var count = 0;
            var count2 = 0;

            while (count != size)
            {
                if (count2++ > 1000)
                    throw new ArgumentException();
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
    }
}
