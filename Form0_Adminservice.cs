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
    public partial class frmAdminservice : Form
    {
        public frmAdminservice()
        {
            InitializeComponent();
        }
        fmsalontestEntities db = new fmsalontestEntities();
        private void Form0_Adminservice_Load(object sender, EventArgs e)
        {
            loadService();
            loadComboCategory();
            ResetAll();
        }

        private void loadService()
        {
            var sv = from s in db.Service join c in db.Category on s.category_no equals c.category_no
                     select new
                     {
                         serviceid = s.serviceid,
                         serviceName = s.serviceName,
                         servicePrice = s.servicePrice,
                         category_no = s.category_no,
                         categotyName = c.categotyName
                        
                     };
            if(sv.Count() > 0)
            {
                dgvService.DataSource = sv.ToList();
                FormatDGV();
            }
        }

        private void FormatDGV()
        {
            if (dgvService.RowCount > 0)
            {
                dgvService.Columns[0].HeaderText = "Ser code";
                dgvService.Columns[1].HeaderText = "Service";
                dgvService.Columns[2].HeaderText = "Price";
                dgvService.Columns[3].HeaderText = "Cate code";
                dgvService.Columns[4].HeaderText = "Category";

            }
        }

        private void loadComboCategory()
        {
            cmbCategory.DataSource = db.Category.ToList();
            cmbCategory.DisplayMember = "category_no";
            cmbCategory.ValueMember = "category_no";
        }
        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category obj = cmbCategory.SelectedItem as Category;
            if (obj != null)
            {
                txtCategoryname.Text = obj.categotyName;

            }
        }

        private void ResetAll()
        {
            cmbCategory.SelectedIndex = -1;
            txtServicename.Text = "";
            txtServiceprice.Text = "";
            txtCategoryname.Text = "";
            txtServiceid.Text = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServicename.Text != "" && txtServiceprice.Text != "")
                {
                    var sv = new Service
                    {
                        serviceName = txtServicename.Text.Trim(),
                        servicePrice = Convert.ToDecimal(txtServiceprice.Text.Trim()),
                        category_no = Convert.ToString(cmbCategory.SelectedValue)

                    };

                    db.Service.Add(sv);
                    db.SaveChanges();
                    MessageBox.Show("Record succeeded", "notification");
                    ResetAll();
                    loadService();
                    txtServicename.Focus();
                }
                else
                {
                    MessageBox.Show("Incomplete data", "notification");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtServiceid.Text != "")
            {
                int svid = Convert.ToInt32(txtServiceid.Text.Trim());
                var sv = (from s in db.Service where s.serviceid == svid select s).FirstOrDefault();
                if(sv != null)
                {
                    sv.serviceName = txtServicename.Text.Trim();
                    sv.servicePrice = Convert.ToDecimal(txtServiceprice.Text.Trim());
                    sv.category_no = Convert.ToString(cmbCategory.SelectedValue);
                }
                using(var tr = db.Database.BeginTransaction())
                {
                    db.SaveChanges();
                    tr.Commit();
                    MessageBox.Show("Edit succeeded", "notification");
                    ResetAll();
                    loadService();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete data?", "notification", MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
            {
                int srvid = Convert.ToInt32(txtServiceid.Text.Trim());
                var sv = (from s in db.Service where s.serviceid == srvid select s).FirstOrDefault();
                if(sv != null)
                {
                    db.Service.Remove(sv);
                    db.SaveChanges();
                    MessageBox.Show("Successfully deleted data", "notification");
                    ResetAll();
                    loadService();
                }
            }
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtServiceid.Text = dgvService.Rows[e.RowIndex].Cells["serviceid"].Value.ToString();
            txtServicename.Text = dgvService.Rows[e.RowIndex].Cells["serviceName"].Value.ToString();
            txtServiceprice.Text = dgvService.Rows[e.RowIndex].Cells["servicePrice"].Value.ToString();
            cmbCategory.Text = dgvService.Rows[e.RowIndex].Cells["category_no"].Value.ToString();
            txtCategoryname.Text = dgvService.Rows[e.RowIndex].Cells["categotyName"].Value.ToString();
        }
    }
}
