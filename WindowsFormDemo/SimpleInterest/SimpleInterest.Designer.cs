namespace SimpleInterest
{
    partial class SimpleInterest
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
            this.principal = new System.Windows.Forms.TextBox();
            this.roi = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(139, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER PRINCIPAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(166, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER RATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(150, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ENTER TIME";
            // 
            // principal
            // 
            this.principal.Location = new System.Drawing.Point(296, 55);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(172, 20);
            this.principal.TabIndex = 3;
            // 
            // roi
            // 
            this.roi.Location = new System.Drawing.Point(296, 110);
            this.roi.Name = "roi";
            this.roi.Size = new System.Drawing.Size(172, 20);
            this.roi.TabIndex = 4;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(293, 170);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(175, 20);
            this.time.TabIndex = 5;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(277, 297);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(156, 20);
            this.res.TabIndex = 7;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(293, 233);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(126, 40);
            this.result.TabIndex = 8;
            this.result.Text = "RESULT";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // SimpleInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.res);
            this.Controls.Add(this.time);
            this.Controls.Add(this.roi);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleInterest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SimpleInterest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox principal;
        private System.Windows.Forms.TextBox roi;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button result;
    }
}

