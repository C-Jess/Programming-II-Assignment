
namespace Assignment.BankAccount
{
    partial class DisplayBankAccount
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
            this.nameOnAccountLabel = new System.Windows.Forms.Label();
            this.overdraftLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.sortCodeLabel = new System.Windows.Forms.Label();
            this.overdraft = new System.Windows.Forms.Label();
            this.nameOnAccount = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.Label();
            this.sortCode = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.poundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameOnAccountLabel
            // 
            this.nameOnAccountLabel.AutoSize = true;
            this.nameOnAccountLabel.Location = new System.Drawing.Point(113, 96);
            this.nameOnAccountLabel.Name = "nameOnAccountLabel";
            this.nameOnAccountLabel.Size = new System.Drawing.Size(0, 13);
            this.nameOnAccountLabel.TabIndex = 28;
            // 
            // overdraftLabel
            // 
            this.overdraftLabel.AutoSize = true;
            this.overdraftLabel.Location = new System.Drawing.Point(113, 119);
            this.overdraftLabel.Name = "overdraftLabel";
            this.overdraftLabel.Size = new System.Drawing.Size(0, 13);
            this.overdraftLabel.TabIndex = 25;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(113, 73);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.accountNumberLabel.TabIndex = 24;
            // 
            // sortCodeLabel
            // 
            this.sortCodeLabel.AutoSize = true;
            this.sortCodeLabel.Location = new System.Drawing.Point(113, 50);
            this.sortCodeLabel.Name = "sortCodeLabel";
            this.sortCodeLabel.Size = new System.Drawing.Size(0, 13);
            this.sortCodeLabel.TabIndex = 23;
            // 
            // overdraft
            // 
            this.overdraft.AutoSize = true;
            this.overdraft.Location = new System.Drawing.Point(12, 119);
            this.overdraft.Name = "overdraft";
            this.overdraft.Size = new System.Drawing.Size(51, 13);
            this.overdraft.TabIndex = 21;
            this.overdraft.Text = "Overdraft";
            // 
            // nameOnAccount
            // 
            this.nameOnAccount.AutoSize = true;
            this.nameOnAccount.Location = new System.Drawing.Point(12, 96);
            this.nameOnAccount.Name = "nameOnAccount";
            this.nameOnAccount.Size = new System.Drawing.Size(95, 13);
            this.nameOnAccount.TabIndex = 20;
            this.nameOnAccount.Text = "Name On Account";
            // 
            // accountNumber
            // 
            this.accountNumber.AutoSize = true;
            this.accountNumber.Location = new System.Drawing.Point(12, 73);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(87, 13);
            this.accountNumber.TabIndex = 19;
            this.accountNumber.Text = "Account Number";
            // 
            // sortCode
            // 
            this.sortCode.AutoSize = true;
            this.sortCode.Location = new System.Drawing.Point(12, 50);
            this.sortCode.Name = "sortCode";
            this.sortCode.Size = new System.Drawing.Size(54, 13);
            this.sortCode.TabIndex = 18;
            this.sortCode.Text = "Sort Code";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(16, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 17;
            // 
            // poundLabel
            // 
            this.poundLabel.AutoSize = true;
            this.poundLabel.Location = new System.Drawing.Point(100, 119);
            this.poundLabel.Name = "poundLabel";
            this.poundLabel.Size = new System.Drawing.Size(13, 13);
            this.poundLabel.TabIndex = 39;
            this.poundLabel.Text = "£";
            // 
            // DisplayBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 152);
            this.Controls.Add(this.poundLabel);
            this.Controls.Add(this.nameOnAccountLabel);
            this.Controls.Add(this.overdraftLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.sortCodeLabel);
            this.Controls.Add(this.overdraft);
            this.Controls.Add(this.nameOnAccount);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.sortCode);
            this.Controls.Add(this.nameLabel);
            this.Name = "DisplayBankAccount";
            this.Text = "DisplayBankAccount";
            this.Load += new System.EventHandler(this.DisplayBankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameOnAccountLabel;
        private System.Windows.Forms.Label overdraftLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label sortCodeLabel;
        private System.Windows.Forms.Label overdraft;
        private System.Windows.Forms.Label nameOnAccount;
        private System.Windows.Forms.Label accountNumber;
        private System.Windows.Forms.Label sortCode;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label poundLabel;
    }
}