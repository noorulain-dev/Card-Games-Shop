using System;

namespace Passtask3{
    class Program{
        static void Main(string[] args){
            // A system object
            ManagementSystem system = new ManagementSystem();

            // Card objects to be added to the inventory
            Card card1 = new Card("Card1", "001", 1, "Blue", false, 20);
            Card card2 = new Card("Card2", "002", 1, "Red", true, 10);
            Card card3 = new Card("Card3", "003", 2, "Green", false, 50);
            Card card4 = new Card("Card4", "004", 5, "Green", true, 70);
            Card card5 = new Card("Card5", "005", 3, "Blue", false, 50);
            system.Cards.Add(card1);
            system.Cards.Add(card2);
            system.Cards.Add(card3);
            system.Cards.Add(card4);
            system.Cards.Add(card5);

            // Customer objects
            Customer customer_ali = new Customer("Ali");
            Customer customer_omar = new Customer("Omar");
            Customer customer_lilya = new Customer("Lilya");
            system.Customers.Add(customer_ali);
            system.Customers.Add(customer_omar);
            system.Customers.Add(customer_lilya);

            // Card game objects
            CardGame game1 = new CardGame("game1");
            CardGame game2 = new CardGame("game2");
            CardGame game3 = new CardGame("game3");
            system.Games.Add(game1);
            system.Games.Add(game2);
            system.Games.Add(game3);

            // Bookings objects
            system.Bookings.Add(new Booking(customer_ali, game1, DateTime.Parse("17-04-2021"), DateTime.Parse("17-04-2021")));
            system.Bookings.Add(new Booking(customer_omar, game3, DateTime.Parse("17-04-2021"), DateTime.Parse("17-04-2021")));
            system.Bookings.Add(new Booking(customer_ali, game3, DateTime.Parse("19-04-2021"), DateTime.Parse("19-04-2021")));

            // Sales objects
            system.Sales.Add(new Sale(customer_lilya, card3, 1500));
            system.Sales.Add(new Sale(customer_lilya, card5, 100));
            system.Sales.Add(new Sale(customer_ali, card1, 500));

            // Make a Manager and a ShopAdmin objects
            Manager manager = new Manager("manager1", "12345", system);
            ShopAdmin admin = new ShopAdmin("admin1", "54321", system);

            // Variables for menu handling
            string choice = "";
            bool success;
            int menu = 0;
            
            // A welcome message
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Welcome to Neko Neko Nyaa\n");
            Console.WriteLine("---------------------------------------\n");

            while (true)
            {
                // The switch statement determines what menu should be displayed
                // dependiong the value of the variable "menu"
                switch (menu)
                {
                    // The main menu of the shop where the user chooses the type
                    // of his/her account and logs in to the system
                    case 0:
                        Console.WriteLine("---------------------------------------\n");
                        Console.WriteLine("Main menu\n");
                        Console.WriteLine("---------------------------------------\n");
                        Console.WriteLine("1. Login as Manager");
                        Console.WriteLine("2. Login as Shop admin");
                        Console.WriteLine("0. Exit");

                        Console.WriteLine();
                        choice = Console.ReadLine();

                        if (choice == "1")
                            menu = 1;
                        else if (choice == "2")
                            menu = 7;
                        else if (choice == "0")
                            Environment.Exit(0);
                        else
                            Console.WriteLine("Invalid input");
                        break;
                    // Handling the login for the Manager
                    case 1:
                        Console.WriteLine();
                        success = manager.Login();
                        if (success)
                            menu = 2;
                        else
                            menu = 0;
                        break;
                    // Displaying the Manager menu and waiting for choice input
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------\n");
                        Console.WriteLine("Manager menu\n");
                        Console.WriteLine("---------------------------------------\n");
                        Console.WriteLine("1. View cards");
                        Console.WriteLine("2. View bookings");
                        Console.WriteLine("3. View sales");
                        Console.WriteLine("4. View loyal customers");
                        Console.WriteLine("5. Log out");
                        Console.WriteLine("0. Exit");

                        Console.WriteLine();
                        choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            menu = 3;
                        }
                        else if (choice == "2")
                        {
                            menu = 4;
                        }
                        else if (choice == "3")
                        {
                            menu = 5;
                        }
                        else if (choice == "4")
                        {
                            menu = 6;
                        }
                        else if (choice == "5")
                        {
                            Console.WriteLine("Logged out.\n");
                            menu = 0;
                        }
                        else if (choice == "0")
                            Environment.Exit(0);
                        else
                            Console.WriteLine("Invalid input");
                        break;
                    case 3:
                        success = manager.ViewCards();
                        if (!success)
                            menu = 2;
                        break;
                    case 4:
                        success = manager.ViewBooking();
                        if (!success)
                            menu = 2;
                        break;
                    case 5:
                        success = manager.ViewSales();
                        if (!success)
                            menu = 2;
                        break;
                    case 6:
                        manager.ViewCustomerDetails();
                        menu = 2;
                        break;
                    // Handling the login for the ShopAdmin
                    case 7:
                        Console.WriteLine();
                        success = admin.Login();
                        if (success)
                            menu = 8;
                        else
                            menu = 0;
                        break;
                    // Displaying the ShopAdmin menu and waiting for choice input
                    case 8:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------\n");
                        Console.WriteLine("Shop admin menu\n");
                        Console.WriteLine("---------------------------------------\n");
                        Console.WriteLine("1. Add customer");
                        Console.WriteLine("2. Edit customer");
                        Console.WriteLine("3. Delete customer");
                        Console.WriteLine("4. Add new card game");
                        Console.WriteLine("5. Edit card game");
                        Console.WriteLine("6. Delete card game");
                        Console.WriteLine("7. Search");
                        Console.WriteLine("8. Record purchse");
                        Console.WriteLine("9. View low inventory stock");
                        Console.WriteLine("10. Add booking");
                        Console.WriteLine("11. Edit booking");
                        Console.WriteLine("12. Cancel booking");
                        Console.WriteLine("13. View bookings");
                        Console.WriteLine("14. View customer details");
                        Console.WriteLine("15. Log out");
                        Console.WriteLine("0. Exit");

                        Console.WriteLine();
                        choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            menu = 9;
                        }
                        else if (choice == "2")
                        {
                            menu = 10;
                        }
                        else if (choice == "3")
                        {
                            menu = 11;
                        }
                        else if (choice == "4")
                        {
                            menu = 12;
                        }
                        else if (choice == "5")
                        {
                            menu = 13;
                        }
                        else if (choice == "6")
                        {
                            menu = 14;
                        }
                        else if (choice == "7")
                        {
                            menu = 15;
                        }
                        else if (choice == "8")
                        {
                            menu = 16;
                        }
                        else if (choice == "9")
                        {
                            menu = 17;
                        }
                        else if (choice == "10")
                        {
                            menu = 18;
                        }
                        else if (choice == "11")
                        {
                            menu = 19;
                        }
                        else if (choice == "12")
                        {
                            menu = 20;
                        }
                        else if (choice == "13")
                        {
                            menu = 21;
                        }
                        else if (choice == "14")
                        {
                            menu = 22;
                        }
                        else if (choice == "15")
                        {
                            Console.WriteLine("Logged out.\n");
                            menu = 0;
                        }
                        else if (choice == "0")
                            Environment.Exit(0);
                        else
                            Console.WriteLine("Invalid input");
                        break;
                    case 9:
                        admin.AddCustomer();
                        menu = 8;
                        break;
                    case 10:
                        success = admin.EditCustomer();
                        if (!success)
                            menu = 8;
                        break;
                    case 11:
                        admin.DeleteCustomer();
                        menu = 8;
                        break;
                    case 12:
                        admin.AddNewCardGame();
                        menu = 8;
                        break;
                    case 13:
                        success = admin.EditCardGame();
                        if (!success)
                            menu = 8;
                        break;
                    case 14:
                        admin.DeleteCardGame();
                        menu = 8;
                        break;
                    case 15:
                        admin.Search();
                        menu = 8;
                        break;
                    case 16:
                        admin.RecordPurchase();
                        menu = 8;
                        break;
                    case 17:
                        admin.ViewLowInvetoryStock();
                        menu = 8;
                        break;
                    case 18:
                        admin.AddBooking();
                        menu = 8;
                        break;
                    case 19:
                        success = admin.EditBooking();
                        if (!success)
                            menu = 8;
                        break;
                    case 20:
                        admin.CancelBooking();
                        menu = 8;
                        break;
                    case 21:
                        admin.ViewBookings();
                        menu = 8;
                        break;
                    case 22:
                        admin.ViewCustomerDetails();
                        menu = 8;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}