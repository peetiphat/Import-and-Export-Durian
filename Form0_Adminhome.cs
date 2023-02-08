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
    public partial class frmAdminhome : Form
    {
        public frmAdminhome()
        {
            InitializeComponent();
        }
        fmsalontestEntities db = new fmsalontestEntities();

        private void Sercha_Click(object sender, EventArgs e)
        {
            
           
        }

        private void frmAdminhome_Load(object sender, EventArgs e)
        {
            var booking = from b in db.Booking select b;
            lblBooking.Text = booking.Count().ToString();

            var customer = from u in db.User where u.Role == "Member" select u;
            lblCustomer.Text = customer.Count().ToString();

            var employee = from ep in db.Employee select ep;
            lblEmployee.Text = employee.Count().ToString();

            var sale = (from b in db.Booking select b.totalPrice).Sum();
            lblSale.Text = sale.ToString();


            loadBooking();

        }

        private void loadBooking()
        {
            var bk = from u in db.User
                     join b in db.Booking on u.userID equals b.userID
                     join ep in db.Employee on b.employee_no equals ep.employee_no
                     orderby b.reserveDate ascending
                     select new
                     {
                         reserve_no = b.reserve_no,
                         userFname = u.userFname,
                         userLname = u.userLname,
                         reserveDate = b.reserveDate,
                         reserveTime = b.reserveTime,
                         totalPrice = b.totalPrice,

                     };
            if (bk.Count() > 0)
            {
                dgvShow.DataSource = bk.ToList();
                FormatDGV();
            }
        }
        private void FormatDGV()
        {
            if (dgvShow.RowCount > 0)
            {
                dgvShow.Columns[0].HeaderText = "Bk code";
                dgvShow.Columns[1].HeaderText = "Name";
                dgvShow.Columns[2].HeaderText = "Lastname";
                dgvShow.Columns[3].HeaderText = "Date";
                dgvShow.Columns[4].HeaderText = "Time";
                dgvShow.Columns[5].HeaderText = "Total";


            }
        }
    }
}
    

