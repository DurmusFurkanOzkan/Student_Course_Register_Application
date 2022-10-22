using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Student_Course_Register_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Course_Register_Application;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form2 = new Form5();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(Account_Type_ComboBox.SelectedItem.ToString().Equals("Teacher"))
            {
                SqlCommand command = new SqlCommand("Select * From Teacher where Number=@p1 and Password=@p2",connection);
                command.Parameters.AddWithValue("@p1", txt_Account_number.Text);
                command.Parameters.AddWithValue("@p2", txt_password.Text);
                SqlDataReader dr = command.ExecuteReader();
                if(dr.Read())
                {
                    Teacher_Form form = new Teacher_Form();
                    form.number = txt_Account_number.Text;
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                connection.Close();
                
            }
            else if(Account_Type_ComboBox.SelectedItem.ToString().Equals("Student"))
            {
                SqlCommand command = new SqlCommand("Select * From Student where Number=@p1 and Password=@p2", connection);
                command.Parameters.AddWithValue("@p1", txt_Account_number.Text);
                command.Parameters.AddWithValue("@p2", txt_password.Text);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    Student_Formcs form = new Student_Formcs();
                    form.number = txt_Account_number.Text;
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                connection.Close();
            }
        }
    }
}
