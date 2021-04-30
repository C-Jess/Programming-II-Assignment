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
        string _name;
        int _cardNumber;
        int _monthStartDate;
        int _yearStartDate;
        int _monthExpiryDate;
        int _yearExpiryDate;
        string _nameOnCard;
        int _CVC;

        public CreditCardCard(){}
        public CreditCardCard(string name,  string cardNumber, string monthStartDate, string yearStartDate, string monthExpiryDate, string yearExpiryDate, string nameOnCard, string CVC)
        {
            _name = name;
            _nameOnCard = nameOnCard;
            int.TryParse(cardNumber, out _cardNumber);
            int.TryParse(monthStartDate, out _monthStartDate);
            int.TryParse(yearStartDate, out _yearStartDate);
            int.TryParse(monthExpiryDate, out _monthExpiryDate);
            int.TryParse(yearExpiryDate, out _yearExpiryDate);
            int.TryParse(CVC, out _CVC);
        }

        public string Category
        {
            get
            {
                return "Credit Card";
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int CardNumber
        {
            get
            {
                return _cardNumber;
            }
            set
            {
                _cardNumber = value;
            }
        }
        public int MonthStartDate
        {
            get
            {
                return _monthStartDate;
            }
            set
            {
                _monthStartDate = value;
            }
        }
        public int YearStartDate
        {
            get
            {
                return _yearStartDate;
            }
            set
            {
                _yearStartDate = value;
            }
        }
        public int MonthExpiryDate
        {
            get
            {
                return _monthExpiryDate;
            }
            set
            {
                _monthExpiryDate = value;
            }
        }
        public int YearExpiryDate
        {
            get
            {
                return _yearExpiryDate;
            }
            set
            {
                _yearExpiryDate = value;
            }
        }
        public string NameOnCard
        {
            get
            {
                return _nameOnCard;
            }
            set
            {
                _nameOnCard = value;
            }
        }
        public int CVC
        {
            get
            {
                return _CVC;
            }
            set
            {
                _CVC = value;
            }
        }
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
            displayPanel.Controls.Add(displayCreditCard);
            displayCreditCard.Show();
        }

        public bool EditData()
        {
            NewCreditCardCard newCreditCardCard = new NewCreditCardCard();
            newCreditCardCard.CreditCard = this;
            if(newCreditCardCard.ShowDialog() == DialogResult.OK)
            {
                _name = newCreditCardCard.CreditCard.Name;
                _cardNumber = newCreditCardCard.CreditCard.CardNumber;
                _monthStartDate = newCreditCardCard.CreditCard.MonthStartDate;
                _yearStartDate = newCreditCardCard.CreditCard.YearStartDate;
                _monthExpiryDate = newCreditCardCard.CreditCard.MonthExpiryDate;
                _yearExpiryDate = newCreditCardCard.CreditCard.YearExpiryDate;
                _nameOnCard = newCreditCardCard.CreditCard.NameOnCard;
                _CVC = newCreditCardCard.CreditCard.CVC;
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
