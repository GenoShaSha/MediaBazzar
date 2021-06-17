
namespace MediaBazzar
{
    partial class CheckRequestFloorForm
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
            this.btnDisapproved = new System.Windows.Forms.Button();
            this.lblReqStock = new System.Windows.Forms.Label();
            this.lbxRequestStock = new System.Windows.Forms.ListBox();
            this.btnApproved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisapproved
            // 
            this.btnDisapproved.Location = new System.Drawing.Point(449, 261);
            this.btnDisapproved.Name = "btnDisapproved";
            this.btnDisapproved.Size = new System.Drawing.Size(136, 39);
            this.btnDisapproved.TabIndex = 64;
            this.btnDisapproved.Text = "DISAPPROVED";
            this.btnDisapproved.UseVisualStyleBackColor = true;
            // 
            // lblReqStock
            // 
            this.lblReqStock.AutoSize = true;
            this.lblReqStock.Location = new System.Drawing.Point(34, 28);
            this.lblReqStock.Name = "lblReqStock";
            this.lblReqStock.Size = new System.Drawing.Size(142, 17);
            this.lblReqStock.TabIndex = 63;
            this.lblReqStock.Text = "List of Request Stock";
            // 
            // lbxRequestStock
            // 
            this.lbxRequestStock.FormattingEnabled = true;
            this.lbxRequestStock.ItemHeight = 16;
            this.lbxRequestStock.Location = new System.Drawing.Point(34, 50);
            this.lbxRequestStock.Name = "lbxRequestStock";
            this.lbxRequestStock.Size = new System.Drawing.Size(551, 196);
            this.lbxRequestStock.TabIndex = 62;
            // 
            // btnApproved
            // 
            this.btnApproved.Location = new System.Drawing.Point(328, 261);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(115, 39);
            this.btnApproved.TabIndex = 61;
            this.btnApproved.Text = "APPROVED";
            this.btnApproved.UseVisualStyleBackColor = true;
            // 
            // CheckRequestFloorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 337);
            this.Controls.Add(this.btnDisapproved);
            this.Controls.Add(this.lblReqStock);
            this.Controls.Add(this.lbxRequestStock);
            this.Controls.Add(this.btnApproved);
            this.Name = "CheckRequestFloorForm";
            this.Text = "CheckRequestFloorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisapproved;
        private System.Windows.Forms.Label lblReqStock;
        private System.Windows.Forms.ListBox lbxRequestStock;
        private System.Windows.Forms.Button btnApproved;
    }
}