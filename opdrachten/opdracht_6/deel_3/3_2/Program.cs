using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var productCreator1 = new ProductCreator(new CoffeeBuilder());
            productCreator1.CreateProduct();
            var product1 = productCreator1.GetProduct();
            product1.ShowInfo();
            
            var productCreator2 = new ProductCreator(new MachiattoBuilder());
            productCreator2.CreateProduct();
            var product2 = productCreator2.GetProduct();
            product2.ShowInfo();

            Console.ReadKey();
        }
    }
    public interface IProductBuilder
    {
        void PrepareType();
        void PrepareStep1();
        void PrepareStep2();
        void PrepareStep3();
        void PrepareStep4();
        Product GetProduct();
    }
    public class CoffeeBuilder : IProductBuilder
    {
        Product objProduct = new Product();
        public void PrepareType()
        {
            objProduct.type = "Irish coffee";
        }
        public void PrepareStep1()
        {
            objProduct.step1 = "Heat water";
        }
        public void PrepareStep2()
        {
            objProduct.step2 = "Grind coffee beans";
        }
        public void PrepareStep3()
        {
            objProduct.step3 = "Add Whiskey";
        }
        public void PrepareStep4()
        {
            objProduct.step4 = "Enjoy your coffee!";
        }
        public Product GetProduct()
        {
            return objProduct;
        }
    }
    public class MachiattoBuilder : IProductBuilder
    {
        Product objProduct = new Product();
        public void PrepareType()
        {
            objProduct.type = "Italian coffee";
        }
        public void PrepareStep1()
        {
            objProduct.step1 = "Heat water";
        }
        public void PrepareStep2()
        {
            objProduct.step2 = "Grind coffee beans";
        }
        public void PrepareStep3()
        {
            objProduct.step3 = "Add Amaretto";
        }
        public void PrepareStep4()
        {
            objProduct.step4 = "Enjoy your coffee!";
        }
        public Product GetProduct()
        {
            return objProduct;
        }
    }
        public class Product
        {
            public string type { get; set; }
            public string step1 { get; set; }
            public string step2 { get; set; }
            public string step3 { get; set; }
            public string step4 { get; set; }
            public Product()
            {
             
            }
            public void ShowInfo(){
                Console.WriteLine("Flavor: {0}", type);
                Console.WriteLine("First: {0}", step1);
                Console.WriteLine("Second: {0}", step2);
                Console.WriteLine("Third: {0}", step3);
                Console.WriteLine("Last: {0}", step4);
            }
        }
            public class ProductCreator{
            private readonly IProductBuilder objBuilder;
            
            public ProductCreator(IProductBuilder builder){
                objBuilder = builder;
            }
            
            public void CreateProduct(){
                objBuilder.PrepareType();
                objBuilder.PrepareStep1();
                objBuilder.PrepareStep2();
                objBuilder.PrepareStep3();
                objBuilder.PrepareStep4();
            }
            
            public Product GetProduct(){
                return objBuilder.GetProduct();
            }
        }
    }