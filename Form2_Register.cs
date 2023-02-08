using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMsalon
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        fmsalontestEntities db = new fmsalontestEntities();
        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User u = new User();
            if(txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                u.userFname = txtFirstname.Text.Trim();
                u.userLname = txtLastname.Text.Trim();
                u.userAddress = txtAddress.Text.Trim();
                u.userTel = txtTelephone.Text.Trim();
                u.Gender = cmbGender.Text.Trim();
                u.Role = cmbRole.Text.Trim();
                u.Username = txtUsername.Text.Trim();
                u.Password = txtPassword.Text.Trim();

                db.User.Add(u);
                db.SaveChanges();
                MessageBox.Show("Successful registration", "Work results");
                Close();
                frmLogin fl = new frmLogin();
                fl.Show();
            }
            else
            {
                MessageBox.Show("Please complete the information", "Work results");
                txtFirstname.Focus();
            }
        }
    }
}
