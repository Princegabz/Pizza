using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {

        String size = "";
        String Base = "";
        String topping1, topping2, topping3 = "";
        String cheese = "";
        Double price = 0;
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private string v6;
        private int v7;

        public Pizza(string v1, string v2, string v3, string v4, string v5, string v6, int v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }

        public void Order(string size, string @base, string topping1, string topping2, string topping3, string cheese, double price)
        {
            this.size = size;
            Base = @base;
            this.topping1 = topping1;
            this.topping2 = topping2;
            this.topping3 = topping3;
            this.cheese = cheese;
            this.price = price;
        }

        public string Size { get => size; set => size = value; }
        public string Base1 { get => Base; set => Base = value; }
        public string Topping1 { get => topping1; set => topping1 = value; }
        public string Topping2 { get => topping2; set => topping2 = value; }
        public string Topping3 { get => topping3; set => topping3 = value; }
        public string Cheese { get => cheese; set => cheese = value; }
        public double Price { get => price; set => price = value; }
    }
}
