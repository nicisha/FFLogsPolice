using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace FFLogsPolice
{
    public partial class FFLogsPolice : Form
    {
        public FFLogsPolice()
        {
            InitializeComponent();
            PlayerBox.Text = "楠木灯";
            ServerBox.Text = "神拳痕";
            Player2Box.Text = "雨茫茫";
            Server2Box.Text = "潮风亭";
            Player3Box.Text = "蓝花楹";
            Server3Box.Text = "旅人栈桥";
            Player4Box.Text = "白筱曦";
            Server4Box.Text = "神拳痕";
            Player5Box.Text = "鹭宫";
            Server5Box.Text = "神拳痕";
            Player6Box.Text = "一位小朋友";
            Server6Box.Text = "神拳痕";
            Player7Box.Text = "澄穆";
            Server7Box.Text = "神拳痕";
            Player8Box.Text = "伊安娜乔苏拿";
            Server8Box.Text = "神拳痕";
            StreamReader keyreader = new StreamReader("key.ini");
            KeyBox.Text = keyreader.ReadLine();
        }
        void SurveyPlayer()
        {
            string url = "https://www.fflogs.com/v1/parses/character/"
                + PlayerBox.Text + "/" + ServerBox.Text + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + KeyBox.Text;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);
            CParse p1s = player.FindParse(78);
            if (p1s == null)
            {
                player1raid1Box.Text = "无记录";
            }
            else
            {
                player1raid1Box.Text = p1s.percentile.ToString("0");
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player1raid2Box.Text = "无记录";
            }
            else
            {
                player1raid2Box.Text = p2s.percentile.ToString("0");
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player1raid3Box.Text = "无记录";
            }
            else
            {
                player1raid3Box.Text = p3s.percentile.ToString("0");
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player1raid4Box.Text = "无记录";
            }
            else
            {
                player1raid4Box.Text = p4s_1.percentile.ToString("0");
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player1raid5Box.Text = "无记录";
            }
            else
            {
                player1raid5Box.Text = p4s_2.percentile.ToString("0");
            }
        }
        void SurveyPlayer2()
        {
            string url = "https://www.fflogs.com/v1/parses/character/"
                + Player2Box.Text + "/" + Server2Box.Text + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + KeyBox.Text;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);
            CParse p1s = player.FindParse(78);
            if (p1s == null)
            {
                player2raid1Box.Text = "无记录";
            }
            else
            {
                player2raid1Box.Text = p1s.percentile.ToString("0");
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player2raid2Box.Text = "无记录";
            }
            else
            {
                player2raid2Box.Text = p2s.percentile.ToString("0");
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player2raid3Box.Text = "无记录";
            }
            else
            {
                player2raid3Box.Text = p3s.percentile.ToString("0");
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player2raid4Box.Text = "无记录";
            }
            else
            {
                player2raid4Box.Text = p4s_1.percentile.ToString("0");
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player2raid5Box.Text = "无记录";
            }
            else
            {
                player2raid5Box.Text = p4s_2.percentile.ToString("0");
            }
        }
        void SurveyPlayer3()
        {
            string url = "https://www.fflogs.com/v1/parses/character/"
                + Player3Box.Text + "/" + Server3Box.Text + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + KeyBox.Text;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);
            CParse p1s = player.FindParse(78);
            if (p1s == null)
            {
                player3raid1Box.Text = "无记录";
            }
            else
            {
                player3raid1Box.Text = p1s.percentile.ToString("0");
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player3raid2Box.Text = "无记录";
            }
            else
            {
                player3raid2Box.Text = p2s.percentile.ToString("0");
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player3raid3Box.Text = "无记录";
            }
            else
            {
                player3raid3Box.Text = p3s.percentile.ToString("0");
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player3raid4Box.Text = "无记录";
            }
            else
            {
                player3raid4Box.Text = p4s_1.percentile.ToString("0");
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player3raid5Box.Text = "无记录";
            }
            else
            {
                player3raid5Box.Text = p4s_2.percentile.ToString("0");
            }
        }
        void SurveyPlayer4()
        {
            string url = "https://www.fflogs.com/v1/parses/character/"
                + Player4Box.Text + "/" + Server4Box.Text + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + KeyBox.Text;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);
            CParse p1s = player.FindParse(78);
            if (p1s == null)
            {
                player4raid1Box.Text = "无记录";
            }
            else
            {
                player4raid1Box.Text = p1s.percentile.ToString("0");
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player4raid2Box.Text = "无记录";
            }
            else
            {
                player4raid2Box.Text = p2s.percentile.ToString("0");
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player4raid3Box.Text = "无记录";
            }
            else
            {
                player4raid3Box.Text = p3s.percentile.ToString("0");
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player4raid4Box.Text = "无记录";
            }
            else
            {
                player4raid4Box.Text = p4s_1.percentile.ToString("0");
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player4raid5Box.Text = "无记录";
            }
            else
            {
                player4raid5Box.Text = p4s_2.percentile.ToString("0");
            }
        }
        void SurveyPlayer5()
        {
            string url = "https://www.fflogs.com/v1/parses/character/"
                + Player5Box.Text + "/" + Server5Box.Text + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + KeyBox.Text;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);
            CParse p1s = player.FindParse(78);
            if (p1s == null)
            {
                player5raid1Box.Text = "无记录";
            }
            else
            {
                player5raid1Box.Text = p1s.percentile.ToString("0");
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player5raid2Box.Text = "无记录";
            }
            else
            {
                player5raid2Box.Text = p2s.percentile.ToString("0");
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player5raid3Box.Text = "无记录";
            }
            else
            {
                player5raid3Box.Text = p3s.percentile.ToString("0");
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player5raid4Box.Text = "无记录";
            }
            else
            {
                player5raid4Box.Text = p4s_1.percentile.ToString("0");
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player5raid5Box.Text = "无记录";
            }
            else
            {
                player5raid5Box.Text = p4s_2.percentile.ToString("0");
            }
        }
        void SurveyPlayer6()
        {
            string url = "https://www.fflogs.com/v1/parses/character/"
                + Player6Box.Text + "/" + Server6Box.Text + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + KeyBox.Text;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);
            CParse p1s = player.FindParse(78);
            if (p1s == null)
            {
                player6raid1Box.Text = "无记录";
            }
            else
            {
                player6raid1Box.Text = p1s.percentile.ToString("0");
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player6raid2Box.Text = "无记录";
            }
            else
            {
                player6raid2Box.Text = p2s.percentile.ToString("0");
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player6raid3Box.Text = "无记录";
            }
            else
            {
                player6raid3Box.Text = p3s.percentile.ToString("0");
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player6raid4Box.Text = "无记录";
            }
            else
            {
                player6raid4Box.Text = p4s_1.percentile.ToString("0");
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player6raid5Box.Text = "无记录";
            }
            else
            {
                player6raid5Box.Text = p4s_2.percentile.ToString("0");
            }
        }
        void SurveyPlayer7()
        {
            string url = "https://www.fflogs.com/v1/parses/character/"
                + Player7Box.Text + "/" + Server7Box.Text + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + KeyBox.Text;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);
            CParse p1s = player.FindParse(78);
            if (p1s == null)
            {
                player7raid1Box.Text = "无记录";
            }
            else
            {
                player7raid1Box.Text = p1s.percentile.ToString("0");
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player7raid2Box.Text = "无记录";
            }
            else
            {
                player7raid2Box.Text = p2s.percentile.ToString("0");
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player7raid3Box.Text = "无记录";
            }
            else
            {
                player7raid3Box.Text = p3s.percentile.ToString("0");
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player7raid4Box.Text = "无记录";
            }
            else
            {
                player7raid4Box.Text = p4s_1.percentile.ToString("0");
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player7raid5Box.Text = "无记录";
            }
            else
            {
                player7raid5Box.Text = p4s_2.percentile.ToString("0");
            }
        }
        void SurveyPlayer8()
        {
            string url = "https://www.fflogs.com/v1/parses/character/"
                + Player8Box.Text + "/" + Server8Box.Text + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + KeyBox.Text;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);
            CParse p1s = player.FindParse(78);
            if (p1s == null)
            {
                player8raid1Box.Text = "无记录";
            }
            else
            {
                player8raid1Box.Text = p1s.percentile.ToString("0");
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player8raid2Box.Text = "无记录";
            }
            else
            {
                player8raid2Box.Text = p2s.percentile.ToString("0");
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player8raid3Box.Text = "无记录";
            }
            else
            {
                player8raid3Box.Text = p3s.percentile.ToString("0");
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player8raid4Box.Text = "无记录";
            }
            else
            {
                player8raid4Box.Text = p4s_1.percentile.ToString("0");
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player8raid5Box.Text = "无记录";
            }
            else
            {
                player8raid5Box.Text = p4s_2.percentile.ToString("0");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ServerBox.Text.Length == 0)
                MessageBox.Show("请填写您的角色所在服务器");
            else
            {
                if (PlayerBox.Text.Length > 0)
                {
                    SurveyPlayer();
                }
                if (Player2Box.Text.Length > 0)
                {
                    if (Server2Box.Text.Length == 0)
                        Server2Box.Text = ServerBox.Text;
                    SurveyPlayer2();
                }
                if (Player3Box.Text.Length > 0)
                {
                    if (Server3Box.Text.Length == 0)
                        Server3Box.Text = ServerBox.Text;
                    SurveyPlayer3();
                }
                if (Player4Box.Text.Length > 0)
                {
                    if (Server4Box.Text.Length == 0)
                        Server4Box.Text = ServerBox.Text;
                    SurveyPlayer4();
                }
                if (Player5Box.Text.Length > 0)
                {
                    if (Server5Box.Text.Length == 0)
                        Server5Box.Text = ServerBox.Text;
                    SurveyPlayer5();
                }
                if (Player6Box.Text.Length > 0)
                {
                    if (Server6Box.Text.Length == 0)
                        Server6Box.Text = ServerBox.Text;
                    SurveyPlayer6();
                }
                if (Player7Box.Text.Length > 0)
                {
                    if (Server7Box.Text.Length == 0)
                        Server7Box.Text = ServerBox.Text;
                    SurveyPlayer7();
                }
                if (Player8Box.Text.Length > 0)
                {
                    if (Server8Box.Text.Length == 0)
                        Server8Box.Text = ServerBox.Text;
                    SurveyPlayer8();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cn.fflogs.com/profile");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("/e <1>:<2>:<3>:<4>:<5>:<6>:<7>:<8>");
            MessageBox.Show("复制完成");
        }
        private void Macro_Click(object sender, EventArgs e)
        {
            string rtn1 = "/p " + PlayerBox.Text + "@" + ServerBox.Text 
                + " P1S:" + player1raid1Box.Text 
                + " P2S:" + player1raid2Box.Text 
                + " P3S:" + player1raid3Box.Text 
                + " P4S门神:" + player1raid4Box.Text 
                + " P4S本体:" + player1raid5Box.Text + "\r\n";
            string rtn2 = "/p " + Player2Box.Text + "@" + Server2Box.Text 
                + " P1S:" + player2raid1Box.Text 
                + " P2S:" + player2raid2Box.Text 
                + " P3S:" + player2raid3Box.Text 
                + " P4S门神:" + player2raid4Box.Text 
                + " P4S本体:" + player2raid5Box.Text + "\r\n";
            string rtn3 = "/p " + Player3Box.Text + "@" + Server3Box.Text 
                + " P1S:" + player3raid1Box.Text 
                + " P2S:" + player3raid2Box.Text 
                + " P3S:" + player3raid3Box.Text 
                + " P4S门神4S:" + player3raid4Box.Text 
                + " P4S本体:" + player3raid5Box.Text + "\r\n";
            string rtn4 = "/p " + Player4Box.Text + "@" + Server4Box.Text 
                + " P1S:" + player4raid1Box.Text 
                + " P2S:" + player4raid2Box.Text 
                + " P3S:" + player4raid3Box.Text 
                + " P4S门神:" + player4raid4Box.Text 
                + " P4S本体:" + player4raid5Box.Text + "\r\n";
            string rtn5 = "/p " + Player5Box.Text + "@" + Server5Box.Text 
                + " P1S:" + player5raid1Box.Text 
                + " P2S:" + player5raid2Box.Text 
                + " P3S:" + player5raid3Box.Text 
                + " P4S门神:" + player5raid4Box.Text 
                + " P4S本体:" + player5raid5Box.Text + "\r\n";
            string rtn6 = "/p " + Player6Box.Text + "@" + Server6Box.Text 
                + " P1S:" + player6raid1Box.Text 
                + " P2S:" + player6raid2Box.Text 
                + " P3S:" + player6raid3Box.Text 
                + " P4S门神:" + player6raid4Box.Text 
                + " P4S本体:" + player6raid5Box.Text + "\r\n";
            string rtn7 = "/p " + Player7Box.Text + "@" + Server7Box.Text 
                + " P1S:" + player7raid1Box.Text 
                + " P2S:" + player7raid2Box.Text 
                + " P3S:" + player7raid3Box.Text 
                + " P4S门神:" + player7raid4Box.Text 
                + " P4S本体:" + player7raid5Box.Text + "\r\n";
            string rtn8 = "/p " + Player8Box.Text + "@" + Server8Box.Text 
                + " P1S:" + player8raid1Box.Text 
                + " P2S:" + player8raid2Box.Text 
                + " P3S:" + player8raid3Box.Text 
                + " P4S门神:" + player8raid4Box.Text 
                + " P4S本体:" + player8raid5Box.Text + "\r\n";
            string rtn = "/p FFLogs快查结果<se.1>\r\n" + rtn1 + rtn2 + rtn3 + rtn4 + rtn5 + rtn6 + rtn7 + rtn8;
            string msg = "宏已完成，点击确定复制进剪贴板\r\n" + rtn;
            MessageBox.Show(msg);
            Clipboard.SetText(rtn);
        }
    }
}
