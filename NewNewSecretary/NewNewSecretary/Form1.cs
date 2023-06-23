//using Clinical_System;
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
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Net.Http;


namespace NewNewSecretary
{
    public partial class Form1 : Form
    {
        //protected FhirClient _client;
        //Dictionary<string, Patients> Patients_dic = new Dictionary<string, Patients>();//This dic mimics the database, once Patient added to server we save refrence to its logical id
        SqlConnection con = new SqlConnection();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            FhirClientSettings _settings = new FhirClientSettings()
            {
                PreferredFormat = ResourceFormat.Json,
            };
            //_client = new FhirClient("https://fhir.simplifier.net/Pharmacy", _settings);
            //_client.RequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiaG9zc2FtZWxkZWVuYW53ZXIiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImFkNTUwM2Q5LTU4N2QtNGUxMi1hOTMwLTcyMTM3ODFhYjViOCIsImp0aSI6ImNmYzRiYjc5LTQ2YzktNGUyYi05NThhLWM3MThjN2ZlMzk5YSIsImV4cCI6MTY4NzMwMjQzMiwiaXNzIjoiYXBpLnNpbXBsaWZpZXIubmV0IiwiYXVkIjoiYXBpLnNpbXBsaWZpZXIubmV0In0.GLhtAhdnd-iVh_hLXfiok2y38OFSfPTDEVG9xfxI8is");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            con.Open();
            SqlCommand end = new SqlCommand("UPDATE Staff SET active = 0 WHERE active = 2;", con);
            end.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patients p = new Patients(this);
            p.TopLevel = false;
            PanMain.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patients p = new Patients(this);
            p.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment(this);
            a.TopLevel = false;
            PanMain.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            IBLDATE.Text = "Date: " + DateTime.Now.Date.ToString("M/d/yyyy");
            con.Open();
            SqlCommand sName = new SqlCommand("SELECT * FROM Staff WHERE active = 2;", con);
            SqlDataReader Secretary = sName.ExecuteReader();
            if (Secretary.Read())
            {
                label1.Text = Secretary["fname"].ToString() + " " + Secretary["lname"].ToString();
                label2.Text = Secretary["ID"].ToString();
            }

            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search(this);
            s.TopLevel = false;
            PanMain.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void PanMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            con.Open();
            SqlCommand end = new SqlCommand("UPDATE Staff SET active = 0 WHERE active = 2;", con);
            end.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand Timeline = new SqlCommand("select patient_fname + ' ' + patient_lname as Patient_Name, NID, apTime as Appointment_Time from patient, Appointment where pNID = NID and apDate = @apDate order by apTime ASC;", con);
            Timeline.Parameters.Add("@apDate", DateTime.Now.Date.ToString("M/d/yyyy"));
            SqlDataAdapter adptr = new SqlDataAdapter(Timeline);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand Timeline = new SqlCommand("select patient_fname + ' ' + patient_lname as Patient_Name, NID, apTime as Appointment_Time, apDate as Date from patient, Appointment where pNID = NID order by apDate ASC;", con);
            SqlDataAdapter adptr = new SqlDataAdapter(Timeline);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand Timeline = new SqlCommand("select patient_fname + ' ' + patient_lname as Patient_Name, NID, apTime as Appointment_Time from patient, Appointment where pNID = NID and apDate = @apDate order by apTime ASC;", con);
            Timeline.Parameters.Add("@apDate", dateTimePicker1.Value.ToString());
            SqlDataAdapter adptr = new SqlDataAdapter(Timeline);
            DataTable dt = new DataTable();
            adptr.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
