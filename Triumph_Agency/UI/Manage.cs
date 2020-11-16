using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.UserLogin;

namespace UI
{
    public partial class Manage : Form
    {
        int mov;
        int movX;
        int movY;
        public Manage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn muốn đóng ứng dụng này? ", " Thoát ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (exit == DialogResult.No)
            {
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void FormInPanel(object formP)
        {
            if (this.splitContainer1.Panel2.Controls.Count > 0)
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            Form fh = formP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(fh);
            this.splitContainer1.Tag = fh;
            fh.Show();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            FormInPanel(new DaiLy());
        }

        private void btnMathang_Click(object sender, EventArgs e)
        {
            FormInPanel(new MatHang());

        }

        private void btnXuathang_Click(object sender, EventArgs e)
        {
            FormInPanel(new XuatHang());

        }

        private void btnThutien_Click(object sender, EventArgs e)
        {
            FormInPanel(new ThuTien());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            FormInPanel(new BaoCao());
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            lblName.Text = UserCache.LastName + " " + UserCache.FirstName;
            lblPos.Text = UserCache.Position;
            lblEmail.Text = UserCache.Email;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Bạn muốn thoát khỏi phiên làm việc này? ", " Đăng Xuất ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (log == DialogResult.Yes)
            {
                this.Close();
            }
            else if (log == DialogResult.No)
            {
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
