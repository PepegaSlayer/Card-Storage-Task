using System.Reflection.Emit;
using System.Windows.Forms;

namespace CardHolder
{
    public partial class Form1 : Form
    {
        public List<Deck> decks = new List<Deck>();

        public Dictionary<Suit, char> suits = new Dictionary<Suit, char>()
        {
            [Suit.diamonds] = '♦',
            [Suit.hearts] = '♥',
            [Suit.spades] = '♠',
            [Suit.clubs] = '♣'

        };

        public Dictionary<int, string> ranks = new Dictionary<int, string>()
        {
            [1] = "2",
            [2] = "3",
            [3] = "4",
            [4] = "5",
            [5] = "6",
            [6] = "7",
            [7] = "8",
            [8] = "9",
            [9] = "10",
            [10] = "J",
            [11] = "Q",
            [12] = "K",
            [13] = "A"

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CreateFrom create = new CreateFrom();
            if (create.ShowDialog() == DialogResult.OK)
            {
                Deck deck = create.GetDeck();
                decks.Add(deck);
                listBox1.Items.Add(decks.Last().name);
            }

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeDeck();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            decks.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            Deck deck = decks[listBox1.SelectedIndex];
            for (var i = 0; i < deck.cards.Count; i++)
            {
                var index = new Random().Next(i, deck.cards.Count);
                var temp = deck.cards[i];
                deck.cards[i] = deck.cards[index];
                deck.cards[index] = temp;
            }
            changeDeck();
        }

        public void changeDeck()
        {
            CardsBox.Text = "";
            if (listBox1.SelectedIndex >= 0)
                foreach (Card card in decks[listBox1.SelectedIndex].cards)
                    CardsBox.Text += ranks[card.rank] + suits[card.suit] + " ";
        }
    }
}