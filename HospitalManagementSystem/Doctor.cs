using HospitalManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.Repositories;

namespace HospitalManagementSystem
{
    public partial class frmDoctor : Form
    {
        private int _id = 0;
        Models.HospitalDBEntities entities = new Models.HospitalDBEntities();
        IHospitalRepository _db = null;

        public frmDoctor(HospitalRepository context)
        {
            _db = context;
            InitializeComponent();
            DisplayData();
        }
        public frmDoctor() : this(new HospitalRepository()) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter Doctors First Name !");
                return;
            }
           var doctor = entities.Doctors.Add(new Models.Doctor()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Speciallity = txtSpecial.Text,
                PhoneNo = txtPhoneNo.Text,
                EmailAddress = txtEmailAddress.Text
            });

            _db.AddNewDoctor(doctor);
            DisplayData();
            Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter Doctors First Name !");
                return;
            }

            Models.Doctor p = entities.Doctors.SingleOrDefault(dr => dr.DoctorID == _id);
            if (p != null)
            {
                p.DoctorID = _id;
                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;
                p.PhoneNo = txtPhoneNo.Text;
                p.EmailAddress = txtEmailAddress.Text;
                p.Speciallity = txtSpecial.Text;
                
            }
            _db.UpdateDoctor(p);
            DisplayData();

            MessageBox.Show("Successfully Updated !");
            Clear();

            DisplayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Models.Doctor p = entities.Doctors.SingleOrDefault(dr => dr.DoctorID == _id);
            if (_id == 0)
            {
                MessageBox.Show("Please select an item do be deleted !");
            }
            
            if (p != null)
            {
                _db.DeleteDoctor(p);
                DisplayData();
                MessageBox.Show("Successfully Removed  !");
                Clear();
            }
            else
            {
                throw new ApplicationException("Can not find the Patinent !");
            }
            DisplayData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSpecial.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmailAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        private void DisplayData()
        {
            var result = _db.GetAllDoctors();
            dataGridView1.DataSource = result.ToList();
        }

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSpecial.Text = "";
            txtPhoneNo.Text = "";
            txtEmailAddress.Text = "";
        }


    }
}
