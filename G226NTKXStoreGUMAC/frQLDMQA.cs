using System;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frQLDMQA : Form
    {
        public frQLDMQA()
        {
            InitializeComponent();
        }

        private void fr2QLDMQA_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'dMNSX._DMNSX' table.You can move, or remove it, as needed.
            this.dMNSXTableAdapter.Fill(this.dMNSX._DMNSX);
        //TODO: This line of code loads data into the 'nhomSP._NhomSP' table.You can move, or remove it, as needed.
            this.nhomSPTableAdapter.Fill(this.nhomSP._NhomSP);
            loadDataGridView();
        }
        private void comboBoxNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            try
            {
                if (this.comboBoxNhomSP.SelectedValue != null)
                {
                    this.dMQuanAoTableAdapter.Fill(this.dMQA.DMQuanAo, int.Parse(this.comboBoxNhomSP.SelectedValue.ToString()));
                    dataGridViewQA.DataSource = this.dMQA.DMQuanAo;
                }
            }
            catch (System.Exception) { }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm sản phẩm")
            {
                EnabledInput(enabled: true);
                ClearDataInput();
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnThem.Text = "Lưu (Thêm)";
                return;
            }
            UpdateDMQA();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa sản phẩm") //BẮT ĐẦU SỬA
            {
                EnabledInput(true);
                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                //oldim = pictureBoxhinh.ImageLocation;

                //pictureBoxhinh.Click += new EventHandler(ChonHinh);
                return;
            }
            UpdateDMQA();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Hủy")
            {
                EnabledInput(enabled: false);
                ClearDataInput();
                btnSua.Text = "Sửa sản phẩm";
                btnThem.Text = "Thêm sản phẩm";
                btnXoa.Text = "Xóa sản phẩm";
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                return;
            }

            if (dataGridViewQA.SelectedRows.Count == null || dataGridViewQA.SelectedRows.Count < 0)
            {
                MessageBox.Show("Chọn sản phẩm muốn xóa");
                return;
            }

            DialogResult ch = MessageBox.Show("THIỆT LÀ MUỐN XÓA : " + txtmsquanao.Text +
           ": " + txttensp.Text + " PHẢI KHÔNG (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    deleteDMQA();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sản phẩm" +
               ex.Message);
                }
                //B3: Tải BD lên DataGridView sau khi xóa
                try
                {
                    loadDataGridView();
                }
                catch (System.Exception) { }
            }

        }

        private void dataGridViewQA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                setDataInput(e.RowIndex);
            }
        }
        private void dataGridViewQA_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewQA.SelectedRows.Count >= 0)
            {
                setDataInput(dataGridViewQA.SelectedRows.Count);
            }
        }
        private void setDataInput(int rowIndex)
        {
            
            //Lấy dữ liệu từ hàng được chọn
           DataGridViewRow rows = dataGridViewQA.Rows[rowIndex];
            if (rows.IsNewRow)
            {
                return;
            }
            foreach (DataGridViewCell cell in rows.Cells)
            {
                Console.WriteLine($"{cell.OwningColumn.HeaderText}: {cell.Value}");
            }

            try
            {  // Gán giá trị vào các control tương ứng
                txtmsquanao.Text = rows.Cells["ID"].Value?.ToString();
                txttensp.Text = rows.Cells["tensp"].Value?.ToString();
                txtgiavon.Text = rows.Cells["giavon"].Value?.ToString();
                txtchatlieu.Text = rows.Cells["chatlieu"].Value?.ToString();
                txtmausac.Text = rows.Cells["mausac"].Value?.ToString();
                txtphongcach.Text = rows.Cells["phongcach"].Value?.ToString();
                txtmota.Text = rows.Cells["mota"].Value?.ToString();
                cbconhang.Checked = rows.Cells["consp"].Value != null && (bool)rows.Cells["consp"].Value;

                //Nếu có ngày sản xuất, gán giá trị vào DateTimePicker
                if (rows.Cells["ngaysx"].Value != null && DateTime.TryParse(rows.Cells["ngaysx"].Value.ToString(), out DateTime ngaysx))
                {
                    dateTimePicketNgSX.Value = ngaysx;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("setDataInput lỗi: " + ex.Message);
            }
        }

        private void EnabledInput(bool enabled = false)
        {
            txtmsquanao.Enabled = enabled;
            txttensp.Enabled = enabled;
            txtgiavon.Enabled = enabled;
            comboBoxNhomSX.Enabled = enabled;
            txtchatlieu.Enabled = enabled;
            txtmota.Enabled = enabled;
            txtmausac.Enabled = enabled;
            txtphongcach.Enabled = enabled;
            dateTimePicketNgSX.Enabled = enabled;
            cbconhang.Enabled = enabled;
            btnSua.Enabled = enabled;
            btnXoa.Enabled = enabled;
            txtkichthuoc.Enabled = enabled;
        }
        private void ClearDataInput()
        {
            //pictureBoxhinh.ImageLocation = apppath + "ImageChoose.png";
            //pictureBoxhinh.Click += new EventHandler(ChonHinh);
            txtmsquanao.Text = "";
            txttensp.Text = "";
            txtgiavon.Text = "";
            txtchatlieu.Text = "";
            txtmota.Text = "";
            txtmausac.Text = "";
            txtphongcach.Text = "";
            txtkichthuoc.Text = "";
        }

        private void deleteDMQA() {
            this.dMQuanAoTableAdapter.DeleteQuery(Convert.ToInt32(txtmsquanao.Text));
        }

        private void UpdateDMQA()
        {
            if((txtmsquanao.Text??"") == "")
            {
                this.dMQuanAoTableAdapter.Add((int)comboBoxNhomSX.SelectedValue,
                (int)comboBoxNhomSX.SelectedValue, txttensp.Text,
                string.IsNullOrWhiteSpace(txtgiavon.Text) ? 0 : double.Parse(txtgiavon.Text.Trim()),
                txtchatlieu.Text,
                txtkichthuoc.Text,
                txtmausac.Text,
                txtphongcach.Text,
                txtmota.Text,
                 DateTime.TryParse(dateTimePicketNgSX.Text, out DateTime parsedDate) ? parsedDate.ToString("yyyy-MM-dd") : string.Empty,
                 "",
                 cbconhang.Checked
                );
            }
            else
            {
                this.dMQuanAoTableAdapter.UpdateData((int)comboBoxNhomSX.SelectedValue,
                (int)comboBoxNhomSX.SelectedValue, txttensp.Text,
                string.IsNullOrWhiteSpace(txtgiavon.Text) ? 0 : double.Parse(txtgiavon.Text.Trim()),
                txtchatlieu.Text,
                txtkichthuoc.Text,
                txtmausac.Text,
                txtphongcach.Text,
                txtmota.Text,
                 DateTime.TryParse(dateTimePicketNgSX.Text, out DateTime parsedDate) ? parsedDate.ToString("yyyy-MM-dd") : string.Empty,
                 "",
                 cbconhang.Checked,
                 Convert.ToInt32(txtmsquanao.Text)
                );
            }
            loadDataGridView();
            MessageBox.Show("Lưu thành công");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Muốn đóng màn hình không (Y/N)", "Xác nhận",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Muốn đóng màn hình không (Y/N)", "Xác nhận",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit(); // Explicit namespace to resolve ambiguity
            }
        }
    }
}
