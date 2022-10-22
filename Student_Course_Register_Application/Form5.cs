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
    public partial class Form5 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Course_Register_Application;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_Register_ApplicationDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.course_Register_ApplicationDataSet.Course);

        }

        
    }
}
