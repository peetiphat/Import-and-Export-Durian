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
    public partial class frmAdminbooking : Form
    {
        public frmAdminbooking()
        {
            InitializeComponent();
        }

        fmsalontestEntities db = new fmsalontestEntities();
        private void frmAdminbooking_Load(object sender, EventArgs e)
        {
            
            loadBooking();
            loadComboEmployee();
            ResetAll();
            
        }

        private void loadBooking()
        {
            var bk = from u in db.User join b in db.Booking on u.userID equals b.userID 
                     join ep in db.Employee on b.employee_no equals ep.employee_no
                     select new
                     {
                         reserve_no = b.reserve_no,
                         userFname = u.userFname,
                         userLname = u.userLname,
                         reserveDate = b.reserveDate,
                         reserveTime = b.reserveTime,
                         totalPrice = b.totalPrice,
                         employee_no = ep.employee_no

                     };
            if(bk.Count() > 0)
            {
                dgvBooking.DataSource = bk.ToList();
                FormatDGV();
            }
        }
        private void FormatDGV()
        {
            if (dgvBooking.RowCount > 0)
            {
                dgvBooking.Columns[0].HeaderText = "Bk code";
                dgvBooking.Columns[1].HeaderText = "Name";
                dgvBooking.Columns[2].HeaderText = "Lastname";
                dgvBooking.Columns[3].HeaderText = "Date";
                dgvBooking.Columns[4].HeaderText = "Time";
                dgvBooking.Columns[5].HeaderText = "Total";
                dgvBooking.Columns[6].HeaderText = "Emp code";

            }
        }

        
        private void loadComboEmployee()
        {
            
            cmbEmployeeno.DataSource = db.Employee.ToList();
            cmbEmployeeno.DisplayMember = "employee_no";
            cmbEmployeeno.ValueMember = "employee_no";
        }

        private void cmbEmployeeno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Employee obj = cmbEmployeeno.SelectedItem as Employee;
            if (obj != null)
            {
                txtEmployeename.Text = obj.employeeFname + "  " + obj.employeeLname;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtReserveno.Text != "")
            {
                int bkid = Convert.ToInt32(txtReserveno.Text.Trim());
                var bk = (from b in db.Booking where b.reserve_no == bkid select b).FirstOrDefault();
                if (bk != null)
                {
                    bk.reserveDate = dtime.Value;
                    bk.reserveTime = cmbTime.Text.Trim();
                    bk.totalPrice = Convert.ToDecimal(txtTotalprice.Text.Trim());
                    bk.employee_no = Convert.ToInt32(cmbEmployeeno.SelectedValue);

                }
                using (var tr = db.Database.BeginTransaction())
                {
                    db.SaveChanges();
                    tr.Commit();
                    MessageBox.Show("Record succeeded", "notification");
                    ResetAll();
                    loadBooking();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete data?", "notification", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int bkvid = Convert.ToInt32(txtReserveno.Text.Trim());
                var bk = (from b in db.Booking where b.reserve_no == bkvid select b).FirstOrDefault();
                if (bk != null)
                {
                    db.Booking.Remove(bk);
                    db.SaveChanges();
                    MessageBox.Show("Successfully deleted data", "notification");
                    ResetAll();
                    loadBooking();
                }
            }
        }



        private void ResetAll()
        {
            cmbTime.SelectedIndex = -1;
            cmbEmployeeno.SelectedIndex = -1;
            txtReserveno.Text = "";
            txtTotalprice.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtEmployeename.Text = "";
            dtime.Value = DateTime.Now;
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex == -1)
             {
                    return;
             }
             txtReserveno.Text = dgvBooking.Rows[e.RowIndex].Cells["reserve_no"].Value.ToString();
             txtTotalprice.Text = dgvBooking.Rows[e.RowIndex].Cells["totalPrice"].Value.ToString();
             txtFname.Text = dgvBooking.Rows[e.RowIndex].Cells["userFname"].Value.ToString();
             txtLname.Text = dgvBooking.Rows[e.RowIndex].Cells["userLname"].Value.ToString();
             dtime.Text = dgvBooking.Rows[e.RowIndex].Cells["reserveDate"].Value.ToString();
             cmbTime.Text = dgvBooking.Rows[e.RowIndex].Cells["reserveTime"].Value.ToString();
             cmbEmployeeno.Text = dgvBooking.Rows[e.RowIndex].Cells["employee_no"].Value.ToString();

            Employee obj = cmbEmployeeno.SelectedItem as Employee;
            if (obj != null)
            {
                txtEmployeename.Text = obj.employeeFname + "  " + obj.employeeLname;
            }


        }
    }
}
