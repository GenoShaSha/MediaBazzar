﻿
namespace MediaBazzar
{
    partial class SignInForm
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxArtNumb = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblUsrName = new System.Windows.Forms.Label();
            this.tbxProdName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(54, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password :";
            // 
            // tbxArtNumb
            // 
            this.tbxArtNumb.Location = new System.Drawing.Point(137, 121);
            this.tbxArtNumb.Name = "tbxArtNumb";
            this.tbxArtNumb.Size = new System.Drawing.Size(175, 22);
            this.tbxArtNumb.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(212, 197);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 37);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // lblUsrName
            // 
            this.lblUsrName.AutoSize = true;
            this.lblUsrName.Location = new System.Drawing.Point(54, 124);
            this.lblUsrName.Name = "lblUsrName";
            this.lblUsrName.Size = new System.Drawing.Size(81, 17);
            this.lblUsrName.TabIndex = 3;
            this.lblUsrName.Text = "Username :";
            // 
            // tbxProdName
            // 
            this.tbxProdName.Location = new System.Drawing.Point(137, 149);
            this.tbxProdName.Name = "tbxProdName";
            this.tbxProdName.Size = new System.Drawing.Size(175, 22);
            this.tbxProdName.TabIndex = 62;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 296);
            this.Controls.Add(this.tbxProdName);
            this.Controls.Add(this.lblUsrName);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbxArtNumb);
            this.Controls.Add(this.lblPassword);
            this.Name = "SignInForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxArtNumb;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblUsrName;
        private System.Windows.Forms.TextBox tbxProdName;
    }
}

