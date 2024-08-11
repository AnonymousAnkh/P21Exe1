namespace P21Exe1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFind = new Button();
            btnExit = new Button();
            labNum1 = new Label();
            labNum2 = new Label();
            labMaxNum = new Label();
            txtNum1 = new TextBox();
            txtMaxNum = new TextBox();
            txtNum2 = new TextBox();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.Location = new Point(251, 282);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(155, 45);
            btnFind.TabIndex = 0;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(459, 282);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(155, 45);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // labNum1
            // 
            labNum1.AutoSize = true;
            labNum1.Location = new Point(251, 62);
            labNum1.Name = "labNum1";
            labNum1.Size = new Size(61, 25);
            labNum1.TabIndex = 2;
            labNum1.Text = "Num1";
            // 
            // labNum2
            // 
            labNum2.AutoSize = true;
            labNum2.Location = new Point(251, 137);
            labNum2.Name = "labNum2";
            labNum2.Size = new Size(61, 25);
            labNum2.TabIndex = 3;
            labNum2.Text = "Num2";
            // 
            // labMaxNum
            // 
            labMaxNum.AutoSize = true;
            labMaxNum.Location = new Point(251, 213);
            labMaxNum.Name = "labMaxNum";
            labMaxNum.Size = new Size(89, 25);
            labMaxNum.TabIndex = 4;
            labMaxNum.Text = "Max Num";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(383, 62);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(178, 31);
            txtNum1.TabIndex = 5;
            // 
            // txtMaxNum
            // 
            txtMaxNum.Location = new Point(383, 213);
            txtMaxNum.Name = "txtMaxNum";
            txtMaxNum.Size = new Size(178, 31);
            txtMaxNum.TabIndex = 6;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(383, 137);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(178, 31);
            txtNum2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum2);
            Controls.Add(txtMaxNum);
            Controls.Add(txtNum1);
            Controls.Add(labMaxNum);
            Controls.Add(labNum2);
            Controls.Add(labNum1);
            Controls.Add(btnExit);
            Controls.Add(btnFind);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFind;
        private Button btnExit;
        private Label labNum1;
        private Label labNum2;
        private Label labMaxNum;
        private TextBox txtNum1;
        private TextBox txtMaxNum;
        private TextBox txtNum2;
    }
}
