using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LC_forChinaValorantForms
{
    public partial class Form1 : Form
    {
        bool On;
        Point Pos;

        public Form1()
        {
            InitializeComponent();

            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };

            DirectoryInfo di = new DirectoryInfo("Paks");
            if (!di.Exists)
            {
                di.Create();
                MessageBox.Show("사용 전 read me를 읽어주세요.", "Lang Changer Made By Likegravity");
            }
            label2.Text = "idle";
            //파일 cpath 없으면 만들기
            FileInfo fi = new FileInfo("CPath");
            if (fi.Exists) 
            {
                guna2TextBox1.Text = File.ReadAllText(fi.FullName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Working.";
            //chinaGameFolder == 원래게임폴더경로  (C:\Tencent Games\VALORANT\live\ShooterGame\Content\Paks)
            string chinaGameFolder = guna2TextBox1.Text;
            // koreanGameFolder == 걍 한국발로 폴더 (C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks)
            string ENGameFolder = System.Environment.CurrentDirectory + "\\Paks";

            if (chinaGameFolder == "")
            {
                MessageBox.Show("중국발로란트 폴더의 경로를 설정해주세요.", "Lang Changer Made By Likegravity");
                label2.Text = "Idle";
                return;
            }


            //원래 짱깨파일을 짱깨파일 2로 이름변환을 해놓고 유지하려했는데, 굳이?라는생각이듬. 어차피 클라이언트 런쳐에서 손상파일자동보정해줌 ㅇ
            //그래서 그냥 파일 삭제하기로 진행함.
            label2.Text = "Working..";
            try
            {
                File.Delete(chinaGameFolder + "\\zh_CN_Audio-WindowsClient.pak");
                File.Delete(chinaGameFolder + "\\zh_CN_Audio-WindowsClient.sig");
                File.Delete(chinaGameFolder + "\\zh_CN_Text-WindowsClient.pak");
                File.Delete(chinaGameFolder + "\\zh_CN_Text-WindowsClient.sig");
                label2.Text = "Working...";
            }
            catch
            {
                MessageBox.Show("중국발로란트 파일의 경로설정이 잘못되었습니다.", "Lang Changer Made By Likegravity");
                label2.Text = "Idle";
                return;
            }

            //영어 언어파일을 불러서 중국파일로 이름 바꿔치기
            try
            {
                File.Copy(ENGameFolder + "\\en_US_Audio-WindowsClient.pak", chinaGameFolder + "\\zh_CN_Audio-WindowsClient.pak");
                File.Copy(ENGameFolder + "\\en_US_Audio-WindowsClient.sig", chinaGameFolder + "\\zh_CN_Audio-WindowsClient.sig");
                File.Copy(ENGameFolder + "\\en_US_Text-WindowsClient.pak", chinaGameFolder + "\\zh_CN_Text-WindowsClient.pak");
                File.Copy(ENGameFolder + "\\en_US_Text-WindowsClient.sig", chinaGameFolder + "\\zh_CN_Text-WindowsClient.sig");
                label2.Text = "Done!";

            }
            catch
            {
                MessageBox.Show("\"Paks\"폴더에 영어pak 파일이 없거나 이름이 잘못됨.", "Lang Changer Made By Likegravity");
                label2.Text = "Idle";
                return;
            }


            //여기서부터는 이전코드

            /*언어 설정파일 ex) en_US ko_KR
            string Lang = File.ReadAllText("Lang.txt");
            Console.WriteLine("");
            Console.WriteLine("[1] 실행");
            string read = Console.ReadLine();
            if (read == "1")
            {

            }
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //글자칸에 글자변경시 CPath 파일 계속 동기화(저장)
            File.WriteAllText("CPath", guna2TextBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
