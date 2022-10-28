namespace WindowsForms
{
    partial class claclculator
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.opr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(185, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the first number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(170, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the Second numer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(344, 41);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(168, 20);
            this.num1.TabIndex = 2;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(344, 105);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(168, 20);
            this.num2.TabIndex = 3;
            // 
            // opr
            // 
            this.opr.Location = new System.Drawing.Point(344, 165);
            this.opr.Name = "opr";
            this.opr.Size = new System.Drawing.Size(168, 20);
            this.opr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(200, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the operator";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(300, 231);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(75, 23);
            this.res.TabIndex = 6;
            this.res.Text = "SUBMIT";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(372, 298);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(115, 20);
            this.result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opr);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox opr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.TextBox result;
    }
}

