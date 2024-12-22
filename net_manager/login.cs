using System;
using System.Windows.Forms;

namespace net_manager
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "admin" && txtMK.Text == "admin")
            {
                Main main = new Main();
                main.Show();
                this.Hide(); 
            }
            else
            {
                 MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
