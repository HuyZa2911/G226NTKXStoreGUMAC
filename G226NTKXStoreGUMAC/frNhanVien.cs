using System;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frNhanVien : Form
    {
        int vt = -1;
        public frNhanVien()
        {
            InitializeComponent();
        }
        private void frNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMNSX._DMNSX' table. You can move, or remove it, as needed.
            this.dMNVTableAdapter.FillBy(this.dMNV._DMNV);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            setvalue();
        }

        void setvalue()
        {
            txtTen.Text = dataGridViewVN.Rows[vt].Cells["hoten"].Value.ToString();
            txtSdt.Text = dataGridViewVN.Rows[vt].Cells["sdt"].Value.ToString();
            txtTaiKhoan.Text = dataGridViewVN.Rows[vt].Cells["taikhoan"].Value.ToString();
            txtMatKhau.Text = dataGridViewVN.Rows[vt].Cells["matkhau"].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!checkValueNull())
            {
                return;
            }

            DialogResult ch = MessageBox.Show("Bạn có muốn thêm nhân viên " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = this.dMNVTableAdapter.InsertQuery(
                 txtTen.Text, txtSdt.Text,
                txtTaiKhoan.Text,
                txtMatKhau.Text
                );
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công");
                frNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công! Vui lòng thử lại sau");

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn xóa nhân viên " + txtTen.Text + " không (Y/N)?", "Xác nhận",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = dMNVTableAdapter.DeleteQuery(
                int.Parse(dataGridViewVN.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Xóa thành công");
                frNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa không thành công! Vui lòng thử lại sau");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!checkValueNull())
            {
                return;
            }


            DialogResult ch = MessageBox.Show("Bạn có muốn cập nhật nhân viên " + dataGridViewVN.Rows[vt].Cells["hoten"].Value.ToString() + " thành " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result =
            this.dMNVTableAdapter.UpdateQuery(
                 txtTen.Text, txtSdt.Text,
                txtTaiKhoan.Text,
                txtMatKhau.Text, int.Parse(dataGridViewVN.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Cập nhật thành công");
                frNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công! Vui lòng thử lại sau");

            }
        }

        private bool checkValueNull()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập sdt");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return false;
            }
            return true;
        }

    }
}
