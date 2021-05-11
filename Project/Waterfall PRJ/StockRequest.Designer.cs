
namespace Waterfall_PRJ
{
    partial class StockRequest
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
            this.lbxStockWarehouse = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblAmountRequest = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.lblgoodID = new System.Windows.Forms.Label();
            this.tbxGID = new System.Windows.Forms.TextBox();
            this.tbxEmpId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxStockWarehouse
            // 
            this.lbxStockWarehouse.FormattingEnabled = true;
            this.lbxStockWarehouse.ItemHeight = 16;
            this.lbxStockWarehouse.Location = new System.Drawing.Point(36, 99);
            this.lbxStockWarehouse.Name = "lbxStockWarehouse";
            this.lbxStockWarehouse.Size = new System.Drawing.Size(591, 276);
            this.lbxStockWarehouse.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Waterfall_PRJ.Properties.Resources.productstock_warehouse;
            this.pictureBox1.Location = new System.Drawing.Point(80, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(515, 400);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(112, 55);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lblAmountRequest
            // 
            this.lblAmountRequest.AutoSize = true;
            this.lblAmountRequest.Location = new System.Drawing.Point(55, 430);
            this.lblAmountRequest.Name = "lblAmountRequest";
            this.lblAmountRequest.Size = new System.Drawing.Size(64, 17);
            this.lblAmountRequest.TabIndex = 4;
            this.lblAmountRequest.Text = "Amount :";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(55, 459);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(97, 17);
            this.lblEmployeeID.TabIndex = 7;
            this.lblEmployeeID.Text = "Employee  Id :";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(125, 427);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(119, 22);
            this.tbxAmount.TabIndex = 9;
            // 
            // lblgoodID
            // 
            this.lblgoodID.AutoSize = true;
            this.lblgoodID.Location = new System.Drawing.Point(55, 400);
            this.lblgoodID.Name = "lblgoodID";
            this.lblgoodID.Size = new System.Drawing.Size(68, 17);
            this.lblgoodID.TabIndex = 10;
            this.lblgoodID.Text = "Good ID :";
            // 
            // tbxGID
            // 
            this.tbxGID.Location = new System.Drawing.Point(125, 397);
            this.tbxGID.Name = "tbxGID";
            this.tbxGID.Size = new System.Drawing.Size(119, 22);
            this.tbxGID.TabIndex = 11;
            // 
            // tbxEmpId
            // 
            this.tbxEmpId.Location = new System.Drawing.Point(158, 456);
            this.tbxEmpId.Name = "tbxEmpId";
            this.tbxEmpId.Size = new System.Drawing.Size(86, 22);
            this.tbxEmpId.TabIndex = 12;
            // 
            // StockRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 508);
            this.Controls.Add(this.tbxEmpId);
            this.Controls.Add(this.tbxGID);
            this.Controls.Add(this.lblgoodID);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblAmountRequest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbxStockWarehouse);
            this.Name = "StockRequest";
            this.Text = "StockRequestWarehouse";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbxStockWarehouse;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblAmountRequest;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label lblgoodID;
        private System.Windows.Forms.TextBox tbxGID;
        private System.Windows.Forms.TextBox tbxEmpId;
    }
}