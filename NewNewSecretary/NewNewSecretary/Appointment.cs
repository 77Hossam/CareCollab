using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewNewSecretary
{
    public partial class Appointment : Form
    {
        Form1 f = new Form1();

        public Appointment(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            AddAppointment f = new AddAppointment();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
