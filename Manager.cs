using System;

namespace Passtask3
{
    /// <summary>
    /// This is a subclass of the user class and represents 
    /// a manager of the system
    /// It has all the menus that a manager has access to
    /// </summary>
    public class Manager:User {
        private ManagementSystem m_System;

        /// <summary>
        /// Make a Manager object from user name and password and a ManagementSystem object
        /// </summary>
        /// <param name="name">The name of the user</param>
        /// <param name="password">The password the user</param>
        /// <param name="system">The system that this user will operate on</param>
        public Manager(string name, string password, ManagementSystem system):base(name, password){
            m_System = system;
        }

        /// <summary>
        /// This method handles the ViewCards menu of the manager
        /// The manager can view the cards and filter them by different fields
        /// Returns a boolean that determines if the user has exited
        /// this menu or not</summary>
        public bool ViewCards(){
            string _choice = "";
            bool _result = true;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Cards menu\n");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("1. View all");
            Console.WriteLine("2. Filter by name");
            Console.WriteLine("3. Filter by series number");
            Console.WriteLine("4. Filter by rarity");
            Console.WriteLine("5. Filter by color");
            Console.WriteLine("6. View foil or non-foil cards");
            Console.WriteLine("0. Back" );

            _choice = Console.ReadLine();

            if (_choice == "1"){
                Console.WriteLine();
                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Cards.Count; i++){
                    Console.WriteLine(m_System.Cards[i]);
                }
            } else if (_choice == "2") {
                Console.WriteLine();

                Console.Write("Enter card name: ");
                string _name = Console.ReadLine();

                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Cards.Count; i++){
                    if (m_System.Cards[i].Name.Contains(_name))
                        Console.WriteLine(m_System.Cards[i]);
                }
            } else if (_choice == "3") {
                Console.WriteLine();

                Console.Write("Enter card series number: ");
                string _nbr = Console.ReadLine();

                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Cards.Count; i++){
                    if (m_System.Cards[i].SeriesNumber.Contains(_nbr))
                        Console.WriteLine(m_System.Cards[i]);
                }
            } else if (_choice == "4"){
                Console.WriteLine();

                Console.Write("Enter card rarity: ");
                string _rarity = Console.ReadLine();

                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Cards.Count; i++){
                    if (m_System.Cards[i].Rarity == int.Parse(_rarity))
                        Console.WriteLine(m_System.Cards[i]);
                }
            } else if (_choice == "5"){
                Console.WriteLine();

                Console.Write("Enter card color: ");
                string _color = Console.ReadLine();

                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Cards.Count; i++){
                    if (m_System.Cards[i].Color.ToLower().Contains(_color.ToLower()))
                        Console.WriteLine(m_System.Cards[i]);
                }
            } else if (_choice == "6"){
                Console.WriteLine();

                Console.Write("Foil or non-foil? (Enter true or false): ");
                string _foil = Console.ReadLine();

                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Cards.Count; i++){
                    if (m_System.Cards[i].Foil == bool.Parse(_foil))
                        Console.WriteLine(m_System.Cards[i]);
                }
            } else if (_choice == "0"){
                _result = false;
            } else{
                Console.WriteLine("Invalid input");
            }

            return _result;
        }

        /// <summary>
        /// This method handles the ViewBookings menu of the manager
        /// The manager can view all the bookings with details made 
        /// by customers or filter them 
        /// Returns a boolean that determines if the user has exited
        /// this menu or not</summary>
        public bool ViewBooking(){
            string _choice = "";
            bool _result = true;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Bookings menu\n");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("1. View all");
            Console.WriteLine("2. Filter by day");
            Console.WriteLine("3. Filter by date range");
            Console.WriteLine("0. Back");

            Console.WriteLine();
            _choice = Console.ReadLine();

            if (_choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Bookings.Count; i++){
                    Console.WriteLine(m_System.Bookings[i]);
                }
            } else if (_choice == "2"){
                Console.WriteLine();

                Console.Write("Enter date (Format dd-mm-yyyy): ");
                string _date = Console.ReadLine();

                DateTime _dt = DateTime.Parse(_date);

                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Bookings.Count; i++){
                    if (m_System.Bookings[i].From.Year == _dt.Year &&
                        m_System.Bookings[i].From.Month == _dt.Month &&
                        m_System.Bookings[i].From.Day == _dt.Day)
                        Console.WriteLine(m_System.Bookings[i]);
                }
            } else if (_choice == "3"){
                Console.WriteLine();

                Console.Write("Enter start date (Format dd-mm-yyyy): ");
                string _startdate = Console.ReadLine();

                Console.Write("Enter end date (Format dd-mm-yyyy): ");
                string _enddate = Console.ReadLine();

                DateTime _dateform = DateTime.Parse(_startdate);
                DateTime _dateto = DateTime.Parse(_enddate);

                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Bookings.Count; i++){
                    if (m_System.Bookings[i].From >= _dateform && m_System.Bookings[i].To <= _dateto)
                        Console.WriteLine(m_System.Bookings[i]);
                }
            } else if (_choice == "0"){
                _result = false;
            } else{
                Console.WriteLine("Invalid input");
            }

            return _result;
        }

        /// <summary>
        /// This method handles the ViewSales menu of the manager
        /// The manager can view all the sales that have been made or
        /// filter them by item
        /// Returns a boolean that determines if the user has exited
        /// this menu or not</summary>
        public bool ViewSales()
        {
            string _choice = "";
            bool _result = true;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Sales menu\n");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("1. View all");
            Console.WriteLine("2. Filter by item");
            Console.WriteLine("0. Back");

            Console.WriteLine();
            _choice = Console.ReadLine();

            if (_choice == "1"){
                Console.WriteLine();
                Console.WriteLine("Result: ");
                for (int i = 0; i < m_System.Sales.Count; i++){
                    Console.WriteLine(m_System.Sales[i]);
                }
            } else if (_choice == "2"){
                Console.WriteLine();

                Console.Write("Enter item name: ");
                string _item = Console.ReadLine();

                for (int i = 0; i < m_System.Sales.Count; i++){
                    if (m_System.Sales[i].Item.Name == _item)
                        Console.WriteLine(m_System.Sales[i]);
                }
            } else if (_choice == "0"){
                _result = false;
            } else {
                Console.WriteLine("Invalid input");
            }

            return _result;
        }

        /// <summary>
        /// This method handles the View loyal customers menu
        /// The manager can view the list of all the loyal 
        /// customers to the shop
        /// </summary>
        public override void ViewCustomerDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Result: ");
            for (int i = 0; i < m_System.Customers.Count; i++){
                int _total = 0;
                for (int j = 0; j < m_System.Sales.Count; j++){
                    if (m_System.Customers[i] == m_System.Sales[j].Customer)
                        _total += m_System.Sales[j].Price;
                } if (_total > 1000){
                    Console.WriteLine(m_System.Customers[i].Name);
                }
            }
        }
    }
}