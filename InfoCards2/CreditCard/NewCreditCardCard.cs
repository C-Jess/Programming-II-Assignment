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
        string _name;
        int _cardNumber;
        int _monthStartDate;
        int _yearStartDate;
        int _monthExpiryDate;
        int _yearExpiryDate;
        string _nameOnCard;
        int _CVC;
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
        public NewCreditCardCard()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool validationFailed = false;
            _name = nameTextBox.Text;
            _nameOnCard = nameOnCardTextBox.Text;

            if (!int.TryParse(cardNumberTextBox.Text, out _cardNumber))
            {
                validationFailed = true;
            }
            if (!int.TryParse(startMonthTextBox.Text, out _monthStartDate))
            {
                validationFailed = true;
            }
            if (!int.TryParse(startYearTextBox.Text, out _yearStartDate))
            {
                validationFailed = true;
            }
            if (!int.TryParse(expiryMonthTextBox.Text, out _monthExpiryDate))
            {
                validationFailed = true;
            }
            if (!int.TryParse(expiryYearTextBox.Text, out _yearExpiryDate))
            {
                validationFailed = true;
            }
            if (!int.TryParse(CVCTextBox.Text, out _CVC))
            {
                validationFailed = true;
            }

            if (!validationFailed)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
