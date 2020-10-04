using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoCardDecks
{
    class Deck
    {
        private List<Card> cards;
        private Random random  = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        public void Shuffle()
        {
            //this method shuffles the cards by reaffanging them in random order
        }

        public IEnumerable<string> GetCardNames()
        {
            //this method returns a string array contains each cards name
        }
        
        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit()); 
        }
    }
}
