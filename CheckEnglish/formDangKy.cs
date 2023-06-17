using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CheckEnglish
{
    public partial class formDangKy : Form
    {

        private SQLiteConnection conn = new SQLiteConnection("Data Source=Database\\database.db");
        public formDangKy()
        {
            InitializeComponent();
        }

        private void formDangKy_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                var sql = "SELECT * FROM taikhoan WHERE username = @user";
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tài khoản, " + dt.Rows[0]["username"].ToString() + " đã tồn tại trong hệ thống, vui lòng chọn tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        try
                        {
                            var sqlInto = $"INSERT INTO taikhoan(id,username,password,name,role) VALUES (NULL, @username, @pass, @fullname, 0);";
                            var dangky = new SQLiteCommand(sqlInto, conn);
                            dangky.Parameters.AddWithValue("@username", txtUsername.Text);
                            dangky.Parameters.AddWithValue("@pass", txtPassword.Text);
                            dangky.Parameters.AddWithValue("@fullname", txtName.Text);
                            dangky.ExecuteNonQuery();
                            MessageBox.Show("Đăng ký tài khoản mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể đăng ký tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                    throw;
                }
                finally { conn.Close(); }
            }
            else { MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
    
}
