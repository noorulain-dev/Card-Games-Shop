using System;
namespace Passtask3
{
    /// <summary>
    /// This class holds the details of a sale
    /// </summary>
    public class Sale
    {
        private Customer m_Customer;
        private Card m_Item;
        private int m_Price;

        /// <summary>
        /// Make a Sale object
        /// </summary>
        /// <param name="customer">The customer who made the purchase</param>
        /// <param name="item">The item taht has been sold to a customer</param>
        /// <param name="price">The total amout of money that customer paid</param>
        public Sale(Customer customer, Card item, int price){
            m_Customer = customer;
            m_Item = item;
            m_Price = price;
        }

        public Customer Customer{
            get{ return m_Customer; }
        }
        public Card Item{
            get{ return m_Item; }
        }
        public int Price{
            get{ return m_Price; }
        }

        /// <summary>
        /// Make a string form a sale object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Sale of " + m_Item.Name + "\tBy " + m_Customer.Name;
        }
    }
}