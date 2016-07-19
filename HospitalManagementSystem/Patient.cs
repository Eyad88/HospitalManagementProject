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
    public partial class frmPatient : Form
    {
        private int _id = 0;
        Models.HospitalDBEntities entities = new Models.HospitalDBEntities();
        IHospitalRepository _db = null;

        public frmPatient(HospitalRepository context)
        {
            _db = context;
            InitializeComponent();
            DisplayData();
        }
        public frmPatient() : this(new HospitalRepository()) { }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter First Name !");
                return;
            }
            if (String.IsNullOrEmpty(dateTimePicker1.Value.ToShortDateString()))
            {
                MessageBox.Show("Please Enter Date of Birth  !");
                return;
            }
            var patinets = entities.Patients.Add(new Models.Patient()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = txtGender.Text,
                DateOfBirth = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()),
                PhoneNo = txtPhoneNo.Text,
                EmailAddress = txtEmailAddress.Text,
                HouseNo = txtHouseNo.Text,
                AddressLine1 = txtAddress1.Text,
                AddressLine2 = txtAddress2.Text,
                City = txtCity.Text,
                Country = txtContry.Text,
                PostCode = txtPostcode.Text,
                NINumber = txtNiNO.Text,
                MaritalStatusStr = cmbStatus.SelectedText,
                DescriptionOfHealth = txtDesc.Text
            });

            _db.AddNewPatient(patinets);
            
            MessageBox.Show("Successfully Created !");
            Clear();
            DisplayData();
        }
        private void DisplayData()
        {
            var result = _db.GetAllPatient();
            dataGridView1.DataSource = result.ToList();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGender.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPhoneNo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmailAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtHouseNo.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtAddress1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtAddress2.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtContry.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtPostcode.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtNiNO.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            cmbStatus.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtGender.Text = "";
            dateTimePicker1.Text = "";
            txtPhoneNo.Text = "";
            txtEmailAddress.Text = "";
            txtHouseNo.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtContry.Text = "";
            txtPostcode.Text = "";
            txtNiNO.Text = "";
            txtDesc.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter First Name !");
                return;
            }
            if (String.IsNullOrEmpty(dateTimePicker1.Value.ToShortDateString()))
            {
                MessageBox.Show("Please Enter Date of Birth  !");
                return;
            }

            Models.Patient p = entities.Patients.SingleOrDefault(dr => dr.PatientId == _id);
            if (p != null)
            {
                p.PatientId = _id;
                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;
                p.Gender = txtGender.Text;
                p.DateOfBirth = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                p.PhoneNo = txtPhoneNo.Text;
                p.EmailAddress = txtEmailAddress.Text;
                p.HouseNo = txtHouseNo.Text;
                p.AddressLine1 = txtAddress1.Text;
                p.AddressLine2 = txtAddress2.Text;
                p.City = txtCity.Text;
                p.Country = txtContry.Text;
                p.PostCode = txtPostcode.Text;
                p.NINumber = txtNiNO.Text;
                p.MaritalStatusStr = cmbStatus.SelectedText;
                p.DescriptionOfHealth = txtDesc.Text;                
            }

            // Call Repository to Update Patient
            _db.UpdatePatient(p);

            DisplayData();

            MessageBox.Show("Successfully Updated !");
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Please select an item do be deleted !");
            }
            Models.Patient p = entities.Patients.SingleOrDefault(dr => dr.PatientId == _id);

            if (p != null)
            {
                _db.DeletePatient(p);
                DisplayData();
                MessageBox.Show("Successfully Removed  !");
                Clear();
            }
            else
            {
                throw new ApplicationException("Can not find the Patinent !");
            }

        }
    }
}
