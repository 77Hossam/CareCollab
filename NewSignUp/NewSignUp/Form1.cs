using Clinical_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSignUp
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection();
        string role, fname, lname, email, password, passconfirm, gender, phone;

        private void combobtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobtn.SelectedIndex == 0)
            {
                role = "Doctor";
            }
            else if (combobtn.SelectedIndex == 1)
            {
                role = "Patient";
            }
            else
            {
                role = "Secretary";
            }
        }

        private void combobtnGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobtnGender.SelectedIndex == 0)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            fname = txtFName.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            phone = txtPhoneNumber.Text;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            age = int.Parse(txtAge.Text);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            passconfirm = txtConfirmPassword.Text;

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblWrongConfirmPassword.ForeColor = Color.Green;
                lblWrongConfirmPassword.Text = "Valid Confirm Password";
            }

            else
            {
                lblWrongConfirmPassword.ForeColor = Color.Red;
                lblWrongConfirmPassword.Text = "Wrong Confirm Password";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            lname = txtLName.Text;
        }

        private void txtNationalID_TextChanged(object sender, EventArgs e)
        {
            NID = long.Parse(txtNationalID.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpValidation signupV = new SignUpValidation();
            signupV.PatientNationalID = txtNationalID.Text;
            signupV.PatientFirstName = txtFName.Text;
            signupV.PatientLastName = txtLName.Text;
            signupV.PatientEmail = txtEmail.Text;
            signupV.PatientPassword = txtPassword.Text;
            signupV.PatientConfirmPassword = txtConfirmPassword.Text;
            signupV.PatientPhone = txtPhoneNumber.Text;
            signupV.PatientAge = txtAge.Text;

            // Patient Validation
            ValidationContext validationContext = new ValidationContext(signupV);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(signupV, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "PatientNationalID":
                            lblNationalIDError.Text = item.ErrorMessage;
                            break;

                        case "PatientFirstName":
                            lblFNameError.Text = item.ErrorMessage;
                            break;

                        case "PatientLastName":
                            lblLNameError.Text = item.ErrorMessage;
                            break;

                        case "PatientPhone":
                            lblPhoneError.Text = item.ErrorMessage;
                            break;

                        case "PatientEmail":
                            lblEmailError.Text = item.ErrorMessage;
                            break;

                        case "PatientPassword":
                            lblPasswordError.Text = item.ErrorMessage;
                            break;

                        case "PatientConfirmPassword":
                            lblConfirmPasswordError.Text = item.ErrorMessage;
                            break;

                        case "PatientAge":
                            lblAgeError.Text = item.ErrorMessage;
                            break;

                        default:
                            MessageBox.Show(item.ErrorMessage);
                            break;
                    }
                }
            }


            else
            {
                con.Open();
                if (role == "Doctor" || role == "Secretary")
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Staff (fname, lname, role, contact, sex, staff_age, email, password) values (@fname, @lname, @role, @contact, @sex, @staff_age, @email, @password);", con);
                    cmd2.Parameters.Add("@fname", fname);
                    cmd2.Parameters.Add("@lname", lname);
                    cmd2.Parameters.Add("@role", role);
                    cmd2.Parameters.Add("@contact", phone);
                    cmd2.Parameters.Add("@sex", gender);
                    cmd2.Parameters.Add("@staff_age", age);
                    cmd2.Parameters.Add("@email", email);
                    cmd2.Parameters.Add("@password", password);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO patient(NID, patient_fname, patient_lname, phoneNumber, age, Gender) values(@NID, @patient_fname, @patient_lname, @phoneNumber, @age, @Gender);", con);
                    cmd3.Parameters.Add("@NID", NID);
                    cmd3.Parameters.Add("@patient_fname", fname);
                    cmd3.Parameters.Add("@patient_lname", lname);
                    cmd3.Parameters.Add("@phoneNumber", phone);
                    cmd3.Parameters.Add("@age", age);
                    cmd3.Parameters.Add("@Gender", gender);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Data Saved Successfully");
            }
        }

        int age;
        long NID;
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
        }
    }
}
