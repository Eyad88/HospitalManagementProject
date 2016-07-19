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
    public partial class frmDrug : Form
    {
        private int _id = 0;
        Models.HospitalDBEntities entities = new Models.HospitalDBEntities();
        IHospitalRepository _db = null;

        public frmDrug(HospitalRepository context)
        {
            _db = context;
            InitializeComponent();
            DisplayData();
        }
        public frmDrug(): this(new HospitalRepository()) { }

        private void button1_Click(object sender, EventArgs e)
        {
            int distance;
            bool isInt = int.TryParse(txtMaxDose.Text, out distance);
            if (!isInt)
            {
                MessageBox.Show("WARNING ! Maximum Dose Must be an Integer");
                return;
            }
            isInt = int.TryParse(txtMinDose.Text, out distance);
            if (!isInt)
            {
                MessageBox.Show("WARNING ! Minimum Dose Must be an Integer");
                return;
            }

            if (String.IsNullOrEmpty(txtDrugName.Text))
            {
                MessageBox.Show("Please Enter Drug Name !");
                return;
            }
           var drugs= entities.Drugs.Add(new Models.Drug()
            {
                DrugName = txtDrugName.Text,
                Minimum_Dose = txtMinDose.Text,
                Maximum_Dose = txtMaxDose.Text

            });
            _db.AddNewDrug(drugs);
            DisplayData();
            Clear();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDrugName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaxDose.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMinDose.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void DisplayData()
        {
            var result = _db.GetAllDrugs().ToList();
            dataGridView1.DataSource = result.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int distance;
            bool isInt = int.TryParse(txtMaxDose.Text, out distance);
            if (!isInt)
            {
                MessageBox.Show("WARNING ! Maximum Dose Must be an Integer");
                return;
            }
            isInt = int.TryParse(txtMinDose.Text, out distance);
            if (!isInt)
            {
                MessageBox.Show("WARNING ! Minimum Dose Must be an Integer");
                return;
            }

            if (String.IsNullOrEmpty(txtDrugName.Text))
            {
                MessageBox.Show("Please Enter Drug Name !");
                return;
            }
            if (_id < 0)
            {
                MessageBox.Show("Please select an item to be Updated !");
                return;
            }

            Models.Drug p = entities.Drugs.SingleOrDefault(dr => dr.DrugId == _id);
            if (p != null)
            {
                p.DrugId = _id;
                p.DrugName = txtDrugName.Text;
                p.Maximum_Dose = txtMaxDose.Text;
                p.Minimum_Dose = txtMinDose.Text;                
            }
            _db.UpdateDrug(p);
            DisplayData();

            MessageBox.Show("Successfully Updated !");
            Clear();

            DisplayData();
        }

        public void Clear()
        {
            txtDrugName.Text = "";
            txtMaxDose.Text = "";
            txtMinDose.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_id < 0)
            {
                MessageBox.Show("Please select an item to be deleted !");
                return;
            }

            Models.Drug p = entities.Drugs.SingleOrDefault(dr => dr.DrugId == _id);
            if (p != null)
            {
                _db.DeleteDrug(p);                
                DisplayData();

                MessageBox.Show("Successfully Removed  !");
                Clear();
            }
            else
            {
                throw new ApplicationException("Can not find the Doctor");
            }
            DisplayData();

        }
    }
}
