
namespace CalculatorApp
{
    partial class CalcForm
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
            this.oneButton = new System.Windows.Forms.Button();
            this.eigftButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.twoButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.leftBracket = new System.Windows.Forms.Button();
            this.rightBracket = new System.Windows.Forms.Button();
            this.devisionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.functionDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(14, 422);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(80, 80);
            this.oneButton.TabIndex = 0;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // eigftButton
            // 
            this.eigftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eigftButton.Location = new System.Drawing.Point(100, 250);
            this.eigftButton.Name = "eigftButton";
            this.eigftButton.Size = new System.Drawing.Size(80, 80);
            this.eigftButton.TabIndex = 1;
            this.eigftButton.Text = "8";
            this.eigftButton.UseVisualStyleBackColor = true;
            this.eigftButton.Click += new System.EventHandler(this.eigftButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(14, 250);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(80, 80);
            this.sevenButton.TabIndex = 2;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(100, 508);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(80, 80);
            this.zeroButton.TabIndex = 3;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(14, 508);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 80);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(100, 336);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(80, 80);
            this.fiveButton.TabIndex = 5;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(14, 336);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(80, 80);
            this.fourButton.TabIndex = 6;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // display
            // 
            this.display.AutoEllipsis = true;
            this.display.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Location = new System.Drawing.Point(14, 60);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(338, 86);
            this.display.TabIndex = 7;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(100, 422);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(80, 80);
            this.twoButton.TabIndex = 8;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalButton.Location = new System.Drawing.Point(272, 422);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(80, 166);
            this.equalButton.TabIndex = 9;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(186, 336);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(80, 80);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(186, 250);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(80, 80);
            this.nineButton.TabIndex = 11;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(186, 422);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(80, 80);
            this.threeButton.TabIndex = 12;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(272, 250);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(80, 80);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(272, 336);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(80, 80);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // leftBracket
            // 
            this.leftBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBracket.Location = new System.Drawing.Point(14, 164);
            this.leftBracket.Name = "leftBracket";
            this.leftBracket.Size = new System.Drawing.Size(80, 80);
            this.leftBracket.TabIndex = 16;
            this.leftBracket.Text = "(";
            this.leftBracket.UseVisualStyleBackColor = true;
            // 
            // rightBracket
            // 
            this.rightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBracket.Location = new System.Drawing.Point(100, 164);
            this.rightBracket.Name = "rightBracket";
            this.rightBracket.Size = new System.Drawing.Size(80, 80);
            this.rightBracket.TabIndex = 17;
            this.rightBracket.Text = ")";
            this.rightBracket.UseVisualStyleBackColor = true;
            // 
            // devisionButton
            // 
            this.devisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devisionButton.Location = new System.Drawing.Point(186, 164);
            this.devisionButton.Name = "devisionButton";
            this.devisionButton.Size = new System.Drawing.Size(80, 80);
            this.devisionButton.TabIndex = 18;
            this.devisionButton.Text = "/";
            this.devisionButton.UseVisualStyleBackColor = true;
            this.devisionButton.Click += new System.EventHandler(this.devisionButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.Location = new System.Drawing.Point(272, 164);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(80, 80);
            this.multiplyButton.TabIndex = 19;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decimalButton.Location = new System.Drawing.Point(186, 508);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(80, 80);
            this.decimalButton.TabIndex = 20;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // functionDisplay
            // 
            this.functionDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.functionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.functionDisplay.Location = new System.Drawing.Point(14, 20);
            this.functionDisplay.Name = "functionDisplay";
            this.functionDisplay.Size = new System.Drawing.Size(338, 40);
            this.functionDisplay.TabIndex = 21;
            this.functionDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 602);
            this.Controls.Add(this.functionDisplay);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.devisionButton);
            this.Controls.Add(this.rightBracket);
            this.Controls.Add(this.leftBracket);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.display);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.eigftButton);
            this.Controls.Add(this.oneButton);
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button eigftButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button leftBracket;
        private System.Windows.Forms.Button rightBracket;
        private System.Windows.Forms.Button devisionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Label functionDisplay;
    }
}

