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
            KeyBox.Text = "f1db1a4a1127fd16b00d02b3cb3d0d77";
        }

        private void button1_Click(object sender, EventArgs e)
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
                player1raid1Box.Text = p1s.percentile.ToString();
            }
            CParse p2s = player.FindParse(79);
            if (p2s == null)
            {
                player1raid2Box.Text = "无记录";
            }
            else
            {
                player1raid2Box.Text = p2s.percentile.ToString();
            }
            CParse p3s = player.FindParse(80);
            if (p3s == null)
            {
                player1raid3Box.Text = "无记录";
            }
            else
            {
                player1raid3Box.Text = p3s.percentile.ToString();
            }
            CParse p4s_1 = player.FindParse(81);
            if (p4s_1 == null)
            {
                player1raid4Box.Text = "无记录";
            }
            else
            {
                player1raid4Box.Text = p4s_1.percentile.ToString();
            }
            CParse p4s_2 = player.FindParse(82);
            if (p4s_2 == null)
            {
                player1raid5Box.Text = "无记录";
            }
            else
            {
                player1raid5Box.Text = p4s_2.percentile.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cn.fflogs.com/profile");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
