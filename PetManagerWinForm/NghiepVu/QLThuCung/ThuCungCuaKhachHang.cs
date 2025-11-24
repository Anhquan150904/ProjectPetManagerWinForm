using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PetManagerData.Models;

namespace PetManagerWinForm.NghiepVu.QLThuCung
{
    public partial class ThuCungCuaKhachHang : Form
    {
        public ThuCungCuaKhachHang()
        {
            InitializeComponent();
            ThuCungCuaKhachHang_Load();
            AddEvents();
        }

        private List<PetCustomerInfo> pets = new List<PetCustomerInfo>();
        private int oldPetId;

        private void ThuCungCuaKhachHang_Load()
        {
            dataGridView1.AutoGenerateColumns = false;

            pets = new List<PetCustomerInfo>()
            {
                new PetCustomerInfo {
                    Pet_Id = 1, Pet_Name="Cún Đen", Pet_Type="Dog",
                    Cus_Id = 10, Cus_Name="Nguyễn Văn A", Cus_Email="a@gmail.com",
                    Cus_Phone="0909000111", Time="2025-01-01"
                },
                new PetCustomerInfo {
                    Pet_Id = 2, Pet_Name="Mèo Muối", Pet_Type="Cat",
                    Cus_Id = 11, Cus_Name="Trần Thị B", Cus_Email="b@gmail.com",
                    Cus_Phone="0909111222", Time="2025-01-02"
                }
            };

            dataGridView1.DataSource = pets;
        }

        private void AddEvents()
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            btn_ShowAll.Click += btn_ShowAll_Click;
            btnRefresh.Click += btnRefresh_Click;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            txtId.Text = row.Cells["ID_Pet"].Value?.ToString();
            txtPetName.Text = row.Cells["Pet_Name"].Value?.ToString();
            txtPetType.Text = row.Cells["Pet_Type"].Value?.ToString();

            txtCusID.Text = row.Cells["Cus_ID"].Value?.ToString();
            txtCus_Name.Text = row.Cells["Cus_Name"].Value?.ToString();
            txtCusEmail.Text = row.Cells["Cus_Email"].Value?.ToString();
            txtPhoneNumber.Text = row.Cells["Cus_Phone"].Value?.ToString();
            txtTime.Text = row.Cells["Time"].Value?.ToString();

            oldPetId = Convert.ToInt32(row.Cells["ID_Pet"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newPet = new PetCustomerInfo
            {
                Pet_Id = int.Parse(txtId.Text),
                Pet_Name = txtPetName.Text,
                Pet_Type = txtPetType.Text,

                Cus_Id = int.Parse(txtCusID.Text),
                Cus_Name = txtCus_Name.Text,
                Cus_Email = txtCusEmail.Text,
                Cus_Phone = txtPhoneNumber.Text,

                Time = txtTime.Text
            };

            pets.Add(newPet);
            ReloadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var oldPet = pets.FirstOrDefault(p => p.Pet_Id == oldPetId);

            if (oldPet != null)
                pets.Remove(oldPet);

            var newPet = new PetCustomerInfo
            {
                Pet_Id = int.Parse(txtId.Text),
                Pet_Name = txtPetName.Text,
                Pet_Type = txtPetType.Text,

                Cus_Id = int.Parse(txtCusID.Text),
                Cus_Name = txtCus_Name.Text,
                Cus_Email = txtCusEmail.Text,
                Cus_Phone = txtPhoneNumber.Text,

                Time = txtTime.Text
            };

            pets.Add(newPet);
            ReloadGrid();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var petDelete = pets.FirstOrDefault(p => p.Pet_Id == id);

            if (petDelete != null)
                pets.Remove(petDelete);

            ReloadGrid();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var result = pets.Where(p =>
                p.Pet_Name.ToLower().Contains(keyword) ||
                p.Pet_Type.ToLower().Contains(keyword) ||
                p.Cus_Name.ToLower().Contains(keyword)
            ).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result;
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void ReloadGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pets;
        }

        private void ClearTextbox()
        {
            txtId.Clear();
            txtPetName.Clear();
            txtPetType.Clear();
            txtCusID.Clear();
            txtCus_Name.Clear();
            txtCusEmail.Clear();
            txtPhoneNumber.Clear();
            txtTime.Clear();
        }
    }
}

