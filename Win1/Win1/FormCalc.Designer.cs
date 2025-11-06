namespace Win1
{
    partial class FormCalc
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
            label1 = new Label();
            label2 = new Label();
            num2txt = new TextBox();
            num1txt = new TextBox();
            Summbtn = new Button();
            Subbtn = new Button();
            Multibtn = new Button();
            Divbtn = new Button();
            num3txt = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 193);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Первое число";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 247);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Второе число";
            // 
            // num2txt
            // 
            num2txt.Location = new Point(356, 244);
            num2txt.Name = "num2txt";
            num2txt.Size = new Size(100, 23);
            num2txt.TabIndex = 2;
            // 
            // num1txt
            // 
            num1txt.Location = new Point(356, 190);
            num1txt.Name = "num1txt";
            num1txt.Size = new Size(100, 23);
            num1txt.TabIndex = 3;
            // 
            // Summbtn
            // 
            Summbtn.Location = new Point(291, 295);
            Summbtn.Name = "Summbtn";
            Summbtn.Size = new Size(75, 23);
            Summbtn.TabIndex = 4;
            Summbtn.Text = "Сложить";
            Summbtn.UseVisualStyleBackColor = true;
            Summbtn.Click += Summbtn_Click;
            // 
            // Subbtn
            // 
            Subbtn.Location = new Point(417, 295);
            Subbtn.Name = "Subbtn";
            Subbtn.Size = new Size(75, 23);
            Subbtn.TabIndex = 5;
            Subbtn.Text = "Вычесть";
            Subbtn.UseVisualStyleBackColor = true;
            Subbtn.Click += Subbtn_Click;
            // 
            // Multibtn
            // 
            Multibtn.Location = new Point(291, 340);
            Multibtn.Name = "Multibtn";
            Multibtn.Size = new Size(75, 23);
            Multibtn.TabIndex = 6;
            Multibtn.Text = "Умножить";
            Multibtn.UseVisualStyleBackColor = true;
            Multibtn.Click += Multibtn_Click;
            // 
            // Divbtn
            // 
            Divbtn.Location = new Point(417, 340);
            Divbtn.Name = "Divbtn";
            Divbtn.Size = new Size(75, 23);
            Divbtn.TabIndex = 7;
            Divbtn.Text = "Разделить";
            Divbtn.UseVisualStyleBackColor = true;
            Divbtn.Click += Divbtn_Click;
            // 
            // num3txt
            // 
            num3txt.Location = new Point(584, 212);
            num3txt.Name = "num3txt";
            num3txt.Size = new Size(100, 23);
            num3txt.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 215);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "Результат";
            // 
            // FormCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(num3txt);
            Controls.Add(Divbtn);
            Controls.Add(Multibtn);
            Controls.Add(Subbtn);
            Controls.Add(Summbtn);
            Controls.Add(num1txt);
            Controls.Add(num2txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCalc";
            Text = "FormCalc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox num2txt;
        private TextBox num1txt;
        private Button Summbtn;
        private Button Subbtn;
        private Button Multibtn;
        private Button Divbtn;
        private TextBox num3txt;
        private Label label3;
    }
}