class MenuItem : Product
{
    private double price;
    private string currency;

    public double Price { get; set; }
    public string Currency { get; set; }

    public MenuItem(string name, string type, string[] ingredients, double price, string currency) 
    {
        this.Name = name;
        this.Type = type;
        this.Ingredients = ingredients;
        this.price = price;
        this.currency = currency;
    }
}