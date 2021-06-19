
namespace MediaBazzar
{
    partial class UpdateProductQuantity
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbxStock = new System.Windows.Forms.ListBox();
            this.lblProdQuantity = new System.Windows.Forms.Label();
            this.tbxUpdateQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 36);
            this.btnBack.TabIndex = 73;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(214, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbxStock
            // 
            this.lbxStock.FormattingEnabled = true;
            this.lbxStock.ItemHeight = 16;
            this.lbxStock.Location = new System.Drawing.Point(55, 134);
            this.lbxStock.Name = "lbxStock";
            this.lbxStock.Size = new System.Drawing.Size(275, 308);
            this.lbxStock.TabIndex = 74;
            // 
            // lblProdQuantity
            // 
            this.lblProdQuantity.AutoSize = true;
            this.lblProdQuantity.Location = new System.Drawing.Point(52, 97);
            this.lblProdQuantity.Name = "lblProdQuantity";
            this.lblProdQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblProdQuantity.TabIndex = 68;
            this.lblProdQuantity.Text = "Quantity :";
            // 
            // tbxUpdateQuantity
            // 
            this.tbxUpdateQuantity.Location = new System.Drawing.Point(127, 94);
            this.tbxUpdateQuantity.Name = "tbxUpdateQuantity";
            this.tbxUpdateQuantity.Size = new System.Drawing.Size(203, 22);
            this.tbxUpdateQuantity.TabIndex = 70;
            // 
            // UpdateProductQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 582);
            this.Controls.Add(this.lbxStock);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbxUpdateQuantity);
            this.Controls.Add(this.lblProdQuantity);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateProductQuantity";
            this.Text = "UpdateProductQuantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lbxStock;
        private System.Windows.Forms.Label lblProdQuantity;
        private System.Windows.Forms.TextBox tbxUpdateQuantity;
    }
}