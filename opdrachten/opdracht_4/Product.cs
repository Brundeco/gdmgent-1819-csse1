class Product {

    private string name;
    private string type;
    private string[] ingredients;

    public string Name {get; set;}
    public string Type {get; set;}
    public string[] Ingredients {get; set;}

    public Product(string name, string type, string[] ingredients)
    {
        this.name = name;
        this.type = type;
        this.ingredients = ingredients;
    }

}