
namespace MediaBazzar
{
    partial class RestockFloorProductManagementForm
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
            this.lblReqStock = new System.Windows.Forms.Label();
            this.lbxRequestStock = new System.Windows.Forms.ListBox();
            this.btnApproved = new System.Windows.Forms.Button();
            this.btnWarehouseRequest = new System.Windows.Forms.Button();
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.btnAddNewProd = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReqStock
            // 
            this.lblReqStock.AutoSize = true;
            this.lblReqStock.Location = new System.Drawing.Point(26, 34);
            this.lblReqStock.Name = "lblReqStock";
            this.lblReqStock.Size = new System.Drawing.Size(192, 17);
            this.lblReqStock.TabIndex = 61;
            this.lblReqStock.Text = "List of Floor Product Request";
            // 
            // lbxRequestStock
            // 
            this.lbxRequestStock.FormattingEnabled = true;
            this.lbxRequestStock.ItemHeight = 16;
            this.lbxRequestStock.Location = new System.Drawing.Point(26, 56);
            this.lbxRequestStock.Name = "lbxRequestStock";
            this.lbxRequestStock.Size = new System.Drawing.Size(432, 196);
            this.lbxRequestStock.TabIndex = 60;
            // 
            // btnApproved
            // 
            this.btnApproved.Location = new System.Drawing.Point(26, 268);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(432, 30);
            this.btnApproved.TabIndex = 62;
            this.btnApproved.Text = "APPROVED";
            this.btnApproved.UseVisualStyleBackColor = true;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
            // 
            // btnWarehouseRequest
            // 
            this.btnWarehouseRequest.Location = new System.Drawing.Point(250, 315);
            this.btnWarehouseRequest.Name = "btnWarehouseRequest";
            this.btnWarehouseRequest.Size = new System.Drawing.Size(208, 30);
            this.btnWarehouseRequest.TabIndex = 65;
            this.btnWarehouseRequest.Text = "Send Request";
            this.btnWarehouseRequest.UseVisualStyleBackColor = true;
            this.btnWarehouseRequest.Click += new System.EventHandler(this.btnWarehouseRequest_Click);
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.Location = new System.Drawing.Point(26, 315);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(208, 29);
            this.btnUpdateProd.TabIndex = 64;
            this.btnUpdateProd.Text = "Update Product";
            this.btnUpdateProd.UseVisualStyleBackColor = true;
            this.btnUpdateProd.Click += new System.EventHandler(this.btnUpdateProd_Click);
            // 
            // btnAddNewProd
            // 
            this.btnAddNewProd.Location = new System.Drawing.Point(26, 353);
            this.btnAddNewProd.Name = "btnAddNewProd";
            this.btnAddNewProd.Size = new System.Drawing.Size(432, 28);
            this.btnAddNewProd.TabIndex = 72;
            this.btnAddNewProd.Text = "ADD NEW PRODUCT TO THE FLOOR";
            this.btnAddNewProd.UseVisualStyleBackColor = true;
            this.btnAddNewProd.Click += new System.EventHandler(this.btnAddNewProd_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(349, 11);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(109, 38);
            this.btnSignOut.TabIndex = 100;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // RestockFloorProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 414);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnAddNewProd);
            this.Controls.Add(this.btnWarehouseRequest);
            this.Controls.Add(this.btnUpdateProd);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.lblReqStock);
            this.Controls.Add(this.lbxRequestStock);
            this.Name = "RestockFloorProductManagementForm";
            this.Text = "RestockFloorProductManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReqStock;
        private System.Windows.Forms.ListBox lbxRequestStock;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.Button btnWarehouseRequest;
        private System.Windows.Forms.Button btnUpdateProd;
        private System.Windows.Forms.Button btnAddNewProd;
        private System.Windows.Forms.Button btnSignOut;
    }
}