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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Media;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace DrPanel
{
    public partial class DrPanel : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int myfunc(String a, String b, int c, int d);
        SqlConnection con = new SqlConnection();
        Stopwatch stopwatch;
        public DrPanel()
        {
            InitializeComponent();
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
            /*UserControls.NewSessionUserControl NewSession = new UserControls.NewSessionUserControl();
            addUserControl(NewSession);
            UserControls.PrescriptionUserControl Presc = new UserControls.PrescriptionUserControl();
            addUserControl(Presc);
            UserControls.FirstSession FS = new UserControls.FirstSession();
            addUserControl(FS);
            UserControls.Appointments A = new UserControls.Appointments();
            addUserControl(A);
            UserControls.OCR o = new UserControls.OCR();
            addUserControl(o);*/
        }


        private void addUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();




        }


        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand dName = new SqlCommand("SELECT * FROM Staff WHERE active = 1;",con);
            SqlDataReader current_doctor = dName.ExecuteReader();
            if(current_doctor.Read())
            {
                DBname.Text = current_doctor["fname"].ToString() + " " + current_doctor["lname"].ToString();
                DBid.Text = current_doctor["ID"].ToString();
            }
            current_doctor.Close();
            con.Close();
            stopwatch = new Stopwatch();
            lblTimer.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //NewSession BTN
        private void button4_Click(object sender, EventArgs e)
        {
            UserControls.NewSessionUserControl NewSession = new UserControls.NewSessionUserControl();
            addUserControl(NewSession);
        }
        //Appointments BTN
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            UserControls.Appointments A = new UserControls.Appointments();
            addUserControl(A);
        }
        //OCR BTN
        private void btnOCR_Click(object sender, EventArgs e)
        {
            UserControls.OCR o = new UserControls.OCR();
            addUserControl(o);
        }

        //Prescription BTN
        private void button3_Click(object sender, EventArgs e)
        {
            UserControls.PrescriptionUserControl Presc = new UserControls.PrescriptionUserControl();
            addUserControl(Presc);
        }
        //AudioCalls BTN
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewSession_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand activeP = new SqlCommand("SELECT * from patient where active = 1;", con);
            SqlDataReader activereader = activeP.ExecuteReader();
            if(activereader.Read() == false)
            {
                MessageBox.Show("You have to select a patient", "Patient Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserControls.NewSessionUserControl NewSession = new UserControls.NewSessionUserControl();
                addUserControl(NewSession);
            }
            con.Close();
        }

        private void AudioCallsBtu_Click(object sender, EventArgs e)
        {
       
        }

        private void PrescriptionBtu_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand activeP = new SqlCommand("SELECT * from patient where active = 1;", con);
            SqlDataReader activereader = activeP.ExecuteReader();
            if (activereader.Read() == false)
            {
                MessageBox.Show("You have to select a patient", "Patient Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (activereader["SessionNum"].ToString() == "0")
                {
                    MessageBox.Show("This patient does not have any recorded sessions to extract a prescription for, please add patient history.", "No Sessions Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserControls.PrescriptionUserControl Presc = new UserControls.PrescriptionUserControl();
                    addUserControl(Presc);
                }
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PanelDrProfile_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand end = new SqlCommand("UPDATE Staff SET active = 0 WHERE active = 1;", con);
            end.ExecuteNonQuery();
            SqlCommand endpt = new SqlCommand("UPDATE patient set active = 0 where active = 1", con);
            endpt.ExecuteNonQuery();
            SqlCommand endpres = new SqlCommand("UPDATE prescription set active = 0 where active = 1;", con);
            endpres.ExecuteNonQuery();
            con.Close();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand logOut = new SqlCommand("update patient set active = 0 where active = 1", con);
            logOut.ExecuteNonQuery();
            SqlCommand activate = new SqlCommand("UPDATE patient set active = 1 where NID = @NID;", con);
            activate.Parameters.Add("NID", txtSearch.Text);
            activate.ExecuteNonQuery();
            txtSearch.Text = "";
            SqlCommand currentPT = new SqlCommand("SELECT * from patient where active = 1;", con);
            SqlDataReader sessionReader = currentPT.ExecuteReader();
            long NID = 0;
            while (sessionReader.Read())
            {
                NID = long.Parse(sessionReader["NID"].ToString());
                label4.Text = "Name: " + sessionReader["patient_fname"].ToString() + " " + sessionReader["patient_lname"].ToString();
                label6.Text = "Age: " + sessionReader["age"].ToString();
                label5.Text = "NID: " + sessionReader["NID"].ToString();
                label33.Text = "City: " + sessionReader["city"].ToString();
                if (sessionReader["SessionNum"].ToString() == "0")
                {
                    UserControls.FirstSession firstSession = new UserControls.FirstSession();
                    addUserControl(firstSession);
                }
                else
                {
                    UserControls.NewSessionUserControl NewSession = new UserControls.NewSessionUserControl();
                    addUserControl(NewSession);
                    label7.Text = "Self_Employed: " + sessionReader["Self_Employed"].ToString();
                    label9.Text = "Family History: " + sessionReader["Family_History"].ToString();
                    label8.Text = "Treatment: " + sessionReader["Treatment"].ToString();
                    label29.Text = "Work_Interfere: " + sessionReader["Work_Interfere"].ToString();
                    label20.Text = "Num of Employees: " + sessionReader["Num_Employees"].ToString();
                    label16.Text = "Remote Work: " + sessionReader["Remote_Work"].ToString();
                    label12.Text = "Tech Company: " + sessionReader["Tech_Company"].ToString();
                    label30.Text = "Benefits: " + sessionReader["Benefits"].ToString();
                    label27.Text = "Care Options: " + sessionReader["Care_Options"].ToString();
                    label11.Text = "Wellness Program: " + sessionReader["Wellness_Program"].ToString();
                    label10.Text = "Seek Help: " + sessionReader["Seek_Help"].ToString();
                    label17.Text = "Anonymity: " + sessionReader["Anonymity"].ToString();
                    label32.Text = "Leave: " + sessionReader["Leave"].ToString();
                    label21.Text = "Physical Health Conseq.: " + sessionReader["PHC"].ToString();
                    label15.Text = "Mental Health Conseq.: " + sessionReader["MHC"].ToString();
                    label25.Text = "Coworkers: " + sessionReader["Coworkers"].ToString();
                    label22.Text = "Supervisor: " + sessionReader["Supervisor"].ToString();
                    label23.Text = "Mental Health Int.: " + sessionReader["MHI"].ToString();
                    label31.Text = "Physical Health Int.: " + sessionReader["PHI"].ToString();
                    label28.Text = "Mental vs Physical: " + sessionReader["MVSPH"].ToString();
                    label24.Text = "OBS Conseq.: " + sessionReader["OBS_Consequences"].ToString();
                    richTextBox1.Text = sessionReader["Comments"].ToString();
                }
            }
            sessionReader.Close();
            SqlCommand allergies = new SqlCommand("select * from Medication_Allergies where NID = @NID;", con);
            allergies.Parameters.Add("@NID", NID);
            SqlDataReader allergyReader = allergies.ExecuteReader();
            Allergieslabel.Text = "";
            while(allergyReader.HasRows)
            {
                while(allergyReader.Read())
                {
                    if (allergyReader["Allergy"].ToString() == "Other (Specify)")
                    {
                        Allergieslabel.Text = Allergieslabel.Text + allergyReader["specification"].ToString() + " - ";
                    }
                    else
                    {
                        Allergieslabel.Text = Allergieslabel.Text + allergyReader["Allergy"].ToString() + " - ";
                    }
                }
                allergyReader.NextResult();
            }
            allergyReader.Close();
            SqlCommand HCcmd = new SqlCommand("SELECT * from Health_Conditions where NID = @NID;", con);
            HCcmd.Parameters.Add("@NID",NID);
            SqlDataReader HCreader = HCcmd.ExecuteReader();
            label34.Text = "";
            while(HCreader.HasRows)
            {
                while(HCreader.Read())
                {
                    if (HCreader["Condition"].ToString() == "Other (Specify)")
                    {
                        label34.Text = label34.Text + HCreader["specification"].ToString() + " - ";
                    }
                    else
                    {
                        label34.Text = label34.Text + HCreader["Condition"].ToString() + " - ";
                    }
                }
                HCreader.NextResult();
            }
            HCreader.Close();

            //Previous Session Data retrieve
            SqlCommand symptom = new SqlCommand("Select * from Symptom where NID = @NID;", con);
            symptom.Parameters.Add("@NID", NID);
            SqlDataReader symptomReader = symptom.ExecuteReader();
            label39.Text = "";
            while(symptomReader.HasRows)
            {
                while(symptomReader.Read())
                {
                    if (symptomReader["symptom"].ToString() == "Socially inappropriate" || symptomReader["symptom"].ToString() == "Thought disorder" || symptomReader["symptom"].ToString() == "Other observed symptoms")
                    {
                        label39.Text = label39.Text + " " + symptomReader["symptom"].ToString() + " (" + symptomReader["specification"].ToString() + ") - " ;
                    }
                    else
                    {
                        label39.Text = label39.Text + symptomReader["symptom"].ToString() + " - ";
                    }
                }
                symptomReader.NextResult();
            }
            symptomReader.Close();

            SqlCommand Treatment = new SqlCommand("Select * from Treatment where NID = @NID;", con);
            Treatment.Parameters.Add("@NID", NID);
            SqlDataReader treatmentReader = Treatment.ExecuteReader();
            while(treatmentReader.Read())
            {
                label40.Text = treatmentReader["CT_issues"].ToString();
                label44.Text = treatmentReader["evidence"].ToString();
                label46.Text = treatmentReader["FT"].ToString();
                label48.Text = treatmentReader["action"].ToString();
            }
            treatmentReader.Close();

            SqlCommand response = new SqlCommand("SELECT * from response where NID = @NID;", con);
            response.Parameters.Add("@NID", NID);
            SqlDataReader responseReader = response.ExecuteReader();
            label42.Text = "";
            while(responseReader.HasRows)
            {
                while(responseReader.Read())
                {
                    label42.Text = label42.Text + responseReader["response"].ToString() + " - ";
                }
                responseReader.NextResult();
            }
            responseReader.Close();
            con.Close();
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myfunc("open new Type waveaudio Alias recsound", "", 0, 0);
            myfunc("record recsound", "", 0, 0);
            stopwatch.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            myfunc("save recsound C:\\Users\\hussa\\Desktop\\Recordings\\audi_33.wav", "", 0, 0);
            myfunc("Close recsound", "", 0, 0);
            stopwatch.Stop();
            stopwatch.Reset();
            MessageBox.Show("Session Recording Saved Successfully.");
        }
        private void TimerTick(object sender, EventArgs e)
        {
            lblTimer.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
