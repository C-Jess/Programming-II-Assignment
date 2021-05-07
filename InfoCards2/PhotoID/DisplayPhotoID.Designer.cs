
namespace Assignment.PhotoID
{
    partial class DisplayPhotoID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.address = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.givenNames = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.givenNamesLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(261, 159);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(48, 13);
            this.address.TabIndex = 21;
            this.address.Text = "Address:";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(261, 130);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(69, 13);
            this.dob.TabIndex = 20;
            this.dob.Text = "Date of Birth:";
            // 
            // givenNames
            // 
            this.givenNames.AutoSize = true;
            this.givenNames.Location = new System.Drawing.Point(261, 101);
            this.givenNames.Name = "givenNames";
            this.givenNames.Size = new System.Drawing.Size(80, 13);
            this.givenNames.TabIndex = 19;
            this.givenNames.Text = "Given Name(s):";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(261, 72);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(52, 13);
            this.surname.TabIndex = 18;
            this.surname.Text = "Surname:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(261, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(30, 13);
            this.title.TabIndex = 17;
            this.title.Text = "Title:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(261, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 16;
            this.name.Text = "Name:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(232, 217);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 15;
            this.photoPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(357, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 22;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(357, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 13);
            this.titleLabel.TabIndex = 23;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(357, 72);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(0, 13);
            this.surnameLabel.TabIndex = 24;
            // 
            // givenNamesLabel
            // 
            this.givenNamesLabel.AutoSize = true;
            this.givenNamesLabel.Location = new System.Drawing.Point(357, 101);
            this.givenNamesLabel.Name = "givenNamesLabel";
            this.givenNamesLabel.Size = new System.Drawing.Size(0, 13);
            this.givenNamesLabel.TabIndex = 25;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(357, 130);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(0, 13);
            this.dobLabel.TabIndex = 26;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(357, 159);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(0, 13);
            this.addressLabel.TabIndex = 27;
            // 
            // DisplayPhotoID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 250);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.givenNamesLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.givenNames);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.title);
            this.Controls.Add(this.name);
            this.Controls.Add(this.photoPictureBox);
            this.Name = "DisplayPhotoID";
            this.Text = "Display Photo ID Details";
            this.Load += new System.EventHandler(this.DisplayPhotoID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label givenNames;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label givenNamesLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label addressLabel;
    }
}