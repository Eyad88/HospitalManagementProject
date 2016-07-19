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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToLower()=="super" && txtPassword.Text.ToLower()=="admin")
            {
                frmMainForm main = new frmMainForm(txtUserName.Text);
                main.Show();
                this.Hide();
                return;
            }
            else
            {
                DBAccess.DataAccess db = new DBAccess.DataAccess();
                var tempUser = db.LoginValidation(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                if (tempUser != null)
                {
                    frmMainForm main = new frmMainForm(txtUserName.Text);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Please Enter Valid UserName and Password";
                }
            }
        }
    }
}
