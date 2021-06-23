namespace MediaBazzar
{
    partial class CRUDdepartment
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxUpName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRmvID = new System.Windows.Forms.Label();
            this.btnRmv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tbxAddDep = new System.Windows.Forms.TextBox();
            this.lblDepName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxRmvID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxDepartment = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxUpName);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.lblRmvID);
            this.groupBox3.Location = new System.Drawing.Point(19, 125);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(295, 102);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Update Department";
            // 
            // tbxUpName
            // 
            this.tbxUpName.Location = new System.Drawing.Point(124, 24);
            this.tbxUpName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxUpName.Name = "tbxUpName";
            this.tbxUpName.Size = new System.Drawing.Size(148, 20);
            this.tbxUpName.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(184, 54);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRmvID
            // 
            this.lblRmvID.AutoSize = true;
            this.lblRmvID.Location = new System.Drawing.Point(21, 26);
            this.lblRmvID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRmvID.Name = "lblRmvID";
            this.lblRmvID.Size = new System.Drawing.Size(99, 13);
            this.lblRmvID.TabIndex = 15;
            this.lblRmvID.Text = "Department Name :";
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(184, 56);
            this.btnRmv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(75, 32);
            this.btnRmv.TabIndex = 15;
            this.btnRmv.Text = "REMOVE";
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStock);
            this.groupBox1.Controls.Add(this.tbxAddDep);
            this.groupBox1.Controls.Add(this.lblDepName);
            this.groupBox1.Location = new System.Drawing.Point(19, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(295, 98);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Department";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(205, 52);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(55, 32);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "ADD";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tbxAddDep
            // 
            this.tbxAddDep.Location = new System.Drawing.Point(124, 22);
            this.tbxAddDep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAddDep.Name = "tbxAddDep";
            this.tbxAddDep.Size = new System.Drawing.Size(148, 20);
            this.tbxAddDep.TabIndex = 40;
            // 
            // lblDepName
            // 
            this.lblDepName.AutoSize = true;
            this.lblDepName.Location = new System.Drawing.Point(21, 24);
            this.lblDepName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepName.Name = "lblDepName";
            this.lblDepName.Size = new System.Drawing.Size(99, 13);
            this.lblDepName.TabIndex = 43;
            this.lblDepName.Text = "Department Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRmv);
            this.groupBox2.Controls.Add(this.tbxRmvID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(19, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(295, 102);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Department";
            // 
            // tbxRmvID
            // 
            this.tbxRmvID.Location = new System.Drawing.Point(47, 26);
            this.tbxRmvID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxRmvID.Name = "tbxRmvID";
            this.tbxRmvID.Size = new System.Drawing.Size(224, 20);
            this.tbxRmvID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID :";
            // 
            // lbxDepartment
            // 
            this.lbxDepartment.FormattingEnabled = true;
            this.lbxDepartment.Location = new System.Drawing.Point(334, 62);
            this.lbxDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxDepartment.Name = "lbxDepartment";
            this.lbxDepartment.Size = new System.Drawing.Size(234, 277);
            this.lbxDepartment.TabIndex = 73;
            this.lbxDepartment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxDepartment_MouseClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(513, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 32);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CRUDdepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbxDepartment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CRUDdepartment";
            this.Text = "CRUDdepartment";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.TextBox tbxUpName;
        private System.Windows.Forms.Label lblRmvID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox tbxAddDep;
        private System.Windows.Forms.Label lblDepName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxRmvID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxDepartment;
        private System.Windows.Forms.Button btnBack;
    }
}