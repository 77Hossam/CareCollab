using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using System.Net.Http;
using MySql.Data.MySqlClient;



namespace NewNewSecretary
{
    public partial class AddPatient : Form
    {
        //protected FhirClient _client;
        SqlConnection con = new SqlConnection();
        //MySQL connection
        //MySqlConnection mySqlConnection = new MySqlConnection("server=sql12.freesqldatabase.com; user=sql12628032; database=sql12628032; password=fVWYdFY3Wc");

        public AddPatient()
        {
            InitializeComponent();
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
            FhirClientSettings _settings = new FhirClientSettings()
            {
                PreferredFormat = ResourceFormat.Json,
            };
            //we use simplifier for testing and educational purposes
            //_client = new FhirClient("https://fhir.simplifier.net/Pharmacy", _settings);
            //_client.RequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiaG9zc2FtZWxkZWVuYW53ZXIiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImFkNTUwM2Q5LTU4N2QtNGUxMi1hOTMwLTcyMTM3ODFhYjViOCIsImp0aSI6IjZmZWM0YmQ1LWFlZGEtNDViYi05YzUwLWNjYWM4ZDU3NjFjYyIsImV4cCI6MTY4NzM5NTU1MiwiaXNzIjoiYXBpLnNpbXBsaWZpZXIubmV0IiwiYXVkIjoiYXBpLnNpbXBsaWZpZXIubmV0In0.yCkYt1OkafK4lHHRUEYDwLuxVtGLge8XCYNFKXQMVig");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnBrowseImage_Click_1(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose image |*.png;*.bmp;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Pic.Image = Image.FromFile(ofd.FileName);
            }*/
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            //save patient's data in SQL server
            con.Open();
            SqlCommand patientdata = new SqlCommand("INSERT INTO patient(NID, patient_fname, patient_lname, phoneNumber, age, Gender, city) values(@NID, @patient_fname, @patient_lname, @phoneNumber, @age, @Gender, @city);", con);
            patientdata.Parameters.Add("@NID", TxtNationalID.Text);
            patientdata.Parameters.Add("@patient_fname", TxtFirstName.Text);
            patientdata.Parameters.Add("@patient_lname", TxtLastName.Text);
            patientdata.Parameters.Add("@phoneNumber", TxtPhoneNumber.Text);
            patientdata.Parameters.Add("@age", TxtAge.Text);
            patientdata.Parameters.Add("@city", TxtCity.Text);
            if (rdbtnMale.Checked)
            {
                patientdata.Parameters.Add("@Gender", rdbtnMale.Text);
            }
            if (rdbtnFemale.Checked)
            {
                patientdata.Parameters.Add("@Gender", rdbtnFemale.Text);
            }
            patientdata.ExecuteNonQuery();
            con.Close();

            //mySqlConnection.Open();
            String patient_fname = TxtFirstName.Text;
            String patient_lname = TxtLastName.Text;
            long NID = long.Parse(TxtNationalID.Text);
            String phoneNumber = TxtPhoneNumber.Text;
            int age = int.Parse(TxtAge.Text);
            String Gender = " ";
            if(rdbtnMale.Checked)
            {
                Gender = "Male";
            }
            if(rdbtnFemale.Checked)
            {
                Gender = "Female";
            }
            //MySqlCommand newPatient = new MySqlCommand("Insert into patient(NID, patient_fname, patient_lname, phoneNumber, age, Gender) values(@NID, @patient_fname, @patient_lname, @phoneNumber, @age, @Gender);", mySqlConnection);
            //newPatient.Parameters.AddWithValue("@patient_fname", patient_fname);
            //newPatient.Parameters.AddWithValue("@patient_lname", patient_lname);
            //newPatient.Parameters.AddWithValue("@NID", NID);
            //newPatient.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            //newPatient.Parameters.AddWithValue("@age", age);
            //newPatient.Parameters.AddWithValue("@Gender", Gender);

            //newPatient.ExecuteNonQuery();
            //mySqlConnection.Close();

            MessageBox.Show("Patient Added Successfully");
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
