
namespace MediaBazzar
{
    partial class UpdateProductPrice
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
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.lblProdPrice = new System.Windows.Forms.Label();
            this.lblProdArtNumber = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxArtNumb = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 36);
            this.btnBack.TabIndex = 83;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // tbxProdName
            // 
            this.tbxProdName.Location = new System.Drawing.Point(127, 139);
            this.tbxProdName.Name = "tbxProdName";
            this.tbxProdName.Size = new System.Drawing.Size(153, 22);
            this.tbxProdName.TabIndex = 82;
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(110, 171);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(170, 22);
            this.tbxUpdatePrice.TabIndex = 80;
            // 
            // lblProdPrice
            // 
            this.lblProdPrice.AutoSize = true;
            this.lblProdPrice.Location = new System.Drawing.Point(56, 173);
            this.lblProdPrice.Name = "lblProdPrice";
            this.lblProdPrice.Size = new System.Drawing.Size(48, 17);
            this.lblProdPrice.TabIndex = 78;
            this.lblProdPrice.Text = "Price :";
            // 
            // lblProdArtNumber
            // 
            this.lblProdArtNumber.AutoSize = true;
            this.lblProdArtNumber.Location = new System.Drawing.Point(56, 114);
            this.lblProdArtNumber.Name = "lblProdArtNumber";
            this.lblProdArtNumber.Size = new System.Drawing.Size(99, 17);
            this.lblProdArtNumber.TabIndex = 77;
            this.lblProdArtNumber.Text = "Art. Numbers :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(180, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 76;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxArtNumb
            // 
            this.tbxArtNumb.Location = new System.Drawing.Point(161, 111);
            this.tbxArtNumb.Name = "tbxArtNumb";
            this.tbxArtNumb.Size = new System.Drawing.Size(119, 22);
            this.tbxArtNumb.TabIndex = 75;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(56, 142);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(65, 17);
            this.lblProdName.TabIndex = 74;
            this.lblProdName.Text = "Product :";
            // 
            // UpdateProductPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 294);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbxProdName);
            this.Controls.Add(this.tbxUpdatePrice);
            this.Controls.Add(this.lblProdPrice);
            this.Controls.Add(this.lblProdArtNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxArtNumb);
            this.Controls.Add(this.lblProdName);
            this.Name = "UpdateProductPrice";
            this.Text = "UpdateProductPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbxProdName;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.Label lblProdPrice;
        private System.Windows.Forms.Label lblProdArtNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxArtNumb;
        private System.Windows.Forms.Label lblProdName;
    }
}