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
    public partial class frNSX : Form
    {
        int vt = -1;
        public frNSX()
        {
            InitializeComponent();
        }

        private void frNSX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMNSX._DMNSX' table. You can move, or remove it, as needed.
            this.dMNSXTableAdapter.Fill(this.dMNSX._DMNSX);

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            setvalue();
        }

        void setvalue()
        {
            txtTen.Text = dataGridViewNSX.Rows[vt].Cells["tennsx"].Value.ToString();
            txtQuocGia.Text = dataGridViewNSX.Rows[vt].Cells["quocgia"].Value.ToString();
            txtMota.Text = dataGridViewNSX.Rows[vt].Cells["mota"].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!checkValueNull())
            {
                return;
            }

            DialogResult ch = MessageBox.Show("Bạn có muốn thêm nsx " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = this.dMNSXTableAdapter.InsertQuery(
                 txtTen.Text, txtQuocGia.Text, txtMota.Text
                );
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công");
                frNSX_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công! Vui lòng thử lại sau");

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn xóa nsx " + txtTen.Text + " không (Y/N)?", "Xác nhận",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result = dMNSXTableAdapter.DeleteQuery(
                int.Parse(dataGridViewNSX.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Xóa thành công");
                frNSX_Load(sender, e);
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


            DialogResult ch = MessageBox.Show("Bạn có muốn cập nhật nsx " + dataGridViewNSX.Rows[vt].Cells["tennsx"].Value.ToString() + " thành " + txtTen.Text + " không (Y/N)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.No)
            {
                return;
            }
            int result =
            this.dMNSXTableAdapter.UpdateQuery(
                 txtTen.Text, txtQuocGia.Text, txtMota.Text, int.Parse(dataGridViewNSX.Rows[vt].Cells["ID"].Value.ToString())
                );
            if (result == 1)
            {
                MessageBox.Show("Cập nhật thành công");
                frNSX_Load(sender, e);
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
          
            if (string.IsNullOrWhiteSpace(txtQuocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập quốc gia");
                return false;
            }
            return true;
        }

       
    }
}
