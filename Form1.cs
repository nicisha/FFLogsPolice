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
        public static string FFLogsV1Key;
        CPlayer[] cPlayers = new CPlayer[8];
        string[] ServerList = {"白银乡","白金幻象","神拳痕","潮风亭","旅人栈桥","拂晓之间","龙巢神殿","梦羽宝境"
                ,"红玉海","神意之地","拉诺西亚","幻影群岛","萌芽池","宇宙和音","沃仙曦染","晨曦王座"
                ,"紫水栈桥","延夏","静语庄园","摩杜纳","海猫茶屋","柔风海湾","琥珀原"
                ,"水晶塔","银泪湖","太阳海岸","伊修加德","红茶川"};
        public FFLogsPolice()
        {
            InitializeComponent();
            StreamReader keyreader = new StreamReader("key.ini");
            FFLogsV1Key = keyreader.ReadLine();
            KeyBox.Text = FFLogsV1Key;
        }
        void SurveyPlayer()
        {
            CPlayer player = new CPlayer();
            player.name = PlayerBox.Text;
            player.server = ServerBox.Text;
            if (!player.Survey())
                return;
            cPlayers[0] = player;
            player1raid1Box.Text = player.FindParseAndGetSpecPct(78);
            player1raid2Box.Text = player.FindParseAndGetSpecPct(79);
            player1raid3Box.Text = player.FindParseAndGetSpecPct(80);
            player1raid4Box.Text = player.FindParseAndGetSpecPct(81);
            player1raid5Box.Text = player.FindParseAndGetSpecPct(82);
        }
        void SurveyPlayer2()
        {
            CPlayer player = new CPlayer();
            player.name = Player2Box.Text;
            player.server = Server2Box.Text;
            if (!player.Survey())
                return;
            cPlayers[1] = player;
            player2raid1Box.Text = player.FindParseAndGetSpecPct(78);
            player2raid2Box.Text = player.FindParseAndGetSpecPct(79);
            player2raid3Box.Text = player.FindParseAndGetSpecPct(80);
            player2raid4Box.Text = player.FindParseAndGetSpecPct(81);
            player2raid5Box.Text = player.FindParseAndGetSpecPct(82);
        }
        void SurveyPlayer3()
        {
            CPlayer player = new CPlayer();
            player.name = Player3Box.Text;
            player.server = Server3Box.Text;
            if (!player.Survey())
                return;
            cPlayers[2] = player;
            player3raid1Box.Text = player.FindParseAndGetSpecPct(78);
            player3raid2Box.Text = player.FindParseAndGetSpecPct(79);
            player3raid3Box.Text = player.FindParseAndGetSpecPct(80);
            player3raid4Box.Text = player.FindParseAndGetSpecPct(81);
            player3raid5Box.Text = player.FindParseAndGetSpecPct(82);
        }
        void SurveyPlayer4()
        {
            CPlayer player = new CPlayer();
            player.name = Player4Box.Text;
            player.server = Server4Box.Text;
            if (!player.Survey())
                return;
            cPlayers[3] = player;
            player4raid1Box.Text = player.FindParseAndGetSpecPct(78);
            player4raid2Box.Text = player.FindParseAndGetSpecPct(79);
            player4raid3Box.Text = player.FindParseAndGetSpecPct(80);
            player4raid4Box.Text = player.FindParseAndGetSpecPct(81);
            player4raid5Box.Text = player.FindParseAndGetSpecPct(82);
        }
        void SurveyPlayer5()
        {
            CPlayer player = new CPlayer();
            player.name = Player5Box.Text;
            player.server = Server5Box.Text;
            if (!player.Survey())
                return;
            cPlayers[4] = player;
            player5raid1Box.Text = player.FindParseAndGetSpecPct(78);
            player5raid2Box.Text = player.FindParseAndGetSpecPct(79);
            player5raid3Box.Text = player.FindParseAndGetSpecPct(80);
            player5raid4Box.Text = player.FindParseAndGetSpecPct(81);
            player5raid5Box.Text = player.FindParseAndGetSpecPct(82);
        }
        void SurveyPlayer6()
        {
            CPlayer player = new CPlayer();
            player.name = Player6Box.Text;
            player.server = Server6Box.Text;
            if (!player.Survey())
                return;
            cPlayers[5] = player;
            player6raid1Box.Text = player.FindParseAndGetSpecPct(78);
            player6raid2Box.Text = player.FindParseAndGetSpecPct(79);
            player6raid3Box.Text = player.FindParseAndGetSpecPct(80);
            player6raid4Box.Text = player.FindParseAndGetSpecPct(81);
            player6raid5Box.Text = player.FindParseAndGetSpecPct(82);
        }
        void SurveyPlayer7()
        {
            CPlayer player = new CPlayer();
            player.name = Player7Box.Text;
            player.server = Server7Box.Text;
            if (!player.Survey())
                return;
            cPlayers[6] = player;
            player7raid1Box.Text = player.FindParseAndGetSpecPct(78);
            player7raid2Box.Text = player.FindParseAndGetSpecPct(79);
            player7raid3Box.Text = player.FindParseAndGetSpecPct(80);
            player7raid4Box.Text = player.FindParseAndGetSpecPct(81);
            player7raid5Box.Text = player.FindParseAndGetSpecPct(82);
        }
        void SurveyPlayer8()
        {
            CPlayer player = new CPlayer();
            player.name = Player8Box.Text;
            player.server = Server8Box.Text;
            if (!player.Survey())
                return;
            cPlayers[7] = player;
            player8raid1Box.Text = player.FindParseAndGetSpecPct(78);
            player8raid2Box.Text = player.FindParseAndGetSpecPct(79);
            player8raid3Box.Text = player.FindParseAndGetSpecPct(80);
            player8raid4Box.Text = player.FindParseAndGetSpecPct(81);
            player8raid5Box.Text = player.FindParseAndGetSpecPct(82);
        }
        void GetNamesFromTeamBox()
        {
            string teamstr = TeamBox.Text;
            if (teamstr == null)
                return;
            if (teamstr.Length == 0)
                return;
            string[] names = teamstr.Split(':');
            int count = names.Count();
            if (count >= 1)
            {
                string[] strs = GetNameAndServer(names[0]);
                PlayerBox.Text = strs[0];
                ServerBox.Text = strs[1];
            }
            if (count >= 2)
            {
                string[] strs = GetNameAndServer(names[1]);
                Player2Box.Text = strs[0];
                Server2Box.Text = strs[1];
            }
            if (count >= 3)
            {
                string[] strs = GetNameAndServer(names[2]);
                Player3Box.Text = strs[0];
                Server3Box.Text = strs[1];
            }
            if (count >= 4)
            {
                string[] strs = GetNameAndServer(names[3]);
                Player4Box.Text = strs[0];
                Server4Box.Text = strs[1];
            }
            if (count >= 5)
            {
                string[] strs = GetNameAndServer(names[4]);
                Player5Box.Text = strs[0];
                Server5Box.Text = strs[1];
            }
            if (count >= 6)
            {
                string[] strs = GetNameAndServer(names[5]);
                Player6Box.Text = strs[0];
                Server6Box.Text = strs[1];
            }
            if (count >= 7)
            {
                string[] strs = GetNameAndServer(names[6]);
                Player7Box.Text = strs[0];
                Server7Box.Text = strs[1];
            }
            if (count >= 8)
            {
                string[] strs = GetNameAndServer(names[7]);
                Player8Box.Text = strs[0];
                Server8Box.Text = strs[1];
            }
        }
        string[] GetNameAndServer(string nameserver)
        {
            string name = nameserver;
            string[] rtn = { "", "" };
            for (int i=0;i<ServerList.Count();i++)
            {
                if (name.Contains(ServerList[i]))
                {
                    int flag = name.LastIndexOf(ServerList[i]);
                    name = name.Remove(flag);
                    rtn[0] = name;
                    rtn[1] = ServerList[i];
                    return rtn;
                }
            }
            rtn[0] = name;
            return rtn;
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
            string rtn = "/p FFLogs快查结果<se.1>";
            int playercount = 0;
            for (int i = 0; i < cPlayers.Count(); i++)
            {
                if (cPlayers[i] == null)
                    continue;
                if (cPlayers[i].name == null)
                    continue;
                if (cPlayers[i].name.Length > 0)
                {
                    string str = "\r\n" + "/p " + cPlayers[i].name + "@" + cPlayers[i].server
                        + " P1S:" + cPlayers[i].FindParseAndGetPercentile(78)
                        + " P2S:" + cPlayers[i].FindParseAndGetPercentile(79)
                        + " P3S:" + cPlayers[i].FindParseAndGetPercentile(80)
                        + " P4S门神:" + cPlayers[i].FindParseAndGetPercentile(81)
                        + " P4S本体:" + cPlayers[i].FindParseAndGetPercentile(82);
                    rtn += str;
                    playercount++;
                }
            }
            string msg = "";
            if (playercount > 0)
            {
                msg = "宏已完成，点击确定复制进剪贴板\r\n" + rtn;
                Clipboard.SetText(rtn);
            }
            else
            {
                msg = "未匹配到log";
            }
            MessageBox.Show(msg);
        }

        private void TeamBox_TextChanged(object sender, EventArgs e)
        {
            GetNamesFromTeamBox();
        }
    }
}
