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
            this.phieuXKTableAdapter.Fill(this.phieuXK._PhieuXK);
            this.phieuNKTableAdapter.Fill(this.phieuNK._PhieuNK);
            cbbKho.SelectedIndex = -1;
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
    }
}
