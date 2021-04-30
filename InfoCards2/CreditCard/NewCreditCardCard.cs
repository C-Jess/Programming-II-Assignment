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
    public partial class NewCreditCardCard : Form
    {
        CreditCardCard _creditCard;
        public CreditCardCard CreditCard
        {
            get
            {
                return _creditCard;
            }
            set
            {
                _creditCard = value;
            }
        }


        public NewCreditCardCard()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool validationFailed = false;
            int cardNumber;
            int monthStartDate;
            int yearStartDate;
            int monthExpiryDate;
            int yearExpiryDate;
            int CVC;
            string name = nameTextBox.Text;
            string nameOnCard = nameOnCardTextBox.Text;

            if (!int.TryParse(cardNumberTextBox.Text, out cardNumber))
            {
                validationFailed = true;
            }
            if (!int.TryParse(startMonthTextBox.Text, out monthStartDate))
            {
                validationFailed = true;
            }
            if (!int.TryParse(startYearTextBox.Text, out yearStartDate))
            {
                validationFailed = true;
            }
            if (!int.TryParse(expiryMonthTextBox.Text, out monthExpiryDate))
            {
                validationFailed = true;
            }
            if (!int.TryParse(expiryYearTextBox.Text, out yearExpiryDate))
            {
                validationFailed = true;
            }
            if (!int.TryParse(CVCTextBox.Text, out CVC))
            {
                validationFailed = true;
            }

            if (!validationFailed)
            {
                _creditCard.Name = name;
                _creditCard.CardNumber = cardNumber;
                _creditCard.MonthStartDate = monthStartDate;
                _creditCard.YearStartDate = yearStartDate;
                _creditCard.MonthExpiryDate = monthExpiryDate;
                _creditCard.YearExpiryDate = yearExpiryDate;
                _creditCard.NameOnCard = nameOnCard;
                _creditCard.CVC = CVC;
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NewCreditCardCard_Load(object sender, EventArgs e)
        {
            if (CreditCard.Name != null)
            {
                nameTextBox.Text = CreditCard.Name;
                cardNumberTextBox.Text = CreditCard.CardNumber.ToString();
                startMonthTextBox.Text = CreditCard.MonthStartDate.ToString();
                startYearTextBox.Text = CreditCard.YearStartDate.ToString();
                expiryMonthTextBox.Text = CreditCard.MonthExpiryDate.ToString();
                expiryYearTextBox.Text = CreditCard.YearExpiryDate.ToString();
                nameOnCardTextBox.Text = CreditCard.NameOnCard;
                CVCTextBox.Text = CreditCard.CVC.ToString();
            }
        }
    }
}