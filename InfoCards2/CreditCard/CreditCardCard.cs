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
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            throw new NotImplementedException();
        }

        public string GetDataAsString()
        {
            throw new NotImplementedException();
        }
    }
}
