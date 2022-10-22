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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Course_Register_Application;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            if(account_type.SelectedItem.ToString().Equals("Teacher"))
            {
                SqlCommand command = new SqlCommand("Insert into Teacher (Name,Surname,Branch,Mail_address,Telephone_number,Password) values(@p1,@p2,@p3,@p4,@p5,@p6)",connection);
                command.Parameters.AddWithValue("@p1", txt_name.Text);
                command.Parameters.AddWithValue("@p2", txt_surname.Text);
                command.Parameters.AddWithValue("@p3", Comboboxbracnh.Text);
                command.Parameters.AddWithValue("@p4", txt_mailaddress.Text);
                command.Parameters.AddWithValue("@p5", txt_telephonenumber.Text);
                command.Parameters.AddWithValue("@p6", txt_password.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Account Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (account_type.SelectedItem.ToString().Equals("Student"))
            {
                SqlCommand command = new SqlCommand("Insert into Student (Name,Surname,Class,Mail_address,Telephone_number,Password) values(@p1,@p2,@p3,@p4,@p5,@p6)", connection);
                command.Parameters.AddWithValue("@p1", txt_name.Text);
                command.Parameters.AddWithValue("@p2", txt_surname.Text);
                command.Parameters.AddWithValue("@p3", Comboboxclass.Text);
                command.Parameters.AddWithValue("@p4", txt_mailaddress.Text);
                command.Parameters.AddWithValue("@p5", txt_telephonenumber.Text);
                command.Parameters.AddWithValue("@p6", txt_password.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Account Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }

        private void account_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (account_type.SelectedItem.ToString().Equals("Teacher"))
            {
                lbl_class.Visible = false;
                Comboboxclass.Visible = false;
                lbl_branch.Visible = true;
                Comboboxbracnh.Visible = true;
            }
            else if((account_type.SelectedItem.ToString().Equals("Student")))
            {
                lbl_branch.Visible = false;
                Comboboxbracnh.Visible = false;
                lbl_class.Visible = true;
                Comboboxclass.Visible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            account_type.Items.Add("Teacher");
            account_type.Items.Add("Student");
            Comboboxclass.Items.Add("1. Class");
            Comboboxclass.Items.Add("2. Class");
            Comboboxclass.Items.Add("3. Class");
            Comboboxclass.Items.Add("4. Class");
            SqlDataAdapter da = new SqlDataAdapter("Select * From Course", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Comboboxbracnh.ValueMember = "ID";
            Comboboxbracnh.DisplayMember = "Name";
            Comboboxbracnh.DataSource = dt;
        }
    }
}
