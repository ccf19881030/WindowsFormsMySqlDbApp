namespace WindowsFormsMySqlDbApp
{
    partial class DashBoardForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.fisrstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsTextBox = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.emailAdressInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailAddressInsTextBox = new System.Windows.Forms.TextBox();
            this.insertDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(92, 24);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 12);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "LastName:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(128, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(177, 24);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 12;
            this.peopleFoundListBox.Location = new System.Drawing.Point(82, 80);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(557, 196);
            this.peopleFoundListBox.TabIndex = 3;
            // 
            // fisrstNameInsLabel
            // 
            this.fisrstNameInsLabel.AutoSize = true;
            this.fisrstNameInsLabel.Location = new System.Drawing.Point(80, 313);
            this.fisrstNameInsLabel.Name = "fisrstNameInsLabel";
            this.fisrstNameInsLabel.Size = new System.Drawing.Size(71, 12);
            this.fisrstNameInsLabel.TabIndex = 4;
            this.fisrstNameInsLabel.Text = "First Name:";
            // 
            // firstNameInsTextBox
            // 
            this.firstNameInsTextBox.Location = new System.Drawing.Point(177, 310);
            this.firstNameInsTextBox.Name = "firstNameInsTextBox";
            this.firstNameInsTextBox.Size = new System.Drawing.Size(147, 21);
            this.firstNameInsTextBox.TabIndex = 5;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(80, 359);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(65, 12);
            this.lastNameInsLabel.TabIndex = 6;
            this.lastNameInsLabel.Text = "Last Name:";
            // 
            // emailAdressInsLabel
            // 
            this.emailAdressInsLabel.AutoSize = true;
            this.emailAdressInsLabel.Location = new System.Drawing.Point(80, 394);
            this.emailAdressInsLabel.Name = "emailAdressInsLabel";
            this.emailAdressInsLabel.Size = new System.Drawing.Size(83, 12);
            this.emailAdressInsLabel.TabIndex = 7;
            this.emailAdressInsLabel.Text = "Email Adress:";
            // 
            // lastNameInsTextBox
            // 
            this.lastNameInsTextBox.Location = new System.Drawing.Point(177, 350);
            this.lastNameInsTextBox.Name = "lastNameInsTextBox";
            this.lastNameInsTextBox.Size = new System.Drawing.Size(147, 21);
            this.lastNameInsTextBox.TabIndex = 9;
            // 
            // emailAddressInsTextBox
            // 
            this.emailAddressInsTextBox.Location = new System.Drawing.Point(177, 391);
            this.emailAddressInsTextBox.Name = "emailAddressInsTextBox";
            this.emailAddressInsTextBox.Size = new System.Drawing.Size(147, 21);
            this.emailAddressInsTextBox.TabIndex = 10;
            // 
            // insertDataButton
            // 
            this.insertDataButton.Location = new System.Drawing.Point(128, 432);
            this.insertDataButton.Name = "insertDataButton";
            this.insertDataButton.Size = new System.Drawing.Size(75, 23);
            this.insertDataButton.TabIndex = 11;
            this.insertDataButton.Text = "insert";
            this.insertDataButton.UseVisualStyleBackColor = true;
            this.insertDataButton.Click += new System.EventHandler(this.insertDataButton_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.insertDataButton);
            this.Controls.Add(this.emailAddressInsTextBox);
            this.Controls.Add(this.lastNameInsTextBox);
            this.Controls.Add(this.emailAdressInsLabel);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.firstNameInsTextBox);
            this.Controls.Add(this.fisrstNameInsLabel);
            this.Controls.Add(this.peopleFoundListBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "DashBoardForm";
            this.Text = "MySQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.Label fisrstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsTextBox;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.Label emailAdressInsLabel;
        private System.Windows.Forms.MaskedTextBox lastNameInsTextBox;
        private System.Windows.Forms.TextBox emailAddressInsTextBox;
        private System.Windows.Forms.Button insertDataButton;
    }
}

