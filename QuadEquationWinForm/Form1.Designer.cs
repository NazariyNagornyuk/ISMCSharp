namespace QuadEquationWinForm
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
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelX1 = new System.Windows.Forms.Label();
            this.LabelX2 = new System.Windows.Forms.Label();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.TextBoxC = new System.Windows.Forms.TextBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextBoxX1 = new System.Windows.Forms.TextBox();
            this.TextBoxX2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "c=";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(19, 143);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(18, 13);
            this.LabelX.TabIndex = 3;
            this.LabelX.Text = "x=";
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            this.LabelX1.Location = new System.Drawing.Point(14, 168);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(24, 13);
            this.LabelX1.TabIndex = 4;
            this.LabelX1.Text = "x1=";
            // 
            // LabelX2
            // 
            this.LabelX2.AutoSize = true;
            this.LabelX2.Location = new System.Drawing.Point(14, 193);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(24, 13);
            this.LabelX2.TabIndex = 5;
            this.LabelX2.Text = "x2=";
            // 
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(39, 13);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(214, 20);
            this.TextBoxA.TabIndex = 6;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(39, 39);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(214, 20);
            this.TextBoxB.TabIndex = 7;
            // 
            // TextBoxC
            // 
            this.TextBoxC.Location = new System.Drawing.Point(39, 65);
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.Size = new System.Drawing.Size(214, 20);
            this.TextBoxC.TabIndex = 8;
            // 
            // TextBoxX
            // 
            this.TextBoxX.Location = new System.Drawing.Point(39, 140);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.ReadOnly = true;
            this.TextBoxX.Size = new System.Drawing.Size(214, 20);
            this.TextBoxX.TabIndex = 9;
            // 
            // TextBoxX1
            // 
            this.TextBoxX1.Location = new System.Drawing.Point(39, 165);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.ReadOnly = true;
            this.TextBoxX1.Size = new System.Drawing.Size(214, 20);
            this.TextBoxX1.TabIndex = 10;
            // 
            // TextBoxX2
            // 
            this.TextBoxX2.Location = new System.Drawing.Point(39, 190);
            this.TextBoxX2.Name = "TextBoxX2";
            this.TextBoxX2.ReadOnly = true;
            this.TextBoxX2.Size = new System.Drawing.Size(214, 20);
            this.TextBoxX2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxX2);
            this.Controls.Add(this.TextBoxX1);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.TextBoxC);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.TextBoxA);
            this.Controls.Add(this.LabelX2);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QuadEquationWinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelX1;
        private System.Windows.Forms.Label LabelX2;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxC;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.TextBox TextBoxX1;
        private System.Windows.Forms.TextBox TextBoxX2;
        private System.Windows.Forms.Button button1;
    }
}

