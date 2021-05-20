using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pheonix_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Thread PK;
        public Image img = new Bitmap(Properties.Resources.DR_OFF);
        public Image img2 = new Bitmap(Properties.Resources.DR_ON);
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("PhoenixMiner.exe"))
            {
                MessageBox.Show("Error : PhoenixMiner.exe 가 없습니다." + Environment.NewLine + "Phoenix_Launcher는 PhoenixMiner.exe가 있는 폴더에 같이 있어야 합니다.");
                try
                {
                    PK.Suspend();
                    PK.Abort();
                    Process[] proc = Process.GetProcessesByName("PhoenixMiner");
                    if (proc.Length > 0)
                    {
                        proc[0].Kill();
                    }

                    Application.ExitThread();
                    Application.Exit();
                    Environment.Exit(0);
                    Process.GetCurrentProcess().Kill();
                    this.Close();
                }
                catch
                {
                    Application.ExitThread();
                    Application.Exit();
                    Environment.Exit(0);
                    Process.GetCurrentProcess().Kill();
                    this.Close();
                }
            }
            else
            {
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.MaximizeBox = false;
            }
        }

        public ProcessStartInfo psi = new ProcessStartInfo();
        public Process proc = new Process();

        protected override void WndProc(ref Message m) //마우스 함수
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
        }
        private const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form
        public int CO = 0;
        private void START_Click(object sender, EventArgs e)
        {
            CO = 1;
            if (START.Text == "전체GPU 채굴")
            {
                START.Text = "채굴정지";
                START2.Enabled = false;
                START2.BackColor = Color.LightGray;
                PK = new Thread(new ThreadStart(Mining_Start));
                PK.Start();
                pictureBox1.Image = img2;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                START.Text = "전체GPU 채굴";
                START2.Enabled = true;
                START2.BackColor = Color.White;
                PK.Suspend();
                PK.Abort();
                Process[] proc = Process.GetProcessesByName("PhoenixMiner");
                if(proc.Length > 0)
                {
                    proc[0].Kill();
                }
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void START2_Click(object sender, EventArgs e)
        {
            CO = 2;
            if (START2.Text == "단일GPU 채굴")
            {
                START2.Text = "채굴정지";
                START.Enabled = false;
                START.BackColor = Color.LightGray;
                PK = new Thread(new ThreadStart(Mining_Start));
                PK.Start();
                pictureBox1.Image = img2;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                START2.Text = "단일GPU 채굴";
                START.Enabled = true;
                START.BackColor = Color.White;
                PK.Suspend();
                PK.Abort();
                Process[] proc = Process.GetProcessesByName("PhoenixMiner");
                if (proc.Length > 0)
                {
                    proc[0].Kill();
                }
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public static string txt = "";
        public void Mining_Start()
        {
            try
            {
                if (CO == 1)
                {
                    psi.FileName = @"GPU_Other.bat";
                }
                else
                {
                    psi.FileName = @"GPU1.bat";
                }
                psi.Arguments = "";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;


                proc.EnableRaisingEvents = false;
                proc = Process.Start(psi);

                while (true)
                {
                    txt = proc.StandardOutput.ReadLine(); // blocking 함수

                    if (txt == null) // 프로세스가 종료한 경우 null 반환
                    {
                        break;
                    }
                    
                    CON_1.AppendText(Environment.NewLine + txt);
                    Check();
                }
            }
            catch
            {

                CON_1.Text += "에러";
            }
        }

        void Check()
        {
            bool yn = txt.Contains("Eth speed"); //yn == true
            if(yn == true)
            {
                string[] arr_temp = txt.Split(' ');
                Eth_Speed.Text = "채굴속도: " + arr_temp[2] + arr_temp[3].Substring(0, arr_temp[3].Length - 1);

                Eth_Share.Text = "총 쉐어: " + arr_temp[5].Substring(0, arr_temp[5].Length - 1);

                TIME.Text = "가동시간: " + arr_temp[7];
            }

            bool yn2 = txt.Contains("GPUs power");
            if(yn2 == true)
            {
                string[] arr_temp2 = txt.Split(':');
                G_Power.Text = "GPU전력사용량:" + arr_temp2[1];
            }

            bool yn3 = txt.Contains("Accepted shares");
            if(yn3 == true)
            {
                string[] arr_temp3 = txt.Split(' ');
                Acc.Text = "Accepted shares: " + arr_temp3[3];

                string[] arr_temp3_1 = arr_temp3[4].Split('(');
                stales.Text = "stales: " + arr_temp3_1[1];

                rejected.Text = "rejected shares: " + arr_temp3[8];
            }

            bool yn4 = txt.Contains("Incorrect shares");
            if(yn4 == true)
            {
                string[] arr_temp4 = txt.Split(' ');
                Incorrect.Text = "Incorrect shares: " + arr_temp4[3];
                percentage.Text = "stales percentage: " + arr_temp4[8];
            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                PK.Suspend();
                PK.Abort();
                Process[] proc = Process.GetProcessesByName("PhoenixMiner");
                if (proc.Length > 0)
                {
                    proc[0].Kill();
                }

                Application.ExitThread();
                Application.Exit();
                Environment.Exit(0);
                Process.GetCurrentProcess().Kill();
                this.Close();
            }
            catch
            {
                Application.ExitThread();
                Application.Exit();
                Environment.Exit(0);
                Process.GetCurrentProcess().Kill();
                this.Close();
            }
        }

        private void Del_Log_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceDir = Directory.GetCurrentDirectory();
                string[] txtList = Directory.GetFiles(sourceDir, "*.txt");

                foreach (string f in txtList)
                {
                    File.Delete(f);
                }
                MessageBox.Show("삭제완료");
            }
            catch
            {
                MessageBox.Show("삭제완료");
            }
        }

        private void Open_Folder_Click(object sender, EventArgs e)
        {
            String filePath = Directory.GetCurrentDirectory();
            Process.Start(filePath);
        }

        private void G_Power_Click(object sender, EventArgs e)
        {

        }

        private void Eth_Share_Click(object sender, EventArgs e)
        {

        }

        private void Eth_Speed_Click(object sender, EventArgs e)
        {

        }

        private void TIME_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Process.Start("https://miningpoolhub.com/");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Process.Start("https://miningcalc.kr/miningpoolhub");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Process.Start("https://upbit.com/home");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                PK.Suspend();
                PK.Abort();
                Process[] proc = Process.GetProcessesByName("PhoenixMiner");
                if (proc.Length > 0)
                {
                    proc[0].Kill();
                }

                Application.ExitThread();
                Application.Exit();
                Environment.Exit(0);
                Process.GetCurrentProcess().Kill();
                this.Close();
            }
            catch
            {
                Application.ExitThread();
                Application.Exit();
                Environment.Exit(0);
                Process.GetCurrentProcess().Kill();
                this.Close();
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PK.Suspend();
                PK.Abort();
                Process[] proc = Process.GetProcessesByName("PhoenixMiner");
                if (proc.Length > 0)
                {
                    proc[0].Kill();
                }

                Application.ExitThread();
                Application.Exit();
                Environment.Exit(0);
                Process.GetCurrentProcess().Kill();
                this.Close();
            }
            catch
            {
                Application.ExitThread();
                Application.Exit();
                Environment.Exit(0);
                Process.GetCurrentProcess().Kill();
                this.Close();
            }
        }

        private void Under_Ground_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(3000);
            notifyIcon1.Visible = true;
            this.Hide();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
