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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        fmsalontestEntities db = new fmsalontestEntities();

        public int userID;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                var rec = db.User.Where(us => us.Username == username && us.Password == password).FirstOrDefault();

                if(rec != null)
                {
                    Hide();
                    if(rec.Role == "Admin")
                    {
                        
                        frmMainadmin fma = new frmMainadmin();
                        fma.Show();
                    }
                    else
                    {
                        
                        frmMain fm = new frmMain();
                        userID = rec.userID;
                        fm.userID = userID;
                        fm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Login failed", "Work results");
                    txtUsername.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Work results");
            }
        }

        private void btrRegister_Click(object sender, EventArgs e)
        {
            frmRegister freg = new frmRegister();
            freg.Show();
            this.Hide();
        }
    }
}
