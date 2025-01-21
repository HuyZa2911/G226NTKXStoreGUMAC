using System;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frNhapKho : Form
    {
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
        }
        private void comboBoxNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
    
}
