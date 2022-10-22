
namespace Student_Course_Register_Application
{
    partial class Teacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Form));
            this.lbl_name_surname = new System.Windows.Forms.Label();
            this.lbl_account_number = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_course = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_date = new System.Windows.Forms.MaskedTextBox();
            this.msk_time = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name_surname
            // 
            this.lbl_name_surname.AutoSize = true;
            this.lbl_name_surname.Font = new System.Drawing.Font("Gigi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_surname.Location = new System.Drawing.Point(169, 60);
            this.lbl_name_surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name_surname.Name = "lbl_name_surname";
            this.lbl_name_surname.Size = new System.Drawing.Size(97, 41);
            this.lbl_name_surname.TabIndex = 2;
            this.lbl_name_surname.Text = "label3";
            // 
            // lbl_account_number
            // 
            this.lbl_account_number.AutoSize = true;
            this.lbl_account_number.Font = new System.Drawing.Font("Gigi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account_number.Location = new System.Drawing.Point(167, 19);
            this.lbl_account_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_account_number.Name = "lbl_account_number";
            this.lbl_account_number.Size = new System.Drawing.Size(99, 41);
            this.lbl_account_number.TabIndex = 3;
            this.lbl_account_number.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Font = new System.Drawing.Font("Gigi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course.Location = new System.Drawing.Point(317, 35);
            this.lbl_course.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(99, 41);
            this.lbl_course.TabIndex = 6;
            this.lbl_course.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.msk_time);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.msk_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Study";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time:";
            // 
            // msk_date
            // 
            this.msk_date.Location = new System.Drawing.Point(108, 45);
            this.msk_date.Mask = "00/00/0000";
            this.msk_date.Name = "msk_date";
            this.msk_date.Size = new System.Drawing.Size(100, 30);
            this.msk_date.TabIndex = 12;
            this.msk_date.ValidatingType = typeof(System.DateTime);
            // 
            // msk_time
            // 
            this.msk_time.Location = new System.Drawing.Point(108, 92);
            this.msk_time.Mask = "00:00";
            this.msk_time.Name = "msk_time";
            this.msk_time.Size = new System.Drawing.Size(100, 30);
            this.msk_time.TabIndex = 13;
            this.msk_time.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create Study";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gigi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teacher";
            // 
            // Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_account_number);
            this.Controls.Add(this.lbl_name_surname);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Teacher_Form";
            this.Text = "Teacher_Form";
            this.Load += new System.EventHandler(this.Teacher_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name_surname;
        private System.Windows.Forms.Label lbl_account_number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox msk_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}