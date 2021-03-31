namespace CRUD_StockManagement
{
    partial class Form1
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
            this.btnAddStock = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxArtNumb = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblArtNumb = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxProductPrice = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.tbxDimention = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxStock = new System.Windows.Forms.ListBox();
            this.cbxUpdateCat = new System.Windows.Forms.ComboBox();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUpdateArtNr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxUpdateDim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(109, 203);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(96, 39);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "ADD";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(62, 153);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(53, 17);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Name :";
            // 
            // tbxArtNumb
            // 
            this.tbxArtNumb.Location = new System.Drawing.Point(177, 119);
            this.tbxArtNumb.Name = "tbxArtNumb";
            this.tbxArtNumb.Size = new System.Drawing.Size(168, 22);
            this.tbxArtNumb.TabIndex = 2;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(62, 187);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(48, 17);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "Price :";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(62, 221);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category :";
            // 
            // lblArtNumb
            // 
            this.lblArtNumb.AutoSize = true;
            this.lblArtNumb.Location = new System.Drawing.Point(62, 122);
            this.lblArtNumb.Name = "lblArtNumb";
            this.lblArtNumb.Size = new System.Drawing.Size(109, 17);
            this.lblArtNumb.TabIndex = 5;
            this.lblArtNumb.Text = "Article Number :";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(121, 150);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(224, 22);
            this.tbxProductName.TabIndex = 6;
            // 
            // tbxProductPrice
            // 
            this.tbxProductPrice.Location = new System.Drawing.Point(121, 184);
            this.tbxProductPrice.Name = "tbxProductPrice";
            this.tbxProductPrice.Size = new System.Drawing.Size(224, 22);
            this.tbxProductPrice.TabIndex = 7;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "Household",
            "Computer & Electronics",
            "Kitchen"});
            this.cbxCategory.Location = new System.Drawing.Point(141, 218);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(204, 24);
            this.cbxCategory.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveStock);
            this.groupBox1.Controls.Add(this.tbxDimention);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddStock);
            this.groupBox1.Location = new System.Drawing.Point(32, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 263);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Stock";
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.Location = new System.Drawing.Point(218, 203);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(95, 39);
            this.btnRemoveStock.TabIndex = 15;
            this.btnRemoveStock.Text = "REMOVE";
            this.btnRemoveStock.UseVisualStyleBackColor = true;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);
            // 
            // tbxDimention
            // 
            this.tbxDimention.Location = new System.Drawing.Point(109, 169);
            this.tbxDimention.Name = "tbxDimention";
            this.tbxDimention.Size = new System.Drawing.Size(204, 22);
            this.tbxDimention.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dimention :";
            // 
            // lbxStock
            // 
            this.lbxStock.FormattingEnabled = true;
            this.lbxStock.ItemHeight = 16;
            this.lbxStock.Location = new System.Drawing.Point(392, 93);
            this.lbxStock.Name = "lbxStock";
            this.lbxStock.Size = new System.Drawing.Size(551, 516);
            this.lbxStock.TabIndex = 11;
            this.lbxStock.SelectedIndexChanged += new System.EventHandler(this.lbxStock_SelectedIndexChanged);
            // 
            // cbxUpdateCat
            // 
            this.cbxUpdateCat.FormattingEnabled = true;
            this.cbxUpdateCat.Items.AddRange(new object[] {
            "Household",
            "Computer & Electronics",
            "Kitchen"});
            this.cbxUpdateCat.Location = new System.Drawing.Point(109, 134);
            this.cbxUpdateCat.Name = "cbxUpdateCat";
            this.cbxUpdateCat.Size = new System.Drawing.Size(204, 24);
            this.cbxUpdateCat.TabIndex = 19;
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(121, 453);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(224, 22);
            this.tbxUpdatePrice.TabIndex = 18;
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(121, 419);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(224, 22);
            this.tbxUpdateName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Article Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price :";
            // 
            // tbxUpdateArtNr
            // 
            this.tbxUpdateArtNr.Location = new System.Drawing.Point(177, 388);
            this.tbxUpdateArtNr.Name = "tbxUpdateArtNr";
            this.tbxUpdateArtNr.Size = new System.Drawing.Size(168, 22);
            this.tbxUpdateArtNr.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxUpdateCat);
            this.groupBox2.Controls.Add(this.tbxUpdateDim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnUpdateProducts);
            this.groupBox2.Location = new System.Drawing.Point(32, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 266);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Stock";
            // 
            // tbxUpdateDim
            // 
            this.tbxUpdateDim.Location = new System.Drawing.Point(109, 169);
            this.tbxUpdateDim.Name = "tbxUpdateDim";
            this.tbxUpdateDim.Size = new System.Drawing.Size(204, 22);
            this.tbxUpdateDim.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dimention :";
            // 
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.Location = new System.Drawing.Point(218, 206);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(95, 39);
            this.btnUpdateProducts.TabIndex = 1;
            this.btnUpdateProducts.Text = "UPDATE";
            this.btnUpdateProducts.UseVisualStyleBackColor = true;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 639);
            this.Controls.Add(this.tbxUpdatePrice);
            this.Controls.Add(this.tbxUpdateName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUpdateArtNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbxStock);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.tbxProductPrice);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.lblArtNumb);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.tbxArtNumb);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxArtNumb;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblArtNumb;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxProductPrice;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.ListBox lbxStock;
        private System.Windows.Forms.TextBox tbxDimention;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUpdateCat;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUpdateArtNr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxUpdateDim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateProducts;
    }
}

