using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Assignment.PhotoID
{
    /// <summary>
    /// Represents a photo ID info card.
    /// </summary>
    public class PhotoIDCard : IInfoCard
    {
        /// <summary>
        /// Create an empty photo ID info card.
        /// </summary>
        public PhotoIDCard() { }
        /// <summary>
        /// Create an existing credit photo ID card.
        /// </summary>
        /// <param name="name">Name of the info card.</param>
        /// <param name="title">Title on ID.</param>
        /// <param name="surname">Surname on ID.</param>
        /// <param name="givenNames">Given name(s) on ID.</param>
        /// <param name="dobYear">Year of birth on ID.</param>
        /// <param name="dobMonth">Month of birth on ID.</param>
        /// <param name="dobDay">Day of birth on ID.</param>
        /// <param name="address">Address on ID.</param>
        /// <param name="photo">Base64 of image on ID.</param>
        public PhotoIDCard(string name, string title, string surname, string givenNames, string dobYear, string dobMonth, string dobDay, string address, string photo)
        {
            Name = name;
            Title = title;
            Surname = surname;
            GivenNames = givenNames;
            Address = address.Replace("\t", "\n");
            DOB = new DateTime(int.Parse(dobYear), int.Parse(dobMonth), int.Parse(dobDay));
            Photo = ConvertBase64ToImage(photo);
        }

        /// <value>
        /// Gets the category.
        /// </value>
        public string Category { get; } = "Photo ID";
        public string Name { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string GivenNames { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public Image Photo { get; set; }

        /// <summary>
        /// Closes the info card's display form.
        /// </summary>
        public void CloseDisplay()
        {
            Form form = Application.OpenForms["DisplayPhotoID"];
            if (form != null)
            {
                form.Dispose();
            }
        }

        /// <summary>
        /// Opens the info card's display form.
        /// </summary>
        /// <param name="displayPanel">The panel to display the form in.</param>
        public void DisplayData(Panel displayPanel)
        {
            // Create form and show.
            DisplayPhotoID displayPhotoID = new DisplayPhotoID(this);
            displayPhotoID.Show();
        }

        /// <summary>
        /// Opens a model dialog box to edit the data of the info card.
        /// </summary>
        /// <returns>If the card was changed or not.</returns>
        public bool EditData()
        {
            // Create new edit form.
            NewPhotoIDCard newPhotoID = new NewPhotoIDCard();
            newPhotoID.PhotoID = this;
            // Display form.
            if (newPhotoID.ShowDialog() == DialogResult.OK)
            {
                // Save the respective properties from the form to the info card.
                Name = newPhotoID.PhotoID.Name;
                Title = newPhotoID.PhotoID.Title;
                Surname = newPhotoID.PhotoID.Surname;
                GivenNames = newPhotoID.PhotoID.GivenNames;
                DOB = newPhotoID.PhotoID.DOB;
                Address = newPhotoID.PhotoID.Address;
                Photo = newPhotoID.PhotoID.Photo;
                newPhotoID.Dispose();
                return true;
            }
            else
            {
                newPhotoID.Dispose();
                return false;
            }
        }

        /// <summary>
        /// Convert all data to a string format.
        /// </summary>
        /// <returns>A string containing all data serperated by |.</returns>
        public string GetDataAsString()
        {
            string combinedData = Category + "|" + Name + "|" + Title + "|" + Surname + "|" + GivenNames + "|" + DOB.Year.ToString() + "|" + DOB.Month.ToString() + "|" + DOB.Day.ToString() + "|" + Address.Replace("\n","\t") + "|" + ConvertImageToBase64(Photo);
            return combinedData;
        }

        /// <summary>
        /// Converts an Image to base64.
        /// </summary>
        /// <param name="image">Image to be converted.</param>
        /// <returns>String of the base64.</returns>
        private string ConvertImageToBase64(Image image)
        {
            // Converts the image to a byte array.
            byte[] imageBytes = (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
            // Converts the byte array to a string of base64.
            return Convert.ToBase64String(imageBytes);
        }

        /// <summary>
        /// Converts base64 to an Image.
        /// </summary>
        /// <param name="base64">A sting in base64 to be converted</param>
        /// <returns>The Image that represents base64</returns>
        private Image ConvertBase64ToImage(string base64)
        {
            return Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
        }
    }
}
