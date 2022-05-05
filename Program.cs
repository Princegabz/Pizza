using System;

namespace Pizza
{
    class Program
    {
        private static bool bLoop;
        private static int iSize;
        private static object strName;
        private static object strAddress;
        private static object time;
        private static object strTopping;
        private static string strCheese;

        static void Main(string[] args)
        {

     //     Order Gabe = new Order()

             Pizza[] GabesPizza = new Pizza[3];
            GabesPizza[0] = new Pizza("Large", "Thick", "None", "None", "Cheese", "Yellow", 70);
            GabesPizza[1] = new Pizza("Large", "Thick", "None", "None", "Cheese", "Yellow", 70);
            GabesPizza[2] = new Pizza("Large", "Thick", "None", "None", "Cheese", "Yellow", 70);

            Order Gabe = new Order(GabesPizza, "Durban road", "South End", "Gabe");

            Console.WriteLine(Gabe.ToString());






















            String[] arrSize = {"Large","Medium","Small"};
            String[] arrThickness = { "Thick", "Thin"}; //This is supposed to be a boolean
            String[] arrTopping = { "Topping1", "Topping2", "Topping3" };
            int Price;

            Order sd = new Order(4);
            sd.LoadPresetData();
            sd.AddPizza( strName, strAddress,time, arrSize[iSize] , strTopping  );
            
          
            Console.WriteLine("Welcome to the Pizza Menu");
            Console.WriteLine("Enter 1 to Order a pizza");
            Console.WriteLine("Enter any other number to exit");
          
            int menu = Convert.ToInt32(Console.ReadLine()); //should be in a loop so tht user can order another pizza 
                                                            // would you lie to buy another pizza then ask only pizza related questions not the user personal details 


            if (menu == 1)
            {
                Console.Write("Please enter customer name");
                strName = Console.ReadLine();
=
                Console.WriteLine("Please enter customer Address");
                strAddress = Console.ReadLine();


                time = DateTime.Now.ToString("hh:mm:ss t");

                Console.WriteLine("Please Select the size of the pizza: 0-Large 1-Medium 2-Small");
                iSize = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Is this a delivery? type in  yes or no");
                strTopping = Console.ReadLine();

                Console.WriteLine("Would you like Topping 1,2 or 3?");
                strTopping = Console.ReadLine();

                Console.WriteLine("What cheeese type would you like?");
                strCheese = Console.ReadLine();

               //price of pizza will be determined buy what the user chose
              
            }
         
            else if (menu == 3) //Change the style
            {
                Console.WriteLine("Please enter from 0 to 4, what stage if loadshedding it is");

                try
                {
                    sd.setStage = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number and try again");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(1000);
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number and try again");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(1000);
                }
            }
            else //Wrong input selected
            {
                
                bLoop = false;
            }
        }
    }

}
    

