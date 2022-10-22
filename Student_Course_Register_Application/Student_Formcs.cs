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
    public partial class Student_Formcs : Form
    {
        public string number;
        public Student_Formcs()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Course_Register_Application;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("exec Study_procedure", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Student_Formcs_Load(object sender, EventArgs e)
        {
            lbl_account_number.Text = number;
            connection.Open();
            SqlCommand command = new SqlCommand("Select Name+' '+Surname from Student where Number=@p1", connection);
            command.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {
                lbl_student_name.Text = dr[0].ToString();
            }
            connection.Close();
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            DialogResult dialogResult = MessageBox.Show("Do you want to append this course?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult== DialogResult.Yes)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                string id= dataGridView1.Rows[index].Cells[0].Value.ToString();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Study Set Student=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", number);
                command.Parameters.AddWithValue("@p2", id);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Attented the course", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }

        }
    }
}
