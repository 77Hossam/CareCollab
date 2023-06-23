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
    public partial class FirstSession : UserControl
    {
        SqlConnection con = new SqlConnection();
        public FirstSession()
        {
            InitializeComponent();
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
        }

        private void NewSessionLabel_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FirstSession_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand pNID = new SqlCommand("SELECT * from patient where active = 1;", con);
            SqlDataReader readerNID = pNID.ExecuteReader();
            long NID = 0;
            while (readerNID.Read())
            {
                NID = long.Parse(readerNID["NID"].ToString());
            }
            readerNID.Close();
            SqlCommand patientTwo = new SqlCommand(
            @"Update patient SET 
            Self_Employed = @Self_Employed, 
            Family_History = @Family_History, 
            Treatment = @Treatment, 
            Work_Interfere = @Work_Interfere, 
            Num_Employees = @Num_Employees, 
            Remote_Work = @Remote_Work, 
            Tech_Company = @Tech_Company, 
            Benefits = @Benefits, 
            Care_Options = @Care_Options, 
            Wellness_Program = @Wellness_Program, 
            Seek_Help = @Seek_Help, 
            Anonymity = @Anonymity, 
            Leave = @Leave,
            PHC = @PHC, 
            MHC = @MHC, 
            Coworkers = @Coworkers, 
            Supervisor = @Supervisor, 
            MHI = @MHI, 
            PHI = @PHI, 
            MVSPH = @MVSPH, 
            OBS_Consequences = @OBS_Consequences,
            Comments = @Comments, 
            Occupation = @Occupation 
            where active = 1;", con);


            patientTwo.Parameters.Add("@Comments", richTextBox1.Text);
            patientTwo.Parameters.Add("@Num_Employees", textBox5.Text);
            patientTwo.Parameters.Add("@MA_Specify", textBox1.Text);
            patientTwo.Parameters.Add("@HC_Specify", textBox2.Text);
            patientTwo.Parameters.Add("@Occupation", textBox7.Text);



            //Self Employed
            if (radioButton4.Checked)
            {
                patientTwo.Parameters.Add("@Self_Employed", radioButton4.Text);
            }
            if (radioButton3.Checked)
            {
                patientTwo.Parameters.Add("@Self_Employed", radioButton3.Text);
            }
            //Family History
            if (radioButton6.Checked)
            {
                patientTwo.Parameters.Add("@Family_History", radioButton6.Text);
            }
            if (radioButton5.Checked)
            {
                patientTwo.Parameters.Add("@Family_History", radioButton5.Text);
            }

            //Treatment

            if (radioButton8.Checked)
            {
                patientTwo.Parameters.Add("@Treatment", radioButton8.Text);
            }
            if (radioButton7.Checked)
            {
                patientTwo.Parameters.Add("@Treatment", radioButton7.Text);
            }

            //Work_Interfere
            patientTwo.Parameters.Add("@Work_Interfere", comboBox1.SelectedItem.ToString());

            //Remote_Work
            if (radioButton10.Checked)
            {
                patientTwo.Parameters.Add("@Remote_Work", radioButton10.Text);
            }
            if (radioButton9.Checked)
            {
                patientTwo.Parameters.Add("@Remote_Work", radioButton9.Text);
            }


            //Tech_Company
            if (radioButton14.Checked)
            {
                patientTwo.Parameters.Add("@Tech_Company", radioButton14.Text);
            }
            if (radioButton15.Checked)
            {
                patientTwo.Parameters.Add("@Tech_Company", radioButton15.Text);
            }
            if (radioButton13.Checked)
            {
                patientTwo.Parameters.Add("@Tech_Company", radioButton13.Text);
            }

            //Benefits
            if (radioButton16.Checked)
            {
                patientTwo.Parameters.Add("@Benefits", radioButton16.Text);
            }
            if (radioButton17.Checked)
            {
                patientTwo.Parameters.Add("@Benefits", radioButton17.Text);
            }
            if (radioButton18.Checked)
            {
                patientTwo.Parameters.Add("@Benefits", radioButton18.Text);
            }

            //Care_Options
            if (radioButton19.Checked)
            {
                patientTwo.Parameters.Add("@Care_Options", radioButton19.Text);
            }
            if (radioButton20.Checked)
            {
                patientTwo.Parameters.Add("@Care_Options", radioButton20.Text);
            }
            if (radioButton21.Checked)
            {
                patientTwo.Parameters.Add("@Care_Options", radioButton21.Text);
            }

            //Wellness_Program
            if (radioButton22.Checked)
            {
                patientTwo.Parameters.Add("@Wellness_Program", radioButton22.Text);
            }
            if (radioButton23.Checked)
            {
                patientTwo.Parameters.Add("@Wellness_Program", radioButton23.Text);
            }
            if (radioButton24.Checked)
            {
                patientTwo.Parameters.Add("@Wellness_Program", radioButton24.Text);
            }
            //Seek_Help
            if (radioButton25.Checked)
            {
                patientTwo.Parameters.Add("@Seek_Help", radioButton25.Text);
            }
            if (radioButton26.Checked)
            {
                patientTwo.Parameters.Add("@Seek_Help", radioButton26.Text);
            }
            if (radioButton27.Checked)
            {
                patientTwo.Parameters.Add("@Seek_Help", radioButton27.Text);
            }
            //Anonymity
            if (radioButton28.Checked)
            {
                patientTwo.Parameters.Add("@Anonymity", radioButton28.Text);
            }
            if (radioButton29.Checked)
            {
                patientTwo.Parameters.Add("@Anonymity", radioButton29.Text);
            }
            if (radioButton30.Checked)
            {
                patientTwo.Parameters.Add("@Anonymity", radioButton30.Text);
            }

            //Leave
            patientTwo.Parameters.Add("@Leave", comboBox2.SelectedItem.ToString());

            //PHC
            if (radioButton34.Checked)
            {
                patientTwo.Parameters.Add("@PHC", radioButton34.Text);
            }
            if (radioButton35.Checked)
            {
                patientTwo.Parameters.Add("@PHC", radioButton35.Text);
            }
            if (radioButton36.Checked)
            {
                patientTwo.Parameters.Add("@PHC", radioButton36.Text);
            }
            //MHC
            if (radioButton31.Checked)
            {
                patientTwo.Parameters.Add("@MHC", radioButton31.Text);
            }
            if (radioButton32.Checked)
            {
                patientTwo.Parameters.Add("@MHC", radioButton32.Text);
            }
            if (radioButton33.Checked)
            {
                patientTwo.Parameters.Add("@MHC", radioButton33.Text);
            }
            //Coworkers
            if (radioButton37.Checked)
            {
                patientTwo.Parameters.Add("@Coworkers", radioButton37.Text);
            }
            if (radioButton38.Checked)
            {
                patientTwo.Parameters.Add("@Coworkers", radioButton38.Text);
            }
            if (radioButton39.Checked)
            {
                patientTwo.Parameters.Add("@Coworkers", radioButton39.Text);
            }

            //Supervisor
            if (radioButton50.Checked)
            {
                patientTwo.Parameters.Add("@Supervisor", radioButton50.Text);
            }
            if (radioButton51.Checked)
            {
                patientTwo.Parameters.Add("@Supervisor", radioButton51.Text);
            }

            //MHI
            if (radioButton46.Checked)
            {
                patientTwo.Parameters.Add("@MHI", radioButton46.Text);
            }
            if (radioButton47.Checked)
            {
                patientTwo.Parameters.Add("@MHI", radioButton47.Text);
            }
            if (radioButton48.Checked)
            {
                patientTwo.Parameters.Add("@MHI", radioButton48.Text);
            }

            //PHI
            if (radioButton43.Checked)
            {
                patientTwo.Parameters.Add("@PHI", radioButton43.Text);
            }
            if (radioButton44.Checked)
            {
                patientTwo.Parameters.Add("@PHI", radioButton44.Text);
            }
            if (radioButton45.Checked)
            {
                patientTwo.Parameters.Add("@PHI", radioButton45.Text);
            }
            //MVSPH
            if (radioButton40.Checked)
            {
                patientTwo.Parameters.Add("@MVSPH", radioButton40.Text);
            }
            if (radioButton41.Checked)
            {
                patientTwo.Parameters.Add("@MVSPH", radioButton41.Text);
            }
            if (radioButton42.Checked)
            {
                patientTwo.Parameters.Add("@MVSPH", radioButton42.Text);
            }
            //OBS_Consequences
            if (radioButton49.Checked)
            {
                patientTwo.Parameters.Add("@OBS_Consequences", radioButton49.Text);
            }
            if (radioButton52.Checked)
            {
                patientTwo.Parameters.Add("@OBS_Consequences", radioButton52.Text);
            }
            //Medication_Allergies
            if (checkBox1.Checked)
            {
                SqlCommand MAO = new SqlCommand("INSERT INTO Medication_Allergies(NID,Allergy) VALUES (@NID, @Allergy);", con);
                MAO.Parameters.Add("@NID", NID);
                MAO.Parameters.Add("@Allergy", checkBox1.Text);
                MAO.ExecuteNonQuery();
            }
            if (checkBox2.Checked)
            {
                SqlCommand MAT = new SqlCommand("INSERT INTO Medication_Allergies(NID,Allergy) VALUES (@NID, @Allergy);", con);
                MAT.Parameters.Add("@NID", NID);
                MAT.Parameters.Add("@Allergy", checkBox2.Text);
                MAT.ExecuteNonQuery();
            }
            if (checkBox3.Checked)
            {
                SqlCommand MATT = new SqlCommand("INSERT INTO Medication_Allergies(NID,Allergy,specification) VALUES (@NID, @Allergy,@specification);", con);
                MATT.Parameters.Add("@NID", NID);
                MATT.Parameters.Add("@Allergy", checkBox3.Text);
                MATT.Parameters.Add("@specification", textBox1.Text);
                MATT.ExecuteNonQuery();
            }
            if (checkBox4.Checked)
            {
                SqlCommand MATT = new SqlCommand("INSERT INTO Medication_Allergies(NID,Allergy) VALUES (@NID, @Allergy);", con);
                MATT.Parameters.Add("@NID", NID);
                MATT.Parameters.Add("@Allergy", checkBox4.Text);
                MATT.ExecuteNonQuery();
            }
            if (checkBox5.Checked)
            {
                SqlCommand MAF = new SqlCommand("INSERT INTO Medication_Allergies(NID,Allergy) VALUES (@NID, @Allergy);", con);
                MAF.Parameters.Add("@NID", NID);
                MAF.Parameters.Add("@Allergy", checkBox5.Text);
                MAF.ExecuteNonQuery();
            }
            if (checkBox6.Checked)
            {
                SqlCommand MAS = new SqlCommand("INSERT INTO Medication_Allergies(NID,Allergy) VALUES (@NID, @Allergy);", con);
                MAS.Parameters.Add("@NID", NID);
                MAS.Parameters.Add("@Allergy", checkBox6.Text);
                MAS.ExecuteNonQuery();
            }
            //Health_Condition
            if (checkBox7.Checked)
            {
                SqlCommand HCO = new SqlCommand("INSERT INTO Health_Conditions(NID,Condition) VALUES (@NID, @Condition);", con);
                HCO.Parameters.Add("@NID", NID);
                HCO.Parameters.Add("@Condition", checkBox7.Text);
                HCO.ExecuteNonQuery();
            }
            if (checkBox8.Checked)
            {
                SqlCommand HCT = new SqlCommand("INSERT INTO Health_Conditions(NID,Condition) VALUES (@NID, @Condition);", con);
                HCT.Parameters.Add("@NID", NID);
                HCT.Parameters.Add("@Condition", checkBox8.Text);
                HCT.ExecuteNonQuery();
            }
            if (checkBox9.Checked)
            {
                SqlCommand HCTT = new SqlCommand("INSERT INTO Health_Conditions(NID,Condition) VALUES (@NID, @Condition);", con);
                HCTT.Parameters.Add("@NID", NID);
                HCTT.Parameters.Add("@Condition", checkBox9.Text);
                HCTT.ExecuteNonQuery();
            }
            if (checkBox10.Checked)
            {
                SqlCommand HCF = new SqlCommand("INSERT INTO Health_Conditions(NID,Condition,specification) VALUES (@NID, @Condition,@specification);", con);
                HCF.Parameters.Add("@NID", NID);
                HCF.Parameters.Add("@Condition", checkBox10.Text);
                HCF.Parameters.Add("@specification", textBox2.Text);
                HCF.ExecuteNonQuery();
            }
            if (checkBox11.Checked)
            {
                SqlCommand HCFF = new SqlCommand("INSERT INTO Health_Conditions(NID,Condition) VALUES (@NID, @Condition);", con);
                HCFF.Parameters.Add("@NID", NID);
                HCFF.Parameters.Add("@Condition", checkBox11.Text);
                HCFF.ExecuteNonQuery();
            }
            if (checkBox12.Checked)
            {
                SqlCommand HCS = new SqlCommand("INSERT INTO Health_Conditions(NID,Condition) VALUES (@NID, @Condition);", con);
                HCS.Parameters.Add("@NID", NID);
                HCS.Parameters.Add("@Condition", checkBox12.Text);
                HCS.ExecuteNonQuery();
            }
            patientTwo.ExecuteNonQuery();
            SqlCommand patientT = new SqlCommand("Update patient SET SessionNum = 1 WHERE active = 1", con);
            patientT.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Patient History Saved Successfully, please navigate to the next panel.");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
