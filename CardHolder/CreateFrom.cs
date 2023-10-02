using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CardHolder
{
    public partial class CreateFrom : Form
    {
        public CreateFrom()
        {
            InitializeComponent();
        }

        private void createButtton_Click(object sender, EventArgs e)
        {
            var count = rb36.Checked ? 36 : 52;
            DialogResult = DialogResult.OK;
            Tag = new Deck(NewDeckName.Text, count);
            Close();
        }

        public Deck GetDeck()
        {
            return (Deck)Tag;
        }

        private void cencelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void rb52_CheckedChanged(object sender, EventArgs e)
        {
            createButton.Enabled = true;
        }

        private void rb36_CheckedChanged(object sender, EventArgs e)
        {
            createButton.Enabled = true;
        }
    }
}
