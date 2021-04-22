namespace Assignment
{
    partial class NewCard
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listViewCategories = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSelect.Enabled = false;
            this.buttonSelect.Location = new System.Drawing.Point(397, 21);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(101, 34);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Select Card";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(397, 69);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 34);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // listViewCategories
            // 
            this.listViewCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewCategories.FullRowSelect = true;
            this.listViewCategories.Location = new System.Drawing.Point(16, 10);
            this.listViewCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewCategories.MultiSelect = false;
            this.listViewCategories.Name = "listViewCategories";
            this.listViewCategories.Size = new System.Drawing.Size(356, 190);
            this.listViewCategories.TabIndex = 3;
            this.listViewCategories.UseCompatibleStateImageBehavior = false;
            this.listViewCategories.View = System.Windows.Forms.View.Details;
            this.listViewCategories.SelectedIndexChanged += new System.EventHandler(this.listViewCategories_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 250;
            // 
            // NewCard
            // 
            this.AcceptButton = this.buttonSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(527, 209);
            this.Controls.Add(this.listViewCategories);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewCard";
            this.Text = "New Card";
            this.Load += new System.EventHandler(this.NewCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewCategories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}