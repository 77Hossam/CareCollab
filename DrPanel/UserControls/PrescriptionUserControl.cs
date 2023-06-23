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
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MigraDoc.DocumentObjectModel.IO;
using MigraDoc.DocumentObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;
using Chunk = iTextSharp.text.Chunk;
using Color = System.Drawing.Color;
using Guna.UI2.WinForms.Suite;
using static System.Net.Mime.MediaTypeNames;
using MySql.Data.MySqlClient;


namespace DrPanel.UserControls
{
    public partial class PrescriptionUserControl : UserControl
    {
        SqlConnection con = new SqlConnection();
        //MySQL connection
        MySqlConnection mySqlConnection = new MySqlConnection("server=sql12.freesqldatabase.com; user=sql12628032; database=sql12628032; password=fVWYdFY3Wc");

        public PrescriptionUserControl()
        {
            InitializeComponent();

            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label31.Text = richTextBox1.Text;

        }

        private void PrescriptionUserControl_Load(object sender, EventArgs e)
        {
            label30.Text = "";
            label37.Text = "";
            label32.Text = "";
            label33.Text = "";
            label34.Text = "";
            label35.Text = "";
            label36.Text = "";
            label31.Text = "";
            con.Open();

            SqlCommand drInfo = new SqlCommand("SELECT * from Staff where active = 1;", con);
            SqlDataReader drReader = drInfo.ExecuteReader();
            while(drReader.Read())
            {
                label3.Text = "Name: " + drReader["fname"].ToString() + " " + drReader["lname"].ToString();
                label8.Text = "Pkone: 0" + drReader["contact"].ToString();
            }
            drReader.Close();
            label17.Text = "   " + DateTime.Now.Date.ToString("d/M/yyyy");

            //adding new prescription
            SqlCommand currentP = new SqlCommand("SELECT * from patient where active = 1;", con);
            SqlDataReader NIDreader = currentP.ExecuteReader();
            long NID = 0;
            int SessionNO = 0;
            while(NIDreader.Read())
            {
                NID = long.Parse(NIDreader["NID"].ToString());
                SessionNO = int.Parse(NIDreader["SessionNum"].ToString());
            }
            NIDreader.Close();
            SqlCommand newpres = new SqlCommand("insert into prescription(NID, drugsAmount, active, prDate, sessionNO) values(@NID, 0, @active, @prDate, @sessionNO);", con);
            newpres.Parameters.Add("@NID", NID);
            newpres.Parameters.Add("@active", 1);
            newpres.Parameters.Add("@prDate", DateTime.Now.Date.ToString("M/d/yyyy"));
            newpres.Parameters.Add("@sessionNO", SessionNO);
            newpres.ExecuteNonQuery();
            con.Close();
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label30.Text = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label37.Text = comboBox2.SelectedItem.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label32.Text = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label33.Text = comboBox1.SelectedItem.ToString();
        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            label34.Text = numericUpDown2.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label35.Text = numericUpDown1.Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label36.Text = textBox4.Text;
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if(textBox1.Text != "Added Once Only")
            {
                label30.Text = textBox1.Text;
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            label37.Text = comboBox1.SelectedItem.ToString();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            if(textBox6.Text != "Per mg")
            {
                label32.Text = textBox6.Text + " mg";
            }
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            label33.Text = comboBox1.SelectedItem.ToString();
        }

        private void numericUpDown2_ValueChanged_2(object sender, EventArgs e)
        {
            label34.Text = numericUpDown2.Value.ToString();
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            label35.Text = numericUpDown1.Value.ToString();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            label36.Text = textBox4.Text;
        }

        private void btnNavigate_Click_1(object sender, EventArgs e)
        {
            con.Open();

            //retreiving Doctor information
            SqlCommand drData = new SqlCommand("SELECT * from Staff where active = 1;", con);
            SqlDataReader DrReader = drData.ExecuteReader();
            string DrName = "";
            string Drcontact = "";
            while(DrReader.Read())
            {
                DrName = DrReader["fname"].ToString() + " " + DrReader["lname"].ToString();
                Drcontact = "0" + DrReader["contact"].ToString();
            }
            DrReader.Close();
            //Naming the prescription pdf and retrieve patient data
            SqlCommand PdfName = new SqlCommand("SELECT * from patient where active = 1;", con);
            SqlDataReader patientReader = PdfName.ExecuteReader();
            string pdfname = "";
            string pGender = "";
            string pName = "";
            string pAge = "";
            string pPhone = "";
            while (patientReader.Read())
            {
                pdfname = patientReader["patient_fname"].ToString() + patientReader["patient_lname"].ToString() + "_" +patientReader["SessionNum"].ToString();
                pGender = patientReader["Gender"].ToString();
                pName = patientReader["patient_fname"].ToString() + " "+patientReader["patient_lname"].ToString();
                pAge = patientReader["age"].ToString();
                pPhone = patientReader["phoneNumber"].ToString();
            }
            patientReader.Close();
            //retrieve prescription information
            SqlCommand prescriptioninfo = new SqlCommand("SELECT * from prescription where active = 1;", con);
            SqlDataReader prescriptionReader = prescriptioninfo.ExecuteReader();
            string diagnosis = "";
            int presID = 0;
            int drugs = 0;
            while (prescriptionReader.Read())
            {
                diagnosis = prescriptionReader["Diagnosis"].ToString();
                presID = int.Parse(prescriptionReader["prsID"].ToString());
                drugs = int.Parse(prescriptionReader["drugsAmount"].ToString());
            }
            prescriptionReader.Close();

            Document pdoc = new Document(iTextSharp.text.PageSize.A5, 20f, 20f, 30f, 30f);
            PdfWriter pWriter = PdfWriter.GetInstance(pdoc, new FileStream("D:\\BMD302\\Test project\\Prescriptions\\" + pdfname + ".pdf", FileMode.Create));
            pdoc.Open();

            //Image
            System.Drawing.Image pImage = System.Drawing.Image.FromFile("D:\\BMD302\\Test project\\Prescriptions\\Rx.jpeg.jpg");
            iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(pImage, System.Drawing.Imaging.ImageFormat.Jpeg);



            //Fonts
            iTextSharp.text.Font pfont1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Font pfont2 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
            iTextSharp.text.Font pfont3 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 8, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);



            //Paragraphs
            //Clinic Info
            Paragraph pClinicName = new Paragraph("Name: " + DrName, pfont1);
            Paragraph pClinicPhone = new Paragraph("Phone: " + Drcontact, pfont1);
            Paragraph pClinicAddress = new Paragraph("Address: ", pfont1);

            //Patient Info

            Paragraph PInfo = new Paragraph("Patient Info", pfont1);
            Paragraph PGender = new Paragraph("Gender: " + pGender, pfont3);
            Paragraph PName = new Paragraph("Name: " + pName, pfont3);
            Paragraph PAge = new Paragraph("Age: " + pAge, pfont3);
            Paragraph PPhone = new Paragraph("Phone: " + pPhone, pfont3);
            Paragraph Diagnosis = new Paragraph("Diagnosis: " + diagnosis, pfont3);



            //Declaring Variables

            String Medicine = "Medicine_";
            String Strength = "Strength: ";
            String Form = "Form: ";
            String Dose = "Dose: ";
            String Frequency = "Frequency: ";
            String Dispense = "Dispense: ";
            String Date = DateTime.Now.Date.ToString("d/M/yyyy");

            

            Paragraph Datee = new Paragraph("Date                                                                     Signature", pfont1);

            //Paragraphs Lines

            Paragraph lineOne = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            Paragraph lineTwo = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            Paragraph lineThree = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_BOTTOM, 1)));
            Paragraph lineFour = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_BOTTOM, 1)));
            Paragraph lineDate = new Paragraph("     " + Date + "                                                              --------------------");


            //Paragraphs Manipulations

            PInfo.Alignment = Element.ALIGN_CENTER;
            Diagnosis.SpacingAfter = 20;
            Datee.IndentationLeft = 30;
            Datee.Alignment = Element.ALIGN_BOTTOM;
            lineFour.SpacingAfter = 30;
            pClinicName.Alignment = Element.ALIGN_LEFT;
            pClinicPhone.Alignment = Element.ALIGN_LEFT;
            pClinicAddress.Alignment = Element.ALIGN_LEFT;
            ItextImage.Alignment = Element.ALIGN_LEFT;


            //Add Items

            pdoc.Add(pClinicName);
            pdoc.Add(pClinicPhone);
            pdoc.Add(pClinicAddress);
            pdoc.Add(lineOne);
            pdoc.Add(lineTwo);
            pdoc.Add(PInfo);
            pdoc.Add(PGender);
            pdoc.Add(PName);
            pdoc.Add(PAge);
            pdoc.Add(PPhone);
            pdoc.Add(Diagnosis);
            pdoc.Add(ItextImage);
            SqlCommand medications = new SqlCommand("SELECT * from drug where presID = @presID;", con);
            medications.Parameters.Add("@presID", presID);
            SqlDataReader medReader = medications.ExecuteReader();
            int i = 1;
            while (i <= drugs)
            {
                while(medReader.Read())
                {
                    Paragraph medStrOne = new Paragraph("          " + Medicine + i + ": " + medReader["drugName"].ToString() + " " + Strength + medReader["strength"].ToString()+ " mg " +Form + medReader["form"].ToString(), pfont3);
                    Paragraph FDDOne = new Paragraph("          " + Dose + medReader["dose"].ToString() + " " + Frequency + medReader["frequency"].ToString() + " " + Dispense + medReader["dispense"].ToString(), pfont3);
                    Paragraph emptLine = new Paragraph("  ");
                    i++;
                    pdoc.Add(medStrOne);
                    pdoc.Add(FDDOne);
                    pdoc.Add(emptLine);
                }
                medReader.NextResult();
            }
            medReader.Close();
            if(i == 2)
            {
                lineThree.SpacingBefore = 130;
            }
            else if(i == 3)
            {
                lineThree.SpacingBefore = 80;
            }
            else if (i == 4)
            {
                lineThree.SpacingBefore = 40;
            }
            else if (i == 3)
            {
                lineThree.SpacingBefore = 0;
            }
            pdoc.Add(lineThree);
            pdoc.Add(lineFour);
            pdoc.Add(lineDate);
            pdoc.Add(Datee);
            pdoc.Close();
            MessageBox.Show("Prescription Saved and Extracted Successfully.");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand prescription = new SqlCommand("SELECT * from prescription where active = 1;", con);
            SqlDataReader presReader = prescription.ExecuteReader();
            int presID = 0;
            int drugAmount = 0;
            string flag = "";
            while (presReader.Read())
            {
                presID = int.Parse(presReader["prsID"].ToString());
                drugAmount = int.Parse(presReader["drugsAmount"].ToString());
                if (presReader["Diagnosis"].ToString() == "")
                {
                    flag = "green";
                }
                else
                {
                    flag = "red";
                }
            }
            presReader.Close();
            try
            {
                if(textBox1.Text != "" && textBox1.Text != "Added Once Only")
                {
                    if (flag == "green")
                    {
                        SqlCommand diagnosis = new SqlCommand("UPDATE prescription set Diagnosis = @Diagnosis where active = 1;", con);
                        diagnosis.Parameters.Add("@Diagnosis", textBox1.Text);
                        diagnosis.ExecuteNonQuery();

                        SqlCommand medication = new SqlCommand("insert into drug(presID, drugName, strength, form, dispense, dose, frequency, comments) values(@presID, @drugName, @strength, @form, @dispense, @dose, @frequency, @comments);", con);
                        medication.Parameters.Add("@presID", presID);
                        medication.Parameters.Add("@drugName", comboBox2.SelectedItem.ToString());
                        medication.Parameters.Add("@strength", int.Parse(textBox6.Text));
                        medication.Parameters.Add("@form", comboBox1.SelectedItem.ToString());
                        medication.Parameters.Add("@dispense", int.Parse(numericUpDown2.Value.ToString()));
                        medication.Parameters.Add("@dose", int.Parse(numericUpDown1.Value.ToString()));
                        medication.Parameters.Add("@frequency", textBox4.Text);
                        medication.Parameters.Add("@comments", richTextBox1.Text);
                        medication.ExecuteNonQuery();
                        SqlCommand drugNum = new SqlCommand("UPDATE prescription set drugsAmount = @drugsAmount where active = 1;", con);
                        drugNum.Parameters.Add("@drugsAmount", drugAmount + 1);
                        drugNum.ExecuteNonQuery();
                        MessageBox.Show("Drug Added Successfully.");
                        comboBox2.SelectedItem = null;
                        textBox1.Text = "";
                        textBox6.Text = "";
                        textBox4.Text = "";
                        numericUpDown1.Value = 0;
                        numericUpDown2.Value = 0;
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("There is already an existing diagnosis for the current prescription", "Drug Added Before", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    SqlCommand medication = new SqlCommand("insert into drug(presID, drugName, strength, form, dispense, dose, frequency, comments) values(@presID, @drugName, @strength, @form, @dispense, @dose, @frequency, @comments);", con);
                    medication.Parameters.Add("@presID", presID);
                    medication.Parameters.Add("@drugName", comboBox2.SelectedItem.ToString());
                    medication.Parameters.Add("@strength", int.Parse(textBox6.Text));
                    medication.Parameters.Add("@form", comboBox1.SelectedItem.ToString());
                    medication.Parameters.Add("@dispense", int.Parse(numericUpDown2.Value.ToString()));
                    medication.Parameters.Add("@dose", int.Parse(numericUpDown1.Value.ToString()));
                    medication.Parameters.Add("@frequency", textBox4.Text);
                    medication.Parameters.Add("@comments", richTextBox1.Text);
                    medication.ExecuteNonQuery();
                    SqlCommand drugNum = new SqlCommand("UPDATE prescription set drugsAmount = @drugsAmount where active = 1;", con);
                    drugNum.Parameters.Add("@drugsAmount", drugAmount + 1);
                    drugNum.ExecuteNonQuery();
                    MessageBox.Show("Drug Added Successfully.");
                    comboBox2.SelectedItem = null;
                    textBox1.Text = "";
                    textBox6.Text = "";
                    textBox4.Text = "";
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                    richTextBox1.Text = "";
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " values provided are not in a correct format or there are missing values");
            }
            con.Close();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            label31.Text = richTextBox1.Text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Added Once Only")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Added Once Only";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label33.Text = comboBox1.SelectedItem.ToString();
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Per mg")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Per mg";
                textBox6.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            mySqlConnection.Open();
            SqlCommand pres = new SqlCommand("select * from Prescription where active = 1;", con);
            SqlDataReader presReader = pres.ExecuteReader();
            int presID = 0;
            long NID = 0;
            int drugsamount = 0;
            while(presReader.Read())
            {
                presID = int.Parse(presReader["prsID"].ToString());
                drugsamount = int.Parse(presReader["drugsAmount"].ToString());
                NID = long.Parse(presReader["NID"].ToString());
                String Diagnosis = presReader["Diagnosis"].ToString();
                MySqlCommand presc = new MySqlCommand("insert into Prescription(prsID, NID, drugsAmount, active, Diagnosis, prDate) values(@prsID, @NID, @drugsAmount, @active, @Diagnosis, @prDate);", mySqlConnection);
                presc.Parameters.AddWithValue("@prsID", presID);
                presc.Parameters.AddWithValue("@NID", NID);
                presc.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                presc.Parameters.AddWithValue("@drugsAmount", drugsamount);
                presc.Parameters.AddWithValue("@prDate", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                presc.Parameters.AddWithValue("@active", 0);
                presc.ExecuteNonQuery();
            }
            presReader.Close();
            SqlCommand drugs = new SqlCommand("select * from drug where presID = @presID", con);
            drugs.Parameters.Add("@presID", presID);
            SqlDataReader drugsReader = drugs.ExecuteReader();
            while(drugsReader.Read())
            {
                MySqlCommand drug = new MySqlCommand("insert into drug (drugID, presID, drugName, strength, form, dispense, dose, frequency, comments) values (@drugID, @presID, @drugName, @strength, @form, @dispense, @dose, @frequency, @comments);", mySqlConnection);
                drug.Parameters.AddWithValue("@drugID", int.Parse(drugsReader["drugID"].ToString()));
                drug.Parameters.AddWithValue("@presID", presID);
                drug.Parameters.AddWithValue("@drugName", drugsReader["drugName"].ToString());
                drug.Parameters.AddWithValue("@strength", int.Parse(drugsReader["strength"].ToString()));
                drug.Parameters.AddWithValue("@form", drugsReader["form"].ToString());
                drug.Parameters.AddWithValue("@dispense", int.Parse(drugsReader["dispense"].ToString()));
                drug.Parameters.AddWithValue("@dose", int.Parse(drugsReader["dose"].ToString()));
                drug.Parameters.AddWithValue("@frequency", drugsReader["frequency"].ToString());
                drug.Parameters.AddWithValue("@comments", drugsReader["comments"].ToString());

                drug.ExecuteNonQuery();
            }
            drugsReader.Close();
            mySqlConnection.Close();
            con.Close();

            MessageBox.Show("Order Placed Successfully!");
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //label37.Text = comboBox2.SelectedItem.ToString();
        }
    }
}
