
namespace Student_Course_Register_Application
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.account_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_branch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_telephonenumber = new System.Windows.Forms.MaskedTextBox();
            this.txt_mailaddress = new System.Windows.Forms.TextBox();
            this.Comboboxclass = new System.Windows.Forms.ComboBox();
            this.Comboboxbracnh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // account_type
            // 
            this.account_type.FormattingEnabled = true;
            this.account_type.Location = new System.Drawing.Point(378, 152);
            this.account_type.Name = "account_type";
            this.account_type.Size = new System.Drawing.Size(130, 24);
            this.account_type.TabIndex = 10;
            this.account_type.SelectedIndexChanged += new System.EventHandler(this.account_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Account Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(378, 194);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(126, 22);
            this.txt_name.TabIndex = 13;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(378, 229);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(126, 22);
            this.txt_surname.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Surname:";
            // 
            // lbl_branch
            // 
            this.lbl_branch.AutoSize = true;
            this.lbl_branch.Location = new System.Drawing.Point(232, 365);
            this.lbl_branch.Name = "lbl_branch";
            this.lbl_branch.Size = new System.Drawing.Size(57, 17);
            this.lbl_branch.TabIndex = 16;
            this.lbl_branch.Text = "Branch:";
            this.lbl_branch.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mail Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telephone Number:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(378, 336);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(126, 22);
            this.txt_password.TabIndex = 23;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Password:";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(235, 365);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(46, 17);
            this.lbl_class.TabIndex = 24;
            this.lbl_class.Text = "Class:";
            this.lbl_class.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // txt_telephonenumber
            // 
            this.txt_telephonenumber.Location = new System.Drawing.Point(378, 299);
            this.txt_telephonenumber.Mask = "(999) 000-0000";
            this.txt_telephonenumber.Name = "txt_telephonenumber";
            this.txt_telephonenumber.Size = new System.Drawing.Size(126, 22);
            this.txt_telephonenumber.TabIndex = 28;
            // 
            // txt_mailaddress
            // 
            this.txt_mailaddress.Location = new System.Drawing.Point(378, 261);
            this.txt_mailaddress.Name = "txt_mailaddress";
            this.txt_mailaddress.Size = new System.Drawing.Size(126, 22);
            this.txt_mailaddress.TabIndex = 29;
            // 
            // Comboboxclass
            // 
            this.Comboboxclass.FormattingEnabled = true;
            this.Comboboxclass.Location = new System.Drawing.Point(378, 365);
            this.Comboboxclass.Name = "Comboboxclass";
            this.Comboboxclass.Size = new System.Drawing.Size(126, 24);
            this.Comboboxclass.TabIndex = 30;
            this.Comboboxclass.Visible = false;
            // 
            // Comboboxbracnh
            // 
            this.Comboboxbracnh.FormattingEnabled = true;
            this.Comboboxbracnh.Location = new System.Drawing.Point(378, 365);
            this.Comboboxbracnh.Name = "Comboboxbracnh";
            this.Comboboxbracnh.Size = new System.Drawing.Size(126, 24);
            this.Comboboxbracnh.TabIndex = 31;
            this.Comboboxbracnh.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 489);
            this.Controls.Add(this.Comboboxbracnh);
            this.Controls.Add(this.Comboboxclass);
            this.Controls.Add(this.txt_mailaddress);
            this.Controls.Add(this.txt_telephonenumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_branch);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.account_type);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox account_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_branch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_telephonenumber;
        private System.Windows.Forms.TextBox txt_mailaddress;
        private System.Windows.Forms.ComboBox Comboboxclass;
        private System.Windows.Forms.ComboBox Comboboxbracnh;
    }
}