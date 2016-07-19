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

namespace HospitalManagementSystem
{
    public partial class frmPescribed : Form
    {
        Models.HospitalDBEntities entities = new Models.HospitalDBEntities();
        IHospitalRepository _db = null;

        private int _id = 0;
        private int _total = 0;

        public frmPescribed(HospitalRepository context)
        {
            _db = context;
            InitializeComponent();
            DisplayData();
            txtTotalCost.ReadOnly = true;
        }
        public frmPescribed() : this(new HospitalRepository()) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbDrug.SelectedValue.ToString())||string.IsNullOrEmpty(cmbPatinet.SelectedValue.ToString())||string.IsNullOrEmpty(cmbPatinet.SelectedValue.ToString()))
            {
                MessageBox.Show("WARNING ! You Must Select Doctors, Patients and Drug Name, If Aany of them not created Please Created Tham First !");
                return;
            }

           var prescribe= entities.Prescribes.Add(new Models.Prescribe()
            {
                DrugId = Convert.ToInt32(cmbDrug.SelectedValue),
                PatientId = Convert.ToInt32(cmbPatinet.SelectedValue),
                DoctorId = Convert.ToInt32(cmbDoctor.SelectedValue),
                UnitCost = Convert.ToInt32(txtUnitCost.Text),
                TotalCost = Convert.ToInt32(txtTotalCost.Text),
                Quantity = Convert.ToInt32(txtQuantity.Text),
                PrescribedTime = Convert.ToDateTime(dateTimePicker1.Text)
            });

            _db.AddNewPrescribe(prescribe);
            
            DisplayData();
            MessageBox.Show("Successfully Created !");
            Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AutoCalulateTotal();
        }

        public void AutoCalulateTotal()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text) == false)
                    {
                        _total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtUnitCost.Text);
                    }
                }
            }
            txtTotalCost.Text = _total.ToString();
        }


        private void DisplayData()
        {
            var result = _db.GetAllPrescribe();
            dataGridView1.DataSource = result.ToList();

            var doctors = _db.GetAllDoctors().ToList();
            var patients = _db.GetAllPatient().ToList();
            var drugs = _db.GetAllDrugs().ToList();

            // Binding Doctors to Combo Box
            cmbDoctor.DataSource = doctors;
            cmbDoctor.DisplayMember = "FirstName";
            cmbDoctor.ValueMember = "DoctorID";// Set Column Name of DataTable to set as Value Field


            // Binding Patiens to combo Box
            cmbPatinet.DataSource = patients;
            cmbPatinet.DisplayMember = "FirstName";
            cmbPatinet.ValueMember = "PatientId";// Set Column Name of DataTable to set as Value Field


            // Binding Drug to combo Box
            cmbDrug.DataSource = drugs;
            cmbDrug.DisplayMember = "DrugName";
            cmbDrug.ValueMember = "DrugId";// Set Column Name of DataTable to set as Value Field
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Models.Prescribe p = entities.Prescribes.SingleOrDefault(dr => dr.PrescribedId == _id);
            if (p != null)
            {
                p.DrugId = Convert.ToInt32(cmbDrug.SelectedValue);
                p.PatientId = Convert.ToInt32(cmbPatinet.SelectedValue);
                p.DoctorId = Convert.ToInt32(cmbDoctor.SelectedValue);
                p.UnitCost = Convert.ToInt32(txtUnitCost.Text);
                p.TotalCost = Convert.ToInt32(txtTotalCost.Text);
                p.Quantity = Convert.ToInt32(txtQuantity.Text);
                p.PrescribedTime = Convert.ToDateTime(dateTimePicker1.Text);                
            }
            _db.UpdatePrescribe(p);
            DisplayData();

            MessageBox.Show("Successfully Updated !");
            Clear();          

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbDrug.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbPatinet.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbDoctor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUnitCost.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTotalCost.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Models.Prescribe p = entities.Prescribes.SingleOrDefault(dr => dr.PrescribedId == _id);
            if (p != null)
            {
                _db.DeletePrescribe(p);                
                DisplayData();
                MessageBox.Show("Successfully Removed  !");
                Clear();
            }
            else
            {
                throw new ApplicationException("Can not find the Prescription !");
            }
            DisplayData();
        }
        public void Clear()
        {
            txtUnitCost.Text = "";
            txtQuantity.Text = "";
            txtTotalCost.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
