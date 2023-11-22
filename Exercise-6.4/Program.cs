namespace Exercise_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Order myOrder = new Order();
            myOrder.orderInfo();

        }
            struct Order
        {
            public string itemName;
            public int unitCount;
            public int unitCost;
            public int totalPrice() => unitCost * unitCount;
            public void orderInfo()
            {
                Console.WriteLine("Input item name:");
                itemName = Console.ReadLine();

                Console.WriteLine("Input unit cost:");
                unitCost = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input unit count");
                unitCount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Order information: {unitCount} {itemName} items at ${unitCost} each, " +
                    $"total cost ${totalPrice()}");
            }
        }
    }
}
