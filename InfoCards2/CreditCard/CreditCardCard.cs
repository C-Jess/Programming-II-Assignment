using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.CreditCard
{
    public class CreditCardCard : IInfoCard
    {
        public CreditCardCard(){}
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

        public string Category { get; } = "Credit Card";
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
        public string CVC{ get; set; }

        public void CloseDisplay()
        {
            Form form = Application.OpenForms["DisplayCreditCard"];
            if(form != null)
            {
                form.Dispose();
            }
        }

        public void DisplayData(Panel displayPanel)
        {
            DisplayCreditCard displayCreditCard = new DisplayCreditCard(this);
            displayCreditCard.TopLevel = false;
            displayCreditCard.TopMost = true;
            displayCreditCard.FormBorderStyle = FormBorderStyle.None;
            displayCreditCard.WindowState = FormWindowState.Maximized;
            displayPanel.Controls.Add(displayCreditCard);
            displayCreditCard.Show();
        }

        public bool EditData()
        {
            NewCreditCardCard newCreditCardCard = new NewCreditCardCard();
            newCreditCardCard.CreditCard = this;
            if(newCreditCardCard.ShowDialog() == DialogResult.OK)
            {
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

        public string GetDataAsString()
        {
            string combinedData = Category + "|" + Name + "|" + CardNumber + "|" + StartDate.Month.ToString() + "|" + StartDate.Year.ToString() + "|" + ExpiryDate.Month.ToString() + "|" + ExpiryDate.Year.ToString() + "|" + NameOnCard + "|" + CVC;
            return combinedData;
        }
    }
}
