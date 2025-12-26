namespace PetManagerWinForm.NghiepVu.QLDichVu
{
    partial class Type
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvTypes = new DataGridView();
            colTypeId = new DataGridViewTextBoxColumn();
            colTypeName = new DataGridViewTextBoxColumn();
            panelControl = new Panel();
            labelSearch = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lblName = new Label();
            txtTypeName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTypes).BeginInit();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTypes
            // 
            dgvTypes.AllowUserToAddRows = false;
            dgvTypes.AllowUserToDeleteRows = false;
            dgvTypes.BackgroundColor = Color.White;
            dgvTypes.BorderStyle = BorderStyle.None;
            dgvTypes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTypes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 84, 84);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(231, 84, 84);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTypes.ColumnHeadersHeight = 40;
            dgvTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTypes.Columns.AddRange(new DataGridViewColumn[] { colTypeId, colTypeName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 229, 229);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTypes.Dock = DockStyle.Fill;
            dgvTypes.EnableHeadersVisualStyles = false;
            dgvTypes.GridColor = Color.FromArgb(255, 200, 200);
            dgvTypes.Location = new Point(0, 0);
            dgvTypes.Margin = new Padding(4, 3, 4, 3);
            dgvTypes.MultiSelect = false;
            dgvTypes.Name = "dgvTypes";
            dgvTypes.ReadOnly = true;
            dgvTypes.RowHeadersVisible = false;
            dgvTypes.RowTemplate.Height = 35;
            dgvTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTypes.Size = new Size(374, 532);
            dgvTypes.TabIndex = 0;
            // 
            // colTypeId
            // 
            colTypeId.HeaderText = "ID";
            colTypeId.Name = "colTypeId";
            colTypeId.ReadOnly = true;
            colTypeId.Width = 60;
            // 
            // colTypeName
            // 
            colTypeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTypeName.HeaderText = "Type Name";
            colTypeName.Name = "colTypeName";
            colTypeName.ReadOnly = true;
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.FromArgb(255, 240, 241);
            panelControl.Controls.Add(labelSearch);
            panelControl.Controls.Add(btnSearch);
            panelControl.Controls.Add(txtSearch);
            panelControl.Controls.Add(btnRefresh);
            panelControl.Controls.Add(btnDelete);
            panelControl.Controls.Add(btnEdit);
            panelControl.Controls.Add(btnAdd);
            panelControl.Controls.Add(lblName);
            panelControl.Controls.Add(txtTypeName);
            panelControl.Dock = DockStyle.Right;
            panelControl.Location = new Point(374, 0);
            panelControl.Margin = new Padding(4, 3, 4, 3);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(303, 532);
            panelControl.TabIndex = 1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 10F);
            labelSearch.ForeColor = Color.FromArgb(90, 30, 30);
            labelSearch.Location = new Point(16, 298);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(67, 19);
            labelSearch.TabIndex = 43;
            labelSearch.Text = "Tìm kiếm:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(231, 76, 60);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(217, 323);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 33);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(21, 323);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(188, 29);
            txtSearch.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(21, 213);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(268, 35);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(173, 162);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 35);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(41, 128, 185);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(21, 162);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 35);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(21, 110);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(268, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.ForeColor = Color.FromArgb(90, 30, 30);
            lblName.Location = new Point(16, 35);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 21);
            lblName.TabIndex = 5;
            lblName.Text = "Tên loại:";
            // 
            // txtTypeName
            // 
            txtTypeName.Font = new Font("Segoe UI", 12F);
            txtTypeName.Location = new Point(21, 62);
            txtTypeName.Margin = new Padding(4, 3, 4, 3);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(268, 29);
            txtTypeName.TabIndex = 2;
            // 
            // Type
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 532);
            Controls.Add(dgvTypes);
            Controls.Add(panelControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Type";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý loại dịch vụ";
            Load += Type_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTypes).EndInit();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}