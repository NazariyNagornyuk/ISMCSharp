namespace WinForm01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "x=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "y=";
            // 
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(38, 9);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(141, 20);
            this.TextBoxA.TabIndex = 4;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(38, 35);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(141, 20);
            this.TextBoxB.TabIndex = 5;
            // 
            // TextBoxX
            // 
            this.TextBoxX.Location = new System.Drawing.Point(38, 61);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(141, 20);
            this.TextBoxX.TabIndex = 6;
            // 
            // TextBoxY
            // 
            this.TextBoxY.Location = new System.Drawing.Point(38, 125);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.ReadOnly = true;
            this.TextBoxY.Size = new System.Drawing.Size(141, 20);
            this.TextBoxY.TabIndex = 7;
            // 
            // ButtonResult
            // 
            this.ButtonResult.Location = new System.Drawing.Point(12, 87);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(167, 32);
            this.ButtonResult.TabIndex = 8;
            this.ButtonResult.Text = "Calculate";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(191, 155);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.TextBoxY);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.TextBoxA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WinForm01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.TextBox TextBoxY;
        private System.Windows.Forms.Button ButtonResult;
    }
}

