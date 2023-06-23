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
    public partial class NewSessionUserControl : UserControl
    {
        SqlConnection con = new SqlConnection();
        public NewSessionUserControl()
        {
            InitializeComponent();
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
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
            if (checkBox12.Checked)
            {
                SqlCommand AggressionV = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                AggressionV.Parameters.Add("@NID", NID);
                AggressionV.Parameters.Add("@Symptom", checkBox12.Text);
                AggressionV.ExecuteNonQuery();
            }
            if (checkBox1.Checked)
            {
                SqlCommand AggressionP = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                AggressionP.Parameters.Add("@NID", NID);
                AggressionP.Parameters.Add("@Symptom", checkBox1.Text);
                AggressionP.ExecuteNonQuery();
            }
            if (checkBox7.Checked)
            {
                SqlCommand Agitation = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Agitation.Parameters.Add("@NID", NID);
                Agitation.Parameters.Add("@Symptom", checkBox7.Text);
                Agitation.ExecuteNonQuery();
            }
            if (checkBox5.Checked)
            {
                SqlCommand Anger = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Anger.Parameters.Add("@NID", NID);
                Anger.Parameters.Add("@Symptom", checkBox5.Text);
                Anger.ExecuteNonQuery();
            }
            if (checkBox4.Checked)
            {
                SqlCommand Anhedonia = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Anhedonia.Parameters.Add("@NID", NID);
                Anhedonia.Parameters.Add("@Symptom", checkBox4.Text);
                Anhedonia.ExecuteNonQuery();
            }
            if (checkBox6.Checked)
            {
                SqlCommand Anxiety = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Anxiety.Parameters.Add("@NID", NID);
                Anxiety.Parameters.Add("@Symptom", checkBox6.Text);
                Anxiety.ExecuteNonQuery();
            }
            if (checkBox3.Checked)
            {
                SqlCommand Apetite = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Apetite.Parameters.Add("@NID", NID);
                Apetite.Parameters.Add("@Symptom", checkBox3.Text);
                Apetite.ExecuteNonQuery();
            }
            if (checkBox2.Checked)
            {
                SqlCommand DangerO = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                DangerO.Parameters.Add("@NID", NID);
                DangerO.Parameters.Add("@Symptom", checkBox2.Text);
                DangerO.ExecuteNonQuery();
            }
            if (checkBox8.Checked)
            {
                SqlCommand DangerS = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                DangerS.Parameters.Add("@NID", NID);
                DangerS.Parameters.Add("@Symptom", checkBox8.Text);
                DangerS.ExecuteNonQuery();
            }
            if (checkBox9.Checked)
            {
                SqlCommand dEnergy = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                dEnergy.Parameters.Add("@NID", NID);
                dEnergy.Parameters.Add("@Symptom", checkBox9.Text);
                dEnergy.ExecuteNonQuery();
            }
            if (checkBox11.Checked)
            {
                SqlCommand Delusions = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Delusions.Parameters.Add("@NID", NID);
                Delusions.Parameters.Add("@Symptom", checkBox11.Text);
                Delusions.ExecuteNonQuery();
            }
            if (checkBox15.Checked)
            {
                SqlCommand Depression = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Depression.Parameters.Add("@NID", NID);
                Depression.Parameters.Add("@Symptom", checkBox15.Text);
                Depression.ExecuteNonQuery();
            }
            if (checkBox14.Checked)
            {
                SqlCommand Distract = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Distract.Parameters.Add("@NID", NID);
                Distract.Parameters.Add("@Symptom", checkBox14.Text);
                Distract.ExecuteNonQuery();
            }
            if (checkBox13.Checked)
            {
                SqlCommand Lability = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Lability.Parameters.Add("@NID", NID);
                Lability.Parameters.Add("@Symptom", checkBox13.Text);
                Lability.ExecuteNonQuery();
            }
            if (checkBox10.Checked)
            {
                SqlCommand Worth = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Worth.Parameters.Add("@NID", NID);
                Worth.Parameters.Add("@Symptom", checkBox10.Text);
                Worth.ExecuteNonQuery();
            }
            if (checkBox16.Checked)
            {
                SqlCommand aHalucinations = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                aHalucinations.Parameters.Add("@NID", NID);
                aHalucinations.Parameters.Add("@Symptom", checkBox16.Text);
                aHalucinations.ExecuteNonQuery();
            }
            if (checkBox22.Checked)
            {
                SqlCommand vHalucinations = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                vHalucinations.Parameters.Add("@NID", NID);
                vHalucinations.Parameters.Add("@Symptom", checkBox22.Text);
                vHalucinations.ExecuteNonQuery();
            }
            if (checkBox23.Checked)
            {
                SqlCommand Hopelessness = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Hopelessness.Parameters.Add("@NID", NID);
                Hopelessness.Parameters.Add("@Symptom", checkBox23.Text);
                Hopelessness.ExecuteNonQuery();
            }
            if (checkBox24.Checked)
            {
                SqlCommand insomnia = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                insomnia.Parameters.Add("@NID", NID);
                insomnia.Parameters.Add("@Symptom", checkBox24.Text);
                insomnia.ExecuteNonQuery();
            }
            if (checkBox18.Checked)
            {
                SqlCommand impulse = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                impulse.Parameters.Add("@NID", NID);
                impulse.Parameters.Add("@Symptom", checkBox18.Text);
                impulse.ExecuteNonQuery();
            }
            if (checkBox19.Checked)
            {
                SqlCommand irretability = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                irretability.Parameters.Add("@NID", NID);
                irretability.Parameters.Add("@Symptom", checkBox19.Text);
                irretability.ExecuteNonQuery();
            }
            if (checkBox20.Checked)
            {
                SqlCommand nStatement = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                nStatement.Parameters.Add("@NID", NID);
                nStatement.Parameters.Add("@Symptom", checkBox20.Text);
                nStatement.ExecuteNonQuery();
            }
            if (checkBox21.Checked)
            {
                SqlCommand nonComp = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                nonComp.Parameters.Add("@NID", NID);
                nonComp.Parameters.Add("@Symptom", checkBox21.Text);
                nonComp.ExecuteNonQuery();
            }
            if (checkBox17.Checked)
            {
                SqlCommand Restle = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Restle.Parameters.Add("@NID", NID);
                Restle.Parameters.Add("@Symptom", checkBox17.Text);
                Restle.ExecuteNonQuery();
            }
            if (checkBox30.Checked)
            {
                SqlCommand sExpression = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                sExpression.Parameters.Add("@NID", NID);
                sExpression.Parameters.Add("@Symptom", checkBox30.Text);
                sExpression.ExecuteNonQuery();
            }
            if (checkBox31.Checked)
            {
                SqlCommand sDeprecation = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                sDeprecation.Parameters.Add("@NID", NID);
                sDeprecation.Parameters.Add("@Symptom", checkBox31.Text);
                sDeprecation.ExecuteNonQuery();
            }
            if (checkBox32.Checked)
            {
                SqlCommand sDeprecation = new SqlCommand("INSERT into Symptom(NID, Symptom, specification) values(@NID, @Symptom, @specification);", con);
                sDeprecation.Parameters.Add("@NID", NID);
                sDeprecation.Parameters.Add("@Symptom", checkBox32.Text);
                if (richTextBox1.Text != "")
                {
                    sDeprecation.Parameters.Add("@specification", richTextBox1.Text);
                }
                sDeprecation.ExecuteNonQuery();
            }
            if (checkBox26.Checked)
            {
                SqlCommand sWithdrawal = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                sWithdrawal.Parameters.Add("@NID", NID);
                sWithdrawal.Parameters.Add("@Symptom", checkBox26.Text);
                sWithdrawal.ExecuteNonQuery();
            }
            if (checkBox27.Checked)
            {
                SqlCommand Suicide = new SqlCommand("INSERT into Symptom(NID, Symptom) values(@NID, @Symptom);", con);
                Suicide.Parameters.Add("@NID", NID);
                Suicide.Parameters.Add("@Symptom", checkBox27.Text);
                Suicide.ExecuteNonQuery();
            }
            if (checkBox28.Checked)
            {
                SqlCommand sDeprecation = new SqlCommand("INSERT into Symptom(NID, Symptom, specification) values(@NID, @Symptom, @specification);", con);
                sDeprecation.Parameters.Add("@NID", NID);
                sDeprecation.Parameters.Add("@Symptom", checkBox28.Text);
                if (richTextBox2.Text != "")
                {
                    sDeprecation.Parameters.Add("@specification", richTextBox2.Text);
                }
                sDeprecation.ExecuteNonQuery();
            }
            if (checkBox29.Checked)
            {
                SqlCommand sDeprecation = new SqlCommand("INSERT into Symptom(NID, Symptom, specification) values(@NID, @Symptom, @specification);", con);
                sDeprecation.Parameters.Add("@NID", NID);
                sDeprecation.Parameters.Add("@Symptom", checkBox29.Text);
                if (richTextBox3.Text != "")
                {
                    sDeprecation.Parameters.Add("@specification", richTextBox3.Text);
                }
                sDeprecation.ExecuteNonQuery();
            }
            if (checkBox39.Checked)
            {
                SqlCommand improvement = new SqlCommand("INSERT into response(NID, response) values(@NID, @response);", con);
                improvement.Parameters.Add("@NID", NID);
                improvement.Parameters.Add("@response", checkBox39.Text);
                improvement.ExecuteNonQuery();
            }
            if (checkBox37.Checked)
            {
                SqlCommand sImprovement = new SqlCommand("INSERT into response(NID, response) values(@NID, @response);", con);
                sImprovement.Parameters.Add("@NID", NID);
                sImprovement.Parameters.Add("@response", checkBox37.Text);
                sImprovement.ExecuteNonQuery();
            }
            if (checkBox34.Checked)
            {
                SqlCommand maintainFunc = new SqlCommand("INSERT into response(NID, response) values(@NID, @response);", con);
                maintainFunc.Parameters.Add("@NID", NID);
                maintainFunc.Parameters.Add("@response", checkBox34.Text);
                maintainFunc.ExecuteNonQuery();
            }
            if (checkBox25.Checked)
            {
                SqlCommand worse = new SqlCommand("INSERT into response(NID, response) values(@NID, @response);", con);
                worse.Parameters.Add("@NID", NID);
                worse.Parameters.Add("@response", checkBox25.Text);
                worse.ExecuteNonQuery();
            }
            if(richTextBox4.Text != "" && richTextBox5.Text != "" && richTextBox6.Text != "")
            {
                SqlCommand TreatmentFD = new SqlCommand("insert into Treatment(NID, CT_issues, evidence, FT, action) values(@NID, @CT_issues, @evidence, @FT, @action);", con);
                TreatmentFD.Parameters.Add("@NID", NID);
                TreatmentFD.Parameters.Add("@CT_issues", richTextBox4.Text);
                TreatmentFD.Parameters.Add("@evidence", richTextBox5.Text);
                TreatmentFD.Parameters.Add("@FT", richTextBox6.Text);
                if(radioButton1.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton1.Text);
                }
                if(radioButton2.Checked) 
                {
                    TreatmentFD.Parameters.Add("@action", radioButton2.Text);
                }
                if(radioButton3.Checked) 
                {
                    TreatmentFD.Parameters.Add("@action", radioButton3.Text);
                }
                TreatmentFD.ExecuteNonQuery();
            }
            else if (richTextBox4.Text == "" && richTextBox5.Text != "" && richTextBox6.Text != "")
            {
                SqlCommand TreatmentFD = new SqlCommand("insert into Treatment(NID, evidence, FT, action) values(@NID, @evidence, @FT, @action);", con);
                TreatmentFD.Parameters.Add("@NID", NID);
                TreatmentFD.Parameters.Add("@evidence", richTextBox5.Text);
                TreatmentFD.Parameters.Add("@FT", richTextBox6.Text);
                if (radioButton1.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton3.Text);
                }
                TreatmentFD.ExecuteNonQuery();
            }
            else if (richTextBox4.Text != "" && richTextBox5.Text == "" && richTextBox6.Text != "")
            {
                SqlCommand TreatmentFD = new SqlCommand("insert into Treatment(NID, CT_issues, FT, action) values(@NID, @CT_issues, @FT, @action);", con);
                TreatmentFD.Parameters.Add("@NID", NID);
                TreatmentFD.Parameters.Add("@CT_issues", richTextBox4.Text);
                TreatmentFD.Parameters.Add("@FT", richTextBox6.Text);
                if (radioButton1.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton3.Text);
                }
                TreatmentFD.ExecuteNonQuery();
            }
            else if (richTextBox4.Text != "" && richTextBox5.Text != "" && richTextBox6.Text == "")
            {
                SqlCommand TreatmentFD = new SqlCommand("insert into Treatment(NID, CT_issues, evidence, action) values(@NID, @CT_issues, @evidence, @action);", con);
                TreatmentFD.Parameters.Add("@NID", NID);
                TreatmentFD.Parameters.Add("@CT_issues", richTextBox4.Text);
                TreatmentFD.Parameters.Add("@evidence", richTextBox5.Text);
                if (radioButton1.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton3.Text);
                }
                TreatmentFD.ExecuteNonQuery();
            }
            else if (richTextBox4.Text == "" && richTextBox5.Text == "" && richTextBox6.Text != "")
            {
                SqlCommand TreatmentFD = new SqlCommand("insert into Treatment(NID, FT, action) values(@NID, @FT, @action);", con);
                TreatmentFD.Parameters.Add("@NID", NID);
                TreatmentFD.Parameters.Add("@FT", richTextBox6.Text);
                if (radioButton1.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton3.Text);
                }
                TreatmentFD.ExecuteNonQuery();
            }
            else if (richTextBox4.Text != "" && richTextBox5.Text == "" && richTextBox6.Text == "")
            {
                SqlCommand TreatmentFD = new SqlCommand("insert into Treatment(NID, CT_issues, action) values(@NID, @CT_issues, @action);", con);
                TreatmentFD.Parameters.Add("@NID", NID);
                TreatmentFD.Parameters.Add("@CT_issues", richTextBox4.Text);
                if (radioButton1.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton3.Text);
                }
                TreatmentFD.ExecuteNonQuery();
            }
            else if (richTextBox4.Text == "" && richTextBox5.Text != "" && richTextBox6.Text == "")
            {
                SqlCommand TreatmentFD = new SqlCommand("insert into Treatment(NID, evidence, action) values(@NID,  @evidence, @action);", con);
                TreatmentFD.Parameters.Add("@NID", NID);
                TreatmentFD.Parameters.Add("@evidence", richTextBox5.Text);
                if (radioButton1.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton3.Text);
                }
                TreatmentFD.ExecuteNonQuery();
            }
            else if (richTextBox4.Text == "" && richTextBox5.Text == "" && richTextBox6.Text == "")
            {
                SqlCommand TreatmentFD = new SqlCommand("insert into Treatment(NID, action) values(@NID, @action);", con);
                TreatmentFD.Parameters.Add("@NID", NID);
                if (radioButton1.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    TreatmentFD.Parameters.Add("@action", radioButton3.Text);
                }
                TreatmentFD.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Session Data Saved Successfully, Please Navigate to The Next Section");
        }

        private void NewSessionUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
