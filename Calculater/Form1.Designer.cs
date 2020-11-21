namespace Calculater
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.CalculateDisplay = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.buttonPlusMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(22, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(123, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 75);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(224, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 75);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.OrangeRed;
            this.Plus.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Plus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plus.Location = new System.Drawing.Point(324, 55);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(95, 75);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.OrangeRed;
            this.Result.Cursor = System.Windows.Forms.Cursors.Default;
            this.Result.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Result.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(22, 379);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(196, 75);
            this.Result.TabIndex = 0;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = false;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // CalculateDisplay
            // 
            this.CalculateDisplay.BackColor = System.Drawing.Color.Azure;
            this.CalculateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculateDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CalculateDisplay.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CalculateDisplay.Location = new System.Drawing.Point(22, 55);
            this.CalculateDisplay.Name = "CalculateDisplay";
            this.CalculateDisplay.Size = new System.Drawing.Size(297, 70);
            this.CalculateDisplay.TabIndex = 1;
            this.CalculateDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(22, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 75);
            this.button6.TabIndex = 0;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.OrangeRed;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(123, 217);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 75);
            this.button7.TabIndex = 0;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.OrangeRed;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(224, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 75);
            this.button8.TabIndex = 0;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.OrangeRed;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(22, 298);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 75);
            this.button9.TabIndex = 0;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.OrangeRed;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(123, 298);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 75);
            this.button10.TabIndex = 0;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.OrangeRed;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(224, 298);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(95, 75);
            this.button11.TabIndex = 0;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.Color.OrangeRed;
            this.Subtraction.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Subtraction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Subtraction.Location = new System.Drawing.Point(324, 217);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(95, 75);
            this.Subtraction.TabIndex = 0;
            this.Subtraction.Text = "*";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.OrangeRed;
            this.Division.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Division.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Division.Location = new System.Drawing.Point(324, 298);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(95, 75);
            this.Division.TabIndex = 0;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.Color.OrangeRed;
            this.Sqrt.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Sqrt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sqrt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sqrt.Location = new System.Drawing.Point(324, 379);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(95, 75);
            this.Sqrt.TabIndex = 0;
            this.Sqrt.Text = "^";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.OrangeRed;
            this.Minus.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Minus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(324, 136);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(95, 75);
            this.Minus.TabIndex = 0;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-321, -109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(224, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 75);
            this.button5.TabIndex = 0;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Number1.Location = new System.Drawing.Point(22, 22);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(0, 15);
            this.Number1.TabIndex = 5;
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Operation.Location = new System.Drawing.Point(85, 22);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(0, 15);
            this.Operation.TabIndex = 5;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Error.Location = new System.Drawing.Point(151, 22);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 15);
            this.Error.TabIndex = 5;
            // 
            // buttonPlusMin
            // 
            this.buttonPlusMin.BackColor = System.Drawing.Color.White;
            this.buttonPlusMin.FlatAppearance.BorderSize = 0;
            this.buttonPlusMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlusMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPlusMin.Location = new System.Drawing.Point(34, 68);
            this.buttonPlusMin.Name = "buttonPlusMin";
            this.buttonPlusMin.Size = new System.Drawing.Size(40, 42);
            this.buttonPlusMin.TabIndex = 6;
            this.buttonPlusMin.Text = "+ -";
            this.buttonPlusMin.UseVisualStyleBackColor = false;
            this.buttonPlusMin.Click += new System.EventHandler(this.buttonPlusMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(440, 483);
            this.Controls.Add(this.buttonPlusMin);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.CalculateDisplay);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculater";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.TextBox CalculateDisplay;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button buttonPlusMin;
    }
}

