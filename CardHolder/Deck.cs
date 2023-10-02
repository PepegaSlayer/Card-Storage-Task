using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardHolder
{
    public enum Suit
    { 
        diamonds,
        clubs,
        hearts,
        spades
    }

    

    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public string name;
        public Deck( string name0, int value) 
        {
            name = name0;
            int startRank = value == 36 ? 5 : 1;
            for (var i = startRank; i < (value / 4)+startRank; i++)
                for (var j =0; j<4; j++)
                    cards.Add(new Card((Suit)j,i));
        }
    }

    public class Card
    {
        public int rank;
        public Suit suit;
        public Card(Suit suit0, int rank0) 
        {
            rank = rank0;
            suit = suit0;
        }
    }
}
