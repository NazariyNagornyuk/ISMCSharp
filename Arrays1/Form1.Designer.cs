namespace Arrays1
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
            this.labelNumberOfElements = new System.Windows.Forms.Label();
            this.textBoxNumberOfElements = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelSumMinus = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelIndexMax = new System.Windows.Forms.Label();
            this.labelMaxAbs = new System.Windows.Forms.Label();
            this.labelSumPlusIndex = new System.Windows.Forms.Label();
            this.labelInt = new System.Windows.Forms.Label();
            this.textBoxSumMinus = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMaxIndex = new System.Windows.Forms.TextBox();
            this.textBoxNumberInt = new System.Windows.Forms.TextBox();
            this.textBoxSumPlusIndex = new System.Windows.Forms.TextBox();
            this.textBoxMaxAbs = new System.Windows.Forms.TextBox();
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelNumberOfElements
            // 
            this.labelNumberOfElements.AutoSize = true;
            this.labelNumberOfElements.Location = new System.Drawing.Point(13, 13);
            this.labelNumberOfElements.Name = "labelNumberOfElements";
            this.labelNumberOfElements.Size = new System.Drawing.Size(103, 13);
            this.labelNumberOfElements.TabIndex = 0;
            this.labelNumberOfElements.Text = "Скільки елементів:";
            // 
            // textBoxNumberOfElements
            // 
            this.textBoxNumberOfElements.Location = new System.Drawing.Point(122, 10);
            this.textBoxNumberOfElements.Name = "textBoxNumberOfElements";
            this.textBoxNumberOfElements.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfElements.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(239, 8);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(81, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Згенерувати";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelSumMinus
            // 
            this.labelSumMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSumMinus.AutoSize = true;
            this.labelSumMinus.Location = new System.Drawing.Point(12, 266);
            this.labelSumMinus.Name = "labelSumMinus";
            this.labelSumMinus.Size = new System.Drawing.Size(137, 13);
            this.labelSumMinus.TabIndex = 4;
            this.labelSumMinus.Text = "Сума від\'ємних елементів";
            // 
            // labelMax
            // 
            this.labelMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(13, 294);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(130, 13);
            this.labelMax.TabIndex = 5;
            this.labelMax.Text = "Максимальний елемент";
            // 
            // labelIndexMax
            // 
            this.labelIndexMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIndexMax.AutoSize = true;
            this.labelIndexMax.Location = new System.Drawing.Point(13, 322);
            this.labelIndexMax.Name = "labelIndexMax";
            this.labelIndexMax.Size = new System.Drawing.Size(124, 13);
            this.labelIndexMax.TabIndex = 6;
            this.labelIndexMax.Text = "Індекс максимального";
            // 
            // labelMaxAbs
            // 
            this.labelMaxAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaxAbs.AutoSize = true;
            this.labelMaxAbs.Location = new System.Drawing.Point(302, 266);
            this.labelMaxAbs.Name = "labelMaxAbs";
            this.labelMaxAbs.Size = new System.Drawing.Size(147, 13);
            this.labelMaxAbs.TabIndex = 7;
            this.labelMaxAbs.Text = "Максимальний за модулем";
            // 
            // labelSumPlusIndex
            // 
            this.labelSumPlusIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSumPlusIndex.AutoSize = true;
            this.labelSumPlusIndex.Location = new System.Drawing.Point(302, 294);
            this.labelSumPlusIndex.Name = "labelSumPlusIndex";
            this.labelSumPlusIndex.Size = new System.Drawing.Size(121, 13);
            this.labelSumPlusIndex.TabIndex = 8;
            this.labelSumPlusIndex.Text = "Сума індексів додатніх";
            // 
            // labelInt
            // 
            this.labelInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInt.AutoSize = true;
            this.labelInt.Location = new System.Drawing.Point(302, 322);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(113, 13);
            this.labelInt.TabIndex = 9;
            this.labelInt.Text = "Кількість цілих чисел";
            // 
            // textBoxSumMinus
            // 
            this.textBoxSumMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSumMinus.Location = new System.Drawing.Point(155, 263);
            this.textBoxSumMinus.Name = "textBoxSumMinus";
            this.textBoxSumMinus.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumMinus.TabIndex = 10;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMax.Location = new System.Drawing.Point(155, 291);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 11;
            // 
            // textBoxMaxIndex
            // 
            this.textBoxMaxIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMaxIndex.Location = new System.Drawing.Point(155, 319);
            this.textBoxMaxIndex.Name = "textBoxMaxIndex";
            this.textBoxMaxIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxIndex.TabIndex = 12;
            // 
            // textBoxNumberInt
            // 
            this.textBoxNumberInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNumberInt.Location = new System.Drawing.Point(458, 319);
            this.textBoxNumberInt.Name = "textBoxNumberInt";
            this.textBoxNumberInt.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberInt.TabIndex = 15;
            // 
            // textBoxSumPlusIndex
            // 
            this.textBoxSumPlusIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSumPlusIndex.Location = new System.Drawing.Point(458, 291);
            this.textBoxSumPlusIndex.Name = "textBoxSumPlusIndex";
            this.textBoxSumPlusIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumPlusIndex.TabIndex = 14;
            // 
            // textBoxMaxAbs
            // 
            this.textBoxMaxAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMaxAbs.Location = new System.Drawing.Point(458, 263);
            this.textBoxMaxAbs.Name = "textBoxMaxAbs";
            this.textBoxMaxAbs.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxAbs.TabIndex = 13;
            // 
            // listBoxArray
            // 
            this.listBoxArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.Location = new System.Drawing.Point(12, 36);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(542, 212);
            this.listBoxArray.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 350);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.textBoxNumberInt);
            this.Controls.Add(this.textBoxSumPlusIndex);
            this.Controls.Add(this.textBoxMaxAbs);
            this.Controls.Add(this.textBoxMaxIndex);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxSumMinus);
            this.Controls.Add(this.labelInt);
            this.Controls.Add(this.labelSumPlusIndex);
            this.Controls.Add(this.labelMaxAbs);
            this.Controls.Add(this.labelIndexMax);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelSumMinus);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxNumberOfElements);
            this.Controls.Add(this.labelNumberOfElements);
            this.MinimumSize = new System.Drawing.Size(583, 388);
            this.Name = "Form1";
            this.Text = "Arrays1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfElements;
        private System.Windows.Forms.TextBox textBoxNumberOfElements;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelSumMinus;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelIndexMax;
        private System.Windows.Forms.Label labelMaxAbs;
        private System.Windows.Forms.Label labelSumPlusIndex;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.TextBox textBoxSumMinus;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMaxIndex;
        private System.Windows.Forms.TextBox textBoxNumberInt;
        private System.Windows.Forms.TextBox textBoxSumPlusIndex;
        private System.Windows.Forms.TextBox textBoxMaxAbs;
        private System.Windows.Forms.ListBox listBoxArray;
    }
}

