namespace Conversions
{
    partial class Conversions
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.conversionChoiceLabel = new System.Windows.Forms.Label();
            this.conversionChoiceInput = new System.Windows.Forms.TextBox();
            this.conversionValueLabel = new System.Windows.Forms.Label();
            this.conversionValueInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titleLabel.Location = new System.Drawing.Point(132, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Conversion";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.optionsLabel.Location = new System.Drawing.Point(163, 91);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(222, 100);
            this.optionsLabel.TabIndex = 1;
            this.optionsLabel.Text = "1. Inches to Centimetres\r\n2. Feet to Centimetres\r\n3. Yards to Metres\r\n4. Miles to" +
    " Kilometres";
            // 
            // conversionChoiceLabel
            // 
            this.conversionChoiceLabel.AutoSize = true;
            this.conversionChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.conversionChoiceLabel.Location = new System.Drawing.Point(100, 258);
            this.conversionChoiceLabel.Name = "conversionChoiceLabel";
            this.conversionChoiceLabel.Size = new System.Drawing.Size(227, 20);
            this.conversionChoiceLabel.TabIndex = 2;
            this.conversionChoiceLabel.Text = "Enter conversion choice (1 - 4):";
            // 
            // conversionChoiceInput
            // 
            this.conversionChoiceInput.Location = new System.Drawing.Point(353, 258);
            this.conversionChoiceInput.Name = "conversionChoiceInput";
            this.conversionChoiceInput.Size = new System.Drawing.Size(100, 20);
            this.conversionChoiceInput.TabIndex = 3;
            // 
            // conversionValueLabel
            // 
            this.conversionValueLabel.AutoSize = true;
            this.conversionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.conversionValueLabel.Location = new System.Drawing.Point(104, 296);
            this.conversionValueLabel.Name = "conversionValueLabel";
            this.conversionValueLabel.Size = new System.Drawing.Size(207, 20);
            this.conversionValueLabel.TabIndex = 4;
            this.conversionValueLabel.Text = "Enter value to be converted:";
            // 
            // conversionValueInput
            // 
            this.conversionValueInput.Location = new System.Drawing.Point(353, 296);
            this.conversionValueInput.Name = "conversionValueInput";
            this.conversionValueInput.Size = new System.Drawing.Size(100, 20);
            this.conversionValueInput.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(108, 341);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(345, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(135, 367);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(289, 38);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.conversionValueInput);
            this.Controls.Add(this.conversionValueLabel);
            this.Controls.Add(this.conversionChoiceInput);
            this.Controls.Add(this.conversionChoiceLabel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Conversions";
            this.Text = "Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label conversionChoiceLabel;
        private System.Windows.Forms.TextBox conversionChoiceInput;
        private System.Windows.Forms.Label conversionValueLabel;
        private System.Windows.Forms.TextBox conversionValueInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

