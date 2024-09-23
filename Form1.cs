using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                string employeeID = frm.MSNV;
                string fullName = frm.Ten;
                decimal baseSalary = decimal.Parse(frm.LuongCB);

             
                dgvNhanVien.Rows.Add(employeeID, fullName, baseSalary);
            }

        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form2
                string employeeID = frm.txtMSNV.Text;
                string fullName = frm.txtTen.Text;
                decimal baseSalary = decimal.Parse(frm.txtLuongCB.Text);

                // Thêm dòng mới vào DataGridView
                dgvNhanVien.Rows.Add(employeeID, fullName, baseSalary);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvNhanVien.SelectedRows.Count >0)
            {
                dgvNhanVien.Rows.RemoveAt(dgvNhanVien.SelectedRows[0].Index);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
