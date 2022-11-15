using System;
using NUnit.Framework;

namespace Passtask3{

    [TestFixture]

    public class CustomerTests{

        [Test]

        public void AddCustomer(){
            ManagementSystem system = new ManagementSystem();
            Customer customer_ali = new Customer("Ali");
            int count = system.Customers.Count;

            Assert.AreEqual(0, count);

            system.Customers.Add(customer_ali);

            count = system.Customers.Count;

            Assert.AreEqual(1, count);
        }

        [Test]
        public void RemoveCustomer(){
            ManagementSystem system = new ManagementSystem();
            Customer customer_ali = new Customer("Ali");
            Customer customer_omar = new Customer("Omar");

            int count = system.Customers.Count;

            Assert.AreEqual(0, count);

            system.Customers.Add(customer_ali);
            system.Customers.Add(customer_omar);

            system.Customers.Remove(customer_ali);

            count = system.Customers.Count;

            Assert.AreEqual(1, count);
        }

        [Test]
        public void FetchCustomer(){
            ManagementSystem system = new ManagementSystem();
            Customer customer_ali = new Customer("Ali");
            Customer customer_omar = new Customer("Omar");

            int count = system.Customers.Count;

            system.Customers.Add(customer_ali);
            system.Customers.Add(customer_omar);

            Assert.AreEqual(system.Customers[0], customer_ali);
        }
    }

    public class CardTests{

        [Test]

        public void AddCards(){
            ManagementSystem system = new ManagementSystem();
            Card card1 = new Card("Card1", "001", 1, "Blue", false, 20);
            int count = system.Cards.Count;
            
            Assert.AreEqual(0, count);
            
            system.Cards.Add(card1);

            count = system.Cards.Count;

            Assert.AreEqual(1, count);            
        }

        [Test]

        public void RemoveCards(){
            ManagementSystem system = new ManagementSystem();
            Card card1 = new Card("Card1", "001", 1, "Blue", false, 20);
            Card card2 = new Card("Card2", "001", 1, "Blue", false, 20);

            int count = system.Customers.Count;

            Assert.AreEqual(0, count);

            system.Cards.Add(card1);
            system.Cards.Add(card2);

            count = system.Cards.Count;

            Assert.AreEqual(2, count);
 
            system.Cards.Remove(card1);

            count = system.Cards.Count;

            Assert.AreEqual(1, count);
        }

        [Test]

        public void FetchCards(){
            ManagementSystem system = new ManagementSystem();
            Card card1 = new Card("Card1", "001", 1, "Blue", false, 20);
            Card card2 = new Card("Card2", "001", 1, "Blue", false, 20);

            system.Cards.Add(card1);
            system.Cards.Add(card2);
            Assert.AreEqual(system.Cards[0], card1);
            
        }
    }

    public class SalesTests{

        [Test]

        public void AddSales(){
            ManagementSystem system = new ManagementSystem();
            Customer customer_lilya = new Customer("Lilya");
            Card card1 = new Card("Card1", "001", 1, "Blue", false, 20);
            Sale sale1 = new Sale(customer_lilya, card1, 1500);

            int count = system.Sales.Count;
            
            Assert.AreEqual(0, count);
            
            system.Sales.Add(sale1);

            count = system.Sales.Count;
            Assert.AreEqual(1, count);                     
        }

        [Test]
        public void RemoveSales(){
            ManagementSystem system = new ManagementSystem();

            Customer customer_lilya = new Customer("Lilya");
            Customer customer_omar = new Customer("Omar");

            Card card1 = new Card("Card1", "001", 1, "Blue", false, 20);
            Card card2 = new Card("Card2", "001", 1, "Blue", false, 20);

            Sale sale1 = new Sale(customer_lilya, card1, 1500);
            Sale sale2 = new Sale(customer_omar, card2, 500);

            int count = system.Sales.Count;

            Assert.AreEqual(0, count);

            system.Sales.Add(sale1);
            system.Sales.Add(sale2);

            count = system.Sales.Count;

            Assert.AreEqual(2, count);

            system.Sales.Remove(sale1);

            count = system.Sales.Count;

            Assert.AreEqual(1, count);

        }

        [Test]

        public void FetchSales(){
            ManagementSystem system = new ManagementSystem();
            Customer customer_lilya = new Customer("Lilya");
            Customer customer_omar = new Customer("Omar");

            Card card1 = new Card("Card1", "001", 1, "Blue", false, 20);
            Card card2 = new Card("Card2", "001", 1, "Blue", false, 20);

            Sale sale1 = new Sale(customer_lilya, card1, 1500);
            Sale sale2 = new Sale(customer_omar, card2, 500);
            
            system.Sales.Add(sale1);
            system.Sales.Add(sale2);

            Assert.AreEqual(system.Sales[0], sale1);
        }
    }
}