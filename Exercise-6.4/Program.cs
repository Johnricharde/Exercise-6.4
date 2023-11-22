namespace Exercise_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order();
            Console.WriteLine("Input unit cost:");
            myOrder.unitCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input unit count");
            myOrder.unitCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total cost is: {myOrder.totalPrice()}");
        }
            struct Order
        {
            public string itemName;
            public int unitCount;
            public int unitCost;
            public int totalPrice() => unitCost * unitCount;
        }
    }
}
