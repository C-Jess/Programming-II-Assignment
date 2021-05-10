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
        /// <summary>
        /// Credit card info card to store details from form.
        /// </summary>
        public CreditCardCard CreditCard { get; set; }
        public NewCreditCardCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate and save details inputted in form.
        /// </summary>
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

            // Variables to keep track of if the validation has failed.
            bool validationFailed = false;
            bool dateValidationFailed = false;

            string name = nameTextBox.Text;
            string nameOnCard = nameOnCardTextBox.Text;
            string cardNumber = cardNumberTextBox.Text.Replace(" ","");
            string cvc = CVCTextBox.Text;

            // Validate Strings.
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

            // Validate integers.
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

            // Validating date.
            try
            {
                DateTime startDate = new DateTime(yearStartDate, monthStartDate, 1);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                startMonthTextBox.BackColor = Color.Red;
                startYearTextBox.BackColor = Color.Red;
                validationFailed = true;
                dateValidationFailed = true;
            }
            try
            {
                DateTime expiryDate = new DateTime(yearExpiryDate, monthExpiryDate, 1);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                expiryMonthTextBox.BackColor = Color.Red;
                expiryYearTextBox.BackColor = Color.Red;
                validationFailed = true;
                dateValidationFailed = true;
            }

            if (!dateValidationFailed)
            {
                DateTime startDate = new DateTime(yearStartDate, monthStartDate, 1);
                DateTime expiryDate = new DateTime(yearExpiryDate, monthExpiryDate, 1);
                if (startDate > expiryDate)
                {
                    startMonthTextBox.BackColor = Color.Red;
                    startYearTextBox.BackColor = Color.Red;
                    validationFailed = true;
                }
            }

            if (!validationFailed)
            {
                // Save validated details to properties.
                CreditCard.Name = name;
                CreditCard.CardNumber = cardNumber;
                CreditCard.StartDate = new DateTime(yearStartDate,monthStartDate,1);
                CreditCard.ExpiryDate = new DateTime(yearExpiryDate, monthExpiryDate, 1);
                CreditCard.NameOnCard = nameOnCard;
                CreditCard.CVC = cvc;
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Closes form without saving details.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Populate the text boxes when form is loaded.
        /// </summary>
        private void NewCreditCardCard_Load(object sender, EventArgs e)
        {
            // Populate the text boxes with details if the
            // passed credit card info card isn't null.
            if (CreditCard.Name != null)
            {
                nameTextBox.Text = CreditCard.Name.ToString();
                cardNumberTextBox.Text = CreditCard.CardNumber.ToString();
                startMonthTextBox.Text = CreditCard.StartDate.Month.ToString();
                startYearTextBox.Text = CreditCard.StartDate.Year.ToString();
                expiryMonthTextBox.Text = CreditCard.ExpiryDate.Month.ToString();
                expiryYearTextBox.Text = CreditCard.ExpiryDate.Year.ToString();
                nameOnCardTextBox.Text = CreditCard.NameOnCard.ToString();
                CVCTextBox.Text = CreditCard.CVC.ToString();
            }
        }

        /// <summary>
        /// Checks if input is empty or contains |.
        /// </summary>
        /// <param name="input">String to be checked.</param>
        /// <returns>If the string was empty or contained |.</returns>
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