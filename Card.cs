using System;

namespace Passtask3{
    /// <summary>
    /// This class holds the necessary data for a card in the invetory
    /// </summary>
    public class Card{
        private string m_Name;
        private string m_SeriesNumber;
        private int m_Rarity;
        private string m_Color;
        private bool m_Foil;
        private int m_Quantity;

        /// <summary>
        /// The constructor to initialise the private fiedls and make a card object
        /// </summary>
        /// <param name="name">The name of this card</param>
        /// <param name="seriesnbr">The series number of the card</param>
        /// <param name="rarity">The rarity of the card</param>
        /// <param name="color">The color of the card</param>
        /// <param name="foil">This parameter represents whether the card is foil or not</param>
        /// <param name="quantity">The quantity of the card in the inventory</param>
        public Card(string name, string seriesnbr, int rarity, string color, bool foil, int quantity){
            m_Name = name;
            m_SeriesNumber = seriesnbr;
            m_Rarity = rarity;
            m_Color = color;
            m_Foil = foil;
            m_Quantity = quantity;
        }
        
        public string Name{
            get{ return m_Name; }
        }

        public string SeriesNumber{
            get{ return m_SeriesNumber; }
        }

        public int Rarity{ 
            get{ return m_Rarity; }
        }

        public string Color{
            get{ return m_Color; }
        }

        public bool Foil{
            get{ return m_Foil; }
        }

        public int Quantity{
            get{ return m_Quantity; }
        }

        /// <summary>
        /// To make a string from a card object to make it easy to display it via Console.WriteLine
        /// </summary>
        /// <returns></returns>
        public override string ToString(){
            return "Name: " + m_Name + "\tNo: " + m_SeriesNumber + "\tRarity: " + m_Rarity + "\tColor: " + m_Color + "\tFoil: " + m_Foil;
        }
    }
}