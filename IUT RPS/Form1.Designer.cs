namespace IUT_RPS
{
    partial class Form1
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
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AttendanceLabel = new System.Windows.Forms.Label();
            this.Q1Label = new System.Windows.Forms.Label();
            this.Q3Label = new System.Windows.Forms.Label();
            this.Q2Label = new System.Windows.Forms.Label();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.MidLabel = new System.Windows.Forms.Label();
            this.QTLabel = new System.Windows.Forms.Label();
            this.Q4Label = new System.Windows.Forms.Label();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.VivaLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.ItemHeight = 20;
            this.StudentListBox.Location = new System.Drawing.Point(46, 137);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(636, 464);
            this.StudentListBox.TabIndex = 0;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(888, 54);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(126, 26);
            this.IDTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(888, 107);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(126, 57);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search by ID";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AttendanceLabel
            // 
            this.AttendanceLabel.AutoSize = true;
            this.AttendanceLabel.Location = new System.Drawing.Point(764, 201);
            this.AttendanceLabel.Name = "AttendanceLabel";
            this.AttendanceLabel.Size = new System.Drawing.Size(96, 20);
            this.AttendanceLabel.TabIndex = 3;
            this.AttendanceLabel.Text = "Attendance:";
            // 
            // Q1Label
            // 
            this.Q1Label.AutoSize = true;
            this.Q1Label.Location = new System.Drawing.Point(764, 239);
            this.Q1Label.Name = "Q1Label";
            this.Q1Label.Size = new System.Drawing.Size(58, 20);
            this.Q1Label.TabIndex = 4;
            this.Q1Label.Text = "Quiz 1:";
            // 
            // Q3Label
            // 
            this.Q3Label.AutoSize = true;
            this.Q3Label.Location = new System.Drawing.Point(764, 316);
            this.Q3Label.Name = "Q3Label";
            this.Q3Label.Size = new System.Drawing.Size(58, 20);
            this.Q3Label.TabIndex = 6;
            this.Q3Label.Text = "Quiz 3:";
            // 
            // Q2Label
            // 
            this.Q2Label.AutoSize = true;
            this.Q2Label.Location = new System.Drawing.Point(764, 277);
            this.Q2Label.Name = "Q2Label";
            this.Q2Label.Size = new System.Drawing.Size(58, 20);
            this.Q2Label.TabIndex = 5;
            this.Q2Label.Text = "Quiz 2:";
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Location = new System.Drawing.Point(764, 468);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(47, 20);
            this.FinalLabel.TabIndex = 10;
            this.FinalLabel.Text = "Final:";
            // 
            // MidLabel
            // 
            this.MidLabel.AutoSize = true;
            this.MidLabel.Location = new System.Drawing.Point(764, 429);
            this.MidLabel.Name = "MidLabel";
            this.MidLabel.Size = new System.Drawing.Size(38, 20);
            this.MidLabel.TabIndex = 9;
            this.MidLabel.Text = "Mid:";
            // 
            // QTLabel
            // 
            this.QTLabel.AutoSize = true;
            this.QTLabel.Location = new System.Drawing.Point(764, 391);
            this.QTLabel.Name = "QTLabel";
            this.QTLabel.Size = new System.Drawing.Size(144, 20);
            this.QTLabel.TabIndex = 8;
            this.QTLabel.Text = "Quiz Total (Best 3):";
            // 
            // Q4Label
            // 
            this.Q4Label.AutoSize = true;
            this.Q4Label.Location = new System.Drawing.Point(764, 353);
            this.Q4Label.Name = "Q4Label";
            this.Q4Label.Size = new System.Drawing.Size(58, 20);
            this.Q4Label.TabIndex = 7;
            this.Q4Label.Text = "Quiz 4:";
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(764, 620);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(58, 20);
            this.GradeLabel.TabIndex = 14;
            this.GradeLabel.Text = "Grade:";
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Location = new System.Drawing.Point(764, 581);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(95, 20);
            this.PercentageLabel.TabIndex = 13;
            this.PercentageLabel.Text = "Percentage:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(764, 543);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(137, 20);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "Total (Out of 300):";
            // 
            // VivaLabel
            // 
            this.VivaLabel.AutoSize = true;
            this.VivaLabel.Location = new System.Drawing.Point(764, 505);
            this.VivaLabel.Name = "VivaLabel";
            this.VivaLabel.Size = new System.Drawing.Size(43, 20);
            this.VivaLabel.TabIndex = 11;
            this.VivaLabel.Text = "Viva:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(310, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Course Name: Object Oriented Concepts 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(304, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(447, 37);
            this.label14.TabIndex = 16;
            this.label14.Text = "IUT Result Processing System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Developed by: 200042165";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.VivaLabel);
            this.Controls.Add(this.FinalLabel);
            this.Controls.Add(this.MidLabel);
            this.Controls.Add(this.QTLabel);
            this.Controls.Add(this.Q4Label);
            this.Controls.Add(this.Q3Label);
            this.Controls.Add(this.Q2Label);
            this.Controls.Add(this.Q1Label);
            this.Controls.Add(this.AttendanceLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.StudentListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label AttendanceLabel;
        private System.Windows.Forms.Label Q1Label;
        private System.Windows.Forms.Label Q3Label;
        private System.Windows.Forms.Label Q2Label;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.Label MidLabel;
        private System.Windows.Forms.Label QTLabel;
        private System.Windows.Forms.Label Q4Label;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label VivaLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
    }
}

