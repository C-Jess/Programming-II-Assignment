using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CardFactory : IInfoCardFactory
    {
        private readonly Dictionary<string, string> descriptions = new Dictionary<string, string> { { "Credit Card", "Store credit card details" } };

        public string[] CategoriesSupported { get; } = { "Credit Card" };

        public IInfoCard CreateInfoCard(string initialDetails)
        {
            string[] details = initialDetails.Split('|');
            return new CreditCard.CreditCardCard(details[1], details[2], details[3], details[4], details[5], details[6], details[7], details[8]);
        }

        public IInfoCard CreateNewInfoCard(string category)
        {
            return new CreditCard.CreditCardCard();
        }

        public string GetDescription(string category)
        {
            return descriptions[category];
        }
    }
}
