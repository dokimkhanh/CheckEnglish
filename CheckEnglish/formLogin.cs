using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace CheckEnglish
{
    public partial class formLogin : Form
    {

        SQLiteConnection conn;
        private string path = Path.Combine(Environment.CurrentDirectory, @"Settings\account.json");
        public formLogin()
        {
            InitializeComponent();
        }
        private void formLogin_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=Database\\database.db");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                var sql = "SELECT * FROM taikhoan WHERE username = @user AND password = @pass";
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Chào mừng, " + dt.Rows[0]["name"].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Properties.Settings.Default.username = txtUsername.Text;
                        Properties.Settings.Default.password = txtPassword.Text;
                        Properties.Settings.Default.Save();


                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new formDangKy().ShowDialog();
        }
    }
}
