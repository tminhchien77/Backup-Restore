using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backup_restore
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtServer_Click(object sender, EventArgs e)
        {
            txtServer.BackColor= Color.White;
            pnlServer.BackColor= Color.White;
            pictureBoxServer.BackColor= Color.White;
            txtUser.BackColor= SystemColors.Control;
            pnlUser.BackColor = SystemColors.Control;
            pictureBoxUser.BackColor = SystemColors.Control;
            txtPwd.BackColor = SystemColors.Control;
            pnlPwd.BackColor = SystemColors.Control;
            pictureBoxPwd.BackColor = SystemColors.Control;
            pictureBoxEye.Visible = false;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtServer.BackColor = SystemColors.Control;
            pnlServer.BackColor = SystemColors.Control;
            pictureBoxServer.BackColor = SystemColors.Control;
            txtUser.BackColor = Color.White;
            pnlUser.BackColor = Color.White;
            pictureBoxUser.BackColor = Color.White;
            txtPwd.BackColor = SystemColors.Control;
            pnlPwd.BackColor = SystemColors.Control;
            pictureBoxPwd.BackColor = SystemColors.Control;
            pictureBoxEye.Visible = false;
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtServer.BackColor = SystemColors.Control;
            pnlServer.BackColor = SystemColors.Control;
            pictureBoxServer.BackColor = SystemColors.Control;
            txtUser.BackColor = SystemColors.Control;
            pnlUser.BackColor = SystemColors.Control;
            pictureBoxUser.BackColor = SystemColors.Control;
            txtPwd.BackColor = Color.White;
            pnlPwd.BackColor = Color.White;
            pictureBoxPwd.BackColor = Color.White;
            pictureBoxEye.Visible = true;
        }

        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = false;
        }

        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtServer.Text.Trim() == "")
            {
                MessageBox.Show("Tên SERVER không được rỗng.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtServer.Focus();
                return;
            }
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được rỗng.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtUser.Focus();
                return;
            }
            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được rỗng.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtPwd.Focus();
                return;
            }
            Program.servername = txtServer.Text;
            Program.username = txtUser.Text;
            Program.password = txtPwd.Text;

            if (Program.ConnectDB() <= 0) return;

            Program.conn.Close();

            FormMain frmMain = new FormMain();
            Hide();

            frmMain.ShowDialog();
            /*txt.Text = "";
            txtPass.Text = "";*/
            Show();
        }
    }
}
