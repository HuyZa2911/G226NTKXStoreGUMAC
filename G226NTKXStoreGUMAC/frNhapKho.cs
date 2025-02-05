using System;
using System.Data;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frNhapKho : Form
    {

        static int vt = 0;
        static int pos = 0;
        public frNhapKho()
        {
            InitializeComponent();
        }

        private void frNhapKho_Load(object sender, EventArgs e)
        {
            this.phieuNKTableAdapter.Fill(this.phieuNK._PhieuNK);
            this.dMCSBHTableAdapter.Fill(this.dMCSBH._DMCSBH);
            this.dMKhoTableAdapter.Fill(this.dMKho._DMKho);
            this.nhomSPTableAdapter1.Fill(this.nhomSP1._NhomSP);
            loadDataGridView();
            txtMaNV.Text = Common.Common.User.ID.ToString();
            txtTenNV.Text = Common.Common.User.hoten.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs
e)
        {
            pos = e.RowIndex;
        }
        private void comboBoxNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            vt = 0;
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            try
            {
                if (this.comboBoxNhomsp.SelectedValue != null)
                {
                    this.dMQuanAoTableAdapter.Fill(this.dMQA.DMQuanAo, int.Parse(this.comboBoxNhomsp.SelectedValue.ToString()));
                    dataGridViewQA.DataSource = this.dMQA.DMQuanAo;
                }
            }
            catch (System.Exception) { }

        }

        private void btnNK_Click(object sender, EventArgs e)
        {

            if (!checkValueNull())
            {
                return;
            }
            DataGridViewRow selectedRow = dataGridViewQA.Rows[vt];
            string itemCode = selectedRow.Cells[0].Value.ToString().Trim();
            string itemName = selectedRow.Cells[1].Value.ToString().Trim();
            object itemPrice = selectedRow.Cells[4].Value.ToString().Trim();
            double enteredQuantity;

            bool itemExists = false;

            if (!double.TryParse(txtsoluong.Text.Trim(), out enteredQuantity))
            {
                MessageBox.Show("Invalid quantity entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridViewSP.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewSP.Rows.Count; i++)
                {
                    if (dataGridViewSP.Rows[i].Cells["rMaSP"].Value.ToString().Trim() == itemCode)
                    {
                        double currentQuantity = dataGridViewSP.Rows[i].Cells["rSL"].Value != DBNull.Value ? Convert.ToDouble(dataGridViewSP.Rows[i].Cells["rSL"].Value) : 0;
                        dataGridViewSP.Rows[i].Cells["rSL"].Value = currentQuantity + enteredQuantity;
                        dataGridViewSP.Rows[i].Cells["rTien"].Value = convertDouble(dataGridViewSP.Rows[i].Cells["rSL"].Value) * convertDouble(dataGridViewSP.Rows[i].Cells["rGia"].Value);
                        itemExists = true;
                        break;
                    }
                }
            }


            if (!itemExists)
            {
                double price = enteredQuantity * convertDouble(itemPrice);
                dataGridViewSP.Rows.Add(
                  itemCode, itemName, txtsoluong.Text, itemPrice, price, cbbMK.SelectedValue, cbbMK.SelectedItem, cbbCSBH.SelectedValue,
                  cbbCSBH.SelectedItem, dateTimePicketNgSX.Text
                );
            }
            setTotalPrice();
        }

        private void setTotalPrice()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dataGridViewSP.Rows)
            {
                if (row.Cells["rTien"].Value != null)
                {
                    sum += Convert.ToDecimal(row.Cells["rTien"].Value);
                }
            }
            txttongcong.Text = sum.ToString();
        }

        private bool checkValueNull()
        {
            if (string.IsNullOrWhiteSpace(txtsoluong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return false;
            }
            if (comboBoxNhomsp.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm sản phẩm");
                return false;
            }
            if (cbbMK.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn kho");
                return false;
            }

            if (cbbCSBH.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn CSBH");
                return false;
            }
            return true;
        }

        private double convertDouble(object value)
        {
            double data = value != DBNull.Value ? Convert.ToDouble(value) : 0;
            return data;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn hủy sản phầm :" +
           dataGridViewSP.Rows[pos].Cells["rTenSP"].Value + " khỏi Phiếu nhập kho (Y/N)?", "Xác nhận",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                dataGridViewSP.Rows.RemoveAt(pos);
            }
        }
    }

}
