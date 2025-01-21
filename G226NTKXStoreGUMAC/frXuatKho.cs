using System;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frXuatKho : Form
    {

        string masp = "";

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

        }

        private void btnXK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(masp))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
            int rowIndex = dataGridViewXK.Rows.Add();
            DataGridViewRow newRow = dataGridViewXK.Rows[rowIndex];

            newRow.Cells["mssp"].Value = "Value1";
            newRow.Cells["tensp"].Value = "Value2";
            newRow.Cells["sl"].Value = "Value3";
        }
    }
}
