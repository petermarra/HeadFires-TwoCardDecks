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
            List<Card> shuffledCards = new List<Card>();
            while (cards.Count> 0)
            {
                int cardToMove = random.Next(cards.Count);
                shuffledCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = shuffledCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            //this method returns a string array contains each cards name
            string[] cardName = new string[cards.Count];
            //my code.. a for loop was better because it used less lines
            //int cardNumber = 0;
            //foreach (var card in cards)
            //{
            //    cardName[cardNumber] = card.Name;
            //    cardNumber++;
            //}

            for (int i = 0; i < cards.Count; i++)
            {
                cardName[i] = cards[i].Name;
            }
            return cardName;
        }
        
        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit()); 
        }
    }
}
