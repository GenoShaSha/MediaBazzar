﻿
namespace MediaBazzar
{
    partial class AddRmvProductForm
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
            this.StockIdSearchTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lbxStock = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDimention = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxArtNumb = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblArtNumb = new System.Windows.Forms.Label();
            this.tbxProductPrice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.tbxRmvID = new System.Windows.Forms.TextBox();
            this.lblRmvID = new System.Windows.Forms.Label();
            this.btnProdRequest = new System.Windows.Forms.Button();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockIdSearchTB
            // 
            this.StockIdSearchTB.Location = new System.Drawing.Point(584, 89);
            this.StockIdSearchTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StockIdSearchTB.Name = "StockIdSearchTB";
            this.StockIdSearchTB.Size = new System.Drawing.Size(127, 20);
            this.StockIdSearchTB.TabIndex = 65;
            this.StockIdSearchTB.TextChanged += new System.EventHandler(this.StockIdSearchTB_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Search by Art. Numb";
            // 
            // CategoryCB
            // 
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(296, 90);
            this.CategoryCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(159, 21);
            this.CategoryCB.TabIndex = 67;
            this.CategoryCB.Text = "Select Category";
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(296, 74);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(75, 13);
            this.lblProduct.TabIndex = 66;
            this.lblProduct.Text = "List of Product";
            // 
            // lbxStock
            // 
            this.lbxStock.FormattingEnabled = true;
            this.lbxStock.Location = new System.Drawing.Point(296, 127);
            this.lbxStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxStock.Name = "lbxStock";
            this.lbxStock.Size = new System.Drawing.Size(414, 290);
            this.lbxStock.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxQuantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxDimention);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddStock);
            this.groupBox1.Controls.Add(this.tbxProductName);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.tbxArtNumb);
            this.groupBox1.Controls.Add(this.lblProductPrice);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.lblArtNumb);
            this.groupBox1.Controls.Add(this.tbxProductPrice);
            this.groupBox1.Location = new System.Drawing.Point(28, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(256, 240);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(80, 162);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(154, 20);
            this.tbxQuantity.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Quantity:";
            // 
            // tbxDimention
            // 
            this.tbxDimention.Location = new System.Drawing.Point(80, 134);
            this.tbxDimention.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDimention.Name = "tbxDimention";
            this.tbxDimention.Size = new System.Drawing.Size(154, 20);
            this.tbxDimention.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dimention :";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(164, 193);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(72, 32);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "ADD";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(65, 47);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(169, 20);
            this.tbxProductName.TabIndex = 44;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(21, 50);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(41, 13);
            this.lblProductName.TabIndex = 39;
            this.lblProductName.Text = "Name :";
            // 
            // tbxArtNumb
            // 
            this.tbxArtNumb.Location = new System.Drawing.Point(107, 22);
            this.tbxArtNumb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxArtNumb.Name = "tbxArtNumb";
            this.tbxArtNumb.Size = new System.Drawing.Size(127, 20);
            this.tbxArtNumb.TabIndex = 40;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(21, 77);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(37, 13);
            this.lblProductPrice.TabIndex = 41;
            this.lblProductPrice.Text = "Price :";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(21, 105);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 42;
            this.lblCategory.Text = "Category :";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(80, 102);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(154, 21);
            this.cbxCategory.TabIndex = 46;
            // 
            // lblArtNumb
            // 
            this.lblArtNumb.AutoSize = true;
            this.lblArtNumb.Location = new System.Drawing.Point(21, 24);
            this.lblArtNumb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtNumb.Name = "lblArtNumb";
            this.lblArtNumb.Size = new System.Drawing.Size(82, 13);
            this.lblArtNumb.TabIndex = 43;
            this.lblArtNumb.Text = "Article Number :";
            // 
            // tbxProductPrice
            // 
            this.tbxProductPrice.Location = new System.Drawing.Point(65, 75);
            this.tbxProductPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProductPrice.Name = "tbxProductPrice";
            this.tbxProductPrice.Size = new System.Drawing.Size(169, 20);
            this.tbxProductPrice.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveStock);
            this.groupBox3.Controls.Add(this.tbxRmvID);
            this.groupBox3.Controls.Add(this.lblRmvID);
            this.groupBox3.Location = new System.Drawing.Point(28, 302);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(256, 102);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Discontinue Product";
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.Location = new System.Drawing.Point(130, 56);
            this.btnRemoveStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(104, 32);
            this.btnRemoveStock.TabIndex = 15;
            this.btnRemoveStock.Text = "DISCONTINUE";
            this.btnRemoveStock.UseVisualStyleBackColor = true;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);
            // 
            // tbxRmvID
            // 
            this.tbxRmvID.Location = new System.Drawing.Point(47, 26);
            this.tbxRmvID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxRmvID.Name = "tbxRmvID";
            this.tbxRmvID.Size = new System.Drawing.Size(187, 20);
            this.tbxRmvID.TabIndex = 15;
            // 
            // lblRmvID
            // 
            this.lblRmvID.AutoSize = true;
            this.lblRmvID.Location = new System.Drawing.Point(21, 26);
            this.lblRmvID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRmvID.Name = "lblRmvID";
            this.lblRmvID.Size = new System.Drawing.Size(24, 13);
            this.lblRmvID.TabIndex = 15;
            this.lblRmvID.Text = "ID :";
            // 
            // btnProdRequest
            // 
            this.btnProdRequest.Location = new System.Drawing.Point(580, 28);
            this.btnProdRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProdRequest.Name = "btnProdRequest";
            this.btnProdRequest.Size = new System.Drawing.Size(129, 32);
            this.btnProdRequest.TabIndex = 49;
            this.btnProdRequest.Text = "PRODUCT REQUEST";
            this.btnProdRequest.UseVisualStyleBackColor = true;
            this.btnProdRequest.Click += new System.EventHandler(this.btnProdRequest_Click);
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Location = new System.Drawing.Point(472, 28);
            this.btnUpdatePrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(100, 32);
            this.btnUpdatePrice.TabIndex = 70;
            this.btnUpdatePrice.Text = "UPDATE PRICE";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // AddRmvProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 441);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.btnProdRequest);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.StockIdSearchTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lbxStock);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddRmvProductForm";
            this.Text = "AddRmvProductForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StockIdSearchTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ListBox lbxStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDimention;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxArtNumb;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblArtNumb;
        private System.Windows.Forms.TextBox tbxProductPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.TextBox tbxRmvID;
        private System.Windows.Forms.Label lblRmvID;
        private System.Windows.Forms.Button btnProdRequest;
        private System.Windows.Forms.Button btnUpdatePrice;
    }
}