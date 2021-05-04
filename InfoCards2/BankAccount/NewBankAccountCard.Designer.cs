
namespace Assignment.BankAccount
{
    partial class NewBankAccountCard
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.overdraftTextBox = new System.Windows.Forms.TextBox();
            this.sortCodeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.overdraftLabel = new System.Windows.Forms.Label();
            this.sortCodeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameOnAccountLabel = new System.Windows.Forms.Label();
            this.nameOnAccountTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.poundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(203, 162);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(68, 162);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // overdraftTextBox
            // 
            this.overdraftTextBox.Location = new System.Drawing.Point(160, 120);
            this.overdraftTextBox.Name = "overdraftTextBox";
            this.overdraftTextBox.Size = new System.Drawing.Size(81, 20);
            this.overdraftTextBox.TabIndex = 5;
            // 
            // sortCodeTextBox
            // 
            this.sortCodeTextBox.Location = new System.Drawing.Point(116, 39);
            this.sortCodeTextBox.Name = "sortCodeTextBox";
            this.sortCodeTextBox.Size = new System.Drawing.Size(222, 20);
            this.sortCodeTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(116, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(222, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // overdraftLabel
            // 
            this.overdraftLabel.AutoSize = true;
            this.overdraftLabel.Location = new System.Drawing.Point(15, 123);
            this.overdraftLabel.Name = "overdraftLabel";
            this.overdraftLabel.Size = new System.Drawing.Size(121, 13);
            this.overdraftLabel.TabIndex = 20;
            this.overdraftLabel.Text = "Arranged Overdraft Limit";
            // 
            // sortCodeLabel
            // 
            this.sortCodeLabel.AutoSize = true;
            this.sortCodeLabel.Location = new System.Drawing.Point(15, 42);
            this.sortCodeLabel.Name = "sortCodeLabel";
            this.sortCodeLabel.Size = new System.Drawing.Size(54, 13);
            this.sortCodeLabel.TabIndex = 17;
            this.sortCodeLabel.Text = "Sort Code";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(116, 66);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(222, 20);
            this.accountNumberTextBox.TabIndex = 3;
            // 
            // nameOnAccountLabel
            // 
            this.nameOnAccountLabel.AutoSize = true;
            this.nameOnAccountLabel.Location = new System.Drawing.Point(15, 96);
            this.nameOnAccountLabel.Name = "nameOnAccountLabel";
            this.nameOnAccountLabel.Size = new System.Drawing.Size(95, 13);
            this.nameOnAccountLabel.TabIndex = 34;
            this.nameOnAccountLabel.Text = "Name On Account";
            // 
            // nameOnAccountTextBox
            // 
            this.nameOnAccountTextBox.Location = new System.Drawing.Point(116, 93);
            this.nameOnAccountTextBox.Name = "nameOnAccountTextBox";
            this.nameOnAccountTextBox.Size = new System.Drawing.Size(222, 20);
            this.nameOnAccountTextBox.TabIndex = 4;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(15, 69);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.accountNumberLabel.TabIndex = 36;
            this.accountNumberLabel.Text = "Account Number";
            // 
            // poundLabel
            // 
            this.poundLabel.AutoSize = true;
            this.poundLabel.Location = new System.Drawing.Point(145, 123);
            this.poundLabel.Name = "poundLabel";
            this.poundLabel.Size = new System.Drawing.Size(13, 13);
            this.poundLabel.TabIndex = 38;
            this.poundLabel.Text = "£";
            // 
            // NewBankAccountCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 196);
            this.Controls.Add(this.poundLabel);
            this.Controls.Add(this.nameOnAccountTextBox);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.nameOnAccountLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.overdraftTextBox);
            this.Controls.Add(this.sortCodeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.overdraftLabel);
            this.Controls.Add(this.sortCodeLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "NewBankAccountCard";
            this.Text = "NewBankAccountCard";
            this.Load += new System.EventHandler(this.NewBankAccountCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox overdraftTextBox;
        private System.Windows.Forms.TextBox sortCodeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label overdraftLabel;
        private System.Windows.Forms.Label sortCodeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label nameOnAccountLabel;
        private System.Windows.Forms.TextBox nameOnAccountTextBox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label poundLabel;
    }
}