namespace Ecom
{
    partial class ECom
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
            this.pa = new System.Windows.Forms.TextBox();
            this.yes = new System.Windows.Forms.CheckBox();
            this.no = new System.Windows.Forms.CheckBox();
            this.result = new System.Windows.Forms.Button();
            this.result1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER THE PURCHASE AMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARE YOU A PRIME MEMBER ";
            // 
            // pa
            // 
            this.pa.Location = new System.Drawing.Point(355, 24);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(191, 20);
            this.pa.TabIndex = 2;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(364, 72);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(47, 17);
            this.yes.TabIndex = 3;
            this.yes.Text = "YES";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(466, 72);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(42, 17);
            this.no.TabIndex = 4;
            this.no.Text = "NO";
            this.no.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(364, 116);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(155, 38);
            this.result.TabIndex = 5;
            this.result.Text = "CALUCLATE";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(148, 195);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(552, 20);
            this.result1.TabIndex = 6;
            // 
            // ECom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.pa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ECom";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pa;
        private System.Windows.Forms.CheckBox yes;
        private System.Windows.Forms.CheckBox no;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.TextBox result1;
    }
}

