namespace practice1
{
    partial class frmCalculateGrade
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
            label1 = new Label();
            txtNumberGrade = new TextBox();
            txtletterGrade = new TextBox();
            label2 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 105);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "NumberGrade:";
            // 
            // txtNumberGrade
            // 
            txtNumberGrade.Location = new Point(124, 102);
            txtNumberGrade.Name = "txtNumberGrade";
            txtNumberGrade.Size = new Size(100, 23);
            txtNumberGrade.TabIndex = 1;
            txtNumberGrade.TextChanged += txtNumberGrade_TextChanged;
            // 
            // txtletterGrade
            // 
            txtletterGrade.Location = new Point(124, 141);
            txtletterGrade.Name = "txtletterGrade";
            txtletterGrade.Size = new Size(100, 23);
            txtletterGrade.TabIndex = 2;
            txtletterGrade.TabStop = false;
            txtletterGrade.TextChanged += txtletterGrade_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 149);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "LetterGrade:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(89, 190);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(170, 190);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCalculateGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 353);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(txtletterGrade);
            Controls.Add(txtNumberGrade);
            Controls.Add(label1);
            Name = "frmCalculateGrade";
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumberGrade;
        private TextBox txtletterGrade;
        private Label label2;
        private Button btnCalculate;
        private Button btnExit;
    }
}
