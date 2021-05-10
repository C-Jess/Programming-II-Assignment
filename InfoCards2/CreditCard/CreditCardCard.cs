using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.CreditCard
{
    /// <summary>
    /// Represents a credit card info card.
    /// </summary>
    public class CreditCardCard : IInfoCard
    {
        /// <summary>
        /// Create an empty credit card info card.
        /// </summary>
        public CreditCardCard(){}

        /// <summary>
        /// Create an existing credit card info card.
        /// </summary>
        /// <param name="name">Name of the info card.</param>
        /// <param name="cardNumber">Credit card number.</param>
        /// <param name="monthStartDate">Month of the start date.</param>
        /// <param name="yearStartDate">Year of the start date.</param>
        /// <param name="monthExpiryDate">Month of the expiry date.</param>
        /// <param name="yearExpiryDate">Year of the expiry date.</param>
        /// <param name="nameOnCard">Name on credit card.</param>
        /// <param name="cvc">Credit card CVC./param>
        public CreditCardCard(string name,  string cardNumber, string monthStartDate, string yearStartDate, string monthExpiryDate, string yearExpiryDate, string nameOnCard, string cvc)
        {
            Name = name;
            NameOnCard = nameOnCard;
            CardNumber = cardNumber;
            CVC = cvc;
            if(int.TryParse(monthStartDate, out int monthStart))
            {
                if (int.TryParse(yearStartDate, out int yearStart))
                {
                    StartDate = new DateTime(yearStart, monthStart, 1);
                }
            }
            if(int.TryParse(monthExpiryDate, out int monthExpiry))
            {
                if (int.TryParse(yearExpiryDate, out int yearExpiry))
                {
                    ExpiryDate = new DateTime(yearExpiry, monthExpiry, 1);
                }
            }
        }

        /// <value>
        /// Gets the category.
        /// </value>
        public string Category { get; } = "Credit Card";
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
        public string CVC{ get; set; }

        /// <summary>
        /// Closes the info card's display form.
        /// </summary>
        public void CloseDisplay()
        {
            Form form = Application.OpenForms["DisplayCreditCard"];
            if(form != null)
            {
                form.Dispose();
            }
        }

        /// <summary>
        /// Opens the info card's display form.
        /// </summary>
        /// <param name="displayPanel">The panel to display the form in.</param>
        public void DisplayData(Panel displayPanel)
        {
            DisplayCreditCard displayCreditCard = new DisplayCreditCard(this);

            // Allow the form to be displayed in the panel.
            displayCreditCard.TopLevel = false;
            displayCreditCard.TopMost = true;

            // Make the form fullscreen borderless.
            displayCreditCard.FormBorderStyle = FormBorderStyle.None;
            displayCreditCard.WindowState = FormWindowState.Maximized;

            // Add to panel and show.
            displayPanel.Controls.Add(displayCreditCard);
            displayCreditCard.Show();
        }

        /// <summary>
        /// Opens a model dialog box to edit the data of the info card.
        /// </summary>
        /// <returns>If the card was changed or not.</returns>
        public bool EditData()
        {
            // Create new edit form.
            NewCreditCardCard newCreditCardCard = new NewCreditCardCard();
            newCreditCardCard.CreditCard = this;
            // Display form.
            if(newCreditCardCard.ShowDialog() == DialogResult.OK)
            {
                // Save the respective properties from the form to the info card.
                Name = newCreditCardCard.CreditCard.Name;
                CardNumber = newCreditCardCard.CreditCard.CardNumber;
                StartDate = newCreditCardCard.CreditCard.StartDate;
                ExpiryDate = newCreditCardCard.CreditCard.ExpiryDate;
                NameOnCard = newCreditCardCard.CreditCard.NameOnCard;
                CVC = newCreditCardCard.CreditCard.CVC;
                newCreditCardCard.Dispose();
                return true;
            }
            else
            {
                newCreditCardCard.Dispose();
                return false;
            }
        }

        /// <summary>
        /// Convert all data to a string format.
        /// </summary>
        /// <returns>A string containing all data serperated by |.</returns>
        public string GetDataAsString()
        {
            string combinedData = Category + "|" + Name + "|" + CardNumber + "|" + StartDate.Month.ToString() + "|" + StartDate.Year.ToString() + "|" + ExpiryDate.Month.ToString() + "|" + ExpiryDate.Year.ToString() + "|" + NameOnCard + "|" + CVC;
            return combinedData;
        }
    }
}
