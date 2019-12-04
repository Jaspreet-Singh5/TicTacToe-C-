namespace WindowsFormsApp3
{
    partial class Form3
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
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countrycodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.education1 = new System.Windows.Forms.CheckBox();
            this.education2 = new System.Windows.Forms.CheckBox();
            this.education3 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.GroupBox();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(391, 172);
            this.firstnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstnameTextBox.MaxLength = 50;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(124, 23);
            this.firstnameTextBox.TabIndex = 0;
            this.firstnameTextBox.Tag = "";
            this.firstnameTextBox.TextChanged += new System.EventHandler(this.firstnameTextBox_TextChanged);
            this.firstnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstnameTextBox_KeyPress);
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameBox.Location = new System.Drawing.Point(343, 175);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(38, 15);
            this.nameBox.TabIndex = 2;
            this.nameBox.Text = "Name";
            this.nameBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(391, 230);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(274, 23);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(343, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(391, 260);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneTextBox.MaxLength = 10;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(274, 23);
            this.phoneTextBox.TabIndex = 0;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(343, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // countrycodeTextBox
            // 
            this.countrycodeTextBox.Location = new System.Drawing.Point(391, 290);
            this.countrycodeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.countrycodeTextBox.MaxLength = 3;
            this.countrycodeTextBox.Name = "countrycodeTextBox";
            this.countrycodeTextBox.Size = new System.Drawing.Size(274, 23);
            this.countrycodeTextBox.TabIndex = 0;
            this.countrycodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countrycodeTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(304, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country Code";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(385, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "SignUp Form";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.Location = new System.Drawing.Point(391, 319);
            this.zipcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zipcodeTextBox.MaxLength = 6;
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(274, 23);
            this.zipcodeTextBox.TabIndex = 0;
            this.zipcodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipcodeTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(330, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Zip Code";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(391, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(541, 172);
            this.lastnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lastnameTextBox.MaxLength = 50;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(124, 23);
            this.lastnameTextBox.TabIndex = 0;
            this.lastnameTextBox.TextChanged += new System.EventHandler(this.lastnameTextBox_TextChanged);
            this.lastnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastnameTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(391, 201);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(274, 23);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(320, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "INDIA",
            "USA",
            "IRAN",
            "ISRAEL",
            "SAUDI ARABIA",
            "UAE",
            "NEPAL",
            "CHINA",
            "PAKISTAN",
            "BHUTAN"});
            this.country.Location = new System.Drawing.Point(390, 348);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(275, 23);
            this.country.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(331, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Country";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // education1
            // 
            this.education1.AutoSize = true;
            this.education1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.education1.Location = new System.Drawing.Point(390, 377);
            this.education1.Name = "education1";
            this.education1.Size = new System.Drawing.Size(33, 19);
            this.education1.TabIndex = 7;
            this.education1.Text = "X";
            this.education1.UseVisualStyleBackColor = true;
            // 
            // education2
            // 
            this.education2.AutoSize = true;
            this.education2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.education2.Location = new System.Drawing.Point(474, 377);
            this.education2.Name = "education2";
            this.education2.Size = new System.Drawing.Size(41, 19);
            this.education2.TabIndex = 7;
            this.education2.Text = "XII";
            this.education2.UseVisualStyleBackColor = true;
            // 
            // education3
            // 
            this.education3.AutoSize = true;
            this.education3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.education3.Location = new System.Drawing.Point(566, 377);
            this.education3.Name = "education3";
            this.education3.Size = new System.Drawing.Size(97, 19);
            this.education3.TabIndex = 7;
            this.education3.Text = "GRADUATION";
            this.education3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(320, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Education";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.male.Location = new System.Drawing.Point(6, 11);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(53, 19);
            this.male.TabIndex = 8;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.female.Location = new System.Drawing.Point(85, 11);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(64, 19);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.other.Location = new System.Drawing.Point(177, 11);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(56, 19);
            this.other.TabIndex = 8;
            this.other.TabStop = true;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(335, 415);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Gender";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // gender
            // 
            this.gender.Controls.Add(this.male);
            this.gender.Controls.Add(this.other);
            this.gender.Controls.Add(this.female);
            this.gender.Location = new System.Drawing.Point(391, 402);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(274, 36);
            this.gender.TabIndex = 9;
            this.gender.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(934, 520);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.education3);
            this.Controls.Add(this.education2);
            this.Controls.Add(this.education1);
            this.Controls.Add(this.country);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(this.countrycodeTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countrycodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox education1;
        private System.Windows.Forms.CheckBox education2;
        private System.Windows.Forms.CheckBox education3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gender;
    }
}