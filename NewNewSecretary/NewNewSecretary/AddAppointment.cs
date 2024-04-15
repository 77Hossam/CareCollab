using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;


namespace NewNewSecretary
{
    public partial class AddAppointment : Form
    {
        SqlConnection con = new SqlConnection();
        //MySQL connection
        //MySqlConnection mySqlConnection = new MySqlConnection("server=sql12.freesqldatabase.com; user=sql12628032; database=sql12628032; password=fVWYdFY3Wc");

        public AddAppointment()
        {
            InitializeComponent();
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
            con.Open();
            SqlCommand NID = new SqlCommand("SELECT NID FROM patient;", con);
            SqlDataReader Myreader = NID.ExecuteReader();
            int i = 0;
            while (Myreader.Read())
            {
                string menue = Myreader["NID"].ToString();
                comboBox1.Items.Add(menue);
                i++;
            }
            Myreader.Close();
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            long PNID = long.Parse(comboBox1.SelectedItem.ToString());
            con.Open();
            SqlCommand apntm = new SqlCommand("INSERT INTO Appointment(apTime, apDate, pNID) VALUES (@apTime, @apDate, @pNID);", con);
            apntm.Parameters.Add("@apTime", textBox1.Text);
            apntm.Parameters.Add("@apDate", dateTimePicker1.Value.ToString());
            apntm.Parameters.Add("@pNID", PNID);
            apntm.ExecuteNonQuery();

            //mySqlConnection.Open();
            SqlCommand reserved = new SqlCommand("select * from Appointment where pNID = @pNID and apDate = @apDate;", con);
            reserved.Parameters.Add("@pNID", PNID);
            reserved.Parameters.Add("@apDate", dateTimePicker1.Value.ToString());
            SqlDataReader reservedReader = reserved.ExecuteReader();
            int appointmentNum = 0;
            while(reservedReader.Read())
            {
                appointmentNum = int.Parse(reservedReader["appointmentNum"].ToString());
            }
            reservedReader.Close();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "YYYY-MM-dd";
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            //MySqlCommand appoint = new MySqlCommand("insert into Appointment(appointmentNum, apTime, apDate, pNID) values(@appointmentNum, @apTime, @apDate, @pNID);", mySqlConnection);
            //appoint.Parameters.AddWithValue("@appointmentNum",appointmentNum);
            //appoint.Parameters.AddWithValue("@apTime", textBox1.Text);
            //appoint.Parameters.AddWithValue("@apDate", date);
            //appoint.Parameters.AddWithValue("@pNID", PNID);
            //appoint.ExecuteNonQuery();
            //mySqlConnection.Close();
            con.Close();

            this.Close();
            MessageBox.Show("Appointment added successfully");
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblName.Text = comboBox1.SelectedItem.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
