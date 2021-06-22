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
            this.btnRmv = new System.Windows.Forms.Button();
            this.tbxUpName = new System.Windows.Forms.TextBox();
            this.lblRmvID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tbxAddDep = new System.Windows.Forms.TextBox();
            this.lblDepName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxRmvID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxDepartment = new System.Windows.Forms.ListBox();
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
            this.groupBox3.Location = new System.Drawing.Point(25, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 126);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Update Department";
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(246, 69);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(100, 39);
            this.btnRmv.TabIndex = 15;
            this.btnRmv.Text = "REMOVE";
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // tbxUpName
            // 
            this.tbxUpName.Location = new System.Drawing.Point(165, 29);
            this.tbxUpName.Name = "tbxUpName";
            this.tbxUpName.Size = new System.Drawing.Size(196, 22);
            this.tbxUpName.TabIndex = 15;
            // 
            // lblRmvID
            // 
            this.lblRmvID.AutoSize = true;
            this.lblRmvID.Location = new System.Drawing.Point(28, 32);
            this.lblRmvID.Name = "lblRmvID";
            this.lblRmvID.Size = new System.Drawing.Size(131, 17);
            this.lblRmvID.TabIndex = 15;
            this.lblRmvID.Text = "Department Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStock);
            this.groupBox1.Controls.Add(this.tbxAddDep);
            this.groupBox1.Controls.Add(this.lblDepName);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 121);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Department";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(273, 64);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(73, 39);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "ADD";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tbxAddDep
            // 
            this.tbxAddDep.Location = new System.Drawing.Point(165, 27);
            this.tbxAddDep.Name = "tbxAddDep";
            this.tbxAddDep.Size = new System.Drawing.Size(196, 22);
            this.tbxAddDep.TabIndex = 40;
            // 
            // lblDepName
            // 
            this.lblDepName.AutoSize = true;
            this.lblDepName.Location = new System.Drawing.Point(28, 30);
            this.lblDepName.Name = "lblDepName";
            this.lblDepName.Size = new System.Drawing.Size(131, 17);
            this.lblDepName.TabIndex = 43;
            this.lblDepName.Text = "Department Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRmv);
            this.groupBox2.Controls.Add(this.tbxRmvID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(25, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 126);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Department";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(246, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 39);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxRmvID
            // 
            this.tbxRmvID.Location = new System.Drawing.Point(63, 32);
            this.tbxRmvID.Name = "tbxRmvID";
            this.tbxRmvID.Size = new System.Drawing.Size(298, 22);
            this.tbxRmvID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID :";
            // 
            // lbxDepartment
            // 
            this.lbxDepartment.FormattingEnabled = true;
            this.lbxDepartment.ItemHeight = 16;
            this.lbxDepartment.Location = new System.Drawing.Point(445, 76);
            this.lbxDepartment.Name = "lbxDepartment";
            this.lbxDepartment.Size = new System.Drawing.Size(311, 340);
            this.lbxDepartment.TabIndex = 73;
            this.lbxDepartment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxDepartment_MouseClick);
            // 
            // CRUDdepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxDepartment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
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
    }
}