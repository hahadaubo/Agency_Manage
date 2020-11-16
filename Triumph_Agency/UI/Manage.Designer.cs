namespace UI
{
    partial class Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLog = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThutien = new System.Windows.Forms.Button();
            this.btnXuathang = new System.Windows.Forms.Button();
            this.btnMathang = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 132);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(695, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 73);
            this.label2.TabIndex = 7;
            this.label2.Text = "TRIUMPH-MOTORCYCLES";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(6, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(303, 61);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(107, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 28);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPos
            // 
            this.lblPos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.Color.White;
            this.lblPos.Location = new System.Drawing.Point(112, 71);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(197, 25);
            this.lblPos.TabIndex = 11;
            this.lblPos.Text = "Position";
            this.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 130);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnLog);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmail);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.lblPos);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnThutien);
            this.splitContainer1.Panel1.Controls.Add(this.btnXuathang);
            this.splitContainer1.Panel1.Controls.Add(this.btnMathang);
            this.splitContainer1.Panel1.Controls.Add(this.btnDaily);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1920, 950);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Image = global::UI.Properties.Resources.account_logout_48;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(6, 858);
            this.btnLog.Name = "btnLog";
            this.btnLog.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLog.Size = new System.Drawing.Size(303, 68);
            this.btnLog.TabIndex = 27;
            this.btnLog.Text = "Đăng Xuất";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::UI.Properties.Resources.chart_2_48;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(6, 668);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(303, 68);
            this.button5.TabIndex = 24;
            this.button5.Text = "Báo cáo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnThutien
            // 
            this.btnThutien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnThutien.FlatAppearance.BorderSize = 0;
            this.btnThutien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnThutien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThutien.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThutien.ForeColor = System.Drawing.Color.White;
            this.btnThutien.Image = global::UI.Properties.Resources.coins_48;
            this.btnThutien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThutien.Location = new System.Drawing.Point(6, 545);
            this.btnThutien.Name = "btnThutien";
            this.btnThutien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThutien.Size = new System.Drawing.Size(303, 68);
            this.btnThutien.TabIndex = 23;
            this.btnThutien.Text = "Thu tiền";
            this.btnThutien.UseVisualStyleBackColor = false;
            this.btnThutien.Click += new System.EventHandler(this.btnThutien_Click);
            // 
            // btnXuathang
            // 
            this.btnXuathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnXuathang.FlatAppearance.BorderSize = 0;
            this.btnXuathang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnXuathang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuathang.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuathang.ForeColor = System.Drawing.Color.White;
            this.btnXuathang.Image = global::UI.Properties.Resources.package_2_48;
            this.btnXuathang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuathang.Location = new System.Drawing.Point(6, 422);
            this.btnXuathang.Name = "btnXuathang";
            this.btnXuathang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnXuathang.Size = new System.Drawing.Size(303, 68);
            this.btnXuathang.TabIndex = 22;
            this.btnXuathang.Text = "Xuất hàng";
            this.btnXuathang.UseVisualStyleBackColor = false;
            this.btnXuathang.Click += new System.EventHandler(this.btnXuathang_Click);
            // 
            // btnMathang
            // 
            this.btnMathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.btnMathang.FlatAppearance.BorderSize = 0;
            this.btnMathang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnMathang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMathang.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMathang.ForeColor = System.Drawing.Color.White;
            this.btnMathang.Image = global::UI.Properties.Resources.motorcycle_48;
            this.btnMathang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMathang.Location = new System.Drawing.Point(6, 307);
            this.btnMathang.Name = "btnMathang";
            this.btnMathang.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMathang.Size = new System.Drawing.Size(303, 68);
            this.btnMathang.TabIndex = 21;
            this.btnMathang.Text = "Mặt hàng";
            this.btnMathang.UseVisualStyleBackColor = false;
            this.btnMathang.Click += new System.EventHandler(this.btnMathang_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.FlatAppearance.BorderSize = 0;
            this.btnDaily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.ForeColor = System.Drawing.Color.White;
            this.btnDaily.Image = global::UI.Properties.Resources.building_48;
            this.btnDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaily.Location = new System.Drawing.Point(6, 188);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDaily.Size = new System.Drawing.Size(303, 68);
            this.btnDaily.TabIndex = 20;
            this.btnDaily.Text = "Đại lý";
            this.btnDaily.UseVisualStyleBackColor = false;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnHide
            // 
            this.btnHide.Image = global::UI.Properties.Resources.minus_7_xxl;
            this.btnHide.Location = new System.Drawing.Point(1776, 46);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(40, 43);
            this.btnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHide.TabIndex = 10;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::UI.Properties.Resources.hiclipart_com;
            this.btnExit.Location = new System.Drawing.Point(1838, 46);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 43);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 9;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UI.Properties.Resources.logo_triumph;
            this.pictureBox2.Location = new System.Drawing.Point(496, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1604, 950);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(881, 98);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành Viên : Nguyễn Quốc Toàn - 18DH110214\r\n                        Bùi Trương Mạ" +
    "nh Thông - 18DH110723";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giảng Viên : Vũ Đình Ái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1259, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đồ Án Công Nghệ Phần Mềm : Quản Lý Các Đại Lý";
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1850, 950);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Manage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnThutien;
        private System.Windows.Forms.Button btnXuathang;
        private System.Windows.Forms.Button btnMathang;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.PictureBox btnHide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}