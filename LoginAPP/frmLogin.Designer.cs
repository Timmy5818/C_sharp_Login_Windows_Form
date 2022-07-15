
namespace LoginAPP
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin_body = new System.Windows.Forms.Button();
            this.btnLogin_head = new System.Windows.Forms.Button();
            this.btn_post_body = new System.Windows.Forms.Button();
            this.btn_post_head = new System.Windows.Forms.Button();
            this.ListTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(90, 119);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 29);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(139, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 29);
            this.txtUsername.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(300, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(139, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(166, 29);
            this.txtPassword.TabIndex = 5;
            // 
            // btnLogin_body
            // 
            this.btnLogin_body.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin_body.Location = new System.Drawing.Point(12, 164);
            this.btnLogin_body.Name = "btnLogin_body";
            this.btnLogin_body.Size = new System.Drawing.Size(117, 29);
            this.btnLogin_body.TabIndex = 6;
            this.btnLogin_body.Text = "Get body";
            this.btnLogin_body.UseVisualStyleBackColor = true;
            this.btnLogin_body.Click += new System.EventHandler(this.btnLogin_body_Click);
            // 
            // btnLogin_head
            // 
            this.btnLogin_head.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin_head.Location = new System.Drawing.Point(12, 209);
            this.btnLogin_head.Name = "btnLogin_head";
            this.btnLogin_head.Size = new System.Drawing.Size(117, 29);
            this.btnLogin_head.TabIndex = 7;
            this.btnLogin_head.Text = "Get hearder";
            this.btnLogin_head.UseVisualStyleBackColor = true;
            this.btnLogin_head.Click += new System.EventHandler(this.btnLogin_head_Click);
            // 
            // btn_post_body
            // 
            this.btn_post_body.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_post_body.Location = new System.Drawing.Point(139, 164);
            this.btn_post_body.Name = "btn_post_body";
            this.btn_post_body.Size = new System.Drawing.Size(142, 29);
            this.btn_post_body.TabIndex = 8;
            this.btn_post_body.Text = "登入工研院";
            this.btn_post_body.UseVisualStyleBackColor = true;
            this.btn_post_body.Click += new System.EventHandler(this.btn_post_body_Click);
            // 
            // btn_post_head
            // 
            this.btn_post_head.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_post_head.Location = new System.Drawing.Point(135, 209);
            this.btn_post_head.Name = "btn_post_head";
            this.btn_post_head.Size = new System.Drawing.Size(146, 29);
            this.btn_post_head.TabIndex = 9;
            this.btn_post_head.Text = "Post工研院Body";
            this.btn_post_head.UseVisualStyleBackColor = true;
            this.btn_post_head.Click += new System.EventHandler(this.btn_post_head_Click);
            // 
            // ListTest
            // 
            this.ListTest.Location = new System.Drawing.Point(228, 119);
            this.ListTest.Name = "ListTest";
            this.ListTest.Size = new System.Drawing.Size(111, 29);
            this.ListTest.TabIndex = 10;
            this.ListTest.Text = "測試字串";
            this.ListTest.UseVisualStyleBackColor = true;
            this.ListTest.Click += new System.EventHandler(this.ListTest_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 261);
            this.Controls.Add(this.ListTest);
            this.Controls.Add(this.btn_post_head);
            this.Controls.Add(this.btn_post_body);
            this.Controls.Add(this.btnLogin_head);
            this.Controls.Add(this.btnLogin_body);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin_body;
        private System.Windows.Forms.Button btnLogin_head;
        private System.Windows.Forms.Button btn_post_body;
        private System.Windows.Forms.Button btn_post_head;
        private System.Windows.Forms.Button ListTest;
    }
}