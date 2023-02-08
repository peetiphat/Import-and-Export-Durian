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
    public partial class frmBooking : Form
    {
        public frmBooking()
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

        

        private void btnComfirm_Click(object sender, EventArgs e)
        {

            if (cmbTime.Text != "" && cmbEmployee.Text != "")
                {
                var bk = new Booking
                {
                    reserveDate = dtime.Value,
                    reserveTime = cmbTime.Text,
                    totalPrice = Convert.ToDecimal(txtTotalprice.Text),
                    employee_no = Convert.ToInt32(cmbEmployee.SelectedValue),
                    userID = userID

                    };

                    db.Booking.Add(bk);
                    db.SaveChanges();
                


                    MessageBox.Show("Booking succeeded", "notification");
                    ResetAll();
                    txtTotalprice.Text = "";
                    cmbCategory.SelectedIndex = -1;
                    cmbTime.SelectedIndex = -1;
                    cmbEmployee.SelectedIndex = -1;
                    dtime.Value = DateTime.Now;
                    dgvShow.Rows.Clear();
                    dgvShow.Refresh();

                frmCheck fc = new frmCheck();
                fc.userID = userID;
                fc.Show();
                this.Hide();

            }
                else
                {
                    MessageBox.Show("Incomplete data", "notification");
                }
   
        }

        private void frmBookimg_Load(object sender, EventArgs e)
        {
            dtime.Value = DateTime.Now;
           
            //load Combobox 
            loadComboCategory();
            loadComboEmployee();
            ResetAll(); 
            cmbCategory.SelectedIndex = -1;
            cmbEmployee.SelectedIndex = -1;

        }
        private void loadComboEmployee()
        {
            cmbEmployee.DataSource = db.Employee.ToList();
            cmbEmployee.DisplayMember = "employeeFname";
            cmbEmployee.ValueMember = "employee_no";
        }

        private void loadComboCategory()
        {
             cmbCategory.DataSource = db.Category.ToList();
             cmbCategory.DisplayMember = "categotyName";
             cmbCategory.ValueMember = "category_no";
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                cmbService.SelectedIndex = -1;
                string idCat = Convert.ToString(cmbCategory.SelectedValue);
                var servicelist = (from sv in db.Service
                                   where sv.category_no == idCat
                                   select sv).ToList(); 
                 cmbService.DisplayMember = "serviceName";
                cmbService.ValueMember = "Id";
                cmbService.DataSource = servicelist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Work results");
            }
        }

        private void cmbService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Service obj = cmbService.SelectedItem as Service;
            if (obj != null)
              {
                 txtSerPrice.Text = Convert.ToString(obj.servicePrice);
              }
        }




        int n = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {

            DataGridViewRow addrow = new DataGridViewRow();
            addrow.CreateCells(dgvShow);
            addrow.Cells[0].Value = ++n;
            addrow.Cells[1].Value = cmbService.Text;
            addrow.Cells[2].Value = txtSerPrice.Text;

            dgvShow.Rows.Add(addrow);

            cmbCategory.SelectedIndex = -1;
            ResetAll();
            CalPay();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvShow.CurrentCell.RowIndex;
            dgvShow.Rows.RemoveAt(rowIndex);

            CalPay();
        }

        private void CalPay()
        {
            decimal sumpay = 0;
            for (int i = 0; i < dgvShow.Rows.Count; i++)
            {
                sumpay += Convert.ToDecimal(dgvShow.Rows[i].Cells[2].Value);
            }
            txtTotalprice.Text = sumpay.ToString("###,###");
        }

        private void ResetAll()
        {
            //cmbCategory.SelectedIndex = -1;
            cmbService.SelectedIndex = -1;
            txtSerPrice.Text = "";
            
        }
    }
}
