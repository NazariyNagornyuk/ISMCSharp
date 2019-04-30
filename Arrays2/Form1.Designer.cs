namespace Arrays2
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
            this.textBoxProductBetweenMaxAndMinAbs = new System.Windows.Forms.TextBox();
            this.textBoxSumBetweenFirstAndLastZero = new System.Windows.Forms.TextBox();
            this.textBoxSumBetweenFirstMinusAndSecondPlus = new System.Windows.Forms.TextBox();
            this.textBoxProductAfterMin = new System.Windows.Forms.TextBox();
            this.labelMaxAbs = new System.Windows.Forms.Label();
            this.labelIndexMax = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelProductAfterMin = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxNumberOfElements = new System.Windows.Forms.TextBox();
            this.labelNumberOfElements = new System.Windows.Forms.Label();
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxProductBetweenMaxAndMinAbs
            // 
            this.textBoxProductBetweenMaxAndMinAbs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxProductBetweenMaxAndMinAbs.Location = new System.Drawing.Point(296, 329);
            this.textBoxProductBetweenMaxAndMinAbs.Name = "textBoxProductBetweenMaxAndMinAbs";
            this.textBoxProductBetweenMaxAndMinAbs.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductBetweenMaxAndMinAbs.TabIndex = 29;
            // 
            // textBoxSumBetweenFirstAndLastZero
            // 
            this.textBoxSumBetweenFirstAndLastZero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSumBetweenFirstAndLastZero.Location = new System.Drawing.Point(296, 299);
            this.textBoxSumBetweenFirstAndLastZero.Name = "textBoxSumBetweenFirstAndLastZero";
            this.textBoxSumBetweenFirstAndLastZero.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumBetweenFirstAndLastZero.TabIndex = 28;
            // 
            // textBoxSumBetweenFirstMinusAndSecondPlus
            // 
            this.textBoxSumBetweenFirstMinusAndSecondPlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSumBetweenFirstMinusAndSecondPlus.Location = new System.Drawing.Point(296, 275);
            this.textBoxSumBetweenFirstMinusAndSecondPlus.Name = "textBoxSumBetweenFirstMinusAndSecondPlus";
            this.textBoxSumBetweenFirstMinusAndSecondPlus.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumBetweenFirstMinusAndSecondPlus.TabIndex = 27;
            // 
            // textBoxProductAfterMin
            // 
            this.textBoxProductAfterMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxProductAfterMin.Location = new System.Drawing.Point(296, 250);
            this.textBoxProductAfterMin.Name = "textBoxProductAfterMin";
            this.textBoxProductAfterMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductAfterMin.TabIndex = 26;
            // 
            // labelMaxAbs
            // 
            this.labelMaxAbs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMaxAbs.AutoSize = true;
            this.labelMaxAbs.Location = new System.Drawing.Point(4, 336);
            this.labelMaxAbs.Name = "labelMaxAbs";
            this.labelMaxAbs.Size = new System.Drawing.Size(287, 13);
            this.labelMaxAbs.TabIndex = 23;
            this.labelMaxAbs.Text = "Добуток між максимальним і мінімальним за модулем";
            // 
            // labelIndexMax
            // 
            this.labelIndexMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelIndexMax.AutoSize = true;
            this.labelIndexMax.Location = new System.Drawing.Point(4, 306);
            this.labelIndexMax.Name = "labelIndexMax";
            this.labelIndexMax.Size = new System.Drawing.Size(274, 13);
            this.labelIndexMax.TabIndex = 22;
            this.labelIndexMax.Text = "Сума між першим і останнім нульовими елементами";
            // 
            // labelMax
            // 
            this.labelMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(4, 278);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(255, 13);
            this.labelMax.TabIndex = 21;
            this.labelMax.Text = "Сума між першим від\'ємним та другим додатним";
            // 
            // labelProductAfterMin
            // 
            this.labelProductAfterMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelProductAfterMin.AutoSize = true;
            this.labelProductAfterMin.Location = new System.Drawing.Point(3, 250);
            this.labelProductAfterMin.Name = "labelProductAfterMin";
            this.labelProductAfterMin.Size = new System.Drawing.Size(149, 13);
            this.labelProductAfterMin.TabIndex = 20;
            this.labelProductAfterMin.Text = "Добуток після мінімального";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(229, 2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(81, 23);
            this.buttonGenerate.TabIndex = 18;
            this.buttonGenerate.Text = "Згенерувати";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxNumberOfElements
            // 
            this.textBoxNumberOfElements.Location = new System.Drawing.Point(112, 4);
            this.textBoxNumberOfElements.Name = "textBoxNumberOfElements";
            this.textBoxNumberOfElements.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfElements.TabIndex = 17;
            // 
            // labelNumberOfElements
            // 
            this.labelNumberOfElements.AutoSize = true;
            this.labelNumberOfElements.Location = new System.Drawing.Point(3, 7);
            this.labelNumberOfElements.Name = "labelNumberOfElements";
            this.labelNumberOfElements.Size = new System.Drawing.Size(103, 13);
            this.labelNumberOfElements.TabIndex = 16;
            this.labelNumberOfElements.Text = "Скільки елементів:";
            // 
            // listBoxArray
            // 
            this.listBoxArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.Location = new System.Drawing.Point(6, 37);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(390, 186);
            this.listBoxArray.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 361);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.textBoxProductBetweenMaxAndMinAbs);
            this.Controls.Add(this.textBoxSumBetweenFirstAndLastZero);
            this.Controls.Add(this.textBoxSumBetweenFirstMinusAndSecondPlus);
            this.Controls.Add(this.textBoxProductAfterMin);
            this.Controls.Add(this.labelMaxAbs);
            this.Controls.Add(this.labelIndexMax);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelProductAfterMin);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxNumberOfElements);
            this.Controls.Add(this.labelNumberOfElements);
            this.MinimumSize = new System.Drawing.Size(419, 399);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductBetweenMaxAndMinAbs;
        private System.Windows.Forms.TextBox textBoxSumBetweenFirstAndLastZero;
        private System.Windows.Forms.TextBox textBoxSumBetweenFirstMinusAndSecondPlus;
        private System.Windows.Forms.TextBox textBoxProductAfterMin;
        private System.Windows.Forms.Label labelMaxAbs;
        private System.Windows.Forms.Label labelIndexMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelProductAfterMin;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxNumberOfElements;
        private System.Windows.Forms.Label labelNumberOfElements;
        private System.Windows.Forms.ListBox listBoxArray;
    }
}

