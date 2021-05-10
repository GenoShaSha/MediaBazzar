
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.ManagementTabControl = new System.Windows.Forms.TabControl();
            this.EmployeeManagePage = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.removeBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.employeesLB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxPswd = new System.Windows.Forms.TextBox();
            this.lblPswd = new System.Windows.Forms.Label();
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
            this.tbxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.NightRB = new System.Windows.Forms.RadioButton();
            this.AfternoonRB = new System.Windows.Forms.RadioButton();
            this.MorningRB = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.sundayBtn = new System.Windows.Forms.Button();
            this.saturdayBtn = new System.Windows.Forms.Button();
            this.fridayBtn = new System.Windows.Forms.Button();
            this.thursdayBtn = new System.Windows.Forms.Button();
            this.wednesdayBtn = new System.Windows.Forms.Button();
            this.tuesdayBtn = new System.Windows.Forms.Button();
            this.mondayBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.workhrsLbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AvailableEmployeesLB = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NightShiftLB = new System.Windows.Forms.ListBox();
            this.AfternoonShiftLB = new System.Windows.Forms.ListBox();
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
            this.ManagementTabControl.Size = new System.Drawing.Size(661, 577);
            this.ManagementTabControl.TabIndex = 35;
            // 
            // EmployeeManagePage
            // 
            this.EmployeeManagePage.Controls.Add(this.btnLogout);
            this.EmployeeManagePage.Controls.Add(this.removeBTN);
            this.EmployeeManagePage.Controls.Add(this.addBTN);
            this.EmployeeManagePage.Controls.Add(this.updateBTN);
            this.EmployeeManagePage.Controls.Add(this.employeesLB);
            this.EmployeeManagePage.Controls.Add(this.groupBox2);
            this.EmployeeManagePage.Controls.Add(this.groupBox1);
            this.EmployeeManagePage.Controls.Add(this.pictureBox1);
            this.EmployeeManagePage.Location = new System.Drawing.Point(4, 22);
            this.EmployeeManagePage.Name = "EmployeeManagePage";
            this.EmployeeManagePage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.EmployeeManagePage.Size = new System.Drawing.Size(653, 551);
            this.EmployeeManagePage.TabIndex = 1;
            this.EmployeeManagePage.Text = "Employee Management";
            this.EmployeeManagePage.UseVisualStyleBackColor = true;
            this.EmployeeManagePage.Click += new System.EventHandler(this.EmployeeManagePage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(465, 21);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 27);
            this.btnLogout.TabIndex = 44;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // removeBTN
            // 
            this.removeBTN.Location = new System.Drawing.Point(447, 467);
            this.removeBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(157, 27);
            this.removeBTN.TabIndex = 43;
            this.removeBTN.Text = "REMOVE";
            this.removeBTN.UseVisualStyleBackColor = true;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(338, 468);
            this.addBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(105, 27);
            this.addBTN.TabIndex = 42;
            this.addBTN.Text = "Admission Form";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(5, 490);
            this.updateBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(252, 27);
            this.updateBTN.TabIndex = 40;
            this.updateBTN.Text = "UPDATE";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // employeesLB
            // 
            this.employeesLB.FormattingEnabled = true;
            this.employeesLB.Location = new System.Drawing.Point(338, 79);
            this.employeesLB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeesLB.Name = "employeesLB";
            this.employeesLB.Size = new System.Drawing.Size(267, 381);
            this.employeesLB.TabIndex = 39;
            this.employeesLB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.employeesLB_MouseClick_1);
            this.employeesLB.SelectedIndexChanged += new System.EventHandler(this.employeesLB_SelectedIndexChanged);
            this.employeesLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employeesLB_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxPswd);
            this.groupBox2.Controls.Add(this.lblPswd);
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
            this.groupBox2.Location = new System.Drawing.Point(2, 259);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(252, 228);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // tbxPswd
            // 
            this.tbxPswd.Location = new System.Drawing.Point(74, 11);
            this.tbxPswd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPswd.Name = "tbxPswd";
            this.tbxPswd.Size = new System.Drawing.Size(162, 20);
            this.tbxPswd.TabIndex = 43;
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Location = new System.Drawing.Point(15, 14);
            this.lblPswd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(59, 13);
            this.lblPswd.TabIndex = 42;
            this.lblPswd.Text = "Password :";
            // 
            // ContractCB
            // 
            this.ContractCB.FormattingEnabled = true;
            this.ContractCB.Items.AddRange(new object[] {
            "Full Time (40 work hours)",
            "Part Time (30 work hours)",
            "Part Time (20 work hours)"});
            this.ContractCB.Location = new System.Drawing.Point(91, 197);
            this.ContractCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractCB.Name = "ContractCB";
            this.ContractCB.Size = new System.Drawing.Size(146, 21);
            this.ContractCB.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 197);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Contract type:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 176);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Role :";
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(70, 151);
            this.countryTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(167, 20);
            this.countryTB.TabIndex = 38;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(52, 128);
            this.cityTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(186, 20);
            this.cityTB.TabIndex = 37;
            // 
            // postalCodeTB
            // 
            this.postalCodeTB.Location = new System.Drawing.Point(91, 105);
            this.postalCodeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postalCodeTB.Name = "postalCodeTB";
            this.postalCodeTB.Size = new System.Drawing.Size(147, 20);
            this.postalCodeTB.TabIndex = 36;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(70, 82);
            this.addressTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(167, 20);
            this.addressTB.TabIndex = 35;
            // 
            // RoleCB
            // 
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Items.AddRange(new object[] {
            "Administrator",
            "Floor Manager",
            "Floor Staff",
            "Warehouse Manager",
            "Warehouse Staff"});
            this.RoleCB.Location = new System.Drawing.Point(117, 173);
            this.RoleCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(121, 21);
            this.RoleCB.TabIndex = 38;
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.Location = new System.Drawing.Point(104, 60);
            this.phoneNumberTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(134, 20);
            this.phoneNumberTB.TabIndex = 34;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(58, 37);
            this.emailTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(180, 20);
            this.emailTB.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Postal Code :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Country :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "City :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Phone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxID);
            this.groupBox1.Controls.Add(this.lblID);
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
            this.groupBox1.Location = new System.Drawing.Point(54, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(252, 193);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Essential Information";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(35, 20);
            this.tbxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(202, 20);
            this.tbxID.TabIndex = 37;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 23);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID :";
            // 
            // GenderCB
            // 
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary"});
            this.GenderCB.Location = new System.Drawing.Point(124, 89);
            this.GenderCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(115, 21);
            this.GenderCB.TabIndex = 35;
            this.GenderCB.SelectedIndexChanged += new System.EventHandler(this.GenderCB_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Gender:";
            // 
            // DOBPicker
            // 
            this.DOBPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DOBPicker.Location = new System.Drawing.Point(83, 113);
            this.DOBPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.relationshipStatusCB.Location = new System.Drawing.Point(124, 158);
            this.relationshipStatusCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.relationshipStatusCB.Name = "relationshipStatusCB";
            this.relationshipStatusCB.Size = new System.Drawing.Size(115, 21);
            this.relationshipStatusCB.TabIndex = 32;
            // 
            // BSN_TB
            // 
            this.BSN_TB.Location = new System.Drawing.Point(92, 136);
            this.BSN_TB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BSN_TB.Name = "BSN_TB";
            this.BSN_TB.Size = new System.Drawing.Size(147, 20);
            this.BSN_TB.TabIndex = 30;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(83, 67);
            this.lastNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(155, 20);
            this.lastNameTB.TabIndex = 28;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(83, 44);
            this.firstNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(155, 20);
            this.firstNameTB.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Relationship Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "BSN Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date of Birth :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ShiftManagementPage
            // 
            this.ShiftManagementPage.Controls.Add(this.BackBtn);
            this.ShiftManagementPage.Controls.Add(this.dateLbl);
            this.ShiftManagementPage.Controls.Add(this.label28);
            this.ShiftManagementPage.Controls.Add(this.label27);
            this.ShiftManagementPage.Controls.Add(this.NightRB);
            this.ShiftManagementPage.Controls.Add(this.AfternoonRB);
            this.ShiftManagementPage.Controls.Add(this.MorningRB);
            this.ShiftManagementPage.Controls.Add(this.label26);
            this.ShiftManagementPage.Controls.Add(this.label25);
            this.ShiftManagementPage.Controls.Add(this.label24);
            this.ShiftManagementPage.Controls.Add(this.label23);
            this.ShiftManagementPage.Controls.Add(this.label22);
            this.ShiftManagementPage.Controls.Add(this.label21);
            this.ShiftManagementPage.Controls.Add(this.nextBtn);
            this.ShiftManagementPage.Controls.Add(this.sundayBtn);
            this.ShiftManagementPage.Controls.Add(this.saturdayBtn);
            this.ShiftManagementPage.Controls.Add(this.fridayBtn);
            this.ShiftManagementPage.Controls.Add(this.thursdayBtn);
            this.ShiftManagementPage.Controls.Add(this.wednesdayBtn);
            this.ShiftManagementPage.Controls.Add(this.tuesdayBtn);
            this.ShiftManagementPage.Controls.Add(this.mondayBtn);
            this.ShiftManagementPage.Controls.Add(this.label20);
            this.ShiftManagementPage.Controls.Add(this.workhrsLbl);
            this.ShiftManagementPage.Controls.Add(this.label19);
            this.ShiftManagementPage.Controls.Add(this.label12);
            this.ShiftManagementPage.Controls.Add(this.pictureBox2);
            this.ShiftManagementPage.Controls.Add(this.AvailableEmployeesLB);
            this.ShiftManagementPage.Controls.Add(this.label14);
            this.ShiftManagementPage.Controls.Add(this.label15);
            this.ShiftManagementPage.Controls.Add(this.label16);
            this.ShiftManagementPage.Controls.Add(this.NightShiftLB);
            this.ShiftManagementPage.Controls.Add(this.AfternoonShiftLB);
            this.ShiftManagementPage.Controls.Add(this.MorningShiftLB);
            this.ShiftManagementPage.Controls.Add(this.btnAddShift);
            this.ShiftManagementPage.Location = new System.Drawing.Point(4, 22);
            this.ShiftManagementPage.Name = "ShiftManagementPage";
            this.ShiftManagementPage.Size = new System.Drawing.Size(653, 551);
            this.ShiftManagementPage.TabIndex = 2;
            this.ShiftManagementPage.Text = "Work-shift Management";
            this.ShiftManagementPage.UseVisualStyleBackColor = true;
            this.ShiftManagementPage.Enter += new System.EventHandler(this.ShiftManagementPage_Enter);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(2, 79);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(42, 29);
            this.BackBtn.TabIndex = 57;
            this.BackBtn.Text = "<<<";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(496, 271);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(0, 13);
            this.dateLbl.TabIndex = 56;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(410, 335);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 13);
            this.label28.TabIndex = 55;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(496, 235);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 54;
            this.label27.Text = "Selected date:";
            // 
            // NightRB
            // 
            this.NightRB.AutoSize = true;
            this.NightRB.Location = new System.Drawing.Point(88, 235);
            this.NightRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NightRB.Name = "NightRB";
            this.NightRB.Size = new System.Drawing.Size(50, 17);
            this.NightRB.TabIndex = 53;
            this.NightRB.TabStop = true;
            this.NightRB.Text = "Night";
            this.NightRB.UseVisualStyleBackColor = true;
            this.NightRB.CheckedChanged += new System.EventHandler(this.NightRB_CheckedChanged);
            // 
            // AfternoonRB
            // 
            this.AfternoonRB.AutoSize = true;
            this.AfternoonRB.Location = new System.Drawing.Point(88, 213);
            this.AfternoonRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AfternoonRB.Name = "AfternoonRB";
            this.AfternoonRB.Size = new System.Drawing.Size(71, 17);
            this.AfternoonRB.TabIndex = 52;
            this.AfternoonRB.TabStop = true;
            this.AfternoonRB.Text = "Afternoon";
            this.AfternoonRB.UseVisualStyleBackColor = true;
            this.AfternoonRB.CheckedChanged += new System.EventHandler(this.AfternoonRB_CheckedChanged);
            // 
            // MorningRB
            // 
            this.MorningRB.AutoSize = true;
            this.MorningRB.Location = new System.Drawing.Point(88, 191);
            this.MorningRB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MorningRB.Name = "MorningRB";
            this.MorningRB.Size = new System.Drawing.Size(63, 17);
            this.MorningRB.TabIndex = 51;
            this.MorningRB.TabStop = true;
            this.MorningRB.Text = "Morning";
            this.MorningRB.UseVisualStyleBackColor = true;
            this.MorningRB.CheckedChanged += new System.EventHandler(this.MorningRB_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(57, 56);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 13);
            this.label26.TabIndex = 50;
            this.label26.Text = "Sunday";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(530, 56);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 49;
            this.label25.Text = "Saturday";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(463, 56);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "Friday";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(370, 56);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Thursday";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(285, 56);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Wednesday";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(213, 56);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "Tuesday";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(596, 77);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(56, 32);
            this.nextBtn.TabIndex = 43;
            this.nextBtn.Text = ">>>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // sundayBtn
            // 
            this.sundayBtn.Location = new System.Drawing.Point(44, 72);
            this.sundayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sundayBtn.Name = "sundayBtn";
            this.sundayBtn.Size = new System.Drawing.Size(74, 43);
            this.sundayBtn.TabIndex = 42;
            this.sundayBtn.Text = "12/22/2021";
            this.sundayBtn.UseVisualStyleBackColor = true;
            this.sundayBtn.Click += new System.EventHandler(this.sundayBtn_Click);
            // 
            // saturdayBtn
            // 
            this.saturdayBtn.Location = new System.Drawing.Point(518, 72);
            this.saturdayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saturdayBtn.Name = "saturdayBtn";
            this.saturdayBtn.Size = new System.Drawing.Size(74, 43);
            this.saturdayBtn.TabIndex = 41;
            this.saturdayBtn.Text = "12/22/2021";
            this.saturdayBtn.UseVisualStyleBackColor = true;
            this.saturdayBtn.Click += new System.EventHandler(this.saturdayBtn_Click);
            // 
            // fridayBtn
            // 
            this.fridayBtn.Location = new System.Drawing.Point(439, 72);
            this.fridayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fridayBtn.Name = "fridayBtn";
            this.fridayBtn.Size = new System.Drawing.Size(74, 43);
            this.fridayBtn.TabIndex = 40;
            this.fridayBtn.Text = "12/22/2021";
            this.fridayBtn.UseVisualStyleBackColor = true;
            this.fridayBtn.Click += new System.EventHandler(this.fridayBtn_Click);
            // 
            // thursdayBtn
            // 
            this.thursdayBtn.Location = new System.Drawing.Point(360, 72);
            this.thursdayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thursdayBtn.Name = "thursdayBtn";
            this.thursdayBtn.Size = new System.Drawing.Size(74, 43);
            this.thursdayBtn.TabIndex = 39;
            this.thursdayBtn.Text = "12/22/2021";
            this.thursdayBtn.UseVisualStyleBackColor = true;
            this.thursdayBtn.Click += new System.EventHandler(this.thursdayBtn_Click);
            // 
            // wednesdayBtn
            // 
            this.wednesdayBtn.Location = new System.Drawing.Point(280, 72);
            this.wednesdayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wednesdayBtn.Name = "wednesdayBtn";
            this.wednesdayBtn.Size = new System.Drawing.Size(74, 43);
            this.wednesdayBtn.TabIndex = 38;
            this.wednesdayBtn.Text = "12/22/2021";
            this.wednesdayBtn.UseVisualStyleBackColor = true;
            this.wednesdayBtn.Click += new System.EventHandler(this.wednesdayBtn_Click);
            // 
            // tuesdayBtn
            // 
            this.tuesdayBtn.Location = new System.Drawing.Point(201, 72);
            this.tuesdayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tuesdayBtn.Name = "tuesdayBtn";
            this.tuesdayBtn.Size = new System.Drawing.Size(74, 43);
            this.tuesdayBtn.TabIndex = 37;
            this.tuesdayBtn.Text = "12/22/2021";
            this.tuesdayBtn.UseVisualStyleBackColor = true;
            this.tuesdayBtn.Click += new System.EventHandler(this.tuesdayBtn_Click);
            // 
            // mondayBtn
            // 
            this.mondayBtn.Location = new System.Drawing.Point(122, 72);
            this.mondayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mondayBtn.Name = "mondayBtn";
            this.mondayBtn.Size = new System.Drawing.Size(74, 43);
            this.mondayBtn.TabIndex = 36;
            this.mondayBtn.Text = "12/22/2021";
            this.mondayBtn.UseVisualStyleBackColor = true;
            this.mondayBtn.Click += new System.EventHandler(this.mondayBtn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(101, 166);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Assign:";
            // 
            // workhrsLbl
            // 
            this.workhrsLbl.AutoSize = true;
            this.workhrsLbl.Location = new System.Drawing.Point(170, 357);
            this.workhrsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workhrsLbl.Name = "workhrsLbl";
            this.workhrsLbl.Size = new System.Drawing.Size(0, 13);
            this.workhrsLbl.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 496);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Available work hours: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(250, 175);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Available Employees";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Waterfall_PRJ.Properties.Resources.TITLE_WORKSHIFT;
            this.pictureBox2.Location = new System.Drawing.Point(116, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // AvailableEmployeesLB
            // 
            this.AvailableEmployeesLB.FormattingEnabled = true;
            this.AvailableEmployeesLB.Location = new System.Drawing.Point(182, 200);
            this.AvailableEmployeesLB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label14.Location = new System.Drawing.Point(459, 380);
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
            this.label15.Location = new System.Drawing.Point(235, 380);
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
            this.label16.Location = new System.Drawing.Point(26, 380);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Morning Shift (09.00 - 13.00)";
            // 
            // NightShiftLB
            // 
            this.NightShiftLB.FormattingEnabled = true;
            this.NightShiftLB.Location = new System.Drawing.Point(445, 407);
            this.NightShiftLB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NightShiftLB.Name = "NightShiftLB";
            this.NightShiftLB.Size = new System.Drawing.Size(194, 108);
            this.NightShiftLB.TabIndex = 24;
            // 
            // AfternoonShiftLB
            // 
            this.AfternoonShiftLB.FormattingEnabled = true;
            this.AfternoonShiftLB.Location = new System.Drawing.Point(238, 407);
            this.AfternoonShiftLB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AfternoonShiftLB.Name = "AfternoonShiftLB";
            this.AfternoonShiftLB.Size = new System.Drawing.Size(194, 108);
            this.AfternoonShiftLB.TabIndex = 23;
            // 
            // MorningShiftLB
            // 
            this.MorningShiftLB.FormattingEnabled = true;
            this.MorningShiftLB.Location = new System.Drawing.Point(29, 407);
            this.MorningShiftLB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MorningShiftLB.Name = "MorningShiftLB";
            this.MorningShiftLB.Size = new System.Drawing.Size(194, 108);
            this.MorningShiftLB.TabIndex = 22;
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddShift.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShift.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddShift.Location = new System.Drawing.Point(383, 344);
            this.btnAddShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(77, 27);
            this.btnAddShift.TabIndex = 21;
            this.btnAddShift.Text = "ADD";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click_1);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 646);
            this.Controls.Add(this.ManagementTabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox AvailableEmployeesLB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox NightShiftLB;
        private System.Windows.Forms.ListBox AfternoonShiftLB;
        private System.Windows.Forms.ListBox MorningShiftLB;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.ComboBox ContractCB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label workhrsLbl;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button mondayBtn;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button sundayBtn;
        private System.Windows.Forms.Button saturdayBtn;
        private System.Windows.Forms.Button fridayBtn;
        private System.Windows.Forms.Button thursdayBtn;
        private System.Windows.Forms.Button wednesdayBtn;
        private System.Windows.Forms.Button tuesdayBtn;
        private System.Windows.Forms.RadioButton NightRB;
        private System.Windows.Forms.RadioButton AfternoonRB;
        private System.Windows.Forms.RadioButton MorningRB;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox tbxPswd;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label lblID;
    }
}