using task4;

public static class Program
{
    public static void Main()
    {
        Inventory inventory = new Inventory();
        inventory.AddProduct("kitab", 2);
        inventory.AddProduct("defter", 3);
        inventory.AddProduct("qelem", 5);
        inventory.RemoveProduct("defter");
        inventory.GetQuantityByProduct("kitab");
        inventory.UpdateQuantity("qelem", 7);
        inventory.GetQuantityByProduct("qelem");
    }
}