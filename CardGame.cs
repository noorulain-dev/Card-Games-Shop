using System;
namespace Passtask3
{
    /// <summary>
    /// This class hold the necessary data for a Card Game
    /// </summary>
        public class CardGame{
        private string m_Name;

        /// <summary>
        /// The constroctor that makes a card game object
        /// </summary>
        /// <param name="name">The name of the game</param>
        public CardGame(string name){
            m_Name = name;
        }

        public string Name{
            get{ return m_Name; }
            set{ m_Name = value; }
        }
    }
}