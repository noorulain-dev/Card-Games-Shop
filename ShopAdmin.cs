using System;
using System.Collections.Generic;

namespace Passtask3
{
    /// <summary>
    /// This is a subclass of the user class and represents 
    /// a shop admin of the system
    /// It has all the menus that a shop admin has access to
    /// </summary>
    public class ShopAdmin:User{
        private ManagementSystem m_System;
        
        /// <summary>
        /// Make a ShopAdmin object from user name and password and a ManagementSystem object
        /// </summary>
        /// <param name="name">The name of the user</param>
        /// <param name="password">The password the user</param>
        /// <param name="system">The system that this user will operate on</param>
        public ShopAdmin(string name, string password, ManagementSystem system):base(name, password){
            m_System = system;
        }

        /// <summary>
        /// This methods handles the add customer menu of the shop admin
        /// The shop admin can add a new customer of the shop to the system
        /// </summary>

        public void AddCustomer(){
            Console.WriteLine();

            Console.Write("Enter customer name: ");
            string _name = Console.ReadLine();

            m_System.Customers.Add(new Customer(_name));
        }

        /// <summary>
        /// This method handles the edit customer menu
        /// The shop admin can edit customer details in the system
        /// Returns a boolean that determines if the user has exited
        /// this menu or not</summary>
        public bool EditCustomer(){
            string _choice = "";
            string _name = "";
            Customer _customer = null;
            bool _result = true;

            Console.WriteLine();
            Console.Write("Enter customer name: ");
            _name = Console.ReadLine();

            for (int i = 0; i < m_System.Customers.Count; i++){
                if (m_System.Customers[i].Name == _name){
                    _customer = m_System.Customers[i];
                }
            }

            if (_customer == null){
                Console.WriteLine("Customer not found");
                return false;
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Edit customer menu\n");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change points");
            Console.WriteLine("3. Set membership");
            Console.WriteLine("0. Back");

            Console.WriteLine();
            _choice = Console.ReadLine();

            if (_choice == "1"){
                Console.WriteLine();

                Console.Write("Enter new name: ");
                _name = Console.ReadLine();

                _customer.Name = _name;
            } else if (_choice == "2"){
                Console.WriteLine();

                Console.Write("Enter points: ");
                int _points = int.Parse(Console.ReadLine());

                _customer.Points = _points;
            } else if (_choice == "3"){
                Console.WriteLine();

                Console.Write("Enter date (Format dd-mm-yyyy): ");
                string _date = Console.ReadLine();
                
                _customer.MembershipDate = DateTime.Parse(_date);
            } else if (_choice == "0"){
                _result = false;
            } else{
                Console.WriteLine("Invalid input");
            }
            return _result;
        }

        /// <summary>
        /// This method handles the delete customer menu
        /// The shop admin can remove a customer from the shop
        /// </summary>
        public void DeleteCustomer(){
            Console.WriteLine();
            
            Console.Write("Enter customer name: ");
            string _name = Console.ReadLine();

            Customer _customer = null;
            for (int i = 0; i < m_System.Customers.Count; i++)
                if (m_System.Customers[i].Name == _name){
                    _customer = m_System.Customers[i];
            m_System.Customers.Remove(_customer);
            }
        }

        /// <summary>
        /// This method handles the add new card game to the inventory menu
        /// The shop admin can add a new card game to the system
        /// </summary>
        public void AddNewCardGame(){
            Console.WriteLine();

            Console.Write("Enter card game name: ");
            string _name = Console.ReadLine();

            m_System.Games.Add(new CardGame(_name));
        }

