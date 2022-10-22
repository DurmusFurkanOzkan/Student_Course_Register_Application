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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Course_Register_Application;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Contact_Us (Name,Surname,Mail_Address,Telephone_Number,Subject)values(@p1,@p2,@p3,@p4,@p5)", connection);
            command.Parameters.AddWithValue("@p1", txt_name.Text);
            command.Parameters.AddWithValue("@p2", txt_surname.Text);
            command.Parameters.AddWithValue("@p3", txt_mail_address.Text);
            command.Parameters.AddWithValue("@p4", txt_telephone_number.Text);
            command.Parameters.AddWithValue("@p5", txt_subject.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Thank You!We will get back to you as soon as possible.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();

        }
    }
}
