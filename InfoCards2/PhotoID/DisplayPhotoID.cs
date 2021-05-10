using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.PhotoID
{
    public partial class DisplayPhotoID : Form
    {
        /// <summary>
        /// Photo ID info card to store details from class.
        /// </summary>
        private PhotoIDCard photoID;
        /// <summary>
        /// A form to display photo ID info card details.
        /// </summary>
        /// <param name="photoIDCard">Photo ID info card to get details from.</param>
        public DisplayPhotoID(PhotoIDCard photoIDCard)
        {
            InitializeComponent();
            photoID = photoIDCard;
        }

        /// <summary>
        /// Populates the labels with the photo ID details.
        /// </summary>
        private void DisplayPhotoID_Load(object sender, EventArgs e)
        {
            nameLabel.Text = photoID.Name;
            titleLabel.Text = photoID.Title;
            surnameLabel.Text = photoID.Surname;
            givenNamesLabel.Text = photoID.GivenNames;
            // Returns the date as a string in the format dd/MM/YYY.
            dobLabel.Text = photoID.DOB.ToString("d");
            addressLabel.Text = photoID.Address;
            photoPictureBox.Image = photoID.Photo;
        }
    }
}
