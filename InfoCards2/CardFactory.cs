using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CardFactory : IInfoCardFactory
    {
        private readonly Dictionary<string, string> descriptions = new Dictionary<string, string> { { "Credit Card", "Store credit card details" }, {"Bank Account", "Store bank account details" }, {"Photo ID","Store ID details with photo"} };

        public string[] CategoriesSupported { get; } = { "Credit Card", "Bank Account", "Photo ID" };

        public IInfoCard CreateInfoCard(string initialDetails)
        {
            string[] details = initialDetails.Split('|');
            switch (details[0])
            {
                case "Credit Card":
                    return new CreditCard.CreditCardCard(details[1], details[2], details[3], details[4], details[5], details[6], details[7], details[8]);
                case "Bank Account":
                    return new BankAccount.BankAccountCard(details[1], details[2], details[3], details[4], details[5]);
                default:
                    return null;
            }
        }

        public IInfoCard CreateNewInfoCard(string category)
        {
            switch (category)
            {
                case "Credit Card":
                    return new CreditCard.CreditCardCard();
                case "Bank Account":
                    return new BankAccount.BankAccountCard();
                case "Photo ID":
                    return new PhotoID.PhotoIDCard();
                default:
                    return null;
            }
        }

        public string GetDescription(string category)
        {
            return descriptions[category];
        }
    }
}
