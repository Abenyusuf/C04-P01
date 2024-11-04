namespace WindowsFormsApp1
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
            this.TextLabelOne = new System.Windows.Forms.Label();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.AgeCheck = new System.Windows.Forms.CheckBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextLabelOne
            // 
            this.TextLabelOne.AutoSize = true;
            this.TextLabelOne.Location = new System.Drawing.Point(12, 29);
            this.TextLabelOne.Name = "TextLabelOne";
            this.TextLabelOne.Size = new System.Drawing.Size(325, 20);
            this.TextLabelOne.TabIndex = 0;
            this.TextLabelOne.Text = "Please input the number of books purchased";
            // 
            // InputTextbox
            // 
            this.InputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputTextbox.Location = new System.Drawing.Point(343, 29);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(100, 19);
            this.InputTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount of points earned";
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.SystemColors.Window;
            this.OutputLabel.Location = new System.Drawing.Point(343, 101);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(100, 23);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(221, 200);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 40);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(351, 192);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(94, 34);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.CalculateButton);
            this.GroupBox.Controls.Add(this.AgeCheck);
            this.GroupBox.Location = new System.Drawing.Point(-4, -1);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(521, 254);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            // 
            // AgeCheck
            // 
            this.AgeCheck.AutoSize = true;
            this.AgeCheck.Location = new System.Drawing.Point(332, 149);
            this.AgeCheck.Name = "AgeCheck";
            this.AgeCheck.Size = new System.Drawing.Size(119, 24);
            this.AgeCheck.TabIndex = 0;
            this.AgeCheck.Text = "55 or older?";
            this.AgeCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 252);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.TextLabelOne);
            this.Controls.Add(this.GroupBox);
            this.Name = "Form1";
            this.Text = "Book point calculator";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLabelOne;
        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.CheckBox AgeCheck;
    }
}

