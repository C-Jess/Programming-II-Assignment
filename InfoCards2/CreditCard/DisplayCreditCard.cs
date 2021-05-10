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
        /// <summary>
        /// Credit card info card to store details from class.
        /// </summary>
        private CreditCardCard creditCard;
        /// <summary>
        /// A form to display credit card info card details.
        /// </summary>
        /// <param name="creditCardCard">Credit card info card to get details from.</param>
        public DisplayCreditCard(CreditCardCard creditCardCard)
        {
            creditCard = creditCardCard;
            InitializeComponent();
        }

        /// <summary>
        /// Populates the labels with the credit card details.
        /// </summary>
        private void DisplayCreditCard_Load(object sender, EventArgs e)
        {
            nameLabel.Text = creditCard.Name.ToString();
            cardNumberLabel.Text = creditCard.CardNumber.ToString();
            monthStartLabel.Text = creditCard.StartDate.Month.ToString();
            yearStartLabel.Text = creditCard.StartDate.Year.ToString();
            monthExpiryLabel.Text = creditCard.ExpiryDate.Month.ToString();
            yearExpiryLabel.Text = creditCard.ExpiryDate.Year.ToString();
            nameOnCardLabel.Text = creditCard.NameOnCard.ToString();
            CVCLabel.Text = creditCard.CVC.ToString();
        }
    }
}