        /// <summary>
        /// This methods handles the edit card game menu
        /// The shop admin can edit the details of a card game in the system
        /// Returns a boolean that determines if the user has exited
        /// this menu or not</summary>
        public bool EditCardGame(){
            string _choice = "";
            string _name = "";
            CardGame _game = null;
            bool _result = true;

            Console.WriteLine();
            Console.Write("Enter card game name: ");
            _name = Console.ReadLine();

            for (int i = 0; i < m_System.Games.Count; i++){
                if (m_System.Games[i].Name == _name){
                    _game = m_System.Games[i];
                }
            }

            if (_game == null){
                Console.WriteLine("Card game not found");
                return false;
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Edit card game menu\n");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("1. Change name");
            Console.WriteLine("0. Back");

            Console.WriteLine();
            _choice = Console.ReadLine();

            if (_choice == "1"){
                Console.WriteLine();

                Console.Write("Enter new name: ");
                _name = Console.ReadLine();

                _game.Name = _name;
            } else if (_choice == "0"){
                _result = false;
            } else{
                Console.WriteLine("Invalid input");
            }
            return _result;
        }

        /// <summary>
        /// This method handles the delete card game menu
        /// The shop admin can remove a card game from the system
        /// </summary>
        public void DeleteCardGame()
        {
            Console.WriteLine();

            Console.Write("Enter card game name: ");
            string _name = Console.ReadLine();

            CardGame _game = null;
            for (int i = 0; i < m_System.Games.Count; i++){
                if (m_System.Games[i].Name == _name){
                    _game = m_System.Games[i];
            m_System.Games.Remove(_game);
                }
            }
        }

        /// <summary>
        /// This method handles the search menu
        /// The shop admin can search for inventory item (Cards) and view the quantity
        /// </summary>
        public void Search()
        {
            Console.WriteLine();

            Console.Write("Enter card name: ");
            string _card = Console.ReadLine();

            Console.WriteLine("Result: ");
            for (int i = 0; i < m_System.Cards.Count; i++){
                if (m_System.Cards[i].Name == _card){
                    Console.WriteLine("Name: " + m_System.Cards[i].Name + "\tQuantity: " + m_System.Cards[i].Quantity);
                }
            }
        }

        /// <summary>
        /// This methods handles the record purchase menu of the shop admin
        /// The shop admin can record a purchase made by a customer to the system
        /// </summary>
        public void RecordPurchase(){
            Console.WriteLine();

            Console.Write("Enter customer name: ");
            string _name = Console.ReadLine();
            Console.Write("Enter item name: ");
            string _item = Console.ReadLine();
            Console.Write("Enter item name: ");
            int _price = int.Parse(Console.ReadLine());

            Customer _customer = null;
            for (int i = 0; i < m_System.Customers.Count; i++){
                if (m_System.Customers[i].Name == _name)
                    _customer = m_System.Customers[i];
            }

            Card _card = null;
            for (int i = 0; i < m_System.Cards.Count; i++){
                if (m_System.Cards[i].Name == _item)
                    _card = m_System.Cards[i];
            }

            m_System.Sales.Add(new Sale(_customer, _card, _price));
        }

        /// <summary>
        /// This methods handles the low invetory stock menu
        /// The shop admin can view the item that are low in the inventory
        /// </summary>
        public void ViewLowInvetoryStock(){
            Console.WriteLine("Result: ");
            for (int i = 0; i < m_System.Cards.Count; i++){
                if (m_System.Cards[i].Quantity <= 20){
                    Console.WriteLine("Name: " + m_System.Cards[i].Name + "\tQuantity: " + m_System.Cards[i].Quantity);
                }
            }
        }

        /// <summary>
        /// This methods handles the add booking menu of the shop admin
        /// The shop admin can add a new bookign to the system and enters
        /// its details
        /// </summary>
        public void AddBooking(){
            Console.WriteLine();

            Console.Write("Enter customer name: ");
            string _name = Console.ReadLine();

            Console.Write("Enter card game name: ");
            string _game = Console.ReadLine();
            
            Console.Write("Enter start date (Format dd-mm-yyyy): ");
            string _date_start = Console.ReadLine();

            Console.Write("Enter end date (Format dd-mm-yyyy): ");
            string _date_end = Console.ReadLine();

            Customer _customer = null;
            CardGame _cardgame = null;

            for (int i = 0; i < m_System.Customers.Count; i++){
                if (m_System.Customers[i].Name == _name){
                    _customer = m_System.Customers[i];
                }
            }

            for (int i = 0; i < m_System.Games.Count; i++){
                if (m_System.Games[i].Name == _game){
                    _cardgame = m_System.Games[i];
                }
            }

            m_System.Bookings.Add(new Booking(_customer, _cardgame, DateTime.Parse(_date_start), DateTime.Parse(_date_end)));
        }

        /// <summary>
        /// This methods handles the edit menu of the booking
        /// The shop admin can edit a booking by changing the 
        /// The game or the date of the start and the end
        /// </summary>
        /// <returns>Returns a boolean that determines if the user has exited
        /// this menu or not</returns>
        public bool EditBooking(){
            string _choice = "";
            Booking _booking = null;
            bool _result = true;

            Console.WriteLine();
            Console.WriteLine("All bookings: ");
            for (int i = 0; i < m_System.Bookings.Count; i++){
                Console.WriteLine((i + 1) + ". " + m_System.Bookings[i]);
            }
            Console.WriteLine();
            Console.Write("Enter booking number to edit: ");
            int _nbr = int.Parse(Console.ReadLine());

            if (_nbr - 1 < 0 || _nbr - 1 > m_System.Bookings.Count){
                Console.WriteLine("Booking not found");
                return false;
            }

            _booking = m_System.Bookings[_nbr - 1];

            Console.WriteLine();
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Edit booking menu\n");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("1. Change game");
            Console.WriteLine("2. Change start date");
            Console.WriteLine("3. Change end date");
            Console.WriteLine("0. Back");

            Console.WriteLine();
            _choice = Console.ReadLine();

            if (_choice == "1"){
                Console.WriteLine();

                Console.Write("Enter game name: ");
                string _name = Console.ReadLine();

                CardGame _game = null;
                for (int i = 0; i < m_System.Games.Count; i++){
                    if (m_System.Games[i].Name == _name){
                        _game = m_System.Games[i];
                        break;
                    }
                }

                if (_game != null){
                    _booking.Game = _game;
                }
            } else if (_choice == "2"){
                Console.WriteLine();

                Console.Write("Enter start date (Format dd-mm-yyyy): ");
                string _date_start = Console.ReadLine();

                _booking.From = DateTime.Parse(_date_start);
            } else if (_choice == "3"){
                Console.WriteLine();

                Console.Write("Enter end date (Format dd-mm-yyyy): ");
                string _date_end = Console.ReadLine();

                _booking.To = DateTime.Parse(_date_end);
            } else if (_choice == "0"){
                _result = false;
            } else{
                Console.WriteLine("Invalid input");
            }

            return _result;
        }

        /// <summary>
        /// This method handles the cancel bookign menu
        /// The shop admin can cancel a booking and it will be 
        /// removed from the system
        /// </summary>
        public void CancelBooking(){
            Console.WriteLine();
            Console.WriteLine("All bookings: ");
            for (int i = 0; i < m_System.Bookings.Count; i++){
                Console.WriteLine((i + 1) + ". " + m_System.Bookings[i]);
            }
            Console.WriteLine();
            Console.Write("Enter booking number to cancel: ");
            int _nbr = int.Parse(Console.ReadLine());

            if (_nbr - 1 >= 0 && _nbr - 1 < m_System.Bookings.Count){
                m_System.Bookings.RemoveAt(_nbr - 1);
            }
        }

        /// <summary>
        /// This methods handles the view booking menu of the shop admin
        /// The shop admin can view booking details by customer and date
        /// range
        /// </summary>
        public void ViewBookings(){
            Console.WriteLine();

            Console.Write("Enter customer name: ");
            string _name = Console.ReadLine();

            Console.Write("Enter start date (Format dd-mm-yyyy): ");
            string _date_start = Console.ReadLine();

            Console.Write("Enter end date (Format dd-mm-yyyy): ");
            string _date_end = Console.ReadLine();

            DateTime _dt_start = DateTime.Parse(_date_start);
            DateTime _dt_end = DateTime.Parse(_date_end);

            Console.WriteLine("Result: ");
            for (int i = 0; i < m_System.Bookings.Count; i++){
                if (m_System.Bookings[i].Customer.Name == _name && m_System.Bookings[i].From >= _dt_start && m_System.Bookings[i].To <= _dt_end){
                Console.WriteLine(m_System.Bookings[i]);
                }
            }
        }

        /// <summary>
        /// This method handles the view customer details menu
        /// The shop admin can view all all customers of the shop with 
        /// all details
        /// </summary>
        public override void ViewCustomerDetails(){
            Console.WriteLine();
            Console.WriteLine("Result: ");
            for (int i = 0; i < m_System.Customers.Count; i++){
                Console.WriteLine(m_System.Customers[i]);
            }
        }
    }
}