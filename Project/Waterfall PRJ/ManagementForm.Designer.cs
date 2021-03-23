
namespace Waterfall_PRJ
{
    partial class ManagementForm
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
            this.ManagementTabControl = new System.Windows.Forms.TabControl();
            this.EmployeeManagePage = new System.Windows.Forms.TabPage();
            this.removeBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.employeesLB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ContractCB = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.postalCodeTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.RoleCB = new System.Windows.Forms.ComboBox();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.relationshipStatusCB = new System.Windows.Forms.ComboBox();
            this.BSN_TB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShiftManagementPage = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.workhrsLbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.EmployeeCalendar = new Syncfusion.WinForms.Input.SfCalendar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShiftSelectorCB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AvailableEmployeesLB = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NightShiftLB = new System.Windows.Forms.ListBox();
            this.EveningShiftLB = new System.Windows.Forms.ListBox();
            this.MorningShiftLB = new System.Windows.Forms.ListBox();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.ManagementTabControl.SuspendLayout();
            this.EmployeeManagePage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ShiftManagementPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagementTabControl
            // 
            this.ManagementTabControl.Controls.Add(this.EmployeeManagePage);
            this.ManagementTabControl.Controls.Add(this.ShiftManagementPage);
            this.ManagementTabControl.Location = new System.Drawing.Point(3, 2);
            this.ManagementTabControl.Name = "ManagementTabControl";
            this.ManagementTabControl.SelectedIndex = 0;
            this.ManagementTabControl.Size = new System.Drawing.Size(551, 518);
            this.ManagementTabControl.TabIndex = 35;
            // 
            // EmployeeManagePage
            // 
            this.EmployeeManagePage.Controls.Add(this.removeBTN);
            this.EmployeeManagePage.Controls.Add(this.addBTN);
            this.EmployeeManagePage.Controls.Add(this.updateBTN);
            this.EmployeeManagePage.Controls.Add(this.employeesLB);
            this.EmployeeManagePage.Controls.Add(this.groupBox2);
            this.EmployeeManagePage.Controls.Add(this.groupBox1);
            this.EmployeeManagePage.Controls.Add(this.pictureBox1);
            this.EmployeeManagePage.Location = new System.Drawing.Point(4, 22);
            this.EmployeeManagePage.Name = "EmployeeManagePage";
            this.EmployeeManagePage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeManagePage.Size = new System.Drawing.Size(543, 492);
            this.EmployeeManagePage.TabIndex = 1;
            this.EmployeeManagePage.Text = "Employee Management";
            this.EmployeeManagePage.UseVisualStyleBackColor = true;
            // 
            // removeBTN
            // 
            this.removeBTN.Location = new System.Drawing.Point(467, 457);
            this.removeBTN.Margin = new System.Windows.Forms.Padding(2);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(73, 27);
            this.removeBTN.TabIndex = 43;
            this.removeBTN.Text = "REMOVE";
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(274, 454);
            this.addBTN.Margin = new System.Windows.Forms.Padding(2);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(105, 33);
            this.addBTN.TabIndex = 42;
            this.addBTN.Text = "Admission Form";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(85, 457);
            this.updateBTN.Margin = new System.Windows.Forms.Padding(2);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(76, 27);
            this.updateBTN.TabIndex = 40;
            this.updateBTN.Text = "UPDATE";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // employeesLB
            // 
            this.employeesLB.FormattingEnabled = true;
            this.employeesLB.Location = new System.Drawing.Point(274, 68);
            this.employeesLB.Margin = new System.Windows.Forms.Padding(2);
            this.employeesLB.Name = "employeesLB";
            this.employeesLB.Size = new System.Drawing.Size(267, 381);
            this.employeesLB.TabIndex = 39;
            this.employeesLB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.employeesLB_MouseClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ContractCB);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.countryTB);
            this.groupBox2.Controls.Add(this.cityTB);
            this.groupBox2.Controls.Add(this.postalCodeTB);
            this.groupBox2.Controls.Add(this.addressTB);
            this.groupBox2.Controls.Add(this.RoleCB);
            this.groupBox2.Controls.Add(this.phoneNumberTB);
            this.groupBox2.Controls.Add(this.emailTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 238);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(252, 216);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // ContractCB
            // 
            this.ContractCB.FormattingEnabled = true;
            this.ContractCB.Items.AddRange(new object[] {
            "Full Time (40 work hours)",
            "Part Time (30 work hours)",
            "Part Time (20 work hours)"});
            this.ContractCB.Location = new System.Drawing.Point(90, 181);
            this.ContractCB.Margin = new System.Windows.Forms.Padding(2);
            this.ContractCB.Name = "ContractCB";
            this.ContractCB.Size = new System.Drawing.Size(146, 21);
            this.ContractCB.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 181);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Contract type:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 160);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Role :";
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(70, 136);
            this.countryTB.Margin = new System.Windows.Forms.Padding(2);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(167, 20);
            this.countryTB.TabIndex = 38;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(51, 113);
            this.cityTB.Margin = new System.Windows.Forms.Padding(2);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(186, 20);
            this.cityTB.TabIndex = 37;
            // 
            // postalCodeTB
            // 
            this.postalCodeTB.Location = new System.Drawing.Point(90, 89);
            this.postalCodeTB.Margin = new System.Windows.Forms.Padding(2);
            this.postalCodeTB.Name = "postalCodeTB";
            this.postalCodeTB.Size = new System.Drawing.Size(147, 20);
            this.postalCodeTB.TabIndex = 36;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(70, 67);
            this.addressTB.Margin = new System.Windows.Forms.Padding(2);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(167, 20);
            this.addressTB.TabIndex = 35;
            // 
            // RoleCB
            // 
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Items.AddRange(new object[] {
            "Administrator",
            "FloorManager",
            "Employee"});
            this.RoleCB.Location = new System.Drawing.Point(116, 158);
            this.RoleCB.Margin = new System.Windows.Forms.Padding(2);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(121, 21);
            this.RoleCB.TabIndex = 38;
            this.RoleCB.SelectedIndexChanged += new System.EventHandler(this.RoleCB_SelectedIndexChanged);
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.Location = new System.Drawing.Point(103, 45);
            this.phoneNumberTB.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(134, 20);
            this.phoneNumberTB.TabIndex = 34;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(57, 22);
            this.emailTB.Margin = new System.Windows.Forms.Padding(2);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(180, 20);
            this.emailTB.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Postal Code :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Country :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "City :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Phone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenderCB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DOBPicker);
            this.groupBox1.Controls.Add(this.relationshipStatusCB);
            this.groupBox1.Controls.Add(this.BSN_TB);
            this.groupBox1.Controls.Add(this.lastNameTB);
            this.groupBox1.Controls.Add(this.firstNameTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(252, 166);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Essential Information";
            // 
            // GenderCB
            // 
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary"});
            this.GenderCB.Location = new System.Drawing.Point(122, 67);
            this.GenderCB.Margin = new System.Windows.Forms.Padding(2);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(115, 21);
            this.GenderCB.TabIndex = 35;
            this.GenderCB.SelectedIndexChanged += new System.EventHandler(this.GenderCB_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Gender:";
            // 
            // DOBPicker
            // 
            this.DOBPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DOBPicker.Location = new System.Drawing.Point(82, 91);
            this.DOBPicker.Margin = new System.Windows.Forms.Padding(2);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(155, 20);
            this.DOBPicker.TabIndex = 33;
            // 
            // relationshipStatusCB
            // 
            this.relationshipStatusCB.FormattingEnabled = true;
            this.relationshipStatusCB.Items.AddRange(new object[] {
            "Married",
            "Single"});
            this.relationshipStatusCB.Location = new System.Drawing.Point(122, 136);
            this.relationshipStatusCB.Margin = new System.Windows.Forms.Padding(2);
            this.relationshipStatusCB.Name = "relationshipStatusCB";
            this.relationshipStatusCB.Size = new System.Drawing.Size(115, 21);
            this.relationshipStatusCB.TabIndex = 32;
            // 
            // BSN_TB
            // 
            this.BSN_TB.Location = new System.Drawing.Point(90, 114);
            this.BSN_TB.Margin = new System.Windows.Forms.Padding(2);
            this.BSN_TB.Name = "BSN_TB";
            this.BSN_TB.Size = new System.Drawing.Size(147, 20);
            this.BSN_TB.TabIndex = 30;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(82, 45);
            this.lastNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(155, 20);
            this.lastNameTB.TabIndex = 28;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(82, 22);
            this.firstNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(155, 20);
            this.firstNameTB.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Relationship Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "BSN Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date of Birth :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Waterfall_PRJ.Properties.Resources.TITLE_EMPLOYEE;
            this.pictureBox1.Location = new System.Drawing.Point(122, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ShiftManagementPage
            // 
            this.ShiftManagementPage.Controls.Add(this.label20);
            this.ShiftManagementPage.Controls.Add(this.workhrsLbl);
            this.ShiftManagementPage.Controls.Add(this.label19);
            this.ShiftManagementPage.Controls.Add(this.EmployeeCalendar);
            this.ShiftManagementPage.Controls.Add(this.pictureBox2);
            this.ShiftManagementPage.Controls.Add(this.ShiftSelectorCB);
            this.ShiftManagementPage.Controls.Add(this.label12);
            this.ShiftManagementPage.Controls.Add(this.AvailableEmployeesLB);
            this.ShiftManagementPage.Controls.Add(this.label14);
            this.ShiftManagementPage.Controls.Add(this.label15);
            this.ShiftManagementPage.Controls.Add(this.label16);
            this.ShiftManagementPage.Controls.Add(this.NightShiftLB);
            this.ShiftManagementPage.Controls.Add(this.EveningShiftLB);
            this.ShiftManagementPage.Controls.Add(this.MorningShiftLB);
            this.ShiftManagementPage.Controls.Add(this.btnAddShift);
            this.ShiftManagementPage.Location = new System.Drawing.Point(4, 22);
            this.ShiftManagementPage.Name = "ShiftManagementPage";
            this.ShiftManagementPage.Size = new System.Drawing.Size(543, 492);
            this.ShiftManagementPage.TabIndex = 2;
            this.ShiftManagementPage.Text = "Work-shift Management";
            this.ShiftManagementPage.UseVisualStyleBackColor = true;
            this.ShiftManagementPage.Enter += new System.EventHandler(this.ShiftManagementPage_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 468);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Assign:";
            // 
            // workhrsLbl
            // 
            this.workhrsLbl.AutoSize = true;
            this.workhrsLbl.Location = new System.Drawing.Point(127, 437);
            this.workhrsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workhrsLbl.Name = "workhrsLbl";
            this.workhrsLbl.Size = new System.Drawing.Size(0, 13);
            this.workhrsLbl.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 437);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Available work hours: ";
            // 
            // EmployeeCalendar
            // 
            this.EmployeeCalendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.EmployeeCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.EmployeeCalendar.Location = new System.Drawing.Point(15, 75);
            this.EmployeeCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeCalendar.MinimumSize = new System.Drawing.Size(196, 196);
            this.EmployeeCalendar.Name = "EmployeeCalendar";
            this.EmployeeCalendar.Size = new System.Drawing.Size(273, 205);
            this.EmployeeCalendar.TabIndex = 32;
            this.EmployeeCalendar.Text = "sfCalendar1";
            this.EmployeeCalendar.Click += new System.EventHandler(this.EmployeeCalendar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Waterfall_PRJ.Properties.Resources.TITLE_WORKSHIFT;
            this.pictureBox2.Location = new System.Drawing.Point(116, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // ShiftSelectorCB
            // 
            this.ShiftSelectorCB.FormattingEnabled = true;
            this.ShiftSelectorCB.Items.AddRange(new object[] {
            "Morning Shift",
            "Afternoon Shift",
            "Night Shift"});
            this.ShiftSelectorCB.Location = new System.Drawing.Point(58, 466);
            this.ShiftSelectorCB.Margin = new System.Windows.Forms.Padding(2);
            this.ShiftSelectorCB.Name = "ShiftSelectorCB";
            this.ShiftSelectorCB.Size = new System.Drawing.Size(155, 21);
            this.ShiftSelectorCB.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 284);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Available Employees";
            // 
            // AvailableEmployeesLB
            // 
            this.AvailableEmployeesLB.FormattingEnabled = true;
            this.AvailableEmployeesLB.Location = new System.Drawing.Point(15, 301);
            this.AvailableEmployeesLB.Margin = new System.Windows.Forms.Padding(2);
            this.AvailableEmployeesLB.Name = "AvailableEmployeesLB";
            this.AvailableEmployeesLB.Size = new System.Drawing.Size(279, 134);
            this.AvailableEmployeesLB.TabIndex = 28;
            this.AvailableEmployeesLB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AvailableEmployeesLB_MouseClick);
            this.AvailableEmployeesLB.SelectedIndexChanged += new System.EventHandler(this.AvailableEmployeesLB_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(330, 360);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Night Shift (17.00 - 21.00)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(330, 213);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Afternoon Shift (13.00 - 17.00)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(327, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Morning Shift (09.00 - 13.00)";
            // 
            // NightShiftLB
            // 
            this.NightShiftLB.FormattingEnabled = true;
            this.NightShiftLB.Location = new System.Drawing.Point(330, 378);
            this.NightShiftLB.Margin = new System.Windows.Forms.Padding(2);
            this.NightShiftLB.Name = "NightShiftLB";
            this.NightShiftLB.Size = new System.Drawing.Size(194, 108);
            this.NightShiftLB.TabIndex = 24;
            // 
            // EveningShiftLB
            // 
            this.EveningShiftLB.FormattingEnabled = true;
            this.EveningShiftLB.Location = new System.Drawing.Point(330, 231);
            this.EveningShiftLB.Margin = new System.Windows.Forms.Padding(2);
            this.EveningShiftLB.Name = "EveningShiftLB";
            this.EveningShiftLB.Size = new System.Drawing.Size(194, 108);
            this.EveningShiftLB.TabIndex = 23;
            // 
            // MorningShiftLB
            // 
            this.MorningShiftLB.FormattingEnabled = true;
            this.MorningShiftLB.Location = new System.Drawing.Point(330, 93);
            this.MorningShiftLB.Margin = new System.Windows.Forms.Padding(2);
            this.MorningShiftLB.Name = "MorningShiftLB";
            this.MorningShiftLB.Size = new System.Drawing.Size(194, 108);
            this.MorningShiftLB.TabIndex = 22;
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddShift.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShift.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddShift.Location = new System.Drawing.Point(216, 460);
            this.btnAddShift.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(77, 27);
            this.btnAddShift.TabIndex = 21;
            this.btnAddShift.Text = "ADD";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 526);
            this.Controls.Add(this.ManagementTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagementForm";
            this.Text = "Management";
            this.ManagementTabControl.ResumeLayout(false);
            this.EmployeeManagePage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ShiftManagementPage.ResumeLayout(false);
            this.ShiftManagementPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ManagementTabControl;
        private System.Windows.Forms.TabPage EmployeeManagePage;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.ListBox employeesLB;
        private System.Windows.Forms.ComboBox RoleCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox postalCodeTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox phoneNumberTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.ComboBox relationshipStatusCB;
        private System.Windows.Forms.TextBox BSN_TB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage ShiftManagementPage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox ShiftSelectorCB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox AvailableEmployeesLB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox NightShiftLB;
        private System.Windows.Forms.ListBox EveningShiftLB;
        private System.Windows.Forms.ListBox MorningShiftLB;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.ComboBox ContractCB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private Syncfusion.WinForms.Input.SfCalendar EmployeeCalendar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label workhrsLbl;
        private System.Windows.Forms.Label label19;
    }
}