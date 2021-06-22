
namespace MediaBazzar
{
    partial class SchedulingForm
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
            this.btnProdRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdRequest
            // 
            this.btnProdRequest.Location = new System.Drawing.Point(535, 29);
            this.btnProdRequest.Name = "btnProdRequest";
            this.btnProdRequest.Size = new System.Drawing.Size(227, 39);
            this.btnProdRequest.TabIndex = 50;
            this.btnProdRequest.Text = "ADD  PRODUCT  REQUEST";
            this.btnProdRequest.UseVisualStyleBackColor = true;
            this.btnProdRequest.Click += new System.EventHandler(this.btnProdRequest_Click);
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProdRequest);
            this.Name = "SchedulingForm";
            this.Text = "SchedulingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdRequest;
    }
}