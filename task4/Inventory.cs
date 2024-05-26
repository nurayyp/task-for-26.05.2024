namespace task4
{
    internal class Inventory
    {
        public Dictionary<string, int> Products { get; set; }
        public Inventory() 
        {
            Products = new Dictionary<string, int>();
        }
        public void AddProduct(string productName, int quantity)
        {
            Products.Add(productName, quantity);
        }
        public void RemoveProduct(string productName)
        {
            Products.Remove(productName);
        }
        public void UpdateQuantity(string productName, int currentquantity)
        {
            Products[productName] = currentquantity;
        }
        public void GetQuantityByProduct(string productName)
        {
            foreach (var product in Products) 
            { 
                if (product.Key ==  productName)
                {
                    Console.WriteLine(product.Value);
                }
            }
        }
    }
}
