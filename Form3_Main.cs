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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public int userID;
        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }



        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking fB = new frmBooking();
            fB.userID = userID;
            fB.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin fL = new frmLogin();
            fL.Show();
            this.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheck fc = new frmCheck();
            //fc.userID = userID;
            fc.Show();
            this.Hide();
        }
    
    }
}
