using System;

namespace Passtask3
{
    /// <summary>
    /// This class hold the details of a customer
    /// </summary>
    public class Customer
    {
        private string m_Name;
        private int m_Points;
        private DateTime m_MembershipDate;
      
        /// <summary>
        /// The construcotor that makes a customer object and initilises the name field
        /// </summary>
        /// <param name="name">The name of the customer</param>
        public Customer(string name){
            m_Name = name;
            m_Points = 0;
            m_MembershipDate = DateTime.MinValue;
        }
        
        public string Name{
            get{ return m_Name; }
            set{ m_Name = value; }
        }

        public int Points{
            get{ return m_Points; }
            set{ m_Points = value; }
        }

        public bool HasMembership{
            get{ return m_MembershipDate.AddYears(1) >= DateTime.Today; }
        }

        public DateTime MembershipDate{
            get{ return m_MembershipDate; }
            set{ m_MembershipDate = value; }
        }

        /// <summary>
        /// Make a string from customer object
        /// </summary>
        /// <returns></returns>
        public override string ToString(){
            return "Name: " + m_Name + "\tPoints: " + m_Points;
        }
    }
}