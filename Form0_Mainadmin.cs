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
    public partial class frmMainadmin : Form
    {
        public frmMainadmin()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmAdminbooking fa = new frmAdminbooking();
            fa.TopLevel = false;
            panel1.Controls.Add(fa);
            fa.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Hide();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmAdminservice fs = new frmAdminservice();
            fs.TopLevel = false;
            panel1.Controls.Add(fs);
            fs.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmAdminemployee fe = new frmAdminemployee();
            fe.TopLevel = false;
            panel1.Controls.Add(fe);
            fe.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmAdminhome fh = new frmAdminhome();
            fh.TopLevel = false;
            panel1.Controls.Add(fh);
            fh.Show();
        }

        private void frmMainadmin_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmAdminhome fh = new frmAdminhome();
            fh.TopLevel = false;
            panel1.Controls.Add(fh);
            fh.Show();
        }
    }
}
