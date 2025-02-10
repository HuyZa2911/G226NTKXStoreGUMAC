using G226NTKXStoreGUMAC.Data.CTPhieuNKTableAdapters;
using G226NTKXStoreGUMAC.Data.CTPhieuXKTableAdapters;
using System;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frXuatKho : Form
    {

        CTPhieuXKTableAdapter tPhieuXKTableAdapter = new CTPhieuXKTableAdapter();

        int vt = 0;
        int pos = 0;

        public frXuatKho()
        {
            InitializeComponent();
        }

        private void frXuatKho_Load(object sender, EventArgs e)
        {
            this.phieuXKTableAdapter.Fill(this.phieuXK._PhieuXK);
            this.dMKhoTableAdapter.Fill(this.dMKho._DMKho);
            this.dMCSBHTableAdapter.Fill(this.dMCSBH._DMCSBH);
            this.nhomSPTableAdapter.Fill(this.nhomSP._NhomSP);
            loadDataGridView();
        }

        private double convertDouble(object value)
        {
            double data = value != DBNull.Value ? Convert.ToDouble(value) : 0;
            return data;
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

        private int convertInt(object value)
        {
            Console.WriteLine(value);
            int data = value != DBNull.Value ? int.Parse(value.ToString()) : 0;
            return data;
        }

        private void setTotalPrice()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dataGridViewXK.Rows)
            {
                if (row.Cells["rTongTien"].Value != null)
                {
                    sum += Convert.ToDecimal(row.Cells["rTongTien"].Value);
                }
            }
            txttongcong.Text = sum.ToString();
        }

        private void btnXK_Click(object sender, EventArgs e)
        {
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

            if (dataGridViewXK.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewXK.Rows.Count; i++)
                {
                    if (dataGridViewXK.Rows[i].Cells["mssp"].Value.ToString().Trim() == itemCode)
                    {
                        double currentQuantity = dataGridViewXK.Rows[i].Cells["soluong"].Value != DBNull.Value ? Convert.ToDouble(dataGridViewXK.Rows[i].Cells["soluong"].Value) : 0;
                        dataGridViewXK.Rows[i].Cells["soluong"].Value = currentQuantity + enteredQuantity;
                        dataGridViewXK.Rows[i].Cells["rTongTien"].Value = convertDouble(dataGridViewXK.Rows[i].Cells["soluong"].Value) * convertDouble(dataGridViewXK.Rows[i].Cells["gia"].Value);
                        itemExists = true;
                        break;
                    }
                }
            }


            if (!itemExists)
            {
                double price = enteredQuantity * convertDouble(itemPrice);
                dataGridViewXK.Rows.Add(
                  itemCode, itemName, itemPrice, txtsoluong.Text, price
                );
            }
            setTotalPrice();
        }
        private void comboBoxNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            vt = 0;
            loadDataGridView();
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!checkValueNull())
            {
                return;
            }
            if (dataGridViewXK.Rows.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm");
                return;
            }
            var data = this.phieuXKTableAdapter.InsertQuery(
                dateTimePicketNgSX.Text, convertInt(cbbCSBH.SelectedValue.ToString()),
                    Common.Common.User.ID, convertInt(cbbMK.SelectedValue.ToString()), null, txtGhiChu.Text
                );
            for (int i = 0; i < dataGridViewXK.Rows.Count; i++)
            {
                tPhieuXKTableAdapter.InsertQuery(
                    convertInt(dataGridViewXK.Rows[i].Cells["mssp"].Value.ToString()),
                    convertDouble(dataGridViewXK.Rows[i].Cells["soluong"].Value.ToString()),
                    data);
            }
            MessageBox.Show("Lưu thành công");
            dataGridViewXK.Rows.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn hủy sản phầm :" +
          dataGridViewXK.Rows[pos].Cells["tensp"].Value + " khỏi Phiếu xuất kho (Y/N)?", "Xác nhận",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                dataGridViewXK.Rows.RemoveAt(pos);
            }
            setTotalPrice();
        }
    }
}
