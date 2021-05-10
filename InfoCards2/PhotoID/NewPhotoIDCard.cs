using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment.PhotoID
{
    public partial class NewPhotoIDCard : Form
    {
        /// <summary>
        /// Photo ID info card to store details from form.
        /// </summary>
        public PhotoIDCard PhotoID { get; set; }
        public NewPhotoIDCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate and save details inputted in form.
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Reset textbox colours.
            nameTextBox.BackColor = Color.White;
            titleComboBox.BackColor = Color.White;
            surnameTextBox.BackColor = Color.White;
            givenNamesTextBox.BackColor = Color.White;
            dobDateTimePicker.BackColor = Color.White;
            addressRichTextBox.BackColor = Color.White;

            bool validationFailed = false;

            string name = nameTextBox.Text;
            string title = titleComboBox.Text;
            string surname = surnameTextBox.Text;
            string givenNames = givenNamesTextBox.Text;
            DateTime dob = dobDateTimePicker.Value;
            string address = addressRichTextBox.Text;
            Image photo = photoPictureBox.Image;

            // Validate strings.
            if (!CheckInput(name))
            {
                nameTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            Regex r = new Regex("^[a-zA-Z-]*$");
            if (!CheckInput(title)||!r.IsMatch(title))
            {
                titleComboBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(surname))
            {
                surnameTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(givenNames))
            {
                givenNamesTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(address))
            {
                addressRichTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            //Check if an image has been uploaded.
            if(photo == null)
            {
                MessageBox.Show("Please upload a photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validationFailed = true;
            }

            if (!validationFailed)
            {
                // Save validated details to properties.
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

        /// <summary>
        /// Closes form without saving details.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Open a file dialog for the user to select their photo.
        /// </summary>
        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Open file dialog.
                OpenFileDialog dialog = new OpenFileDialog();
                // Set filter so only jpgs and PNGs can be selected.
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    // Display image from file in picture box.
                    photoPictureBox.Image = Image.FromFile(dialog.FileName);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        /// <summary>
        /// Populate the text boxes when form is loaded.
        /// </summary>
        private void NewPhotoIDCard_Load(object sender, EventArgs e)
        {
            // Set the max date of the date time picker to today.
            dobDateTimePicker.MaxDate = DateTime.Today;

            // Populate the text boxes with details if the
            // passed photo ID info card isn't null.
            if (PhotoID.Name != null)
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

        /// <summary>
        /// Checks if input is empty or contains |.
        /// </summary>
        /// <param name="input">String to be checked.</param>
        /// <returns>If the string was empty or contained |.</returns>
        private bool CheckInput(string input)
        {
            if (input == "")
            {
                return false;
            }
            else if (input.Contains("|"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
