namespace CheckEnglish
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.boxCauHoi = new System.Windows.Forms.GroupBox();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.boxTraLoi = new System.Windows.Forms.GroupBox();
            this.lbDapAnDung = new System.Windows.Forms.Label();
            this.awD = new System.Windows.Forms.RadioButton();
            this.awC = new System.Windows.Forms.RadioButton();
            this.awB = new System.Windows.Forms.RadioButton();
            this.awA = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDapAnDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChonDe = new System.Windows.Forms.ComboBox();
            this.boxThongKe = new System.Windows.Forms.GroupBox();
            this.lbPhe = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbThoiGianHoanThanh = new System.Windows.Forms.Label();
            this.lbDaTraLoi = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbTimeRemaing = new System.Windows.Forms.Label();
            this.lbTongCauHoi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLogout = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbCsdl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolAdmin = new System.Windows.Forms.ToolStripDropDownButton();
            this.thêmCâuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReset = new System.Windows.Forms.Button();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.boxCauHoi.SuspendLayout();
            this.boxTraLoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.boxThongKe.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxCauHoi
            // 
            this.boxCauHoi.Controls.Add(this.lbCauHoi);
            this.boxCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCauHoi.Location = new System.Drawing.Point(12, 153);
            this.boxCauHoi.Name = "boxCauHoi";
            this.boxCauHoi.Size = new System.Drawing.Size(627, 145);
            this.boxCauHoi.TabIndex = 0;
            this.boxCauHoi.TabStop = false;
            this.boxCauHoi.Text = "Câu hỏi";
            this.boxCauHoi.Visible = false;
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Location = new System.Drawing.Point(7, 21);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(95, 16);
            this.lbCauHoi.TabIndex = 0;
            this.lbCauHoi.Text = "I spoke to ____";
            // 
            // txtDebug
            // 
            this.txtDebug.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebug.Location = new System.Drawing.Point(336, 65);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(78, 39);
            this.txtDebug.TabIndex = 5;
            this.txtDebug.Visible = false;
            // 
            // boxTraLoi
            // 
            this.boxTraLoi.Controls.Add(this.button1);
            this.boxTraLoi.Controls.Add(this.lbDapAnDung);
            this.boxTraLoi.Controls.Add(this.txtDebug);
            this.boxTraLoi.Controls.Add(this.awD);
            this.boxTraLoi.Controls.Add(this.btnOK);
            this.boxTraLoi.Controls.Add(this.awC);
            this.boxTraLoi.Controls.Add(this.awB);
            this.boxTraLoi.Controls.Add(this.awA);
            this.boxTraLoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTraLoi.Location = new System.Drawing.Point(645, 153);
            this.boxTraLoi.Name = "boxTraLoi";
            this.boxTraLoi.Size = new System.Drawing.Size(666, 145);
            this.boxTraLoi.TabIndex = 1;
            this.boxTraLoi.TabStop = false;
            this.boxTraLoi.Text = "Chọn câu trả lời";
            this.boxTraLoi.Visible = false;
            // 
            // lbDapAnDung
            // 
            this.lbDapAnDung.AutoSize = true;
            this.lbDapAnDung.Location = new System.Drawing.Point(344, 40);
            this.lbDapAnDung.Name = "lbDapAnDung";
            this.lbDapAnDung.Size = new System.Drawing.Size(70, 16);
            this.lbDapAnDung.TabIndex = 4;
            this.lbDapAnDung.Text = "dapandung";
            this.lbDapAnDung.Visible = false;
            // 
            // awD
            // 
            this.awD.AutoSize = true;
            this.awD.Location = new System.Drawing.Point(19, 110);
            this.awD.Name = "awD";
            this.awD.Size = new System.Drawing.Size(75, 20);
            this.awD.TabIndex = 3;
            this.awD.Text = "đáp án a";
            this.awD.UseVisualStyleBackColor = true;
            // 
            // awC
            // 
            this.awC.AutoSize = true;
            this.awC.Location = new System.Drawing.Point(19, 84);
            this.awC.Name = "awC";
            this.awC.Size = new System.Drawing.Size(75, 20);
            this.awC.TabIndex = 2;
            this.awC.Text = "đáp án a";
            this.awC.UseVisualStyleBackColor = true;
            // 
            // awB
            // 
            this.awB.AutoSize = true;
            this.awB.Location = new System.Drawing.Point(19, 58);
            this.awB.Name = "awB";
            this.awB.Size = new System.Drawing.Size(75, 20);
            this.awB.TabIndex = 1;
            this.awB.Text = "đáp án a";
            this.awB.UseVisualStyleBackColor = true;
            // 
            // awA
            // 
            this.awA.AutoSize = true;
            this.awA.Checked = true;
            this.awA.Location = new System.Drawing.Point(19, 32);
            this.awA.Name = "awA";
            this.awA.Size = new System.Drawing.Size(75, 20);
            this.awA.TabIndex = 0;
            this.awA.TabStop = true;
            this.awA.Text = "đáp án a";
            this.awA.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ColCauHoi,
            this.ColDapAn,
            this.ColDapAnDung,
            this.ColDiem});
            this.dataGridView1.Location = new System.Drawing.Point(10, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 375);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 20F;
            this.STT.HeaderText = "#";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // ColCauHoi
            // 
            this.ColCauHoi.FillWeight = 250F;
            this.ColCauHoi.HeaderText = "Câu hỏi";
            this.ColCauHoi.Name = "ColCauHoi";
            this.ColCauHoi.ReadOnly = true;
            // 
            // ColDapAn
            // 
            this.ColDapAn.FillWeight = 50F;
            this.ColDapAn.HeaderText = "Đáp án của bạn";
            this.ColDapAn.Name = "ColDapAn";
            this.ColDapAn.ReadOnly = true;
            // 
            // ColDapAnDung
            // 
            this.ColDapAnDung.FillWeight = 50F;
            this.ColDapAnDung.HeaderText = "Đáp án đúng";
            this.ColDapAnDung.Name = "ColDapAnDung";
            this.ColDapAnDung.ReadOnly = true;
            // 
            // ColDiem
            // 
            this.ColDiem.FillWeight = 50F;
            this.ColDiem.HeaderText = "Điểm nhận được";
            this.ColDiem.Name = "ColDiem";
            this.ColDiem.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1300, 358);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đáp án của bạn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonReset);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cbChonDe);
            this.groupBox4.Controls.Add(this.boxThongKe);
            this.groupBox4.Controls.Add(this.lbThoiGianHoanThanh);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.lbDaTraLoi);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.lbTongCauHoi);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1299, 135);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin bài";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(930, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chọn đề:";
            // 
            // cbChonDe
            // 
            this.cbChonDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonDe.FormattingEnabled = true;
            this.cbChonDe.Location = new System.Drawing.Point(995, 16);
            this.cbChonDe.Name = "cbChonDe";
            this.cbChonDe.Size = new System.Drawing.Size(210, 24);
            this.cbChonDe.TabIndex = 10;
            this.cbChonDe.SelectedIndexChanged += new System.EventHandler(this.cbChonDe_SelectedIndexChanged);
            // 
            // boxThongKe
            // 
            this.boxThongKe.Controls.Add(this.lbPhe);
            this.boxThongKe.Controls.Add(this.picStatus);
            this.boxThongKe.Controls.Add(this.lbDiem);
            this.boxThongKe.Controls.Add(this.pictureBox2);
            this.boxThongKe.Location = new System.Drawing.Point(241, 18);
            this.boxThongKe.Name = "boxThongKe";
            this.boxThongKe.Size = new System.Drawing.Size(432, 86);
            this.boxThongKe.TabIndex = 9;
            this.boxThongKe.TabStop = false;
            this.boxThongKe.Text = "Thống kê";
            this.boxThongKe.Visible = false;
            // 
            // lbPhe
            // 
            this.lbPhe.AutoSize = true;
            this.lbPhe.Font = new System.Drawing.Font("Tahoma", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhe.Location = new System.Drawing.Point(256, 22);
            this.lbPhe.Name = "lbPhe";
            this.lbPhe.Size = new System.Drawing.Size(88, 54);
            this.lbPhe.TabIndex = 3;
            this.lbPhe.Text = "Tốt";
            this.lbPhe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Tahoma", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(74, 22);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(48, 54);
            this.lbDiem.TabIndex = 1;
            this.lbDiem.Text = "0";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbThoiGianHoanThanh
            // 
            this.lbThoiGianHoanThanh.AutoSize = true;
            this.lbThoiGianHoanThanh.Location = new System.Drawing.Point(165, 88);
            this.lbThoiGianHoanThanh.Name = "lbThoiGianHoanThanh";
            this.lbThoiGianHoanThanh.Size = new System.Drawing.Size(14, 16);
            this.lbThoiGianHoanThanh.TabIndex = 8;
            this.lbThoiGianHoanThanh.Text = "0";
            this.lbThoiGianHoanThanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDaTraLoi
            // 
            this.lbDaTraLoi.AutoSize = true;
            this.lbDaTraLoi.Location = new System.Drawing.Point(165, 62);
            this.lbDaTraLoi.Name = "lbDaTraLoi";
            this.lbDaTraLoi.Size = new System.Drawing.Size(14, 16);
            this.lbDaTraLoi.TabIndex = 7;
            this.lbDaTraLoi.Text = "0";
            this.lbDaTraLoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbTimeRemaing);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(693, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 86);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thời gian còn lại (giây)";
            // 
            // lbTimeRemaing
            // 
            this.lbTimeRemaing.AutoSize = true;
            this.lbTimeRemaing.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRemaing.Location = new System.Drawing.Point(49, 19);
            this.lbTimeRemaing.Name = "lbTimeRemaing";
            this.lbTimeRemaing.Size = new System.Drawing.Size(146, 58);
            this.lbTimeRemaing.TabIndex = 0;
            this.lbTimeRemaing.Text = "00:00";
            this.lbTimeRemaing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTongCauHoi
            // 
            this.lbTongCauHoi.AutoSize = true;
            this.lbTongCauHoi.Location = new System.Drawing.Point(164, 37);
            this.lbTongCauHoi.Name = "lbTongCauHoi";
            this.lbTongCauHoi.Size = new System.Drawing.Size(14, 16);
            this.lbTongCauHoi.TabIndex = 6;
            this.lbTongCauHoi.Text = "0";
            this.lbTongCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng thời gian làm bài:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Câu hỏi đã trả lời:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số câu hỏi:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabel1.Text = "Chào mừng, ";
            // 
            // lbUser
            // 
            this.lbUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(40, 17);
            this.lbUser.Text = "name";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel2.Text = "- Chức vụ:";
            // 
            // lbRole
            // 
            this.lbRole.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(30, 17);
            this.lbRole.Text = "role";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel3.Text = " - ";
            // 
            // lblLogout
            // 
            this.lblLogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(63, 17);
            this.lblLogout.Text = "Đăng xuất";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel4.Text = " - ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(145, 17);
            this.toolStripStatusLabel5.Text = "Trạng thái kết nối CSDL: ";
            // 
            // lbCsdl
            // 
            this.lbCsdl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCsdl.Name = "lbCsdl";
            this.lbCsdl.Size = new System.Drawing.Size(30, 17);
            this.lbCsdl.Text = "csdl";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbUser,
            this.toolStripStatusLabel2,
            this.lbRole,
            this.toolStripStatusLabel3,
            this.lblLogout,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.lbCsdl,
            this.toolAdmin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1324, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Kiểm tra lại";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(483, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sửa câu trả lời";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(483, 84);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(165, 34);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Câu tiếp theo";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // toolAdmin
            // 
            this.toolAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmCâuHỏiToolStripMenuItem});
            this.toolAdmin.Image = ((System.Drawing.Image)(resources.GetObject("toolAdmin.Image")));
            this.toolAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdmin.Name = "toolAdmin";
            this.toolAdmin.Size = new System.Drawing.Size(29, 20);
            this.toolAdmin.Text = "toolStripDropDownButton1";
            // 
            // thêmCâuHỏiToolStripMenuItem
            // 
            this.thêmCâuHỏiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmCâuHỏiToolStripMenuItem.Image")));
            this.thêmCâuHỏiToolStripMenuItem.Name = "thêmCâuHỏiToolStripMenuItem";
            this.thêmCâuHỏiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.thêmCâuHỏiToolStripMenuItem.Text = "Quản lý câu hỏi";
            this.thêmCâuHỏiToolStripMenuItem.Click += new System.EventHandler(this.thêmCâuHỏiToolStripMenuItem_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.Location = new System.Drawing.Point(1211, 46);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(82, 80);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Kiểm tra lại";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonReset, "Nhấn vào đây để kiểm tra lại đề mới");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // picStatus
            // 
            this.picStatus.Location = new System.Drawing.Point(196, 22);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(55, 55);
            this.picStatus.TabIndex = 2;
            this.picStatus.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(995, 89);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(210, 37);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Dừng thi, nộp bài";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(995, 46);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(210, 37);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bắt đầu kiểm tra";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 726);
            this.Controls.Add(this.boxCauHoi);
            this.Controls.Add(this.boxTraLoi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check English - Phần mềm kiểm tra trắc nghiệm Tiếng Anh1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.boxCauHoi.ResumeLayout(false);
            this.boxCauHoi.PerformLayout();
            this.boxTraLoi.ResumeLayout(false);
            this.boxTraLoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.boxThongKe.ResumeLayout(false);
            this.boxThongKe.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxCauHoi;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.GroupBox boxTraLoi;
        private System.Windows.Forms.RadioButton awD;
        private System.Windows.Forms.RadioButton awC;
        private System.Windows.Forms.RadioButton awB;
        private System.Windows.Forms.RadioButton awA;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Label lbDapAnDung;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbTimeRemaing;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTongCauHoi;
        private System.Windows.Forms.Label lbThoiGianHoanThanh;
        private System.Windows.Forms.Label lbDaTraLoi;
        private System.Windows.Forms.GroupBox boxThongKe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label lbPhe;
        private System.Windows.Forms.PictureBox picStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbRole;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblLogout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lbCsdl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolAdmin;
        private System.Windows.Forms.ToolStripMenuItem thêmCâuHỏiToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbChonDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDapAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDapAnDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiem;
        private System.Windows.Forms.Button button1;
    }
}

