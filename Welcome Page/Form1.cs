using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DrPanel;
using System.Data.SqlClient;

namespace Clinic_System 
{
    public partial class WelcomePg : Form
    {
        SqlConnection con = new SqlConnection();
        public static string username;
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
        public WelcomePg()
        {
            InitializeComponent();
            con.ConnectionString = @"Server=HOSSAM_LAPTOP\SQLEXPRESS,1433;Database=Clinical;User Id='sa';Password='rude';";
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email address")
            {
                Email.Text = "";
                Email.ForeColor = Color.Black;

            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email address";
                Email.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand creditentials = new SqlCommand("SELECT * from Staff where email = @email;", con);
            creditentials.Parameters.Add("@email", Email.Text);
            SqlDataReader account = creditentials.ExecuteReader();
            if(account.Read())
            {
                if (account["password"].ToString() == Password.Text)
                {
                    if (account["role"].ToString() == "Doctor")
                    {
                        this.Hide();
                        account.Close();
                        SqlCommand activity = new SqlCommand("UPDATE Staff set active = 1 where email = @email;",con);
                        activity.Parameters.Add("@email", Email.Text);
                        activity.ExecuteNonQuery();
                        con.Close();
                        DrPanel.DrPanel f1 = new DrPanel.DrPanel();
                        f1.Show();
                    }
                    else if (account["role"].ToString() == "Secretary")
                    {
                        this.Hide();
                        account.Close();
                        SqlCommand activity = new SqlCommand("UPDATE Staff SET active = 2 where email = @email;", con);
                        activity.Parameters.Add("@email", Email.Text);
                        activity.ExecuteNonQuery();
                        con.Close();
                        NewNewSecretary.Form1 f2 = new NewNewSecretary.Form1();
                        f2.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Password is not correct");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Email is not found");
                con.Close();
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            NewSignUp.Form1 Signup = new NewSignUp.Form1();
            Signup.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}