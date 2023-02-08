
namespace FMsalon
{
    partial class frmAdminbooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbTime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvBooking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTotalprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtReserveno = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbEmployeeno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeename = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTime
            // 
            this.cmbTime.AutoRoundedCorners = true;
            this.cmbTime.BackColor = System.Drawing.Color.Transparent;
            this.cmbTime.BorderRadius = 17;
            this.cmbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTime.ItemHeight = 30;
            this.cmbTime.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.cmbTime.Location = new System.Drawing.Point(385, 118);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(231, 36);
            this.cmbTime.TabIndex = 5;
            // 
            // dgvBooking
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooking.ColumnHeadersHeight = 30;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBooking.Location = new System.Drawing.Point(17, 246);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 30;
            this.dgvBooking.Size = new System.Drawing.Size(908, 287);
            this.dgvBooking.TabIndex = 76;
            this.dgvBooking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBooking.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBooking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBooking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBooking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBooking.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBooking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBooking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBooking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBooking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvBooking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBooking.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvBooking.ThemeStyle.ReadOnly = false;
            this.dgvBooking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBooking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBooking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvBooking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBooking.ThemeStyle.RowsStyle.Height = 30;
            this.dgvBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellContentClick);
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.Animated = true;
            this.txtTotalprice.AutoRoundedCorners = true;
            this.txtTotalprice.BorderRadius = 17;
            this.txtTotalprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalprice.DefaultText = "";
            this.txtTotalprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalprice.Location = new System.Drawing.Point(727, 118);
            this.txtTotalprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.PasswordChar = '\0';
            this.txtTotalprice.PlaceholderText = "";
            this.txtTotalprice.SelectedText = "";
            this.txtTotalprice.Size = new System.Drawing.Size(189, 36);
            this.txtTotalprice.TabIndex = 9;
            // 
            // txtFname
            // 
            this.txtFname.Animated = true;
            this.txtFname.AutoRoundedCorners = true;
            this.txtFname.BorderRadius = 17;
            this.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFname.DefaultText = "";
            this.txtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFname.Location = new System.Drawing.Point(385, 47);
            this.txtFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.PlaceholderText = "";
            this.txtFname.ReadOnly = true;
            this.txtFname.SelectedText = "";
            this.txtFname.Size = new System.Drawing.Size(210, 36);
            this.txtFname.TabIndex = 3;
            // 
            // txtReserveno
            // 
            this.txtReserveno.Animated = true;
            this.txtReserveno.AutoRoundedCorners = true;
            this.txtReserveno.BorderRadius = 17;
            this.txtReserveno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReserveno.DefaultText = "";
            this.txtReserveno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReserveno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReserveno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReserveno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReserveno.FillColor = System.Drawing.Color.LightGray;
            this.txtReserveno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReserveno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReserveno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReserveno.Location = new System.Drawing.Point(124, 47);
            this.txtReserveno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReserveno.Name = "txtReserveno";
            this.txtReserveno.PasswordChar = '\0';
            this.txtReserveno.PlaceholderText = "";
            this.txtReserveno.SelectedText = "";
            this.txtReserveno.Size = new System.Drawing.Size(147, 36);
            this.txtReserveno.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(18, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 71;
            this.label10.Text = "Date";
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BorderRadius = 22;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Indigo;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(684, 556);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 46);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 22;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(808, 556);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 46);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(655, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 68;
            this.label9.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(323, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(291, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(277, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Firstname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Bk code";
            // 
            // dtime
            // 
            this.dtime.AutoRoundedCorners = true;
            this.dtime.BorderRadius = 17;
            this.dtime.Checked = true;
            this.dtime.FillColor = System.Drawing.Color.Gainsboro;
            this.dtime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtime.Location = new System.Drawing.Point(77, 118);
            this.dtime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtime.Name = "dtime";
            this.dtime.Size = new System.Drawing.Size(226, 36);
            this.dtime.TabIndex = 4;
            this.dtime.Value = new System.DateTime(2022, 10, 17, 14, 59, 54, 568);
            // 
            // cmbEmployeeno
            // 
            this.cmbEmployeeno.AutoRoundedCorners = true;
            this.cmbEmployeeno.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmployeeno.BorderRadius = 17;
            this.cmbEmployeeno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmployeeno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmployeeno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmployeeno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmployeeno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmployeeno.ItemHeight = 30;
            this.cmbEmployeeno.Location = new System.Drawing.Point(124, 182);
            this.cmbEmployeeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmployeeno.Name = "cmbEmployeeno";
            this.cmbEmployeeno.Size = new System.Drawing.Size(125, 36);
            this.cmbEmployeeno.TabIndex = 7;
            this.cmbEmployeeno.SelectionChangeCommitted += new System.EventHandler(this.cmbEmployeeno_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(18, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 81;
            this.label5.Text = "Emp code";
            // 
            // txtEmployeename
            // 
            this.txtEmployeename.Animated = true;
            this.txtEmployeename.AutoRoundedCorners = true;
            this.txtEmployeename.BorderRadius = 17;
            this.txtEmployeename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeename.DefaultText = "";
            this.txtEmployeename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeename.Location = new System.Drawing.Point(396, 182);
            this.txtEmployeename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeename.Name = "txtEmployeename";
            this.txtEmployeename.PasswordChar = '\0';
            this.txtEmployeename.PlaceholderText = "";
            this.txtEmployeename.ReadOnly = true;
            this.txtEmployeename.SelectedText = "";
            this.txtEmployeename.Size = new System.Drawing.Size(220, 36);
            this.txtEmployeename.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(270, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 83;
            this.label8.Text = "Emp Name";
            // 
            // txtLname
            // 
            this.txtLname.Animated = true;
            this.txtLname.AutoRoundedCorners = true;
            this.txtLname.BorderRadius = 17;
            this.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLname.DefaultText = "";
            this.txtLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLname.Location = new System.Drawing.Point(727, 47);
            this.txtLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLname.Name = "txtLname";
            this.txtLname.PasswordChar = '\0';
            this.txtLname.PlaceholderText = "";
            this.txtLname.ReadOnly = true;
            this.txtLname.SelectedText = "";
            this.txtLname.Size = new System.Drawing.Size(194, 36);
            this.txtLname.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(613, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 85;
            this.label2.Text = "Lastname";
            // 
            // frmAdminbooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(943, 670);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmployeename);
            this.Controls.Add(this.cmbEmployeeno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtime);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.txtTotalprice);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtReserveno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminbooking";
            this.Text = "Form0_Admin";
            this.Load += new System.EventHandler(this.frmAdminbooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbTime;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBooking;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalprice;
        private Guna.UI2.WinForms.Guna2TextBox txtFname;
        private Guna.UI2.WinForms.Guna2TextBox txtReserveno;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtime;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmployeeno;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeename;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtLname;
        private System.Windows.Forms.Label label2;
    }
}