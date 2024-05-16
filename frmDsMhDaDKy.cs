using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD
{
    public partial class frmDsMhDaDKy : Form
    {
        private string masv;
        public frmDsMhDaDKy(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDsMhDaDKy_Load(object sender, EventArgs e)
        {
            LoadMonDky();        }

        private void LoadMonDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSMHDDKy.DataSource = new Database().SelectData("monDaDKy", lst);
        }

        private void btnDangKyMoi_Click(object sender, EventArgs e)
        {
            new frmDangkyMonhoc(masv).ShowDialog();
            LoadMonDky();
        }
    }
}
