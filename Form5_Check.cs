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
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }


        fmsalontestEntities db = new fmsalontestEntities();

        public int userID;

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain fM = new frmMain();
            fM.Show();
            this.Hide();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            showName();
            loadChkbooking();
           

        }
        public void showName()
        {
            var userinfo = (from u in db.User where u.userID == userID select u).FirstOrDefault();
            if (userinfo != null)
            {
                txtFname.Text = userinfo.userFname;
                txtLname.Text = userinfo.userLname;
                txtPhone.Text = userinfo.userTel;
            }
           
        }

        private void loadChkbooking()
        {
            var bk = from b in db.Booking join ep in db.Employee on b.employee_no equals ep.employee_no where b.userID == userID
                     select new
                     {
                         reserve_no = b.reserve_no,
                         reserveDate = b.reserveDate,
                         reserveTime = b.reserveTime,
                         totalPrice = b.totalPrice,
                         employeeFname = ep.employeeFname,
                         

                     };
            if (bk.Count() > 0)
            {
                dgvShowcheck.DataSource = bk.ToList();
                FormatDGV();
            }
        }

        private void FormatDGV()
        {
            if (dgvShowcheck.RowCount > 0)
            {
                dgvShowcheck.Columns[0].HeaderText = "Bk code";
                dgvShowcheck.Columns[1].HeaderText = "Date";
                dgvShowcheck.Columns[2].HeaderText = "Time";
                dgvShowcheck.Columns[3].HeaderText = "total";
                dgvShowcheck.Columns[4].HeaderText = "Name";


            }
        }
    }
}
