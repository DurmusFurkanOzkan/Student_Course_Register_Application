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
    
    public partial class Teacher_Form : Form
    {
        public string number;
        public Teacher_Form()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Course_Register_Application;Integrated Security=True");
        private void Teacher_Form_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select Name+' '+Surname,Branch from Teacher where Number=@p1", connection);
            command.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                lbl_name_surname.Text = dr[0].ToString();
                lbl_course.Text = dr[1].ToString();
            }
            lbl_account_number.Text= number;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select ID from Course where Name=@p1",connection);
            command1.Parameters.AddWithValue("@p1", lbl_course.Text);
            SqlDataReader dr1 = command1.ExecuteReader();
            int drr=0;
            while(dr1.Read())
            {
                drr = int.Parse(dr1[0].ToString());
            }
            connection.Close();
            connection.Open();
            SqlCommand command = new SqlCommand("insert into study (Course,Teacher,Date,Time) values (@p1,@p2,@p3,@p4)", connection);
            command.Parameters.AddWithValue("@p1", drr);
            command.Parameters.AddWithValue("@p2", number);
            command.Parameters.AddWithValue("@p3", msk_date.Text);
            command.Parameters.AddWithValue("@p4", msk_time.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Study added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
