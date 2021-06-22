
namespace MediaBazzar
{
    partial class AddProductToFloor
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
            this.lbxProductWarehouse = new System.Windows.Forms.ListBox();
            this.lbxProductFloor = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProductFloor = new System.Windows.Forms.Label();
            this.lblProductWarehouse = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblDimention = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblArtNumb = new System.Windows.Forms.Label();
            this.lblRsltArtNumb = new System.Windows.Forms.Label();
            this.lblRsltName = new System.Windows.Forms.Label();
            this.lblRsltPrice = new System.Windows.Forms.Label();
            this.lblRsltCategory = new System.Windows.Forms.Label();
            this.lblRsltDimention = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxProductWarehouse
            // 
            this.lbxProductWarehouse.FormattingEnabled = true;
            this.lbxProductWarehouse.ItemHeight = 16;
            this.lbxProductWarehouse.Location = new System.Drawing.Point(320, 57);
            this.lbxProductWarehouse.Name = "lbxProductWarehouse";
            this.lbxProductWarehouse.Size = new System.Drawing.Size(284, 196);
            this.lbxProductWarehouse.TabIndex = 0;
            this.lbxProductWarehouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxProductWarehouse_MouseClick);
            // 
            // lbxProductFloor
            // 
            this.lbxProductFloor.FormattingEnabled = true;
            this.lbxProductFloor.ItemHeight = 16;
            this.lbxProductFloor.Location = new System.Drawing.Point(43, 298);
            this.lbxProductFloor.Name = "lbxProductFloor";
            this.lbxProductFloor.Size = new System.Drawing.Size(561, 196);
            this.lbxProductFloor.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProductFloor
            // 
            this.lblProductFloor.AutoSize = true;
            this.lblProductFloor.Location = new System.Drawing.Point(40, 278);
            this.lblProductFloor.Name = "lblProductFloor";
            this.lblProductFloor.Size = new System.Drawing.Size(165, 17);
            this.lblProductFloor.TabIndex = 3;
            this.lblProductFloor.Text = "Available Product (Shop)";
            // 
            // lblProductWarehouse
            // 
            this.lblProductWarehouse.AutoSize = true;
            this.lblProductWarehouse.Location = new System.Drawing.Point(317, 37);
            this.lblProductWarehouse.Name = "lblProductWarehouse";
            this.lblProductWarehouse.Size = new System.Drawing.Size(205, 17);
            this.lblProductWarehouse.TabIndex = 4;
            this.lblProductWarehouse.Text = "Available Product (Warehouse)";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(40, 231);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 17);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(119, 231);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(86, 22);
            this.tbxQuantity.TabIndex = 6;
            // 
            // lblDimention
            // 
            this.lblDimention.AutoSize = true;
            this.lblDimention.Location = new System.Drawing.Point(40, 198);
            this.lblDimention.Name = "lblDimention";
            this.lblDimention.Size = new System.Drawing.Size(79, 17);
            this.lblDimention.TabIndex = 48;
            this.lblDimention.Text = "Dimention :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(40, 94);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(53, 17);
            this.lblProductName.TabIndex = 49;
            this.lblProductName.Text = "Name :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(40, 128);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(48, 17);
            this.lblProductPrice.TabIndex = 51;
            this.lblProductPrice.Text = "Price :";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(40, 162);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 17);
            this.lblCategory.TabIndex = 52;
            this.lblCategory.Text = "Category :";
            // 
            // lblArtNumb
            // 
            this.lblArtNumb.AutoSize = true;
            this.lblArtNumb.Location = new System.Drawing.Point(40, 63);
            this.lblArtNumb.Name = "lblArtNumb";
            this.lblArtNumb.Size = new System.Drawing.Size(109, 17);
            this.lblArtNumb.TabIndex = 53;
            this.lblArtNumb.Text = "Article Number :";
            // 
            // lblRsltArtNumb
            // 
            this.lblRsltArtNumb.AutoSize = true;
            this.lblRsltArtNumb.Location = new System.Drawing.Point(155, 63);
            this.lblRsltArtNumb.Name = "lblRsltArtNumb";
            this.lblRsltArtNumb.Size = new System.Drawing.Size(0, 17);
            this.lblRsltArtNumb.TabIndex = 54;
            // 
            // lblRsltName
            // 
            this.lblRsltName.AutoSize = true;
            this.lblRsltName.Location = new System.Drawing.Point(99, 94);
            this.lblRsltName.Name = "lblRsltName";
            this.lblRsltName.Size = new System.Drawing.Size(0, 17);
            this.lblRsltName.TabIndex = 55;
            // 
            // lblRsltPrice
            // 
            this.lblRsltPrice.AutoSize = true;
            this.lblRsltPrice.Location = new System.Drawing.Point(94, 128);
            this.lblRsltPrice.Name = "lblRsltPrice";
            this.lblRsltPrice.Size = new System.Drawing.Size(0, 17);
            this.lblRsltPrice.TabIndex = 56;
            // 
            // lblRsltCategory
            // 
            this.lblRsltCategory.AutoSize = true;
            this.lblRsltCategory.Location = new System.Drawing.Point(119, 162);
            this.lblRsltCategory.Name = "lblRsltCategory";
            this.lblRsltCategory.Size = new System.Drawing.Size(0, 17);
            this.lblRsltCategory.TabIndex = 57;
            // 
            // lblRsltDimention
            // 
            this.lblRsltDimention.AutoSize = true;
            this.lblRsltDimention.Location = new System.Drawing.Point(125, 198);
            this.lblRsltDimention.Name = "lblRsltDimention";
            this.lblRsltDimention.Size = new System.Drawing.Size(0, 17);
            this.lblRsltDimention.TabIndex = 58;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(43, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 28);
            this.btnBack.TabIndex = 59;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddProductToFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 526);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRsltDimention);
            this.Controls.Add(this.lblRsltCategory);
            this.Controls.Add(this.lblRsltPrice);
            this.Controls.Add(this.lblRsltName);
            this.Controls.Add(this.lblRsltArtNumb);
            this.Controls.Add(this.lblDimention);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblArtNumb);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductWarehouse);
            this.Controls.Add(this.lblProductFloor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxProductFloor);
            this.Controls.Add(this.lbxProductWarehouse);
            this.Name = "AddProductToFloor";
            this.Text = "AddProductToFloor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProductWarehouse;
        private System.Windows.Forms.ListBox lbxProductFloor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProductFloor;
        private System.Windows.Forms.Label lblProductWarehouse;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblDimention;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblArtNumb;
        private System.Windows.Forms.Label lblRsltArtNumb;
        private System.Windows.Forms.Label lblRsltName;
        private System.Windows.Forms.Label lblRsltPrice;
        private System.Windows.Forms.Label lblRsltCategory;
        private System.Windows.Forms.Label lblRsltDimention;
        private System.Windows.Forms.Button btnBack;
    }
}