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

namespace NewNewSecretary
{
    public partial class Search : Form
    {
        Form1 f = new Form1();
        SqlConnection con = new SqlConnection();
        public Search(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From patient Where NID = @NID;", con);
            cmd.Parameters.Add("@NID", txtID.Text);
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            if(myreader.Read())
            {
                txtFirstName.Text = myreader["patient_fname"].ToString();
                txtLastName.Text = myreader["patient_lname"].ToString();
                txtPhoneNumber.Text = myreader["phoneNumber"].ToString();
                txtAge.Text = myreader["age"].ToString();
                txtCity.Text = myreader["city"].ToString();
                TxtGender.Text = myreader["Gender"].ToString();
            }
            else
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhoneNumber.Text = "";
                txtAge.Text = "";
                txtCity.Text = "";
                TxtGender.Text = "";
                MessageBox.Show("No Data Found");
            }
            myreader.Close();
            con.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
