using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir_stock_gudang
{
    public partial class formAkunSayaKasir : Form
    {
        public formAkunSayaKasir(string email, Dashboard_kasir dashboard)
        {
            InitializeComponent();

            ucAkunSayaKasir1.AturEmail(email);
            ucAkunSayaKasir1.AturDashboard(dashboard);
        }

        private void formAkunSayaKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
