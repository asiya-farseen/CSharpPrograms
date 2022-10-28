namespace SubmitForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.RadioButton();
            this.m = new System.Windows.Forms.RadioButton();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.location = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PHONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "GENDER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "LOCATION";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(241, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(210, 20);
            this.name.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(241, 42);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(190, 20);
            this.email.TabIndex = 7;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(241, 86);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(190, 20);
            this.phone.TabIndex = 8;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(241, 132);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(67, 17);
            this.f.TabIndex = 9;
            this.f.TabStop = true;
            this.f.Text = "FEMALE";
            this.f.UseVisualStyleBackColor = true;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(346, 132);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(54, 17);
            this.m.TabIndex = 10;
            this.m.TabStop = true;
            this.m.Text = "MALE";
            this.m.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(241, 167);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 20);
            this.dob.TabIndex = 11;
            // 
            // location
            // 
            this.location.FormattingEnabled = true;
            this.location.Items.AddRange(new object[] {
            "BENGALURU URBAN",
            "BENGALURU RURAL",
            "MYSORE",
            "ANEKAL"});
            this.location.Location = new System.Drawing.Point(241, 220);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(190, 21);
            this.location.TabIndex = 12;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(148, 263);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(502, 98);
            this.result.TabIndex = 13;
            this.result.Text = "submit";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.location);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.m);
            this.Controls.Add(this.f);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.RadioButton f;
        private System.Windows.Forms.RadioButton m;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Button result;
    }
}

