// DESIGNER REWORKED FOR FORM QLThuCungDichVu
// Style giống ThuCungDaBan: Panel trái màu trắng, phải màu hồng nhạt,
// DataGridView header đỏ, search bar, title bold.

using System.Windows.Forms;
using System.Drawing;

namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    partial class QLThuCungDichVu
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelLeft;
        private Panel panelRight;

        private DataGridView dgvCustomerPets;

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;

        private Label labelPetId;
        private TextBox txtPetId;

        private Label labelPetName;
        private TextBox txtPetName;

        private Label labelPetAge;
        private TextBox txtPetAge;

        private Label labelService;
        private ComboBox cmbService;

        private Button btnDoneService;

        // DataGridView Columns
        private DataGridViewTextBoxColumn colCPS_Id;
        private DataGridViewTextBoxColumn colPetId;
        private DataGridViewTextBoxColumn colPetName;
        private DataGridViewTextBoxColumn colPetAge;
        private DataGridViewTextBoxColumn colServiceName;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colStatus;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            panelLeft = new Panel();
            dgvCustomerPets = new DataGridView();
            colCPS_Id = new DataGridViewTextBoxColumn();
            colPetId = new DataGridViewTextBoxColumn();
            colPetName = new DataGridViewTextBoxColumn();
            colPetAge = new DataGridViewTextBoxColumn();
            colServiceName = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panelRight = new Panel();
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            labelPetId = new Label();
            txtPetId = new TextBox();
            labelPetName = new Label();
            txtPetName = new TextBox();
            labelPetAge = new Label();
            txtPetAge = new TextBox();
            labelService = new Label();
            cmbService = new ComboBox();
            btnDoneService = new Button();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerPets).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(dgvCustomerPets);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 100);
            panelLeft.TabIndex = 1;
            // 
            // dgvCustomerPets
            // 
            dgvCustomerPets.Columns.AddRange(new DataGridViewColumn[] { colCPS_Id, colPetId, colPetName, colPetAge, colServiceName, colStartDate, colStatus });
            dgvCustomerPets.Location = new Point(0, 0);
            dgvCustomerPets.Name = "dgvCustomerPets";
            dgvCustomerPets.Size = new Size(240, 150);
            dgvCustomerPets.TabIndex = 0;
            dgvCustomerPets.CellClick += dgvCustomerPets_CellClick;
            // 
            // colCPS_Id
            // 
            colCPS_Id.Name = "colCPS_Id";
            // 
            // colPetId
            // 
            colPetId.Name = "colPetId";
            // 
            // colPetName
            // 
            colPetName.Name = "colPetName";
            // 
            // colPetAge
            // 
            colPetAge.Name = "colPetAge";
            // 
            // colServiceName
            // 
            colServiceName.Name = "colServiceName";
            // 
            // colStartDate
            // 
            colStartDate.Name = "colStartDate";
            // 
            // colStatus
            // 
            colStatus.Name = "colStatus";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(lblTitle);
            panelRight.Controls.Add(lblSearch);
            panelRight.Controls.Add(txtSearch);
            panelRight.Controls.Add(btnSearch);
            panelRight.Controls.Add(btnRefresh);
            panelRight.Controls.Add(labelPetId);
            panelRight.Controls.Add(txtPetId);
            panelRight.Controls.Add(labelPetName);
            panelRight.Controls.Add(txtPetName);
            panelRight.Controls.Add(labelPetAge);
            panelRight.Controls.Add(txtPetAge);
            panelRight.Controls.Add(labelService);
            panelRight.Controls.Add(cmbService);
            panelRight.Controls.Add(btnDoneService);
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(200, 100);
            panelRight.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(0, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(0, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Location = new Point(0, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Location = new Point(0, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // labelPetId
            // 
            labelPetId.Location = new Point(0, 0);
            labelPetId.Name = "labelPetId";
            labelPetId.Size = new Size(100, 23);
            labelPetId.TabIndex = 5;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(0, 0);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(100, 23);
            txtPetId.TabIndex = 6;
            // 
            // labelPetName
            // 
            labelPetName.Location = new Point(0, 0);
            labelPetName.Name = "labelPetName";
            labelPetName.Size = new Size(100, 23);
            labelPetName.TabIndex = 7;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(0, 0);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(100, 23);
            txtPetName.TabIndex = 8;
            // 
            // labelPetAge
            // 
            labelPetAge.Location = new Point(0, 0);
            labelPetAge.Name = "labelPetAge";
            labelPetAge.Size = new Size(100, 23);
            labelPetAge.TabIndex = 9;
            // 
            // txtPetAge
            // 
            txtPetAge.Location = new Point(0, 0);
            txtPetAge.Name = "txtPetAge";
            txtPetAge.Size = new Size(100, 23);
            txtPetAge.TabIndex = 10;
            // 
            // labelService
            // 
            labelService.Location = new Point(0, 0);
            labelService.Name = "labelService";
            labelService.Size = new Size(100, 23);
            labelService.TabIndex = 11;
            // 
            // cmbService
            // 
            cmbService.Location = new Point(0, 0);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(121, 23);
            cmbService.TabIndex = 12;
            cmbService.SelectedIndexChanged += cmbService_SelectedIndexChanged;
            // 
            // btnDoneService
            // 
            btnDoneService.FlatAppearance.BorderSize = 0;
            btnDoneService.Location = new Point(0, 0);
            btnDoneService.Name = "btnDoneService";
            btnDoneService.Size = new Size(75, 23);
            btnDoneService.TabIndex = 13;
            btnDoneService.Click += btnDoneService_Click;
            // 
            // QLThuCungDichVu
            // 
            ClientSize = new Size(1400, 900);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "QLThuCungDichVu";
            Text = "Quản Lý Thú Cưng - Dịch Vụ";
            Load += QLThuCungDichVu_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomerPets).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }
    }
}
