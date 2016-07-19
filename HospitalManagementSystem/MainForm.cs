using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class frmMainForm : Form
    {
        public frmMainForm(string userName)
        {
            InitializeComponent();
            lblUserName.Text = userName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewUser user = new frmNewUser();
            user.ShowDialog();
        }

        private void btnPat_Click(object sender, EventArgs e)
        {
            frmPatient pat = new frmPatient();
            pat.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor doc = new frmDoctor();
            doc.ShowDialog();
        }

        private void btnDrug_Click(object sender, EventArgs e)
        {
            frmDrug drg = new frmDrug();
            drg.ShowDialog();
        }

        private void btnPrescribe_Click(object sender, EventArgs e)
        {
            frmPescribed pes = new frmPescribed();
            pes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, Help File is in Under Construction !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreatmentRecord record = new TreatmentRecord();
            record.ShowDialog();
        }
    }
}
