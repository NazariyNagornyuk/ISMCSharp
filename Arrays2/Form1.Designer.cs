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
            this.ArrayTable = new System.Windows.Forms.DataGridView();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxNumberOfElements = new System.Windows.Forms.TextBox();
            this.labelNumberOfElements = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayTable)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductBetweenMaxAndMinAbs
            // 
            this.textBoxProductBetweenMaxAndMinAbs.Location = new System.Drawing.Point(295, 219);
            this.textBoxProductBetweenMaxAndMinAbs.Name = "textBoxProductBetweenMaxAndMinAbs";
            this.textBoxProductBetweenMaxAndMinAbs.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductBetweenMaxAndMinAbs.TabIndex = 29;
            // 
            // textBoxSumBetweenFirstAndLastZero
            // 
            this.textBoxSumBetweenFirstAndLastZero.Location = new System.Drawing.Point(295, 189);
            this.textBoxSumBetweenFirstAndLastZero.Name = "textBoxSumBetweenFirstAndLastZero";
            this.textBoxSumBetweenFirstAndLastZero.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumBetweenFirstAndLastZero.TabIndex = 28;
            // 
            // textBoxSumBetweenFirstMinusAndSecondPlus
            // 
            this.textBoxSumBetweenFirstMinusAndSecondPlus.Location = new System.Drawing.Point(295, 165);
            this.textBoxSumBetweenFirstMinusAndSecondPlus.Name = "textBoxSumBetweenFirstMinusAndSecondPlus";
            this.textBoxSumBetweenFirstMinusAndSecondPlus.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumBetweenFirstMinusAndSecondPlus.TabIndex = 27;
            // 
            // textBoxProductAfterMin
            // 
            this.textBoxProductAfterMin.Location = new System.Drawing.Point(295, 140);
            this.textBoxProductAfterMin.Name = "textBoxProductAfterMin";
            this.textBoxProductAfterMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductAfterMin.TabIndex = 26;
            // 
            // labelMaxAbs
            // 
            this.labelMaxAbs.AutoSize = true;
            this.labelMaxAbs.Location = new System.Drawing.Point(3, 226);
            this.labelMaxAbs.Name = "labelMaxAbs";
            this.labelMaxAbs.Size = new System.Drawing.Size(287, 13);
            this.labelMaxAbs.TabIndex = 23;
            this.labelMaxAbs.Text = "Добуток між максимальним і мінімальним за модулем";
            // 
            // labelIndexMax
            // 
            this.labelIndexMax.AutoSize = true;
            this.labelIndexMax.Location = new System.Drawing.Point(3, 196);
            this.labelIndexMax.Name = "labelIndexMax";
            this.labelIndexMax.Size = new System.Drawing.Size(274, 13);
            this.labelIndexMax.TabIndex = 22;
            this.labelIndexMax.Text = "Сума між першим і останнім нульовими елементами";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(3, 168);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(255, 13);
            this.labelMax.TabIndex = 21;
            this.labelMax.Text = "Сума між першим від\'ємним та другим додатним";
            // 
            // labelProductAfterMin
            // 
            this.labelProductAfterMin.AutoSize = true;
            this.labelProductAfterMin.Location = new System.Drawing.Point(2, 140);
            this.labelProductAfterMin.Name = "labelProductAfterMin";
            this.labelProductAfterMin.Size = new System.Drawing.Size(149, 13);
            this.labelProductAfterMin.TabIndex = 20;
            this.labelProductAfterMin.Text = "Добуток після мінімального";
            // 
            // ArrayTable
            // 
            this.ArrayTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrayTable.Location = new System.Drawing.Point(2, 30);
            this.ArrayTable.Name = "ArrayTable";
            this.ArrayTable.Size = new System.Drawing.Size(668, 103);
            this.ArrayTable.TabIndex = 19;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 257);
            this.Controls.Add(this.textBoxProductBetweenMaxAndMinAbs);
            this.Controls.Add(this.textBoxSumBetweenFirstAndLastZero);
            this.Controls.Add(this.textBoxSumBetweenFirstMinusAndSecondPlus);
            this.Controls.Add(this.textBoxProductAfterMin);
            this.Controls.Add(this.labelMaxAbs);
            this.Controls.Add(this.labelIndexMax);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelProductAfterMin);
            this.Controls.Add(this.ArrayTable);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxNumberOfElements);
            this.Controls.Add(this.labelNumberOfElements);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ArrayTable)).EndInit();
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
        private System.Windows.Forms.DataGridView ArrayTable;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxNumberOfElements;
        private System.Windows.Forms.Label labelNumberOfElements;
    }
}

