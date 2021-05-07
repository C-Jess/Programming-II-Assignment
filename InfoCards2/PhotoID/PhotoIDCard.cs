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
    public class PhotoIDCard : IInfoCard
    {
        public PhotoIDCard() { }
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

        public string Category { get; } = "Photo ID";

        public string Name { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string GivenNames { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public Image Photo { get; set; }

        public void CloseDisplay()
        {
            Form form = Application.OpenForms["DisplayPhotoID"];
            if (form != null)
            {
                form.Dispose();
            }
        }

        public void DisplayData(Panel displayPanel)
        {
            DisplayPhotoID displayPhotoID = new DisplayPhotoID(this);
            displayPhotoID.Show();
        }

        public bool EditData()
        {
            NewPhotoIDCard newPhotoID = new NewPhotoIDCard();
            newPhotoID.PhotoID = this;
            if (newPhotoID.ShowDialog() == DialogResult.OK)
            {
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

        public string GetDataAsString()
        {
            string combinedData = Category + "|" + Name + "|" + Title + "|" + Surname + "|" + GivenNames + "|" + DOB.Year.ToString() + "|" + DOB.Month.ToString() + "|" + DOB.Day.ToString() + "|" + Address.Replace("\n","\t") + "|" + ConvertImageToBase64(Photo);
            return combinedData;
        }

        private string ConvertImageToBase64(Image image)
        {
            byte[] imageBytes = (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
            return Convert.ToBase64String(imageBytes);
        }

        private Image ConvertBase64ToImage(string base64)
        {
            return Image.FromStream(new MemoryStream(Convert.FromBase64String(base64)));
        }
    }
}
