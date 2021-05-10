using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.BankAccount
{
    /// <summary>
    /// Represents a bank account info card.
    /// </summary>
    public class BankAccountCard : IInfoCard
    {
        /// <summary>
        /// Create an empty bank account info card.
        /// </summary>
        public BankAccountCard() { }
        /// <summary>
        /// Create an existing bank account info card.
        /// </summary>
        /// <param name="name">Name of the info card.</param>
        /// <param name="sortCode">Sort code of bank account.</param>
        /// <param name="accountNumber">Acount number of bank account.</param>
        /// <param name="nameOnAccount">Name on the bank account</param>
        /// <param name="overdraft">Overdraft amount limit on the bank account.</param>
        public BankAccountCard(string name, string sortCode, string accountNumber, string nameOnAccount, string overdraft)
        {
            Name = name;
            SortCode = sortCode;
            AccountNumber = accountNumber;
            NameOnAccount = nameOnAccount;
            if(!decimal.TryParse(overdraft,out decimal overdraftOut))
            {
                Overdraft = overdraftOut;
            }
        }

        /// <value>
        /// Gets the category.
        /// </value>
        public string Category { get; } = "Bank Account";
        public string Name { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string NameOnAccount { get; set; }
        public decimal Overdraft { get; set; }

        /// <summary>
        /// Closes the info card's display form.
        /// </summary>
        public void CloseDisplay()
        {
            Form form = Application.OpenForms["DisplayBankAccount"];
            if (form != null)
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
            DisplayBankAccount displayBankAccount = new DisplayBankAccount(this);
            // Allow the form to be displayed in the panel.
            displayBankAccount.TopLevel = false;
            displayBankAccount.TopMost = true;
            // Make the form fullscreen borderless.
            displayBankAccount.FormBorderStyle = FormBorderStyle.None;
            displayBankAccount.WindowState = FormWindowState.Maximized;
            // Add to panel and show.
            displayPanel.Controls.Add(displayBankAccount);
            displayBankAccount.Show();
        }

        /// <summary>
        /// Opens a model dialog box to edit the data of the info card.
        /// </summary>
        /// <returns>If the card was changed or not.</returns>
        public bool EditData()
        {
            // Create new edit form.
            NewBankAccountCard newBankAccountCard = new NewBankAccountCard();
            newBankAccountCard.BankAccount = this;
            // Display form.
            if (newBankAccountCard.ShowDialog() == DialogResult.OK)
            {
                // Save the respective properties from the form to the info card.
                Name = newBankAccountCard.BankAccount.Name;
                SortCode = newBankAccountCard.BankAccount.SortCode;
                AccountNumber = newBankAccountCard.BankAccount.AccountNumber;
                NameOnAccount = newBankAccountCard.BankAccount.NameOnAccount;
                Overdraft = newBankAccountCard.BankAccount.Overdraft;
                newBankAccountCard.Dispose();
                return true;
            }
            else
            {
                newBankAccountCard.Dispose();
                return false;
            }
        }

        /// <summary>
        /// Convert all data to a string format.
        /// </summary>
        /// <returns>A string containing all data serperated by |.</returns>
        public string GetDataAsString()
        {
            string combinedData = Category + "|" + Name + "|" + SortCode + "|" + AccountNumber + "|" + NameOnAccount + "|" + Overdraft.ToString();
            return combinedData;
        }
    }
}
