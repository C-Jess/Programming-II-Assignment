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
    public partial class NewPhotoIDCard : Form
    {
        public PhotoIDCard PhotoID { get; set; }
        public NewPhotoIDCard()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool validationFailed = false;
            string name = nameTextBox.Text;
            string title = titleComboBox.Text;
            string surname = surnameTextBox.Text;
            string givenNames = givenNamesTextBox.Text;
            DateTime dob = dobDateTimePicker.Value;
            string address = addressRichTextBox.Text;
            Image photo = photoPictureBox.Image;

            if (!validationFailed)
            {
                PhotoID.Name = name;
                PhotoID.Title = title;
                PhotoID.Surname = surname;
                PhotoID.GivenNames = givenNames;
                PhotoID.DOB = dob;
                PhotoID.Address = address;
                PhotoID.Photo = photo;
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    photoPictureBox.Image = Image.FromFile(dialog.FileName);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void NewPhotoIDCard_Load(object sender, EventArgs e)
        {
            if(PhotoID.Name != null)
            {
                nameTextBox.Text = PhotoID.Name;
                titleComboBox.Text = PhotoID.Title;
                surnameTextBox.Text = PhotoID.Surname;
                givenNamesTextBox.Text = PhotoID.GivenNames;
                dobDateTimePicker.Value = PhotoID.DOB;
                addressRichTextBox.Text = PhotoID.Address;
                photoPictureBox.Image = PhotoID.Photo;
            }
        }
    }
}
