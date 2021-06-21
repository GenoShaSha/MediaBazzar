
namespace MediaBazzar
{
    partial class ProductRequestFloorForm
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
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIDOutLbl = new System.Windows.Forms.Label();
            this.StockRequestLB = new System.Windows.Forms.ListBox();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeIDLbl = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbxArtNumb = new System.Windows.Forms.TextBox();
            this.lblArtNumb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(309, 322);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(169, 22);
            this.AmountTb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount";
            // 
            // EmployeeIDOutLbl
            // 
            this.EmployeeIDOutLbl.AutoSize = true;
            this.EmployeeIDOutLbl.Location = new System.Drawing.Point(134, 327);
            this.EmployeeIDOutLbl.Name = "EmployeeIDOutLbl";
            this.EmployeeIDOutLbl.Size = new System.Drawing.Size(0, 17);
            this.EmployeeIDOutLbl.TabIndex = 9;
            // 
            // StockRequestLB
            // 
            this.StockRequestLB.FormattingEnabled = true;
            this.StockRequestLB.ItemHeight = 16;
            this.StockRequestLB.Location = new System.Drawing.Point(40, 99);
            this.StockRequestLB.Name = "StockRequestLB";
            this.StockRequestLB.Size = new System.Drawing.Size(450, 196);
            this.StockRequestLB.TabIndex = 7;
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(40, 362);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(450, 42);
            this.RequestBtn.TabIndex = 6;
            this.RequestBtn.Text = "Send Request";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // EmployeeIDLbl
            // 
            this.EmployeeIDLbl.AutoSize = true;
            this.EmployeeIDLbl.Location = new System.Drawing.Point(37, 327);
            this.EmployeeIDLbl.Name = "EmployeeIDLbl";
            this.EmployeeIDLbl.Size = new System.Drawing.Size(91, 17);
            this.EmployeeIDLbl.TabIndex = 12;
            this.EmployeeIDLbl.Text = "Employee ID:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(40, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 35);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbxArtNumb
            // 
            this.tbxArtNumb.Location = new System.Drawing.Point(142, 69);
            this.tbxArtNumb.Name = "tbxArtNumb";
            this.tbxArtNumb.Size = new System.Drawing.Size(137, 22);
            this.tbxArtNumb.TabIndex = 23;
            this.tbxArtNumb.TextChanged += new System.EventHandler(this.tbxArtNumb_TextChanged);
            // 
            // lblArtNumb
            // 
            this.lblArtNumb.AutoSize = true;
            this.lblArtNumb.Location = new System.Drawing.Point(37, 72);
            this.lblArtNumb.Name = "lblArtNumb";
            this.lblArtNumb.Size = new System.Drawing.Size(99, 17);
            this.lblArtNumb.TabIndex = 22;
            this.lblArtNumb.Text = "Art. Numbers: ";
            // 
            // ProductRequestFloorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 429);
            this.Controls.Add(this.tbxArtNumb);
            this.Controls.Add(this.lblArtNumb);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeIDLbl);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeIDOutLbl);
            this.Controls.Add(this.StockRequestLB);
            this.Controls.Add(this.RequestBtn);
            this.Name = "ProductRequestFloorForm";
            this.Text = "ProductRequestFloorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmployeeIDOutLbl;
        private System.Windows.Forms.ListBox StockRequestLB;
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EmployeeIDLbl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbxArtNumb;
        private System.Windows.Forms.Label lblArtNumb;
    }
}