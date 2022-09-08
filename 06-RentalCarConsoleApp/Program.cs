using System;

namespace RentalCarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store renterStore = new Store();

            Console.WriteLine("Hello To Csharp Rental Car Store :-)");

            int action = chooseAction();

            while (action != 0)
            {
                switch (action)
                {
                    // Adding to shopping list
                    case 1:
                        Console.WriteLine("Renting Cars: {0}", action);
                        printInventory(renterStore);
                        Console.WriteLine("Which car would you like to rent? (number)");

                        int carChosen = int.Parse(Console.ReadLine());
                        renterStore.ShoppingList.Add(renterStore.CarList[carChosen]);
                        printShoppingList(renterStore);
                        break;

                    // Adding car to inventory
                    case 2:
                        Console.WriteLine("Store Admin: {0}", action);

                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;

                        Console.WriteLine("Car factory: ford, gm, nissan etc.");
                        carMake = Console.ReadLine();

                        Console.WriteLine("Car model: corvette, focus, ranger");
                        carModel = Console.ReadLine();

                        Console.WriteLine("Renting Price: ");
                        carPrice = decimal.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        renterStore.CarList.Add(newCar);

                        printInventory(renterStore);
                        break;
                    case 3:
                        printShoppingList(renterStore);
                        Console.WriteLine("The total cost of your items is: {0}", renterStore.Checkout());
                        break;
                }
                action = chooseAction();
            }

            //Car c1 = new Car();
            //Console.WriteLine("Car c1 - Make:{0} | Model:{1} | Price:{2}", c1.Make, c1.Model, c1.Price);

            //Car c2 = new Car("Subaru", "Impreza", 399);
            //Console.WriteLine("Car c2 - Make:{0} | Model:{1} | Price:{2}", c2.Make, c2.Model, c2.Price);

            //Store renterStore = new Store();
            //renterStore.ShoppingList.Add(c1);
            //renterStore.ShoppingList.Add(c2);

            //decimal total = renterStore.Checkout();
            //Console.WriteLine("Store value is {0}", total);
            Console.ReadLine();
        }

        private static void printShoppingList(Store renterStore)
        {
            for(int i = 0; i < renterStore.ShoppingList.Count; i++)
            {
                Console.WriteLine("Car {0}: {1}", i, renterStore.ShoppingList[i]);

            }
        }

        private static void printInventory(Store renterStore)
        {
            for(int i = 0; i < renterStore.CarList.Count; i++)
            {
                //Console.WriteLine("Car: {0} | {1} | {2}", c.Make, c.Model, c.Price);
                Console.WriteLine("Car {0}: {1}", i, renterStore.CarList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Action (1) Renting cars (2) to Store admin (3) to Checkout");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
