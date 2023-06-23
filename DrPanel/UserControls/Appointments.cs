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

namespace DrPanel.UserControls
{
    public partial class Appointments : UserControl
    {
        SqlConnection con = new SqlConnection();
        public Appointments()
        {
            InitializeComponent();
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand patients = new SqlCommand("select patient_fname + ' ' + patient_lname as Patient_Name, NID, apTime as Appointment_Time from patient, Appointment where pNID = NID and apDate = @apDate order by apTime ASC;", con);
            patients.Parameters.Add("@apDate", DateTime.Now.Date.ToString("M/d/yyyy"));
            SqlDataAdapter adptr = new SqlDataAdapter(patients);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            dataGridView1.DataSource= dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
