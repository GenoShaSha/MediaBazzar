
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
            this.tbxProdName = new System.Windows.Forms.TextBox();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.tbxUpdateQuantity = new System.Windows.Forms.TextBox();
            this.lblProdQuantity = new System.Windows.Forms.Label();
            this.lblProdArtNumber = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxArtNumb = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
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
            // 
            // tbxProdName
            // 
            this.tbxProdName.Location = new System.Drawing.Point(125, 144);
            this.tbxProdName.Name = "tbxProdName";
            this.tbxProdName.Size = new System.Drawing.Size(207, 22);
            this.tbxProdName.TabIndex = 72;
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(284, 175);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(46, 23);
            this.minusBtn.TabIndex = 71;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(125, 175);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(46, 23);
            this.plusBtn.TabIndex = 69;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            // 
            // tbxUpdateQuantity
            // 
            this.tbxUpdateQuantity.Location = new System.Drawing.Point(177, 176);
            this.tbxUpdateQuantity.Name = "tbxUpdateQuantity";
            this.tbxUpdateQuantity.Size = new System.Drawing.Size(101, 22);
            this.tbxUpdateQuantity.TabIndex = 70;
            // 
            // lblProdQuantity
            // 
            this.lblProdQuantity.AutoSize = true;
            this.lblProdQuantity.Location = new System.Drawing.Point(54, 178);
            this.lblProdQuantity.Name = "lblProdQuantity";
            this.lblProdQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblProdQuantity.TabIndex = 68;
            this.lblProdQuantity.Text = "Quantity :";
            // 
            // lblProdArtNumber
            // 
            this.lblProdArtNumber.AutoSize = true;
            this.lblProdArtNumber.Location = new System.Drawing.Point(54, 119);
            this.lblProdArtNumber.Name = "lblProdArtNumber";
            this.lblProdArtNumber.Size = new System.Drawing.Size(99, 17);
            this.lblProdArtNumber.TabIndex = 67;
            this.lblProdArtNumber.Text = "Art. Numbers :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(230, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbxArtNumb
            // 
            this.tbxArtNumb.Location = new System.Drawing.Point(159, 116);
            this.tbxArtNumb.Name = "tbxArtNumb";
            this.tbxArtNumb.Size = new System.Drawing.Size(173, 22);
            this.tbxArtNumb.TabIndex = 65;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(54, 147);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(65, 17);
            this.lblProdName.TabIndex = 64;
            this.lblProdName.Text = "Product :";
            // 
            // UpdateProductQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 287);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbxProdName);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.tbxUpdateQuantity);
            this.Controls.Add(this.lblProdQuantity);
            this.Controls.Add(this.lblProdArtNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxArtNumb);
            this.Controls.Add(this.lblProdName);
            this.Name = "UpdateProductQuantity";
            this.Text = "UpdateProductQuantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbxProdName;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.TextBox tbxUpdateQuantity;
        private System.Windows.Forms.Label lblProdQuantity;
        private System.Windows.Forms.Label lblProdArtNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxArtNumb;
        private System.Windows.Forms.Label lblProdName;
    }
}