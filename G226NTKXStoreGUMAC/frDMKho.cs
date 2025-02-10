using System;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frDMKho : Form
    {
        int vt = -1;
        public frDMKho()
        {
            InitializeComponent();
        }

        private void frDMKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMKho._DMKho' table. You can move, or remove it, as needed.
            this.dMKhoTableAdapter.Fill(this.dMKho._DMKho);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            setvalue();
        }

        void setvalue()
        {
            txtTen.Text = dataGridViewKho.Rows[vt].Cells["tenkho"].Value.ToString();
            txtDiaChi.Text = dataGridViewKho.Rows[vt].Cells["dc"].Value.ToString();
            txtSDT.Text = dataGridViewKho.Rows[vt].Cells["sdt"].Value.ToString();
            txtSucChua.Text = dataGridViewKho.Rows[vt].Cells["succhua"].Value.ToString();
            txtConTrong.Text = dataGridViewKho.Rows[vt].Cells["controng"].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!checkValueNull())
            {
                return;
            }

            DialogResult ch = MessageBox.Show("Bạn có muốn thêm CSBH " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = this.dMKhoTableAdapter.InsertQuery(
                 txtTen.Text, txtDiaChi.Text, txtSDT.Text, int.Parse(txtSucChua.Text), int.Parse(txtConTrong.Text)
                );
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công");
                frDMKho_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công! Vui lòng thử lại sau");

            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn xóa CSBH " + txtTen.Text + " không (Y/N)?", "Xác nhận",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = dMKhoTableAdapter.DeleteQuery(
                int.Parse(dataGridViewKho.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Xóa thành công");
                frDMKho_Load(sender, e);
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


            DialogResult ch = MessageBox.Show("Bạn có muốn cập nhật CSBH " + dataGridViewKho.Rows[vt].Cells["tencsbh"].Value.ToString() + " thành " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result =
            this.dMKhoTableAdapter.UpdateQuery(
                 txtTen.Text, txtDiaChi.Text, txtSDT.Text, int.Parse(txtSucChua.Text), int.Parse(txtConTrong.Text), int.Parse(dataGridViewKho.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Cập nhật thành công");
                frDMKho_Load(sender, e);
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
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập sdt");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSucChua.Text))
            {
                MessageBox.Show("Vui lòng nhập sức chứa");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtConTrong.Text))
            {
                MessageBox.Show("Vui lòng nhập còn trống");
                return false;
            }
            return true;
        }

    }
}
