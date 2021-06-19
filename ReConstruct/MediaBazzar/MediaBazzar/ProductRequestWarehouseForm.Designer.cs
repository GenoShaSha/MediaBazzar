
namespace MediaBazzar
{
    partial class ProductRequestWarehouseForm
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
            this.EmployeeIDOutLbl = new System.Windows.Forms.Label();
            this.EmployeeIDLbl = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StockRequestLB = new System.Windows.Forms.ListBox();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeIDOutLbl
            // 
            this.EmployeeIDOutLbl.AutoSize = true;
            this.EmployeeIDOutLbl.Location = new System.Drawing.Point(126, 322);
            this.EmployeeIDOutLbl.Name = "EmployeeIDOutLbl";
            this.EmployeeIDOutLbl.Size = new System.Drawing.Size(0, 17);
            this.EmployeeIDOutLbl.TabIndex = 19;
            // 
            // EmployeeIDLbl
            // 
            this.EmployeeIDLbl.AutoSize = true;
            this.EmployeeIDLbl.Location = new System.Drawing.Point(29, 322);
            this.EmployeeIDLbl.Name = "EmployeeIDLbl";
            this.EmployeeIDLbl.Size = new System.Drawing.Size(91, 17);
            this.EmployeeIDLbl.TabIndex = 18;
            this.EmployeeIDLbl.Text = "Employee ID:";
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(313, 319);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(169, 22);
            this.AmountTb.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Amount";
            // 
            // StockRequestLB
            // 
            this.StockRequestLB.FormattingEnabled = true;
            this.StockRequestLB.ItemHeight = 16;
            this.StockRequestLB.Location = new System.Drawing.Point(32, 80);
            this.StockRequestLB.Name = "StockRequestLB";
            this.StockRequestLB.Size = new System.Drawing.Size(450, 228);
            this.StockRequestLB.TabIndex = 15;
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(32, 358);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(450, 35);
            this.RequestBtn.TabIndex = 14;
            this.RequestBtn.Text = "Send Request";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 35);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProductRequestWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 445);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.EmployeeIDOutLbl);
            this.Controls.Add(this.EmployeeIDLbl);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockRequestLB);
            this.Controls.Add(this.RequestBtn);
            this.Name = "ProductRequestWarehouseForm";
            this.Text = "ProductRequestWarehouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeIDOutLbl;
        private System.Windows.Forms.Label EmployeeIDLbl;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StockRequestLB;
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Button btnBack;
    }
}