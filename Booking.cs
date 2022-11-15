using System;

namespace Passtask3{
    /// <summary>
    /// This class holds the necessary data for a booking
    /// </summary>
    public class Booking{
        private Customer m_Customer;
        private CardGame m_Game;
        private DateTime m_From;
        private DateTime m_To;

        /// <summary>
        /// The constructor that inisializes the private filed and makes a booking object
        /// </summary>
        /// <param name="customer">The customer who made tjis booking</param>
        /// <param name="game">The game that the customer booked for</param>
        /// <param name="from">The date and time of when the booking starts</param>
        /// <param name="to">The date and time of when the booking starts</param>
        public Booking(Customer customer, CardGame game, DateTime from, DateTime to)
        {
            m_Customer = customer;
            m_Game = game;
            m_From = from;
            m_To = to;
        }

        public Customer Customer {
            get{return m_Customer;}
        }

        public CardGame Game{
            get {return m_Game; }
            set{ m_Game = value; }
        }

        public DateTime From{
            get{ return m_From; }
            set{ m_From = value; }
        }

        public DateTime To{
            get{ return m_To; }
            set{ m_To = value; }
        }

        /// <summary>
        /// To make a string from a booking object to make it easy to display it via Console.WriteLine
        /// </summary>
        /// <returns></returns>
        public override string ToString(){
            return "Booking by " + m_Customer.Name + " of " + m_Game.Name + "     From: " + m_From + "\tTo: " + m_To;
        }
    }
}