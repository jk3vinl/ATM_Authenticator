using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_Authenticate
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            card = new Card();
            Form2 f = new Form2(card);
            
            DialogResult result= f.ShowDialog();
            if (result == DialogResult.OK)
            {
                cards.Add(card);
                DisplayCards();

            }
            else 
            {
                card = null;
            }
        }
        private Card card;

        private void HomePage_Activated(object sender, EventArgs e)
        {
            this.Visible = true;

        }

        private void HomePage_Deactivate(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            cards = new List<Card>();
        }

        private List<Card> cards;

        private void DisplayCards() 
        {
            listBox1.Items.Clear();
            foreach (Card c in cards) 
            {
                listBox1.Items.Add(c.TypeCard);
                listBox1.Items.Add(c.CardNumber);
                listBox1.Items.Add(c.ExpiryDate);
                listBox1.Items.Add(c.LastName + c.FirstName);


                listBox1.Items.Add(string.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            
        }
    }
}
