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
                MonthStartDate = monthStart;
            }
            if(int.TryParse(yearStartDate, out int yearStart))
            {
                YearStartDate = yearStart;
            }
            if(int.TryParse(monthExpiryDate, out int monthExpiry))
            {
                MonthExpiryDate = monthExpiry;
            }
            if(int.TryParse(yearExpiryDate, out int yearExpiry))
            {
                YearExpiryDate = yearExpiry;
            }
        }

        public string Category { get; } = "Credit Card";
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public int MonthStartDate { get; set; }
        public int YearStartDate { get; set; }
        public int MonthExpiryDate { get; set; }
        public int YearExpiryDate { get; set; }
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
                MonthStartDate = newCreditCardCard.CreditCard.MonthStartDate;
                YearStartDate = newCreditCardCard.CreditCard.YearStartDate;
                MonthExpiryDate = newCreditCardCard.CreditCard.MonthExpiryDate;
                YearExpiryDate = newCreditCardCard.CreditCard.YearExpiryDate;
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
            string combinedData = Category + "|" + Name + "|" + CardNumber + "|" + MonthStartDate + "|" + YearStartDate + "|" + MonthExpiryDate + "|" + YearExpiryDate + "|" + NameOnCard + "|" + CVC;
            return combinedData;
        }
    }
}
