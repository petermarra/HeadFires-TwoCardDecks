using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoCardDecks
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {

        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {

        }
        private void ResetDeck(int deckNumber)
        {
            
        }
        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber==1)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1)
                     listBox1.Items.Add(cardName);
                label1.Text = $"Deck #1 ({deck1.Count} cards)";
            }
            else
            {
                listBox2.Items.Clear();
                foreach (string cardName in deck2)
                    listBox2.Items.Add(cardName);
                label2.Text = $"Deck #2 ({deck2.Count} cards)";
            }
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }
    }
}
