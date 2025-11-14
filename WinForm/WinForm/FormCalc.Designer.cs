namespace WinForm
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
            label3 = new Label();
            summbtn = new Button();
            num1txt = new TextBox();
            num2txt = new TextBox();
            num3txt = new TextBox();
            subbtn = new Button();
            multbtn = new Button();
            divbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 334);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Первое число";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 389);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Второе число";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(611, 359);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 2;
            label3.Text = "Итоговое число";
            label3.Click += label3_Click;
            // 
            // summbtn
            // 
            summbtn.Location = new Point(434, 467);
            summbtn.Name = "summbtn";
            summbtn.Size = new Size(113, 42);
            summbtn.TabIndex = 3;
            summbtn.Text = "Сложить";
            summbtn.UseVisualStyleBackColor = true;
            summbtn.Click += summbtn_Click;
            // 
            // num1txt
            // 
            num1txt.Location = new Point(434, 334);
            num1txt.Name = "num1txt";
            num1txt.Size = new Size(100, 23);
            num1txt.TabIndex = 4;
            num1txt.TextChanged += num1txt_TextChanged;
            // 
            // num2txt
            // 
            num2txt.Location = new Point(434, 389);
            num2txt.Name = "num2txt";
            num2txt.Size = new Size(100, 23);
            num2txt.TabIndex = 5;
            num2txt.TextChanged += num2txt_TextChanged;
            // 
            // num3txt
            // 
            num3txt.Location = new Point(713, 356);
            num3txt.Name = "num3txt";
            num3txt.Size = new Size(100, 23);
            num3txt.TabIndex = 6;
            num3txt.TextChanged += num3txt_TextChanged;
            // 
            // subbtn
            // 
            subbtn.Location = new Point(620, 467);
            subbtn.Name = "subbtn";
            subbtn.Size = new Size(113, 42);
            subbtn.TabIndex = 7;
            subbtn.Text = "Вычесть";
            subbtn.UseVisualStyleBackColor = true;
            subbtn.Click += subbtn_Click;
            // 
            // multbtn
            // 
            multbtn.Location = new Point(434, 548);
            multbtn.Name = "multbtn";
            multbtn.Size = new Size(113, 42);
            multbtn.TabIndex = 8;
            multbtn.Text = "Умножить";
            multbtn.UseVisualStyleBackColor = true;
            multbtn.Click += multbtn_Click;
            // 
            // divbtn
            // 
            divbtn.Location = new Point(620, 548);
            divbtn.Name = "divbtn";
            divbtn.Size = new Size(113, 42);
            divbtn.TabIndex = 9;
            divbtn.Text = "Разделить";
            divbtn.UseVisualStyleBackColor = true;
            divbtn.Click += divbtn_Click;
            // 
            // FormCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 734);
            Controls.Add(divbtn);
            Controls.Add(multbtn);
            Controls.Add(subbtn);
            Controls.Add(num3txt);
            Controls.Add(num2txt);
            Controls.Add(num1txt);
            Controls.Add(summbtn);
            Controls.Add(label3);
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
        private Label label3;
        private Button summbtn;
        private TextBox num1txt;
        private TextBox num2txt;
        private TextBox num3txt;
        private Button subbtn;
        private Button multbtn;
        private Button divbtn;
    }
}