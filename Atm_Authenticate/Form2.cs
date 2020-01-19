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
    public partial class Form2 : Form
    {
        public Form2(Card card)
        {
            InitializeComponent();
            this.card = card;
        }
        private Card card;

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            card.CardNumber = textBox2.Text;
            card.ExpiryDate = textBox4.Text;
            card.LastName = textBox9.Text;
            card.FirstName = textBox7.Text;
            card.TypeCard = textBox14.Text;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
