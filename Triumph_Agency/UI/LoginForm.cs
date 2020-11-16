using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.UserLogin;

namespace UI
{
    public partial class LoginForm : Form
    {
        int mov;
        int movX;
        int movY;

        public LoginForm()
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Nhập ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.White;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "Nhập ID";
                txtID.ForeColor = Color.DimGray;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.FromArgb(25, 30, 39);
                checkBox1.Image = UI.Properties.Resources.visible_32;
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                checkBox1.BackColor = Color.FromArgb(25, 30, 39);
                checkBox1.Image = UI.Properties.Resources.eye_3_32;
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Nhập Password")
            {                    
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;
                checkBox1.Image = UI.Properties.Resources.eye_3_32;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Nhập Password";
                txtPass.ForeColor = Color.DimGray;
                checkBox1.Image = UI.Properties.Resources.visible_32;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "Nhập ID")
            {
                if (txtPass.Text != "Nhập Password")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginID(txtID.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        Manage mng = new Manage();
                        mng.Show();
                        MessageBox.Show(UserCache.Position + " : " + UserCache.LastName + " " + UserCache.FirstName + " " + "truy cập","Quản Lý TRIUMPH-MOTOCYCLES",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        mng.FormClosed += Logout;
                        this.Hide();
                    }
                    else msgError("ID Hoặc Mật Khẩu Không Đúng.");
                    txtID.Clear();
                    txtPass.Clear();
                    txtPass.UseSystemPasswordChar = true;
                    checkBox1.Image = UI.Properties.Resources.eye_3_32;
                    txtID.Focus();
                }
                else msgError("Không Được Để Trống Password");
            }
            else msgError("Không Được Để Trống ID");


        }
        private void msgError(string msg)
        {
            lblMsgError.Text = "      " + msg;
            lblMsgError.Visible = true;
        }

        private void Logout (object sender,FormClosedEventArgs e)
        {
            txtID.Text = "Nhập ID";
            txtPass.Text = "Nhập Password";
            txtPass.UseSystemPasswordChar = false;
            checkBox1.Image = UI.Properties.Resources.visible_32;
            lblMsgError.Visible = false;
            this.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
