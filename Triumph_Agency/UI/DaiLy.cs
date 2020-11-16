using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.DAL;

namespace UI
{
    public partial class DaiLy : Form
    {
        private QuanLyDaiLyEntities db = new QuanLyDaiLyEntities();

        public DaiLy()
        {
            InitializeComponent();
        }

        private void LoadDaiLy()
        {
            var dsDaiLy = from daily in db.DAILies
                           select new { MaDaiLy = daily.MaDaiLy, TenDaiLy = daily.TenDaiLy, MaLoaiDL = daily.MaLoaiDL, SDT = daily.SDT, DiaChi = daily.DiaChi, Quan = daily.Quan, Email = daily.Email, NgayTiepNhan = daily.NgayTiepNhan, TienNo = daily.TienNo, QuanPOS = daily.QuanPOS};
            dgvDaiLy.DataSource = dsDaiLy.ToList();

            AddDaiLyBinding();
        }

        private void AddDaiLyBinding()
        {
            txtMaDaiLy.DataBindings.Clear();
            txtTenDaiLy.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtTienNo.DataBindings.Clear();
            cbbMaLoaiDaiLy.DataBindings.Clear();
            cbbQuan.DataBindings.Clear();
            cbbQuanOrdinal.DataBindings.Clear();
            dtNgayTiepNhan.DataBindings.Clear();

            txtMaDaiLy.DataBindings.Add("Text",dgvDaiLy.DataSource,"MaDaiLy");
            txtTenDaiLy.DataBindings.Add("Text", dgvDaiLy.DataSource, "TenDaiLy");
            txtSDT.DataBindings.Add("Text", dgvDaiLy.DataSource, "SDT");
            txtDiaChi.DataBindings.Add("Text", dgvDaiLy.DataSource, "DiaChi");
            txtEmail.DataBindings.Add("Text", dgvDaiLy.DataSource, "Email");
            txtTienNo.DataBindings.Add("Text", dgvDaiLy.DataSource, "TienNo");
        }

        private void ChangeGridViewHeaderName()
        {
            dgvDaiLy.Columns[0].HeaderText = "Mã Đại Lý";
            dgvDaiLy.Columns[1].HeaderText = "Tên Đại Lý";
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(txtMaDaiLy.Text == "" && txtDiaChi.Text == "" && txtEmail.Text == "" && txtSDT.Text == "" && txtTenDaiLy.Text == "" && txtTienNo.Text == "" && cbbMaLoaiDaiLy.Text =="" && cbbQuan.Text == "" && cbbQuanOrdinal.Text == "")
            {

            }
            else
            {
                txtMaDaiLy.Clear();
                txtDiaChi.Clear();
                txtEmail.Clear();
                txtSDT.Clear();
                txtTenDaiLy.Clear();
                txtTienNo.Clear();
                cbbQuanOrdinal.ResetText();
                cbbQuan.ResetText();
                cbbMaLoaiDaiLy.ResetText();
                MessageBox.Show("Làm mới thành công", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaDaiLy = txtMaDaiLy.Text;
            string TenDaiLy = txtTenDaiLy.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            string MaLoaiDaiLy = cbbMaLoaiDaiLy.Text;
            string Quan = cbbQuan.Text;
            string QuanOrdinal = cbbQuanOrdinal.Text;
            string NgayTiepNhan = dtNgayTiepNhan.Text;


            DAILY daily = db.DAILies.Where(l => l.MaDaiLy == MaDaiLy).SingleOrDefault();

            if (daily != null)
            {
                MessageBox.Show("Mã Lớp Học Đã Tồn Tại");
                return;
            }
            else if (String.IsNullOrEmpty(MaDaiLy) || String.IsNullOrEmpty(TenDaiLy))
            {
                MessageBox.Show("Không Được Để Tên Lớp Trống");
                return;
            }
            else
            {
                daily = new DAILY();
                daily.MaDaiLy = MaDaiLy;
                daily.TenDaiLy = TenDaiLy;
                daily.MaLoaiDL = MaLoaiDaiLy;
                daily.SDT = SDT;
                daily.DiaChi = DiaChi;
                daily.Quan = Quan;
                daily.Email = Email;
                daily.QuanPOS = QuanOrdinal;
                db.DAILies.Add(daily);
                LoadDaiLy();
                MessageBox.Show("Thêm Lớp Học Mới Thành Công");
            }

        }
    }
}
