namespace Win1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginbtn = new Button();
            closebtn = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(280, 130);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(183, 23);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += textBox1_TextChanged;

            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(280, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 23);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 112);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 158);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(280, 227);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(183, 40);
            loginbtn.TabIndex = 9;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += Login_button;
            // 
            // closebtn
            // 
            closebtn.Location = new Point(338, 391);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(75, 23);
            closebtn.TabIndex = 11;
            closebtn.Text = "close";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += Close_button;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(closebtn);
            Controls.Add(loginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button loginbtn;
        private Button closebtn;
    }
}