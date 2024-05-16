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
    public partial class frmQuanLyLop : Form
    {
        public frmQuanLyLop(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private void LoadDSLop()
        {
            List<CustomParameter> firstPara = new List<CustomParameter>();
            firstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = mgv
            });
            firstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });
            dgvDSLop.DataSource = new Database().SelectData("tracuulop", firstPara);
        }

        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadDSLop();
            dgvDSLop.Columns["malophoc"].HeaderText = "Mã lớp";
            dgvDSLop.Columns["mamonhoc"].HeaderText = "Mã môn";
            dgvDSLop.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLop.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSLop.Columns["siso"].HeaderText = "Sỉ số";
            
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadDSLop();
        }
    }
}
