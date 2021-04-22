using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CardFactory : IInfoCardFactory
    {
        Dictionary<string, string> descriptions = new Dictionary<string, string>{ {"Credit Card","Store credit card details"} };
        string[] _categoriesSupported = {"Credit Card"};
        public string[] CategoriesSupported
        {
            get
            {
                return _categoriesSupported;
            }
        }

        public IInfoCard CreateInfoCard(string initialDetails)
        {
            throw new NotImplementedException();
        }

        public IInfoCard CreateNewInfoCard(string category)
        {
            throw new NotImplementedException();
        }

        public string GetDescription(string category)
        {
            return descriptions[category];
        }
    }
}
