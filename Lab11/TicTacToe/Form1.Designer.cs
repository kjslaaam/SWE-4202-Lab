namespace TicTacToe
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
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1ScoreLabel = new System.Windows.Forms.Label();
            this.Player2ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(173, 147);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(26, 26);
            this.textBox11.TabIndex = 0;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(225, 147);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(26, 26);
            this.textBox12.TabIndex = 1;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(279, 147);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(26, 26);
            this.textBox13.TabIndex = 2;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(279, 208);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(26, 26);
            this.textBox23.TabIndex = 5;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(225, 208);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(26, 26);
            this.textBox22.TabIndex = 4;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(173, 208);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(26, 26);
            this.textBox21.TabIndex = 3;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(279, 272);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(26, 26);
            this.textBox33.TabIndex = 8;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(225, 272);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(26, 26);
            this.textBox32.TabIndex = 7;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(173, 272);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(26, 26);
            this.textBox31.TabIndex = 6;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(441, 208);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 39);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Instructions: Enter \"x\" if player 1 and \"o\" if player 2 in box and click \"Submit\"" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "TicTacToe";
            // 
            // Player1ScoreLabel
            // 
            this.Player1ScoreLabel.AutoSize = true;
            this.Player1ScoreLabel.Location = new System.Drawing.Point(173, 336);
            this.Player1ScoreLabel.Name = "Player1ScoreLabel";
            this.Player1ScoreLabel.Size = new System.Drawing.Size(82, 20);
            this.Player1ScoreLabel.TabIndex = 12;
            this.Player1ScoreLabel.Text = "Player 1: 0";
            // 
            // Player2ScoreLabel
            // 
            this.Player2ScoreLabel.AutoSize = true;
            this.Player2ScoreLabel.Location = new System.Drawing.Point(173, 382);
            this.Player2ScoreLabel.Name = "Player2ScoreLabel";
            this.Player2ScoreLabel.Size = new System.Drawing.Size(82, 20);
            this.Player2ScoreLabel.TabIndex = 13;
            this.Player2ScoreLabel.Text = "Player 2: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player2ScoreLabel);
            this.Controls.Add(this.Player1ScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.textBox33);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player1ScoreLabel;
        private System.Windows.Forms.Label Player2ScoreLabel;
    }
}

