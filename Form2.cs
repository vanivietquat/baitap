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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string MSNV
        {
            get { return txtMSNV.Text; }
            set { txtMSNV.Text = value; }
        }

        
        public string Ten
        {
            get { return txtTen.Text; }
            set { txtTen.Text = value; }
        }

        
        public string LuongCB
        {
            get { return txtLuongCB.Text; }
            set { txtLuongCB.Text = value; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSNV.Text) || string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin!", "Loi" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
