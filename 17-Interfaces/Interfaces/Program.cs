using System;
using static System.Net.Mime.MediaTypeNames;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface = defines a "contract" that all the classes inheriting form should follow
            // An interface declares "what a class should have"
            // An interface class defines "how it should do it"

            // Benefit = security + multiple inheritance + "plug-and-play"


            //Fries fries = new Fries();
            //fries.DisplayDetails("Curly Fries", "shoes-string fries, good for sharing");

            Combo comboMeal = new Combo();
            comboMeal.DisplayDetails();
            comboMeal.ComboDiscount();

            Console.ReadLine();
        }

    
        interface IProduct
        {
            void DisplayDetails();
            //void Image();
            void CalculatePrice();
        }


        class Fries : IProduct
        {
            string Title { get; set; }
            string Description { get; set; }
            decimal Price { get; set; }

            //private Image ProductImage { get; set; }
            public void DisplayDetails()
            {
                
            }

            public void DisplayDetails(string Title, string Description)
            {
                this.Title = Title;
                this.Description = Description;
                Console.WriteLine("You have order: {0} - {1}", Title, Description);
            }

            public void CalculatePrice()
            {
                Console.WriteLine("Add up all the item");
            }

        }

        class Drinks
        {

        }

        class Sandwich
        {

        }

        class Combo : IProduct
        {
            public void DisplayDetails()
            {
                Console.WriteLine("Fries, Drinks and Sandwich Combo");
            }

            public void CalculatePrice()
            {
                Console.WriteLine("Add up all the item");
            }
            public void ComboDiscount()
            {
                Console.WriteLine("10% off from total");
            }
        }
    }
}
