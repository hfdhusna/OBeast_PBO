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

namespace BMI_Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        String gender;

        private void weight_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=LAPTOP-29Q67NHD\\SQLEXPRESS;Initial Catalog=BMIApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[UserInput]\r\n           ([weight]\r\n           ,[height]\r\n           ,[birthdate]\r\n           ,[gender])\r\n     VALUES\r\n           ('" + txtWeight.Text + "'\r\n           ,'" + txtHeight.Text + "'\r\n           ,'" + this.birthDate.Text + "'\r\n           ,'" + gender + "')", connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Input Data Success!");

            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }

        private void radbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
