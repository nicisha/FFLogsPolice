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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.fflogs.com/v1/parses/character/%E6%A5%A0%E6%9C%A8%E7%81%AF/%E7%A5%9E%E6%8B%B3%E7%97%95/CN?zone=44&metric=rdps&timeframe=historical&api_key=***************************************";
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            CPlayer player = new CPlayer();
            player.ConvertFromJson(json);

        }
    }
}
