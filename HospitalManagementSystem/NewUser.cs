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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) ||string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter UserName and Password !");
                return;
            }
            Models.HospitalDBEntities db = new Models.HospitalDBEntities();
            db.Logins.Add(new Models.Login() {
                UserName=txtUserName.Text,
                Password=txtPassword.Text,
                EmailAddress=txtEmail.Text
            });
            db.SaveChanges();

            MessageBox.Show("Successfully Created !");
            this.Close();
        }
    }
}
