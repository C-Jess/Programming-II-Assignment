using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment.PhotoID
{
    public class PhotoIDCard : IInfoCard
    {
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
            throw new NotImplementedException();
        }

        public void DisplayData(Panel displayPanel)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
