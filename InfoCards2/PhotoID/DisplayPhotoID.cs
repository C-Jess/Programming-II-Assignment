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
        private PhotoIDCard photoID;
        public DisplayPhotoID(PhotoIDCard photoIDCard)
        {
            InitializeComponent();
            photoID = photoIDCard;
        }

        private void DisplayPhotoID_Load(object sender, EventArgs e)
        {
            nameLabel.Text = photoID.Name;
            titleLabel.Text = photoID.Title;
            surnameLabel.Text = photoID.Surname;
            givenNamesLabel.Text = photoID.GivenNames;
            dobLabel.Text = photoID.DOB.ToString("d");
            addressLabel.Text = photoID.Address;
            photoPictureBox.Image = photoID.Photo;
        }
    }
}
