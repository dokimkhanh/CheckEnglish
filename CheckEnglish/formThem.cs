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

namespace CheckEnglish
{
    public partial class formThem : Form
    {
        List<CauHoi> cauHoiList = new List<CauHoi>();

        private int currentIndex = 0;
        private SQLiteConnection conn = new SQLiteConnection("Data Source=Database\\database.db");
        public formThem()
        {
            InitializeComponent();
        }

        private void LoadBoDe()
        {
            var sql = "SELECT * FROM bode";
            var cmd = new SQLiteCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            dgvDoDe.Rows.Clear();
            while (reader.Read())
            {
                dgvDoDe.Rows.Add(reader.GetInt32(0), reader.GetString(1));
            }
        }

        private void formThem_Load(object sender, EventArgs e)
        {
            #region BoDe
            try
            {
                conn.Open();
                LoadBoDe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test: " + ex);
            }
            finally { conn.Close(); }

            #endregion BoDe

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCauHoi.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCauhoi.Text = dgvCauHoi.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtA.Text = dgvCauHoi.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtB.Text = dgvCauHoi.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtC.Text = dgvCauHoi.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtD.Text = dgvCauHoi.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.SelectedItem = dgvCauHoi.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCauhoi.Text) || string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text) || string.IsNullOrEmpty(txtC.Text) || string.IsNullOrEmpty(txtD.Text))
            {
                MessageBox.Show("Điền đầy đủ thông tin câu hỏi","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            var sql = $"INSERT INTO cauhoi(id,made,noidung,awA,awB,awC,awD,awCorrect) VALUES (NULL, @made, @noidung, @a, @b, @c, @d, @correct);";
            try
            {
                conn.Open();
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@made", txtMaDe.Text);
                cmd.Parameters.AddWithValue("@noidung", txtCauhoi.Text);
                cmd.Parameters.AddWithValue("@a", txtA.Text);
                cmd.Parameters.AddWithValue("@b", txtB.Text);
                cmd.Parameters.AddWithValue("@c", txtC.Text);
                cmd.Parameters.AddWithValue("@d", txtD.Text);
                cmd.Parameters.AddWithValue("@correct", comboBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại, lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCauhoi.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvCauHoi.SelectedRows.Count == 0)
                return; // show a message here to inform

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string sql = "DELETE FROM cauhoi WHERE ID = @rowID";
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(sql, conn);
                    int selectedIndex = dgvCauHoi.SelectedRows[0].Index;
                    int rowID = Convert.ToInt32(dgvCauHoi[0, selectedIndex].Value);
                    cmd.Parameters.AddWithValue("@rowID", rowID);
                    cmd.ExecuteNonQuery();
                    dgvCauHoi.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá thất bại, lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
                return; // show a message here to inform

            var sql = $"UPDATE cauhoi SET noidung = @noidung, awA = @a, awB = @b, awC = @c, awD = @d, awCorrect = @correct WHERE id = @id;";
            try
            {
                conn.Open();
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);

                cmd.Parameters.AddWithValue("@noidung", txtCauhoi.Text);
                cmd.Parameters.AddWithValue("@a", txtA.Text);
                cmd.Parameters.AddWithValue("@b", txtB.Text);
                cmd.Parameters.AddWithValue("@c", txtC.Text);
                cmd.Parameters.AddWithValue("@d", txtD.Text);
                cmd.Parameters.AddWithValue("@correct", comboBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại, lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private void dgvDoDe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            #region CauHoi

            try
            {
                txtMaDe.Text = dgvDoDe.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDe.Text = dgvDoDe.Rows[e.RowIndex].Cells[1].Value.ToString();

                conn.Open();

                dgvCauHoi.Rows.Clear();
                var sql = "SELECT * FROM cauhoi WHERE made = @ma";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", Int32.Parse(dgvDoDe.Rows[e.RowIndex].Cells[0].Value.ToString()));
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    dgvCauHoi.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            finally { conn.Close(); }

            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDe.Text))
                return; // show a message here to inform

            var sql = $"UPDATE bode SET name = @newname WHERE id = @id;";
            try
            {
                conn.Open();
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", txtMaDe.Text);
                cmd.Parameters.AddWithValue("@newname", txtTenDe.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin mã đề thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBoDe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại, lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDe.Text))
            {
                MessageBox.Show("Vui lòng điền thông tin bộ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sql = $"INSERT INTO bode(id,name) VALUES (NULL, @name);";
            try
            {
                conn.Open();
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtTenDe.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mã đề mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBoDe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mã đề mới thất bại, lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            finally { conn.Close(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvDoDe.SelectedRows.Count == 0)
                return; // show a message here to inform

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá mã đề này? Tất cả các câu hỏi ở mã đề này sẽ bị xoá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string sql = "DELETE FROM bode WHERE ID = @rowID";
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(sql, conn);
                    int selectedIndex = dgvDoDe.SelectedRows[0].Index;
                    int rowID = Convert.ToInt32(dgvDoDe[0, selectedIndex].Value);
                    cmd.Parameters.AddWithValue("@rowID", rowID);
                    cmd.ExecuteNonQuery();
                    dgvDoDe.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show("Xoá mã đề thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá thất bại, lỗi: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
            
        }
    }
}
