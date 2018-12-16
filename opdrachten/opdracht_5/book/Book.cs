using System;

namespace book {

  public class Book {

    private string name;
    private Author author;
    private double price;
    private int qtyInStock = 0;
    
    public Book(string name, Author author, double price, int qtyInStock) {
      this.name = name;
      this.author = author;
      this.price = price;
      this.qtyInStock = qtyInStock;
    }
    
    // Getters
    public string getName() 
    {
      return this.name;
    }

    public Author getAuthor() 
    {
      return this.author;
    }

    public double getPrice() 
    {
      return this.price;
    }

    public int getQtyInStock()
    {
      return this.qtyInStock;
    }

    public string getAuthorName()
    {
      return this.author.Name;
    }

    // Setters
    public void setPrice(double price) 
    {
      this.price = price;
    }

    public void setQtyInStock(int qtyInStock)
    {
      this.qtyInStock = qtyInStock;
    }

    // Print
    public void print() {
      Console.WriteLine("Buy " + this.name +  "from " + this.author.Name + " now for " + this.price + " EUR.");
      Console.WriteLine("Still " + this.qtyInStock + " books available");
    }
  }
}