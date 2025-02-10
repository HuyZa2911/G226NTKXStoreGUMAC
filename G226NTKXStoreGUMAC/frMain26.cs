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
    public partial class frMain26 : Form
    {
        private Timer timer;
        public frMain26()
        {
            InitializeComponent();
            InitializeClock();
        }

        private void danhMụcQuầnÁoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frQLDMQA fr = new frQLDMQA();
            fr.Show();
        }

        private void InitializeClock()
        {
            // Tạo Timer
            timer = new Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += Timer_Tick;

            // Bắt đầu Timer
            timer.Start();

            // Đặt thời gian ban đầu
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lbday.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lbday.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void lậpPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frNhapKho fr = new frNhapKho();
            fr.Show();

        }

        private void lậpPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frXuatKho fr = new frXuatKho();
            fr.Show();

        }

        private void trịGiáTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCashFlow fr = new frCashFlow();
            fr.Show();
        }

        private void danhMụcCơSởBánhHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCSBH fr = new frCSBH();
            fr.Show();
        }
    }
}
