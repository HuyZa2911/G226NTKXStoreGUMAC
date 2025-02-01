using G226NTKXStoreGUMAC.Common;
using G226NTKXStoreGUMAC.Data;
using G226NTKXStoreGUMAC.Data.DMNVTableAdapters;
using System;
using System.Linq;
using System.Windows.Forms;

namespace G226NTKXStoreGUMAC
{
    public partial class frLogin : Form
    {
        DMNVTableAdapter dMNVTableAdapter = new DMNVTableAdapter();
        DMNV dmnv = new DMNV();

        public frLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtAccount;
        }
        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender,e);
            }
        }

            private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text, account = txtAccount.Text;
            if (string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(account))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống");
                return;
            }
            DMNV.DMNVDataTable data = dMNVTableAdapter.GetData(account, pass);
           
            if (data.Count == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }
            Common.Common.User = data.First();

            frMain26 m = new frMain26();
            m.Show();
            this.Visible = false;
            this.Hide();
        }
    }
}
