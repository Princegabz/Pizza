using System;

namespace Pizza
{
    class Order
    {
        private Pizza[] PizzaOrder;
        private int amountOfPizza = 0;
        private String address;
        private double totalBill;
        private String time = "";
        private int orderID = 0;
        private bool Delivered = false;
        private String CustomerName;
        private Pizza[] gabesPizza;
        private string v1;
        private string v2;
        private string v3;

        public Order(Pizza[] pizzaOrder, int amountOfPizza, string addressl, string time, int orderID)
        {
            PizzaOrder = pizzaOrder;
            this.amountOfPizza = amountOfPizza;
            this.address = address;
    
            DateTime CurrentTime = DateTime.Now;
            CurrentTime = CurrentTime.AddMinutes(60);
            String Time = DateTime.Now.ToString("hh:mm:ss t");
            this.time = time;
            this.orderID = orderID;
        }

        public Order(Pizza[] gabesPizza, string v1, string v2, string v3)
        {
            this.gabesPizza = gabesPizza;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        private void CreateTotal()
        {
            amountOfPizza = PizzaOrder[].Length();
            for(int i = 0; i < amountOfPizza; i++)
            {
                String strTemp = "Pizza" + (i + 1) + "Pizza base: " + PizzaOrder[i].Base1 + "Pizza size: " + PizzaOrder[i].Size;
            }
        }

        public int AmountOfPizza { get => amountOfPizza; set => amountOfPizza = value; }
        public string Address { get => address; set => address = value; }
        public double TotalBill { get => totalBill; set => totalBill = value; }
        public string Time { get => time; set => time = value; }
        public int OrderID { get => orderID; }
        internal Pizza[] PizzaOrder1 { get => PizzaOrder; set => PizzaOrder = value; }
    }
 }
