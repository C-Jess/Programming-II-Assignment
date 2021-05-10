using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CardFactory : IInfoCardFactory
    {
        // Dictionary to store descriptions for each category.
        private readonly Dictionary<string, string> descriptions = new Dictionary<string, string> { { "Credit Card", "Store credit card details" }, {"Bank Account", "Store bank account details" }, {"Photo ID","Store ID details with photo"} };

        public string[] CategoriesSupported { get; } = { "Credit Card", "Bank Account", "Photo ID" };

        /// <summary>
        /// Creates a card from the initial details.
        /// </summary>
        /// <param name="initialDetails">Initial detail of the card.</param>
        /// <returns>
        /// The respective info card with the initail details.
        /// </returns>
        public IInfoCard CreateInfoCard(string initialDetails)
        {
            // Split the string into seperate details.
            string[] details = initialDetails.Split('|');
            switch (details[0])
            {
                case "Credit Card":
                    return new CreditCard.CreditCardCard(details[1], details[2], details[3], details[4], details[5], details[6], details[7], details[8]);
                case "Bank Account":
                    return new BankAccount.BankAccountCard(details[1], details[2], details[3], details[4], details[5]);
                case "Photo ID":
                    return new PhotoID.PhotoIDCard(details[1], details[2], details[3], details[4], details[5], details[6], details[7], details[8], details[9]);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Creates a new card from the given cetegory.
        /// </summary>
        /// <param name="category">Category of the card.</param>
        /// <returns>
        /// A new info card of the given category.
        /// </returns>
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

        /// <summary>
        /// Gets the description of a given category.
        /// </summary>
        /// <param name="category">Category of the card.</param>
        /// <returns>
        /// The description of the category.
        /// </returns>
        public string GetDescription(string category)
        {
            return descriptions[category];
        }
    }
}
