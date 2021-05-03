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
        public CreditCardCard CreditCard { get; set; }


        public NewCreditCardCard()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Reset textbox colours.
            startMonthTextBox.BackColor = Color.White;
            startYearTextBox.BackColor = Color.White;
            expiryMonthTextBox.BackColor = Color.White;
            expiryYearTextBox.BackColor = Color.White;
            nameTextBox.BackColor = Color.White;
            nameOnCardTextBox.BackColor = Color.White;
            cardNumberTextBox.BackColor = Color.White;
            CVCTextBox.BackColor = Color.White;

            bool validationFailed = false;

            string name = nameTextBox.Text;
            string nameOnCard = nameOnCardTextBox.Text;
            string cardNumber = cardNumberTextBox.Text.Replace(" ","");
            string cvc = CVCTextBox.Text;

            // Clean Strings.
            if (!CheckInput(name))
            {
                nameTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(nameOnCard))
            {
                nameOnCardTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(cardNumber) || !double.TryParse(cardNumber, out _) || cardNumber.Length != 16)
            {
                cardNumberTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(cvc) || !int.TryParse(cvc,out _) || cvc.Length != 3)
            {
                CVCTextBox.BackColor = Color.Red;
                validationFailed = true;
            }

            // Clean integers.
            if (!int.TryParse(startMonthTextBox.Text, out int monthStartDate))
            {
                startMonthTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!int.TryParse(startYearTextBox.Text, out int yearStartDate))
            {
                startYearTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!int.TryParse(expiryMonthTextBox.Text, out int monthExpiryDate))
            {
                expiryMonthTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!int.TryParse(expiryYearTextBox.Text, out int yearExpiryDate))
            {
                expiryYearTextBox.BackColor = Color.Red;
                validationFailed = true;
            }

            if (!validationFailed)
            {
                CreditCard.Name = name;
                CreditCard.CardNumber = cardNumber;
                CreditCard.MonthStartDate = monthStartDate;
                CreditCard.YearStartDate = yearStartDate;
                CreditCard.MonthExpiryDate = monthExpiryDate;
                CreditCard.YearExpiryDate = yearExpiryDate;
                CreditCard.NameOnCard = nameOnCard;
                CreditCard.CVC = cvc;
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
                nameTextBox.Text = CreditCard.Name.ToString();
                cardNumberTextBox.Text = CreditCard.CardNumber.ToString();
                startMonthTextBox.Text = CreditCard.MonthStartDate.ToString();
                startYearTextBox.Text = CreditCard.YearStartDate.ToString();
                expiryMonthTextBox.Text = CreditCard.MonthExpiryDate.ToString();
                expiryYearTextBox.Text = CreditCard.YearExpiryDate.ToString();
                nameOnCardTextBox.Text = CreditCard.NameOnCard.ToString();
                CVCTextBox.Text = CreditCard.CVC.ToString();
            }
        }

        private bool CheckInput(string input)
        {
            if (input == "")
            {
                return false;
            }
            else if (input.Contains("|"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}