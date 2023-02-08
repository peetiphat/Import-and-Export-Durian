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
    public partial class frmAdminemployee : Form
    {
        public frmAdminemployee()
        {
            InitializeComponent();
        }
        fmsalontestEntities db = new fmsalontestEntities();
        private void frmAdminemployee_Load(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void loadEmployee()
        {
            var em = from e in db.Employee
                     select new
                     {
                         employee_no = e.employee_no,
                         employeeFname = e.employeeFname,
                         employeeLname = e.employeeLname,
                         employeeAddress = e.employeeAddress,
                         employeePhone = e.employeePhone

                     };
            if (em.Count() > 0)
            {
                dgvEmployee.DataSource = em.ToList();
                FormatDGV();
            }
        }
        private void FormatDGV()
        {
            if (dgvEmployee.RowCount > 0)
            {
                dgvEmployee.Columns[0].HeaderText = "Emp code";
                dgvEmployee.Columns[1].HeaderText = "Name";
                dgvEmployee.Columns[2].HeaderText = "Lastanme";
                dgvEmployee.Columns[3].HeaderText = "Address";
                dgvEmployee.Columns[4].HeaderText = "Telephone";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFname.Text != "" && txtLname.Text !=  "" && txtAdress.Text != "" && txtPhone.Text != "")
            {
                var em = new Employee
                {
                    employeeFname = txtFname.Text.Trim(),
                    employeeLname = txtLname.Text.Trim(),
                    employeeAddress = txtAdress.Text.Trim(),
                    employeePhone = txtPhone.Text.Trim(),
                };

                db.Employee.Add(em);
                db.SaveChanges();
                MessageBox.Show("Record succeeded", "notification");
                ResetAll();
                loadEmployee();
                txtFname.Focus();

            }
            else
            {
                MessageBox.Show("Incomplete data", "notification");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEmployeeno.Text != "")
            {
                int emid = Convert.ToInt32(txtEmployeeno.Text.Trim());
                var em = (from emp in db.Employee where emp.employee_no == emid select emp).FirstOrDefault();
                if (em != null)
                {
                    em.employeeFname = txtFname.Text.Trim();
                    em.employeeLname = txtLname.Text.Trim();
                    em.employeeAddress = txtAdress.Text.Trim();
                    em.employeePhone = txtPhone.Text.Trim();
                }
                using (var tr = db.Database.BeginTransaction())
                {
                    db.SaveChanges();
                    tr.Commit();
                    MessageBox.Show("Edit succeeded", "notification");
                    ResetAll();
                    loadEmployee();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete data?", "notification", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int empid = Convert.ToInt32(txtEmployeeno.Text.Trim());
                var em = (from emp in db.Employee where emp.employee_no == empid select emp).FirstOrDefault();
                if (em != null)
                {
                    db.Employee.Remove(em);
                    db.SaveChanges();
                    MessageBox.Show("Successfully deleted data", "notification");
                    ResetAll();
                    loadEmployee();
                }
            }
        }

        private void ResetAll()
        {
            txtEmployeeno.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtAdress.Text = "";
            txtPhone.Text = "";
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtEmployeeno.Text = dgvEmployee.Rows[e.RowIndex].Cells["employee_no"].Value.ToString();
            txtFname.Text = dgvEmployee.Rows[e.RowIndex].Cells["employeeFname"].Value.ToString();
            txtLname.Text = dgvEmployee.Rows[e.RowIndex].Cells["employeeLname"].Value.ToString();
            txtAdress.Text = dgvEmployee.Rows[e.RowIndex].Cells["employeeAddress"].Value.ToString();
            txtPhone.Text = dgvEmployee.Rows[e.RowIndex].Cells["employeePhone"].Value.ToString();
        }
    }
}
