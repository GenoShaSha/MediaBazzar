
namespace Waterfall_PRJ
{
    partial class StockRequests
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
            this.RequestBtn = new System.Windows.Forms.Button();
            this.StockRequestLB = new System.Windows.Forms.ListBox();
            this.EmployeeIDLbl = new System.Windows.Forms.Label();
            this.EmployeeIDOutLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(588, 378);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(102, 60);
            this.RequestBtn.TabIndex = 0;
            this.RequestBtn.Text = "Send Request";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // StockRequestLB
            // 
            this.StockRequestLB.FormattingEnabled = true;
            this.StockRequestLB.ItemHeight = 16;
            this.StockRequestLB.Location = new System.Drawing.Point(66, 32);
            this.StockRequestLB.Name = "StockRequestLB";
            this.StockRequestLB.Size = new System.Drawing.Size(624, 340);
            this.StockRequestLB.TabIndex = 1;
            // 
            // EmployeeIDLbl
            // 
            this.EmployeeIDLbl.AutoSize = true;
            this.EmployeeIDLbl.Location = new System.Drawing.Point(63, 390);
            this.EmployeeIDLbl.Name = "EmployeeIDLbl";
            this.EmployeeIDLbl.Size = new System.Drawing.Size(91, 17);
            this.EmployeeIDLbl.TabIndex = 2;
            this.EmployeeIDLbl.Text = "Employee ID:";
            // 
            // EmployeeIDOutLbl
            // 
            this.EmployeeIDOutLbl.AutoSize = true;
            this.EmployeeIDOutLbl.Location = new System.Drawing.Point(160, 390);
            this.EmployeeIDOutLbl.Name = "EmployeeIDOutLbl";
            this.EmployeeIDOutLbl.Size = new System.Drawing.Size(0, 17);
            this.EmployeeIDOutLbl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(374, 390);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(100, 22);
            this.AmountTb.TabIndex = 5;
            // 
            // StockRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeIDOutLbl);
            this.Controls.Add(this.EmployeeIDLbl);
            this.Controls.Add(this.StockRequestLB);
            this.Controls.Add(this.RequestBtn);
            this.Name = "StockRequests";
            this.Text = "StockRequests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.ListBox StockRequestLB;
        private System.Windows.Forms.Label EmployeeIDLbl;
        private System.Windows.Forms.Label EmployeeIDOutLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountTb;
    }
}