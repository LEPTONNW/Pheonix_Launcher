namespace Pheonix_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CON_1 = new System.Windows.Forms.TextBox();
            this.START = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Under_Ground = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.START2 = new System.Windows.Forms.Button();
            this.Del_Log = new System.Windows.Forms.Button();
            this.Open_Folder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.G_Power = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.Incorrect = new System.Windows.Forms.Label();
            this.rejected = new System.Windows.Forms.Label();
            this.stales = new System.Windows.Forms.Label();
            this.Acc = new System.Windows.Forms.Label();
            this.TIME = new System.Windows.Forms.Label();
            this.Eth_Share = new System.Windows.Forms.Label();
            this.Eth_Speed = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CON_1
            // 
            this.CON_1.BackColor = System.Drawing.Color.Black;
            this.CON_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CON_1.Enabled = false;
            this.CON_1.ForeColor = System.Drawing.Color.Lime;
            this.CON_1.Location = new System.Drawing.Point(12, 263);
            this.CON_1.Multiline = true;
            this.CON_1.Name = "CON_1";
            this.CON_1.Size = new System.Drawing.Size(602, 590);
            this.CON_1.TabIndex = 4;
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.White;
            this.START.FlatAppearance.BorderSize = 0;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.START.Location = new System.Drawing.Point(627, 263);
            this.START.MaximumSize = new System.Drawing.Size(251, 78);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(251, 78);
            this.START.TabIndex = 3;
            this.START.Text = "전체GPU 채굴";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exit.Location = new System.Drawing.Point(855, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 28);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Under_Ground
            // 
            this.Under_Ground.FlatAppearance.BorderSize = 0;
            this.Under_Ground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Under_Ground.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Under_Ground.Location = new System.Drawing.Point(815, 1);
            this.Under_Ground.Name = "Under_Ground";
            this.Under_Ground.Size = new System.Drawing.Size(34, 28);
            this.Under_Ground.TabIndex = 6;
            this.Under_Ground.Text = "─";
            this.Under_Ground.UseVisualStyleBackColor = true;
            this.Under_Ground.Click += new System.EventHandler(this.Under_Ground_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pheonix Launcher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 206);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // START2
            // 
            this.START2.BackColor = System.Drawing.Color.White;
            this.START2.FlatAppearance.BorderSize = 0;
            this.START2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.START2.Location = new System.Drawing.Point(627, 347);
            this.START2.MaximumSize = new System.Drawing.Size(251, 78);
            this.START2.Name = "START2";
            this.START2.Size = new System.Drawing.Size(251, 78);
            this.START2.TabIndex = 18;
            this.START2.Text = "단일GPU 채굴";
            this.START2.UseVisualStyleBackColor = false;
            this.START2.Click += new System.EventHandler(this.START2_Click);
            // 
            // Del_Log
            // 
            this.Del_Log.BackColor = System.Drawing.Color.White;
            this.Del_Log.FlatAppearance.BorderSize = 0;
            this.Del_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_Log.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Del_Log.Location = new System.Drawing.Point(627, 441);
            this.Del_Log.MaximumSize = new System.Drawing.Size(251, 78);
            this.Del_Log.Name = "Del_Log";
            this.Del_Log.Size = new System.Drawing.Size(128, 54);
            this.Del_Log.TabIndex = 19;
            this.Del_Log.Text = "로그삭제";
            this.Del_Log.UseVisualStyleBackColor = false;
            this.Del_Log.Click += new System.EventHandler(this.Del_Log_Click);
            // 
            // Open_Folder
            // 
            this.Open_Folder.BackColor = System.Drawing.Color.White;
            this.Open_Folder.FlatAppearance.BorderSize = 0;
            this.Open_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_Folder.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Open_Folder.Location = new System.Drawing.Point(750, 441);
            this.Open_Folder.MaximumSize = new System.Drawing.Size(251, 78);
            this.Open_Folder.Name = "Open_Folder";
            this.Open_Folder.Size = new System.Drawing.Size(128, 54);
            this.Open_Folder.TabIndex = 20;
            this.Open_Folder.Text = "폴더열기";
            this.Open_Folder.UseVisualStyleBackColor = false;
            this.Open_Folder.Click += new System.EventHandler(this.Open_Folder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.G_Power);
            this.groupBox1.Controls.Add(this.percentage);
            this.groupBox1.Controls.Add(this.Incorrect);
            this.groupBox1.Controls.Add(this.rejected);
            this.groupBox1.Controls.Add(this.stales);
            this.groupBox1.Controls.Add(this.Acc);
            this.groupBox1.Controls.Add(this.TIME);
            this.groupBox1.Controls.Add(this.Eth_Share);
            this.groupBox1.Controls.Add(this.Eth_Speed);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(627, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 284);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "모니터";
            // 
            // G_Power
            // 
            this.G_Power.AutoSize = true;
            this.G_Power.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.G_Power.Location = new System.Drawing.Point(16, 104);
            this.G_Power.Name = "G_Power";
            this.G_Power.Size = new System.Drawing.Size(147, 17);
            this.G_Power.TabIndex = 26;
            this.G_Power.Text = "GPU전력사용량: 0 W";
            this.G_Power.Click += new System.EventHandler(this.G_Power_Click);
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.percentage.Location = new System.Drawing.Point(16, 199);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(159, 17);
            this.percentage.TabIndex = 25;
            this.percentage.Text = "stales percentage: 0%";
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Incorrect.Location = new System.Drawing.Point(16, 250);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(131, 17);
            this.Incorrect.TabIndex = 24;
            this.Incorrect.Text = "Incorrect shares: 0";
            // 
            // rejected
            // 
            this.rejected.AutoSize = true;
            this.rejected.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rejected.Location = new System.Drawing.Point(16, 225);
            this.rejected.Name = "rejected";
            this.rejected.Size = new System.Drawing.Size(126, 17);
            this.rejected.TabIndex = 23;
            this.rejected.Text = "rejected shares: 0";
            // 
            // stales
            // 
            this.stales.AutoSize = true;
            this.stales.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stales.Location = new System.Drawing.Point(16, 174);
            this.stales.Name = "stales";
            this.stales.Size = new System.Drawing.Size(63, 17);
            this.stales.TabIndex = 22;
            this.stales.Text = "stales: 0";
            // 
            // Acc
            // 
            this.Acc.AutoSize = true;
            this.Acc.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Acc.Location = new System.Drawing.Point(16, 149);
            this.Acc.Name = "Acc";
            this.Acc.Size = new System.Drawing.Size(136, 17);
            this.Acc.TabIndex = 21;
            this.Acc.Text = "Accepted shares: 0";
            // 
            // TIME
            // 
            this.TIME.AutoSize = true;
            this.TIME.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TIME.Location = new System.Drawing.Point(16, 37);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(82, 17);
            this.TIME.TabIndex = 20;
            this.TIME.Text = "가동시간: 0";
            this.TIME.Click += new System.EventHandler(this.TIME_Click);
            // 
            // Eth_Share
            // 
            this.Eth_Share.AutoSize = true;
            this.Eth_Share.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Eth_Share.Location = new System.Drawing.Point(16, 82);
            this.Eth_Share.Name = "Eth_Share";
            this.Eth_Share.Size = new System.Drawing.Size(102, 17);
            this.Eth_Share.TabIndex = 19;
            this.Eth_Share.Text = "총 쉐어: 0/0/0";
            this.Eth_Share.Click += new System.EventHandler(this.Eth_Share_Click);
            // 
            // Eth_Speed
            // 
            this.Eth_Speed.AutoSize = true;
            this.Eth_Speed.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Eth_Speed.Location = new System.Drawing.Point(16, 59);
            this.Eth_Speed.Name = "Eth_Speed";
            this.Eth_Speed.Size = new System.Drawing.Size(82, 17);
            this.Eth_Speed.TabIndex = 18;
            this.Eth_Speed.Text = "채굴속도: 0";
            this.Eth_Speed.Click += new System.EventHandler(this.Eth_Speed_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(627, 791);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 62);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "바로가기";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(159, 20);
            this.btn3.MaximumSize = new System.Drawing.Size(251, 78);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 29);
            this.btn3.TabIndex = 25;
            this.btn3.Text = "업비트";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(85, 20);
            this.btn2.MaximumSize = new System.Drawing.Size(251, 78);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 29);
            this.btn2.TabIndex = 24;
            this.btn2.Text = "채산성";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(11, 20);
            this.btn1.MaximumSize = new System.Drawing.Size(251, 78);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 29);
            this.btn1.TabIndex = 23;
            this.btn1.Text = "마풀허";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "트레이 아이콘으로 최소화됩니다.";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Pheonix Launcher";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 873);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Open_Folder);
            this.Controls.Add(this.Del_Log);
            this.Controls.Add(this.START2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Under_Ground);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CON_1);
            this.Controls.Add(this.START);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pheonix_Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CON_1;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Under_Ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button START2;
        private System.Windows.Forms.Button Del_Log;
        private System.Windows.Forms.Button Open_Folder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label G_Power;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.Label rejected;
        private System.Windows.Forms.Label stales;
        private System.Windows.Forms.Label Acc;
        private System.Windows.Forms.Label TIME;
        private System.Windows.Forms.Label Eth_Share;
        private System.Windows.Forms.Label Eth_Speed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

