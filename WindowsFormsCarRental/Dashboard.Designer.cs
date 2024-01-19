namespace WindowsFormsCarRental
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.firstTabPage = new System.Windows.Forms.TabControl();
            this.rentCarTab = new System.Windows.Forms.TabPage();
            this.exactRentPeriod = new System.Windows.Forms.TextBox();
            this.periodLabel = new System.Windows.Forms.Label();
            this.rentCarMessageWindow = new System.Windows.Forms.ListBox();
            this.radioOneWeek = new System.Windows.Forms.RadioButton();
            this.radioOneMonth = new System.Windows.Forms.RadioButton();
            this.radioOneDay = new System.Windows.Forms.RadioButton();
            this.rentCarMakeInput = new System.Windows.Forms.TextBox();
            this.rentPhoneNumberInput = new System.Windows.Forms.TextBox();
            this.rentLastNameInput = new System.Windows.Forms.TextBox();
            this.rentFirstNameInput = new System.Windows.Forms.TextBox();
            this.carLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.rentPeriodLabel = new System.Windows.Forms.Label();
            this.rentFinishBtn = new System.Windows.Forms.Button();
            this.returnCarTab = new System.Windows.Forms.TabPage();
            this.returnFinishBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnFirstName = new System.Windows.Forms.TextBox();
            this.returnLastName = new System.Windows.Forms.TextBox();
            this.returnPhoneNumber = new System.Windows.Forms.TextBox();
            this.returnCarMake = new System.Windows.Forms.TextBox();
            this.returnMessageWindow = new System.Windows.Forms.ListBox();
            this.availableCarsTab = new System.Windows.Forms.TabPage();
            this.showCarsBtn = new System.Windows.Forms.Button();
            this.availableCarsWindow = new System.Windows.Forms.ListBox();
            this.firstTabPage.SuspendLayout();
            this.rentCarTab.SuspendLayout();
            this.returnCarTab.SuspendLayout();
            this.availableCarsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(299, 33);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(197, 32);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Car Rental App";
            // 
            // firstTabPage
            // 
            this.firstTabPage.Controls.Add(this.rentCarTab);
            this.firstTabPage.Controls.Add(this.returnCarTab);
            this.firstTabPage.Controls.Add(this.availableCarsTab);
            this.firstTabPage.Location = new System.Drawing.Point(12, 88);
            this.firstTabPage.Name = "firstTabPage";
            this.firstTabPage.SelectedIndex = 2;
            this.firstTabPage.Size = new System.Drawing.Size(776, 405);
            this.firstTabPage.TabIndex = 11;
            // 
            // rentCarTab
            // 
            this.rentCarTab.Controls.Add(this.exactRentPeriod);
            this.rentCarTab.Controls.Add(this.periodLabel);
            this.rentCarTab.Controls.Add(this.rentCarMessageWindow);
            this.rentCarTab.Controls.Add(this.radioOneWeek);
            this.rentCarTab.Controls.Add(this.radioOneMonth);
            this.rentCarTab.Controls.Add(this.radioOneDay);
            this.rentCarTab.Controls.Add(this.rentCarMakeInput);
            this.rentCarTab.Controls.Add(this.rentPhoneNumberInput);
            this.rentCarTab.Controls.Add(this.rentLastNameInput);
            this.rentCarTab.Controls.Add(this.rentFirstNameInput);
            this.rentCarTab.Controls.Add(this.carLabel);
            this.rentCarTab.Controls.Add(this.phoneLabel);
            this.rentCarTab.Controls.Add(this.firstNameLabel);
            this.rentCarTab.Controls.Add(this.lastNameLabel);
            this.rentCarTab.Controls.Add(this.rentPeriodLabel);
            this.rentCarTab.Controls.Add(this.rentFinishBtn);
            this.rentCarTab.Location = new System.Drawing.Point(4, 24);
            this.rentCarTab.Name = "rentCarTab";
            this.rentCarTab.Padding = new System.Windows.Forms.Padding(3);
            this.rentCarTab.Size = new System.Drawing.Size(768, 377);
            this.rentCarTab.TabIndex = 0;
            this.rentCarTab.Text = "Rent a Car";
            this.rentCarTab.UseVisualStyleBackColor = true;
            // 
            // exactRentPeriod
            // 
            this.exactRentPeriod.Location = new System.Drawing.Point(461, 179);
            this.exactRentPeriod.Name = "exactRentPeriod";
            this.exactRentPeriod.Size = new System.Drawing.Size(100, 23);
            this.exactRentPeriod.TabIndex = 12;
            this.exactRentPeriod.TextChanged += new System.EventHandler(this.exactRentPeriod_TextChanged);
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(383, 182);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(72, 15);
            this.periodLabel.TabIndex = 11;
            this.periodLabel.Text = "Exact period";
            // 
            // rentCarMessageWindow
            // 
            this.rentCarMessageWindow.FormattingEnabled = true;
            this.rentCarMessageWindow.ItemHeight = 15;
            this.rentCarMessageWindow.Location = new System.Drawing.Point(283, 218);
            this.rentCarMessageWindow.Name = "rentCarMessageWindow";
            this.rentCarMessageWindow.Size = new System.Drawing.Size(470, 139);
            this.rentCarMessageWindow.TabIndex = 10;
            // 
            // radioOneWeek
            // 
            this.radioOneWeek.AutoSize = true;
            this.radioOneWeek.Location = new System.Drawing.Point(460, 93);
            this.radioOneWeek.Name = "radioOneWeek";
            this.radioOneWeek.Size = new System.Drawing.Size(79, 19);
            this.radioOneWeek.TabIndex = 9;
            this.radioOneWeek.TabStop = true;
            this.radioOneWeek.Text = "One Week";
            this.radioOneWeek.UseVisualStyleBackColor = true;
            // 
            // radioOneMonth
            // 
            this.radioOneMonth.AutoSize = true;
            this.radioOneMonth.Location = new System.Drawing.Point(460, 140);
            this.radioOneMonth.Name = "radioOneMonth";
            this.radioOneMonth.Size = new System.Drawing.Size(86, 19);
            this.radioOneMonth.TabIndex = 9;
            this.radioOneMonth.TabStop = true;
            this.radioOneMonth.Text = "One Month";
            this.radioOneMonth.UseVisualStyleBackColor = true;
            // 
            // radioOneDay
            // 
            this.radioOneDay.AutoSize = true;
            this.radioOneDay.Location = new System.Drawing.Point(460, 45);
            this.radioOneDay.Name = "radioOneDay";
            this.radioOneDay.Size = new System.Drawing.Size(70, 19);
            this.radioOneDay.TabIndex = 9;
            this.radioOneDay.TabStop = true;
            this.radioOneDay.Text = "One Day";
            this.radioOneDay.UseVisualStyleBackColor = true;
            // 
            // rentCarMakeInput
            // 
            this.rentCarMakeInput.Location = new System.Drawing.Point(136, 182);
            this.rentCarMakeInput.Name = "rentCarMakeInput";
            this.rentCarMakeInput.Size = new System.Drawing.Size(100, 23);
            this.rentCarMakeInput.TabIndex = 8;
            // 
            // rentPhoneNumberInput
            // 
            this.rentPhoneNumberInput.Location = new System.Drawing.Point(137, 135);
            this.rentPhoneNumberInput.Name = "rentPhoneNumberInput";
            this.rentPhoneNumberInput.Size = new System.Drawing.Size(100, 23);
            this.rentPhoneNumberInput.TabIndex = 8;
            // 
            // rentLastNameInput
            // 
            this.rentLastNameInput.Location = new System.Drawing.Point(137, 90);
            this.rentLastNameInput.Name = "rentLastNameInput";
            this.rentLastNameInput.Size = new System.Drawing.Size(100, 23);
            this.rentLastNameInput.TabIndex = 8;
            // 
            // rentFirstNameInput
            // 
            this.rentFirstNameInput.Location = new System.Drawing.Point(136, 41);
            this.rentFirstNameInput.Name = "rentFirstNameInput";
            this.rentFirstNameInput.Size = new System.Drawing.Size(100, 23);
            this.rentFirstNameInput.TabIndex = 8;
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(43, 185);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(57, 15);
            this.carLabel.TabIndex = 7;
            this.carLabel.Text = "Car Make";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(43, 140);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(88, 15);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "Phone Number";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(43, 44);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(44, 93);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name";
            // 
            // rentPeriodLabel
            // 
            this.rentPeriodLabel.AutoSize = true;
            this.rentPeriodLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.rentPeriodLabel.Location = new System.Drawing.Point(443, 10);
            this.rentPeriodLabel.Name = "rentPeriodLabel";
            this.rentPeriodLabel.Size = new System.Drawing.Size(103, 21);
            this.rentPeriodLabel.TabIndex = 7;
            this.rentPeriodLabel.Text = "Rent Period:";
            // 
            // rentFinishBtn
            // 
            this.rentFinishBtn.Location = new System.Drawing.Point(14, 334);
            this.rentFinishBtn.Name = "rentFinishBtn";
            this.rentFinishBtn.Size = new System.Drawing.Size(129, 23);
            this.rentFinishBtn.TabIndex = 6;
            this.rentFinishBtn.Text = "Finish";
            this.rentFinishBtn.UseVisualStyleBackColor = true;
            this.rentFinishBtn.Click += new System.EventHandler(this.rentFinishBtn_Click);
            // 
            // returnCarTab
            // 
            this.returnCarTab.Controls.Add(this.returnFinishBtn);
            this.returnCarTab.Controls.Add(this.label4);
            this.returnCarTab.Controls.Add(this.label3);
            this.returnCarTab.Controls.Add(this.label2);
            this.returnCarTab.Controls.Add(this.label1);
            this.returnCarTab.Controls.Add(this.returnFirstName);
            this.returnCarTab.Controls.Add(this.returnLastName);
            this.returnCarTab.Controls.Add(this.returnPhoneNumber);
            this.returnCarTab.Controls.Add(this.returnCarMake);
            this.returnCarTab.Controls.Add(this.returnMessageWindow);
            this.returnCarTab.Location = new System.Drawing.Point(4, 24);
            this.returnCarTab.Name = "returnCarTab";
            this.returnCarTab.Padding = new System.Windows.Forms.Padding(3);
            this.returnCarTab.Size = new System.Drawing.Size(768, 377);
            this.returnCarTab.TabIndex = 1;
            this.returnCarTab.Text = "Return Car";
            this.returnCarTab.UseVisualStyleBackColor = true;
            // 
            // returnFinishBtn
            // 
            this.returnFinishBtn.Location = new System.Drawing.Point(15, 323);
            this.returnFinishBtn.Name = "returnFinishBtn";
            this.returnFinishBtn.Size = new System.Drawing.Size(129, 23);
            this.returnFinishBtn.TabIndex = 6;
            this.returnFinishBtn.Text = "Finish";
            this.returnFinishBtn.UseVisualStyleBackColor = true;
            this.returnFinishBtn.Click += new System.EventHandler(this.returnFinishBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Car Make";
            // 
            // returnFirstName
            // 
            this.returnFirstName.Location = new System.Drawing.Point(137, 30);
            this.returnFirstName.Name = "returnFirstName";
            this.returnFirstName.Size = new System.Drawing.Size(100, 23);
            this.returnFirstName.TabIndex = 8;
            // 
            // returnLastName
            // 
            this.returnLastName.Location = new System.Drawing.Point(137, 81);
            this.returnLastName.Name = "returnLastName";
            this.returnLastName.Size = new System.Drawing.Size(100, 23);
            this.returnLastName.TabIndex = 8;
            // 
            // returnPhoneNumber
            // 
            this.returnPhoneNumber.Location = new System.Drawing.Point(137, 132);
            this.returnPhoneNumber.Name = "returnPhoneNumber";
            this.returnPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.returnPhoneNumber.TabIndex = 8;
            // 
            // returnCarMake
            // 
            this.returnCarMake.Location = new System.Drawing.Point(333, 204);
            this.returnCarMake.Name = "returnCarMake";
            this.returnCarMake.Size = new System.Drawing.Size(100, 23);
            this.returnCarMake.TabIndex = 8;
            // 
            // returnMessageWindow
            // 
            this.returnMessageWindow.FormattingEnabled = true;
            this.returnMessageWindow.ItemHeight = 15;
            this.returnMessageWindow.Location = new System.Drawing.Point(333, 30);
            this.returnMessageWindow.Name = "returnMessageWindow";
            this.returnMessageWindow.Size = new System.Drawing.Size(424, 124);
            this.returnMessageWindow.TabIndex = 10;
            // 
            // availableCarsTab
            // 
            this.availableCarsTab.Controls.Add(this.showCarsBtn);
            this.availableCarsTab.Controls.Add(this.availableCarsWindow);
            this.availableCarsTab.Location = new System.Drawing.Point(4, 24);
            this.availableCarsTab.Name = "availableCarsTab";
            this.availableCarsTab.Padding = new System.Windows.Forms.Padding(3);
            this.availableCarsTab.Size = new System.Drawing.Size(768, 377);
            this.availableCarsTab.TabIndex = 2;
            this.availableCarsTab.Text = "Show Available Cars";
            this.availableCarsTab.UseVisualStyleBackColor = true;
            // 
            // showCarsBtn
            // 
            this.showCarsBtn.Location = new System.Drawing.Point(3, 223);
            this.showCarsBtn.Name = "showCarsBtn";
            this.showCarsBtn.Size = new System.Drawing.Size(112, 23);
            this.showCarsBtn.TabIndex = 1;
            this.showCarsBtn.Text = "Show Cars";
            this.showCarsBtn.UseVisualStyleBackColor = true;
            this.showCarsBtn.Click += new System.EventHandler(this.showCarsBtn_Click);
            // 
            // availableCarsWindow
            // 
            this.availableCarsWindow.FormattingEnabled = true;
            this.availableCarsWindow.ItemHeight = 15;
            this.availableCarsWindow.Location = new System.Drawing.Point(3, 3);
            this.availableCarsWindow.Name = "availableCarsWindow";
            this.availableCarsWindow.Size = new System.Drawing.Size(765, 214);
            this.availableCarsWindow.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 682);
            this.Controls.Add(this.firstTabPage);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.firstTabPage.ResumeLayout(false);
            this.rentCarTab.ResumeLayout(false);
            this.rentCarTab.PerformLayout();
            this.returnCarTab.ResumeLayout(false);
            this.returnCarTab.PerformLayout();
            this.availableCarsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TabControl firstTabPage;
        private System.Windows.Forms.TabPage rentCarTab;
        private System.Windows.Forms.ListBox rentCarMessageWindow;
        private System.Windows.Forms.RadioButton radioOneWeek;
        private System.Windows.Forms.RadioButton radioOneMonth;
        private System.Windows.Forms.RadioButton radioOneDay;
        private System.Windows.Forms.TextBox rentCarMakeInput;
        private System.Windows.Forms.TextBox rentPhoneNumberInput;
        private System.Windows.Forms.TextBox rentLastNameInput;
        private System.Windows.Forms.TextBox rentFirstNameInput;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label rentPeriodLabel;
        private System.Windows.Forms.Button rentFinishBtn;
        private System.Windows.Forms.TabPage returnCarTab;
        private System.Windows.Forms.TabPage availableCarsTab;
        private System.Windows.Forms.ListBox availableCarsWindow;
        private System.Windows.Forms.Button returnFinishBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox returnFirstName;
        private System.Windows.Forms.TextBox returnLastName;
        private System.Windows.Forms.TextBox returnPhoneNumber;
        private System.Windows.Forms.TextBox returnCarMake;
        private System.Windows.Forms.ListBox returnMessageWindow;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.TextBox exactRentPeriod;
        private System.Windows.Forms.Button showCarsBtn;
    }
}

