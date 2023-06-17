using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.ConstrainedExecution;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace CheckEnglish
{
    public partial class formMain : Form
    {

        List<CauHoi> cauHoiList = new List<CauHoi>();
        private int currentIndex = 0;
        private string path = Path.Combine(Environment.CurrentDirectory, @"Settings\account.json");
        private SQLiteConnection conn = new SQLiteConnection("Data Source=Database\\database.db");
        public formMain()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            conn.Open();
            
            if (!string.IsNullOrEmpty(Properties.Settings.Default.username) && !string.IsNullOrEmpty(Properties.Settings.Default.password))
            {
                ShowStatus();

                ShowListDe();
                cbChonDe.SelectedIndex = 0;
                HideCol();

            } else
            {
                new formLogin().ShowDialog();
            }
        }

        private void HideCol()
        {
            dataGridView1.Columns["ColDapAnDung"].Visible = false;
            dataGridView1.Columns["ColDiem"].Visible = false;
        }

        private void ShowCol()
        {
            dataGridView1.Columns["ColDapAnDung"].Visible = true;
            dataGridView1.Columns["ColDiem"].Visible = true;
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {
            string dapan;
            float diem;

            if (awA.Checked) {dapan = "A";} 
            else if (awB.Checked) { dapan = "B"; }
            else if (awC.Checked) { dapan = "C"; }
            else { dapan = "D"; }

            diem = (dapan.Trim() == lbDapAnDung.Text) ? (100/cauHoiList.Count) : 0;

            dataGridView1.Rows.Add(currentIndex, cauHoiList[currentIndex]._debai.ToString(), dapan, lbDapAnDung.Text, diem);

            NextQuest();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void NextQuest()
        {
            currentIndex++;
            if (currentIndex >= cauHoiList.Count)
            {
                //currentIndex = 0;
                btnOK.Enabled = false;
            }
                ShowQuest();
        }

        private void PreviousQuest()
        {
            currentIndex--;
            if (currentIndex >= cauHoiList.Count)
            {
                //currentIndex = 0;
                btnOK.Enabled = false;
            }
            ShowQuest();
        }

        private void ShowQuest()
        {
            //txtDebug.AppendText(cauHoiList[currentIndex]._debai.ToString() + "\r\n");
            if (currentIndex < cauHoiList.Count)
            {
                lbCauHoi.Text = $"Mã câu hỏi: #{currentIndex}: {cauHoiList[currentIndex]._debai.ToString()}";
                awA.Text = cauHoiList[currentIndex]._dapanA.ToString();
                awB.Text = cauHoiList[currentIndex]._dapanB.ToString();
                awC.Text = cauHoiList[currentIndex]._dapanC.ToString();
                awD.Text = cauHoiList[currentIndex]._dapanD.ToString();
                lbDapAnDung.Text = cauHoiList[currentIndex]._dapanDung.ToString().Trim();
            }

        }

        private void ShowStatus()
        {
            var sql = "SELECT * FROM taikhoan WHERE username = @user";
            try
            {
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.username.ToString());
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lbUser.Text = dt.Rows[0]["name"].ToString();
                lbCsdl.Text = "[OK]";
                lbCsdl.ForeColor = Color.Green;

                if (dt.Rows[0]["role"].ToString() == "1")
                {
                    lbRole.Text = "Quản trị viên";
                    lbRole.ForeColor = Color.FromArgb(192, 0, 0);
                    toolAdmin.Visible = true;
                }
                else
                {
                    lbRole.Text = "Thành viên";
                    toolAdmin.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
                throw;
            }
        }

        private void ShowListDe()
        {
            try
            {
                var sqlGetMaDe = "SELECT * FROM bode";
                var cmd = new SQLiteCommand(sqlGetMaDe, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbChonDe.Invoke(new Action(() =>
                    {
                        cbChonDe.Items.Add("#" + reader.GetInt32(0) + " - " + reader.GetString(1));
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ ex);
            }
            finally { conn.Close(); }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();

                Application.Restart();
            }
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        static int time = 3000;
        static int remingTime = time;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            int iMin = (int)time / 60;
            int iSec = (int)time % 60;
            lbTimeRemaing.Text = $"{iMin.ToString("D2")}:{iSec.ToString("D2")}";

            if (time == 0)
            {
                DungThi();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cauHoiList.Count > 0)
            {
                ShowQuest();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                btnOK.Enabled = true;

                timer1.Enabled = true;

                boxCauHoi.Visible = true;
                boxTraLoi.Visible = true;
            }
            else
            {
                MessageBox.Show("Bộ đề này tạm thời chưa có câu hỏi, hãy chọn lại bộ đề khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            DialogResult isStop = MessageBox.Show("Bạn chắc chắn muốn dừng thi và nộp bài?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isStop == DialogResult.Yes)
            {
                btnOK.Enabled = false;
                timer1.Enabled = false;
                DungThi();
                boxThongKe.Visible = true;
            }
            
        }

        private void DungThi()
        {
            remingTime -= time;
            int iMin = (int)remingTime / 60;
            int iSec = (int)remingTime % 60;
            lbThoiGianHoanThanh.Text = $"{iMin.ToString("D2")}:{iSec.ToString("D2")}";

            lbTongCauHoi.Text = cauHoiList.Count.ToString();
            lbDaTraLoi.Text = dataGridView1.RowCount.ToString();

 
            int tempDiem = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tempDiem += Int32.Parse(dataGridView1.Rows[i].Cells["ColDiem"].Value.ToString());
            }
            lbDiem.Text = tempDiem.ToString();

            if (tempDiem > 90)
            {
                lbPhe.Text = "Good";
                picStatus.Image = Properties.Resources.good_quality_55px;
            } else if (tempDiem > 45)
            {
                lbPhe.Text = "Ok";
                picStatus.Image = Properties.Resources.smiling_55px;

            }
            else {
                lbPhe.Text = "Bad";
                picStatus.Image = Properties.Resources.sad_55px;
            }

            ShowCol();
        }

        private void thêmCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formThem().ShowDialog();
        }

        private void cbChonDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                var ma = Regex.Match(cbChonDe.Text, @"#(.*?) ").Groups[1].ToString();
                //MessageBox.Show(ma);
                var sqlCauHoi = "SELECT * FROM cauhoi WHERE made = @ma";
                var cmdCH = new SQLiteCommand(sqlCauHoi, conn);
                cmdCH.Parameters.AddWithValue("@ma", Convert.ToInt32(ma));
                var reader = cmdCH.ExecuteReader();

                cauHoiList.Clear();
                while (reader.Read())
                {
                    CauHoi cauHoi = new CauHoi(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    cauHoiList.Add(cauHoi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            finally { conn.Close(); }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private int rowIndex;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow index = dataGridView1.Rows[e.RowIndex];
                rowIndex = index.Index;
                lbCauHoi.Text = $"Mã câu hỏi: #{index.Cells["STT"].Value}: {index.Cells["ColCauHoi"].Value}";
                if (index.Cells["ColDapAn"].Value.ToString() == "A")
                {
                    awA.Checked = true;
                }
                else if (index.Cells["ColDapAn"].Value.ToString() == "B")
                {
                    awB.Checked = true;
                }
                else if (index.Cells["ColDapAn"].Value.ToString() == "C")
                {
                    awC.Checked = true;
                }
                else if (index.Cells["ColDapAn"].Value.ToString() == "D")
                {
                    awD.Checked = true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hãy chọn câu hỏi cần sửa đáp án!");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string dapan;
                float diem;

                if (awA.Checked) { dapan = "A"; }
                else if (awB.Checked) { dapan = "B"; }
                else if (awC.Checked) { dapan = "C"; }
                else { dapan = "D"; }

                diem = (dapan.Trim() == lbDapAnDung.Text) ? (100 / cauHoiList.Count) : 0;

                dataGridView1.Rows[rowIndex].Cells["ColDapAn"].Value = dapan;
                dataGridView1.Rows[rowIndex].Cells["ColDiem"].Value = diem;
            }
            else
            {
                MessageBox.Show("Chọn câu hỏi cần sửa!");
            }
        }
    }
}
