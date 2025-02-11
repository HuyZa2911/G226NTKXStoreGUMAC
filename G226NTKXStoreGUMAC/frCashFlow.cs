using System;
using System.Globalization;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frCashFlow : Form
    {
        public frCashFlow()
        {
            InitializeComponent();
            
        }

        private void frCashFlow_Load(object sender, EventArgs e)
        {
            this.dMKhoTableAdapter.Fill(this.dMKho._DMKho);
            clearDateTimePicker();
            fillter();
        }

        void clearDateTimePicker() {
            dateTimeTuNgay.CustomFormat = " ";
            dateTimeTuNgay.Format = DateTimePickerFormat.Custom;
            dateTimeDenNgay.CustomFormat = " ";
            dateTimeDenNgay.Format = DateTimePickerFormat.Custom;
            cbbKho.SelectedIndex = -1;
        }

        void fillter() {

            DateTime? tuNgay = null, denNgay = null; int? maKho = null;
            if (cbbKho.SelectedIndex > 0)
            {
                maKho = int.Parse(cbbKho.SelectedValue.ToString());
            }
            if (dateTimeTuNgay.Text !=" ")
            {
                tuNgay = DateTime.Parse(dateTimeTuNgay.Text);
            }
            if (dateTimeDenNgay.Text != " ")
            {
                denNgay = DateTime.Parse(dateTimeDenNgay.Text);
            }
            this.phieuXKTableAdapter.FillBy(this.phieuXK._PhieuXK, tuNgay, denNgay, maKho);
            this.phieuNKTableAdapter.FillBy(this.phieuNK._PhieuNK, tuNgay, denNgay, maKho);
            setValuePrice();
        }

        private void setValuePrice()
        {
            double tongNhapKho = 0;
            double tongXuatKho = 0;

            // Tính tổng giá trị nhập kho
            foreach (DataGridViewRow row in nhapkhoGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string slValue = row.Cells["sl"].Value?.ToString() ?? "0";
                string giaVonValue = row.Cells["giavon"].Value?.ToString() ?? "0";

                if (double.TryParse(slValue, out double sl) && double.TryParse(giaVonValue, out double giaVon))
                {
                    tongNhapKho += sl * giaVon;
                }
            }

            // Tính tổng giá trị xuất kho
            foreach (DataGridViewRow row in xuatKhoGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string slValue = row.Cells["slXK"].Value?.ToString() ?? "0";
                string giaVonValue = row.Cells["giavonXK"].Value?.ToString() ?? "0";

                if (double.TryParse(slValue, out double sl) && double.TryParse(giaVonValue, out double giaVon))
                {
                    tongXuatKho += sl * giaVon;
                }
            }

            // Gán kết quả vào các textbox với định dạng tiền tệ Việt Nam
            txtTongXuatKho.Text = tongNhapKho.ToString("C0", new CultureInfo("vi-VN"));
            txtTongNhapKho.Text = tongXuatKho.ToString("C0", new CultureInfo("vi-VN"));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            fillter();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearDateTimePicker();
            fillter();
        }

        private void dateTimeTuNgay_ValueChanged(object sender, EventArgs e)
        {
            dateTimeTuNgay.Format = DateTimePickerFormat.Long;
        }

        private void dateTimeDenNgay_ValueChanged(object sender, EventArgs e)
        {
            dateTimeDenNgay.Format = DateTimePickerFormat.Long;
        }
    }
}
