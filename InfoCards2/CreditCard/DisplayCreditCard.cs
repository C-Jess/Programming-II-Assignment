using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.CreditCard
{
    public partial class DisplayCreditCard : Form
    {
        private CreditCardCard creditCard;
        public DisplayCreditCard(CreditCardCard creditCardCard)
        {
            creditCard = creditCardCard;
            InitializeComponent();
        }

        private void DisplayCreditCard_Load(object sender, EventArgs e)
        {
            nameLabel.Text = creditCard.Name;
            cardNumberLabel.Text = creditCard.CardNumber.ToString();
            monthStartLabel.Text = creditCard.MonthStartDate.ToString();
            yearStartLabel.Text = creditCard.YearStartDate.ToString();
            monthExpiryLabel.Text = creditCard.MonthExpiryDate.ToString();
            yearExpiryLabel.Text = creditCard.YearExpiryDate.ToString();
            nameOnCardLabel.Text = creditCard.NameOnCard;
            CVCLabel.Text = creditCard.CVC.ToString();
        }
    }
}
