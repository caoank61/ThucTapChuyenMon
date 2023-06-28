using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCM.Properties;

namespace TTCM
{
    public partial class Login : Form
    {
        public static string UserName = "";
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtusn.Text = "";
            txtpw.Text = "";
            txtpw.PasswordChar = '•';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusn.Text.Length == 0 || txtpw.Text.Length == 0)
            {
                MessageBox.Show("UserName hoặc PassWord rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                string strConn = "Data Source=DESKTOP-4SL06A4;Initial Catalog=SweetHome;Integrated Security=True";
                string username = txtusn.Text;
                string password = txtpw.Text;
                string sql = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            InfoWeather infoWeather = new InfoWeather();
                            MessageBox.Show("Welcome to Home Sweet Home!");
                            this.Hide();
                            infoWeather.ShowDialog();
                        }
                        else
                        {
                            // Sai thông tin đăng nhập
                            MessageBox.Show("Thông tin đăng nhập không hợp lệ!");
                        }

                    }
                }
            }
        }

        private void pbshowpw_Click(object sender, EventArgs e)
        {
            if (txtpw.PasswordChar == '\0')
            {
                // Nếu nút được check, hiển thị mật khẩu
                txtpw.PasswordChar = '•';
            }
            else
            {
                // Ngược lại, ẩn mật khẩu
                txtpw.PasswordChar = '\0';
            }
        }
    }
}
