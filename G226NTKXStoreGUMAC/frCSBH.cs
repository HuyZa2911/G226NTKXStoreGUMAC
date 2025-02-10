using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frCSBH : Form
    {
        int vt = -1;
        public frCSBH()
        {
            InitializeComponent();
        }

        private void frCSBH_Load(object sender, EventArgs e)
        {
            this.dMCSBHTableAdapter.Fill(this.dMCSBH._DMCSBH);
            dataGridViewCSBH.DataSource = this.dMCSBH._DMCSBH;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            setvalue();
        }
        void setvalue() {
            txtTen.Text = dataGridViewCSBH.Rows[vt].Cells["tencsbh"].Value.ToString();
            txtDiaChi.Text = dataGridViewCSBH.Rows[vt].Cells["dc"].Value.ToString();
            txtSDT.Text = dataGridViewCSBH.Rows[vt].Cells["sdt"].Value.ToString();
        }

        private bool checkValueNull() {
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
            int result = dMCSBHTableAdapter.InsertQuery(
                txtTen.Text, txtDiaChi.Text, txtSDT.Text
                );
            if(result == 1)
            {
                MessageBox.Show("Thêm thành công");
                frCSBH_Load(sender,e);
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
            int result = dMCSBHTableAdapter.DeleteQuery(
                int.Parse(dataGridViewCSBH.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Xóa thành công");
                frCSBH_Load(sender, e);
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

            DialogResult ch = MessageBox.Show("Bạn có muốn cập nhật CSBH "+ dataGridViewCSBH.Rows[vt].Cells["tencsbh"].Value.ToString() + " thành " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = dMCSBHTableAdapter.UpdateQuery(
                txtTen.Text, txtDiaChi.Text, txtSDT.Text, int.Parse(dataGridViewCSBH.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Cập nhật thành công");
                frCSBH_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công! Vui lòng thử lại sau");

            }
        }
    }
}
