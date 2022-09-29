namespace Activity_7___approximate_pi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.termsBox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter # of terms:";
            // 
            // termsBox
            // 
            this.termsBox.Location = new System.Drawing.Point(121, 12);
            this.termsBox.Name = "termsBox";
            this.termsBox.Size = new System.Drawing.Size(211, 22);
            this.termsBox.TabIndex = 1;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(13, 48);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(114, 46);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Approximate value of pi after # terms";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(17, 148);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(315, 22);
            this.output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 205);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.termsBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox termsBox;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output;
    }
}

