using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class TreatmentRecord : Form
    {
        
        public TreatmentRecord()
        {
            InitializeComponent();
            DisplayData();
        }
        
        private void txtSearchString_TxtChange(object sender, EventArgs e)
        {
            string searchString = txtSearchString.Text.ToLower();
            if (!Regex.IsMatch(searchString, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Only Chartecters ! ");
            }
            Models.HospitalDBEntities db = new Models.HospitalDBEntities();

            var query = from p in db.Patients.Where(x => x.FirstName.ToLower().Contains(searchString))
                        join pr in db.Prescribes on p.PatientId equals pr.PatientId
                        select new { p.FirstName, p.LastName, p.PostCode, pr.PrescribedTime, pr.Quantity, pr.Doctor };
          
            dataGridView1.DataSource = query.ToList();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            Models.HospitalDBEntities db = new Models.HospitalDBEntities();

            var query = from p in db.Patients
                        join pr in db.Prescribes on p.PatientId equals pr.PatientId
                        select new { p.FirstName, p.LastName, p.PostCode, pr.PrescribedTime, pr.Quantity, pr.Doctor };

            dataGridView1.DataSource = query.ToList();
            dataGridView1.DataSource = query.ToList();
        }
    }
}
