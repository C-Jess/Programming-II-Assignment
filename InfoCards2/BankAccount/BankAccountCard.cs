using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.BankAccount
{
    public class BankAccountCard : IInfoCard
    {
        public BankAccountCard() { }
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

        public string Category { get; } = "Bank Account";

        public string Name { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string NameOnAccount { get; set; }
        public decimal Overdraft { get; set; }

        public void CloseDisplay()
        {
            Form form = Application.OpenForms["DisplayBankAccount"];
            if (form != null)
            {
                form.Dispose();
            }
        }

        public void DisplayData(Panel displayPanel)
        {
            DisplayBankAccount displayBankAccount = new DisplayBankAccount(this);
            displayBankAccount.TopLevel = false;
            displayBankAccount.TopMost = true;
            displayBankAccount.FormBorderStyle = FormBorderStyle.None;
            displayBankAccount.WindowState = FormWindowState.Maximized;
            displayPanel.Controls.Add(displayBankAccount);
            displayBankAccount.Show();
        }

        public bool EditData()
        {
            NewBankAccountCard newBankAccountCard = new NewBankAccountCard();
            newBankAccountCard.BankAccount = this;
            if (newBankAccountCard.ShowDialog() == DialogResult.OK)
            {
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

        public string GetDataAsString()
        {
            string combinedData = Category + "|" + Name + "|" + SortCode + "|" + AccountNumber + "|" + NameOnAccount + "|" + Overdraft.ToString();
            return combinedData;
        }
    }
}
