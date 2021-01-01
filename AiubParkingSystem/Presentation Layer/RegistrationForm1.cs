using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubParkingSystem.Presentation_Layer
{
    public partial class RegistrationForm1 : Form
    {
        public RegistrationForm1()
        {
            InitializeComponent();
        }

        private void RegigroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submitbutton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Add Database name"].ConnectionString);
            connection.Open();
            string gen = null;
           
            string sql = "INSERT INTO Users(Username,Password,Phone No,Address,User Type,Vahicle Type) VALUES('" + UsernametextBox1.Text + "','" + PasswordtextBox2.Text + "','" + PhonetextBox1.Text + "','" + AddresstextBox1.Text + "','" + UserTypecomboBox1.Text + "','" + VahicletypecomboBox1.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("User added successfully.");
                UsernametextBox1.Text = PasswordtextBox2.Text = PhonetextBox1.Text = AddresstextBox1.Text = UserTypecomboBox1.Text = VahicletypecomboBox1.Text = string.Empty;
               // radioButton1.Checked = radioButton2.Checked = checkBox1.Checked = false;
            }
            else
            {
                MessageBox.Show("Error in user adding.");
            }
        }
    }
}
