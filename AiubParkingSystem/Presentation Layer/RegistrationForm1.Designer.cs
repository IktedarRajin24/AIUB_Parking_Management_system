namespace AiubParkingSystem.Presentation_Layer
{
    partial class RegistrationForm1
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
            this.RegigroupBox1 = new System.Windows.Forms.GroupBox();
            this.Submitbutton1 = new System.Windows.Forms.Button();
            this.VahicletypecomboBox1 = new System.Windows.Forms.ComboBox();
            this.VahicleTypelabel1 = new System.Windows.Forms.Label();
            this.UserTypecomboBox1 = new System.Windows.Forms.ComboBox();
            this.Usertypelabel1 = new System.Windows.Forms.Label();
            this.AddresstextBox1 = new System.Windows.Forms.TextBox();
            this.Addresslabel1 = new System.Windows.Forms.Label();
            this.PhonetextBox1 = new System.Windows.Forms.TextBox();
            this.PhoneNolabel1 = new System.Windows.Forms.Label();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.Passwordlabel1 = new System.Windows.Forms.Label();
            this.UsernametextBox1 = new System.Windows.Forms.TextBox();
            this.UsernameLebel = new System.Windows.Forms.Label();
            this.RegigroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegigroupBox1
            // 
            this.RegigroupBox1.Controls.Add(this.Submitbutton1);
            this.RegigroupBox1.Controls.Add(this.VahicletypecomboBox1);
            this.RegigroupBox1.Controls.Add(this.VahicleTypelabel1);
            this.RegigroupBox1.Controls.Add(this.UserTypecomboBox1);
            this.RegigroupBox1.Controls.Add(this.Usertypelabel1);
            this.RegigroupBox1.Controls.Add(this.AddresstextBox1);
            this.RegigroupBox1.Controls.Add(this.Addresslabel1);
            this.RegigroupBox1.Controls.Add(this.PhonetextBox1);
            this.RegigroupBox1.Controls.Add(this.PhoneNolabel1);
            this.RegigroupBox1.Controls.Add(this.PasswordtextBox2);
            this.RegigroupBox1.Controls.Add(this.Passwordlabel1);
            this.RegigroupBox1.Controls.Add(this.UsernametextBox1);
            this.RegigroupBox1.Controls.Add(this.UsernameLebel);
            this.RegigroupBox1.Location = new System.Drawing.Point(12, 24);
            this.RegigroupBox1.Name = "RegigroupBox1";
            this.RegigroupBox1.Size = new System.Drawing.Size(432, 510);
            this.RegigroupBox1.TabIndex = 0;
            this.RegigroupBox1.TabStop = false;
            this.RegigroupBox1.Text = "Registration";
            this.RegigroupBox1.Enter += new System.EventHandler(this.RegigroupBox1_Enter);
            // 
            // Submitbutton1
            // 
            this.Submitbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbutton1.Location = new System.Drawing.Point(207, 377);
            this.Submitbutton1.Name = "Submitbutton1";
            this.Submitbutton1.Size = new System.Drawing.Size(119, 37);
            this.Submitbutton1.TabIndex = 12;
            this.Submitbutton1.Text = "Submit";
            this.Submitbutton1.UseVisualStyleBackColor = true;
            this.Submitbutton1.Click += new System.EventHandler(this.Submitbutton1_Click);
            // 
            // VahicletypecomboBox1
            // 
            this.VahicletypecomboBox1.FormattingEnabled = true;
            this.VahicletypecomboBox1.Items.AddRange(new object[] {
            "Student",
            "Faculty"});
            this.VahicletypecomboBox1.Location = new System.Drawing.Point(167, 322);
            this.VahicletypecomboBox1.Name = "VahicletypecomboBox1";
            this.VahicletypecomboBox1.Size = new System.Drawing.Size(159, 24);
            this.VahicletypecomboBox1.TabIndex = 11;
            // 
            // VahicleTypelabel1
            // 
            this.VahicleTypelabel1.AutoSize = true;
            this.VahicleTypelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VahicleTypelabel1.Location = new System.Drawing.Point(28, 322);
            this.VahicleTypelabel1.Name = "VahicleTypelabel1";
            this.VahicleTypelabel1.Size = new System.Drawing.Size(117, 20);
            this.VahicleTypelabel1.TabIndex = 10;
            this.VahicleTypelabel1.Text = "Vahicle Type";
            // 
            // UserTypecomboBox1
            // 
            this.UserTypecomboBox1.FormattingEnabled = true;
            this.UserTypecomboBox1.Items.AddRange(new object[] {
            "Student",
            "Faculty"});
            this.UserTypecomboBox1.Location = new System.Drawing.Point(167, 270);
            this.UserTypecomboBox1.Name = "UserTypecomboBox1";
            this.UserTypecomboBox1.Size = new System.Drawing.Size(159, 24);
            this.UserTypecomboBox1.TabIndex = 9;
            this.UserTypecomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Usertypelabel1
            // 
            this.Usertypelabel1.AutoSize = true;
            this.Usertypelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertypelabel1.Location = new System.Drawing.Point(50, 270);
            this.Usertypelabel1.Name = "Usertypelabel1";
            this.Usertypelabel1.Size = new System.Drawing.Size(95, 20);
            this.Usertypelabel1.TabIndex = 8;
            this.Usertypelabel1.Text = "User Type";
            // 
            // AddresstextBox1
            // 
            this.AddresstextBox1.Location = new System.Drawing.Point(167, 219);
            this.AddresstextBox1.Name = "AddresstextBox1";
            this.AddresstextBox1.Size = new System.Drawing.Size(159, 22);
            this.AddresstextBox1.TabIndex = 7;
            // 
            // Addresslabel1
            // 
            this.Addresslabel1.AutoSize = true;
            this.Addresslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel1.Location = new System.Drawing.Point(50, 221);
            this.Addresslabel1.Name = "Addresslabel1";
            this.Addresslabel1.Size = new System.Drawing.Size(78, 20);
            this.Addresslabel1.TabIndex = 6;
            this.Addresslabel1.Text = "Address";
            // 
            // PhonetextBox1
            // 
            this.PhonetextBox1.Location = new System.Drawing.Point(167, 171);
            this.PhonetextBox1.Name = "PhonetextBox1";
            this.PhonetextBox1.Size = new System.Drawing.Size(159, 22);
            this.PhonetextBox1.TabIndex = 5;
            // 
            // PhoneNolabel1
            // 
            this.PhoneNolabel1.AutoSize = true;
            this.PhoneNolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNolabel1.Location = new System.Drawing.Point(50, 171);
            this.PhoneNolabel1.Name = "PhoneNolabel1";
            this.PhoneNolabel1.Size = new System.Drawing.Size(90, 20);
            this.PhoneNolabel1.TabIndex = 4;
            this.PhoneNolabel1.Text = "Phone No";
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(167, 120);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.Size = new System.Drawing.Size(159, 22);
            this.PasswordtextBox2.TabIndex = 3;
            // 
            // Passwordlabel1
            // 
            this.Passwordlabel1.AutoSize = true;
            this.Passwordlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel1.Location = new System.Drawing.Point(50, 120);
            this.Passwordlabel1.Name = "Passwordlabel1";
            this.Passwordlabel1.Size = new System.Drawing.Size(91, 20);
            this.Passwordlabel1.TabIndex = 2;
            this.Passwordlabel1.Text = "Password";
            // 
            // UsernametextBox1
            // 
            this.UsernametextBox1.Location = new System.Drawing.Point(167, 71);
            this.UsernametextBox1.Name = "UsernametextBox1";
            this.UsernametextBox1.Size = new System.Drawing.Size(159, 22);
            this.UsernametextBox1.TabIndex = 1;
            // 
            // UsernameLebel
            // 
            this.UsernameLebel.AutoSize = true;
            this.UsernameLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLebel.Location = new System.Drawing.Point(50, 71);
            this.UsernameLebel.Name = "UsernameLebel";
            this.UsernameLebel.Size = new System.Drawing.Size(94, 20);
            this.UsernameLebel.TabIndex = 0;
            this.UsernameLebel.Text = "Username";
            // 
            // RegistrationForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 557);
            this.Controls.Add(this.RegigroupBox1);
            this.Name = "RegistrationForm1";
            this.Text = "RegistrationForm1";
            this.RegigroupBox1.ResumeLayout(false);
            this.RegigroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RegigroupBox1;
        private System.Windows.Forms.TextBox AddresstextBox1;
        private System.Windows.Forms.Label Addresslabel1;
        private System.Windows.Forms.TextBox PhonetextBox1;
        private System.Windows.Forms.Label PhoneNolabel1;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.Label Passwordlabel1;
        private System.Windows.Forms.TextBox UsernametextBox1;
        private System.Windows.Forms.Label UsernameLebel;
        private System.Windows.Forms.ComboBox UserTypecomboBox1;
        private System.Windows.Forms.Label Usertypelabel1;
        private System.Windows.Forms.Button Submitbutton1;
        private System.Windows.Forms.ComboBox VahicletypecomboBox1;
        private System.Windows.Forms.Label VahicleTypelabel1;
    }
}