using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.CreditCard
{
    class CreditCardCard : IInfoCard
    {
        string _category = "Credit Card";
        string _name;
        int cardNumber;
        int monthStartDate;
        int yearStartDate;
        int monthExpiryDate;
        int yearExpiryDate;
        string nameOnCard;
        int CVC;
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

        public string Category
        {
            get
            {
                return _category;
            }
        }

        public void CloseDisplay()
        {
            throw new NotImplementedException();
        }

        public void DisplayData(Panel displayPanel)
        {
            throw new NotImplementedException();
        }

        public bool EditData()
        {
            NewCreditCardCard newCreditCardCard = new NewCreditCardCard();
            if(newCreditCardCard.ShowDialog() == DialogResult.OK)
            {
                _name = newCreditCardCard.Name;
                cardNumber = newCreditCardCard.CardNumber;
                monthStartDate = newCreditCardCard.MonthStartDate;
                yearStartDate = newCreditCardCard.YearStartDate;
                monthExpiryDate = newCreditCardCard.MonthExpiryDate;
                yearExpiryDate = newCreditCardCard.YearExpiryDate;
                nameOnCard = newCreditCardCard.NameOnCard;
                CVC = newCreditCardCard.CVC;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetDataAsString()
        {
            throw new NotImplementedException();
        }
    }
}
