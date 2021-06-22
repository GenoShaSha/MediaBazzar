
namespace MediaBazzar
{
    partial class RestockWarehouseProductManagementForm
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
            this.btnApproved = new System.Windows.Forms.Button();
            this.lblReqStock = new System.Windows.Forms.Label();
            this.lbxRequestStock = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApproved
            // 
            this.btnApproved.Location = new System.Drawing.Point(41, 306);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(432, 30);
            this.btnApproved.TabIndex = 65;
            this.btnApproved.Text = "APPROVED";
            this.btnApproved.UseVisualStyleBackColor = true;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // lblReqStock
            // 
            this.lblReqStock.AutoSize = true;
            this.lblReqStock.Location = new System.Drawing.Point(41, 82);
            this.lblReqStock.Name = "lblReqStock";
            this.lblReqStock.Size = new System.Drawing.Size(233, 17);
            this.lblReqStock.TabIndex = 64;
            this.lblReqStock.Text = "List of Warehouse Product Request";
            // 
            // lbxRequestStock
            // 
            this.lbxRequestStock.FormattingEnabled = true;
            this.lbxRequestStock.ItemHeight = 16;
            this.lbxRequestStock.Location = new System.Drawing.Point(41, 104);
            this.lbxRequestStock.Name = "lbxRequestStock";
            this.lbxRequestStock.Size = new System.Drawing.Size(432, 196);
            this.lbxRequestStock.TabIndex = 63;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(41, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 35);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RestockWarehouseProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 375);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.lblReqStock);
            this.Controls.Add(this.lbxRequestStock);
            this.Name = "RestockWarehouseProductManagementForm";
            this.Text = "RestockWarehouseProductManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.Label lblReqStock;
        private System.Windows.Forms.ListBox lbxRequestStock;
        private System.Windows.Forms.Button btnBack;
    }
}