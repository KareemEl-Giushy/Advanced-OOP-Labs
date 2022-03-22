using System;

namespace OOP_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Prod;
            Prod = new Product();

            Product ProdOne = new Product("Samsung", true);

            Product ProdSecond = new Product("Iphone", false, 55f);

            Product Prodthird = new Product(); // Initial value name=Apple size=true price=31.5f

            Product ProdRef = Prodthird;

            ProdOne.name = "Fruit";
            ProdOne.price = 3.4f;
            ProdOne.size  = false;
            ProdOne.status = "frozen";

            Product ProdCopy = new Product(Prodthird);

            Console.WriteLine(Product.IsEqual(Prodthird, Prod)); // true all values equal
            Console.WriteLine(Product.IsEqual(Prodthird, ProdOne)); // fasle not all values equal
            Console.WriteLine(Product.IsEqual(Prodthird, ProdSecond)); // fasle not all values equal
            Console.WriteLine(Product.IsEqual(Prodthird, ProdCopy)); // true all values equal

            Product.Print_Product(Prodthird);
        }
    }
}
