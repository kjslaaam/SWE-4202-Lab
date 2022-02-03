namespace Banking_System
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
            this.initialAmountTextBox = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.ACNumberTextBox = new System.Windows.Forms.TextBox();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.ACNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.ACNumberTextBox2 = new System.Windows.Forms.TextBox();
            this.checkDetailsButton = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.numberOfTransactionsLabel = new System.Windows.Forms.Label();
            this.typeSelectTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // initialAmountTextBox
            // 
            this.initialAmountTextBox.Location = new System.Drawing.Point(71, 98);
            this.initialAmountTextBox.Name = "initialAmountTextBox";
            this.initialAmountTextBox.Size = new System.Drawing.Size(174, 26);
            this.initialAmountTextBox.TabIndex = 1;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(71, 149);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(174, 32);
            this.createAccountButton.TabIndex = 2;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // ACNumberTextBox
            // 
            this.ACNumberTextBox.Location = new System.Drawing.Point(465, 53);
            this.ACNumberTextBox.Name = "ACNumberTextBox";
            this.ACNumberTextBox.Size = new System.Drawing.Size(174, 26);
            this.ACNumberTextBox.TabIndex = 3;
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(465, 98);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(174, 26);
            this.depositTextBox.TabIndex = 4;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(465, 149);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(174, 32);
            this.depositButton.TabIndex = 5;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(817, 149);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(174, 32);
            this.withdrawButton.TabIndex = 8;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(817, 98);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(174, 26);
            this.withdrawTextBox.TabIndex = 7;
            // 
            // ACNumberTextBox1
            // 
            this.ACNumberTextBox1.Location = new System.Drawing.Point(817, 53);
            this.ACNumberTextBox1.Name = "ACNumberTextBox1";
            this.ACNumberTextBox1.Size = new System.Drawing.Size(174, 26);
            this.ACNumberTextBox1.TabIndex = 6;
            // 
            // ACNumberTextBox2
            // 
            this.ACNumberTextBox2.Location = new System.Drawing.Point(71, 256);
            this.ACNumberTextBox2.Name = "ACNumberTextBox2";
            this.ACNumberTextBox2.Size = new System.Drawing.Size(174, 26);
            this.ACNumberTextBox2.TabIndex = 9;
            // 
            // checkDetailsButton
            // 
            this.checkDetailsButton.Location = new System.Drawing.Point(71, 339);
            this.checkDetailsButton.Name = "checkDetailsButton";
            this.checkDetailsButton.Size = new System.Drawing.Size(174, 32);
            this.checkDetailsButton.TabIndex = 10;
            this.checkDetailsButton.Text = "Check Details";
            this.checkDetailsButton.UseVisualStyleBackColor = true;
            this.checkDetailsButton.Click += new System.EventHandler(this.checkDetailsButton_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(324, 256);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(71, 20);
            this.balanceLabel.TabIndex = 11;
            this.balanceLabel.Text = "Balance:";
            // 
            // numberOfTransactionsLabel
            // 
            this.numberOfTransactionsLabel.AutoSize = true;
            this.numberOfTransactionsLabel.Location = new System.Drawing.Point(328, 339);
            this.numberOfTransactionsLabel.Name = "numberOfTransactionsLabel";
            this.numberOfTransactionsLabel.Size = new System.Drawing.Size(178, 20);
            this.numberOfTransactionsLabel.TabIndex = 12;
            this.numberOfTransactionsLabel.Text = "Number of transactions:";
            // 
            // typeSelectTextBox
            // 
            this.typeSelectTextBox.Location = new System.Drawing.Point(71, 53);
            this.typeSelectTextBox.Name = "typeSelectTextBox";
            this.typeSelectTextBox.Size = new System.Drawing.Size(174, 26);
            this.typeSelectTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.typeSelectTextBox);
            this.Controls.Add(this.numberOfTransactionsLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.checkDetailsButton);
            this.Controls.Add(this.ACNumberTextBox2);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.withdrawTextBox);
            this.Controls.Add(this.ACNumberTextBox1);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.ACNumberTextBox);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.initialAmountTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox initialAmountTextBox;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox ACNumberTextBox;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.TextBox ACNumberTextBox1;
        private System.Windows.Forms.TextBox ACNumberTextBox2;
        private System.Windows.Forms.Button checkDetailsButton;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label numberOfTransactionsLabel;
        private System.Windows.Forms.TextBox typeSelectTextBox;
    }
}

