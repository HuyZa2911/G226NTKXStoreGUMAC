using System;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frDMNCC : Form
    {
        int vt = -1;
        public frDMNCC()
        {
            InitializeComponent();
        }

        private void frDMNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMNCC._DMNCC' table. You can move, or remove it, as needed.
            this.dMNCCTableAdapter.Fill(this.dMNCC._DMNCC);

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            setvalue();
        }

        void setvalue()
        {
            txtTen.Text = dataGridViewNCC.Rows[vt].Cells["tenncc"].Value.ToString();
            txtDiaChi.Text = dataGridViewNCC.Rows[vt].Cells["dc"].Value.ToString();
            txtSDT.Text = dataGridViewNCC.Rows[vt].Cells["sdt"].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!checkValueNull())
            {
                return;
            }

            DialogResult ch = MessageBox.Show("Bạn có muốn thêm ncc " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = this.dMNCCTableAdapter.InsertQuery(
                 txtTen.Text, txtDiaChi.Text, txtSDT.Text
                );
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công");
                frDMNCC_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công! Vui lòng thử lại sau");

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn xóa ncc " + txtTen.Text + " không (Y/N)?", "Xác nhận",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = dMNCCTableAdapter.DeleteQuery(
                int.Parse(dataGridViewNCC.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Xóa thành công");
                frDMNCC_Load(sender, e);
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


            DialogResult ch = MessageBox.Show("Bạn có muốn cập nhật ncc " + dataGridViewNCC.Rows[vt].Cells["tenncc"].Value.ToString() + " thành " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result =
            this.dMNCCTableAdapter.UpdateQuery(
                 txtTen.Text, txtDiaChi.Text, txtSDT.Text, int.Parse(dataGridViewNCC.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Cập nhật thành công");
                frDMNCC_Load(sender, e);
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
            return true;
        }
    }
}
