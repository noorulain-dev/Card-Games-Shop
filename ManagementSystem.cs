using System;
using System.Collections.Generic;

namespace Passtask3{
    /// <summary>
    /// This class that hold all the data of the system (Bookings, Customer...)
    /// </summary>
    public class ManagementSystem{
        private List<CardGame> m_Games;
        private List<Booking> m_Bookings;
        private List<Card> m_Cards;
        private List<Customer> m_Customers;
        private List<Sale> m_Sales;

        /// <summary>
        /// Make a ManagementSystem object
        /// </summary>
        public ManagementSystem(){
            m_Games = new List<CardGame>();
            m_Bookings = new List<Booking>();
            m_Cards = new List<Card>();
            m_Customers = new List<Customer>();
            m_Sales = new List<Sale>();
        }

        public List<CardGame> Games{
            get{ return m_Games; }
        }

        public List<Booking> Bookings{
            get{ return m_Bookings; }
        }
        public List<Card> Cards{
            get{ return m_Cards; }
        }

        public List<Customer> Customers
        {
            get{ return m_Customers; }
        }

        public List<Sale> Sales{
            get{ return m_Sales; }
        }
    }
}