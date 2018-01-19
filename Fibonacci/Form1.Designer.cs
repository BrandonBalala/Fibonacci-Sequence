namespace Fibonacci
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
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.loopResultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.fibonacciTextBox = new System.Windows.Forms.TextBox();
            this.calculateFibLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.recursiveResultTextBox = new System.Windows.Forms.TextBox();
            this.loopTimeTextBox = new System.Windows.Forms.TextBox();
            this.recursiveTimeTextBox = new System.Windows.Forms.TextBox();
            this.loopLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.recursiveLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recursiveCheckBox = new System.Windows.Forms.CheckBox();
            this.loopCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.formTitleLabel.Font = new System.Drawing.Font("OCR A Extended", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.Location = new System.Drawing.Point(12, 12);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(319, 29);
            this.formTitleLabel.TabIndex = 0;
            this.formTitleLabel.Text = "Fibonacci Sequence";
            // 
            // loopResultTextBox
            // 
            this.loopResultTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loopResultTextBox.Location = new System.Drawing.Point(100, 210);
            this.loopResultTextBox.Name = "loopResultTextBox";
            this.loopResultTextBox.ReadOnly = true;
            this.loopResultTextBox.Size = new System.Drawing.Size(145, 20);
            this.loopResultTextBox.TabIndex = 8;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(34, 209);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(65, 21);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result: ";
            // 
            // fibonacciTextBox
            // 
            this.fibonacciTextBox.Location = new System.Drawing.Point(127, 108);
            this.fibonacciTextBox.Name = "fibonacciTextBox";
            this.fibonacciTextBox.Size = new System.Drawing.Size(179, 20);
            this.fibonacciTextBox.TabIndex = 0;
            // 
            // calculateFibLabel
            // 
            this.calculateFibLabel.AutoSize = true;
            this.calculateFibLabel.BackColor = System.Drawing.Color.Transparent;
            this.calculateFibLabel.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateFibLabel.Location = new System.Drawing.Point(123, 85);
            this.calculateFibLabel.Name = "calculateFibLabel";
            this.calculateFibLabel.Size = new System.Drawing.Size(208, 20);
            this.calculateFibLabel.TabIndex = 4;
            this.calculateFibLabel.Text = "Calculate Fibonacci Number:";
            // 
            // calculateButton
            // 
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Location = new System.Drawing.Point(175, 133);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(87, 26);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // recursiveResultTextBox
            // 
            this.recursiveResultTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.recursiveResultTextBox.Location = new System.Drawing.Point(251, 210);
            this.recursiveResultTextBox.Name = "recursiveResultTextBox";
            this.recursiveResultTextBox.ReadOnly = true;
            this.recursiveResultTextBox.Size = new System.Drawing.Size(145, 20);
            this.recursiveResultTextBox.TabIndex = 11;
            // 
            // loopTimeTextBox
            // 
            this.loopTimeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loopTimeTextBox.Location = new System.Drawing.Point(100, 236);
            this.loopTimeTextBox.Name = "loopTimeTextBox";
            this.loopTimeTextBox.ReadOnly = true;
            this.loopTimeTextBox.Size = new System.Drawing.Size(145, 20);
            this.loopTimeTextBox.TabIndex = 12;
            // 
            // recursiveTimeTextBox
            // 
            this.recursiveTimeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.recursiveTimeTextBox.Location = new System.Drawing.Point(251, 236);
            this.recursiveTimeTextBox.Name = "recursiveTimeTextBox";
            this.recursiveTimeTextBox.ReadOnly = true;
            this.recursiveTimeTextBox.Size = new System.Drawing.Size(145, 20);
            this.recursiveTimeTextBox.TabIndex = 13;
            // 
            // loopLabel
            // 
            this.loopLabel.AutoSize = true;
            this.loopLabel.BackColor = System.Drawing.Color.Transparent;
            this.loopLabel.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopLabel.Location = new System.Drawing.Point(96, 186);
            this.loopLabel.Name = "loopLabel";
            this.loopLabel.Size = new System.Drawing.Size(48, 21);
            this.loopLabel.TabIndex = 14;
            this.loopLabel.Text = "Loop";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(34, 235);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 21);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "Time:";
            // 
            // recursiveLabel
            // 
            this.recursiveLabel.AutoSize = true;
            this.recursiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.recursiveLabel.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recursiveLabel.Location = new System.Drawing.Point(247, 186);
            this.recursiveLabel.Name = "recursiveLabel";
            this.recursiveLabel.Size = new System.Drawing.Size(83, 21);
            this.recursiveLabel.TabIndex = 15;
            this.recursiveLabel.Text = "Recursive";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.recursiveCheckBox);
            this.groupBox1.Controls.Add(this.loopCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(337, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 67);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // recursiveCheckBox
            // 
            this.recursiveCheckBox.AutoSize = true;
            this.recursiveCheckBox.Location = new System.Drawing.Point(7, 43);
            this.recursiveCheckBox.Name = "recursiveCheckBox";
            this.recursiveCheckBox.Size = new System.Drawing.Size(74, 17);
            this.recursiveCheckBox.TabIndex = 1;
            this.recursiveCheckBox.Text = "Recursive";
            this.recursiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // loopCheckBox
            // 
            this.loopCheckBox.AutoSize = true;
            this.loopCheckBox.Checked = true;
            this.loopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopCheckBox.Location = new System.Drawing.Point(7, 20);
            this.loopCheckBox.Name = "loopCheckBox";
            this.loopCheckBox.Size = new System.Drawing.Size(50, 17);
            this.loopCheckBox.TabIndex = 0;
            this.loopCheckBox.Text = "Loop";
            this.loopCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fibonacci.Properties.Resources.Picture1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.recursiveLabel);
            this.Controls.Add(this.loopLabel);
            this.Controls.Add(this.recursiveTimeTextBox);
            this.Controls.Add(this.loopTimeTextBox);
            this.Controls.Add(this.recursiveResultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.loopResultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.fibonacciTextBox);
            this.Controls.Add(this.calculateFibLabel);
            this.Controls.Add(this.formTitleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.TextBox loopResultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox fibonacciTextBox;
        private System.Windows.Forms.Label calculateFibLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox recursiveResultTextBox;
        private System.Windows.Forms.TextBox loopTimeTextBox;
        private System.Windows.Forms.TextBox recursiveTimeTextBox;
        private System.Windows.Forms.Label loopLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label recursiveLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox recursiveCheckBox;
        private System.Windows.Forms.CheckBox loopCheckBox;
        private System.Windows.Forms.Label label1;
    }
}

