using System;

namespace OOP_Project {
    internal class Product {
        public string name;
        public float price;
        public string status;
        public bool size;
        public int productID;
        public Product(): this ("Apple", true, 31.5f, "fresh") {}
        public Product (Product c) {
            this.name = c.name;
            this.price = c.price;
            this.status = c.status;
            this.size = c.size;
            this.productID = c.productID;
        }
        public Product (string name, bool size) {
            this.name = name;
            this.size = size;
            this.productID = getID();

        }
        public Product (string name, bool size, float price) {
            this.name = name;
            this.size = size;
            this.price = price;
            this.productID = getID();
        }
        public Product (string name, bool size, float price, string status) {
            this.name = name;
            this.size = size;
            this.price = price;
            this.status = status;
            this.productID = getID();
        }
        int getID(){
            int nameHash = this.name == null ? 0 : name.ToLower().GetHashCode();
            int statusHash = this.status == null ? 0 : status.ToLower().GetHashCode();

            return nameHash + (int)this.price * 100 + statusHash + Convert.ToInt32(this.size);
        }
        public static void Print_Product(Product p) {
            Console.WriteLine("Name = " + p.name);
            Console.WriteLine("Size = " + p.size);
            Console.WriteLine("Price = " + p.price);
            Console.WriteLine("Status = " + p.status);
        }

        public static bool IsEqual(Product p1, Product p2) {

            return p1.productID == p2.productID;
        }
        public static bool SamePrice(Product p1, Product p2) {
            
            return p1.price == p2.price;
        }
    }
}