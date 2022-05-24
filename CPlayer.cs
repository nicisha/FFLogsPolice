using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace FFLogsPolice
{
    internal class CPlayer
    {
        public string name { get; set; }
        public string server { get; set; }
        List<CParse> cParses = new List<CParse>();
        public CParse FindParse(int encounterID)
        {
            CParse rtn = null;
            double maxpercentile = 0;
            for (int i = 0; i < cParses.Count; i++)
            {
                CParse par = cParses[i];
                if (par.encounterID == encounterID)
                {
                    if (par.percentile > maxpercentile)
                    {
                        rtn = par;
                        maxpercentile = par.percentile;
                    }
                }
            }
            return rtn;
        }
        public string FindParseAndGetSpecPct(int encounterID)
        {
            CParse parse = FindParse(encounterID);
            if (parse == null)
            {
                return "无记录";
            }
            else
            {
                return parse.getspecpct();
            }
        }
        public string FindParseAndGetPercentile(int encounterID)
        {
            CParse parse = FindParse(encounterID);
            if (parse == null)
            {
                return "无记录";
            }
            else
            {
                return parse.getpercentile();
            }
        }
        public bool Survey(string name, string server)
        {
            if (name == null || server == null)
                return false;
            if (name.Length == 0 || server.Length == 0)
                return false;
            string url = "https://www.fflogs.com/v1/parses/character/"
                + name + "/" + server + "/CN?zone=44&metric=rdps&timeframe=historical&api_key="
                + FFLogsPolice.FFLogsV1Key;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string json = streamReader.ReadToEnd();
            ConvertFromJson(json);
            return true;
        }
        public bool Survey()
        {
            return Survey(name, server);
        }
        public void ConvertFromJson(string json)
        {
            JArray array = (JArray)Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            for (int i = 0; i < array.Count; i++)
            {
                JObject jobj = JObject.Parse(array[i].ToString());
                int difficulty = int.Parse(jobj["difficulty"].ToString());
                if (difficulty == 100)
                    continue;
                CParse parse = new CParse();
                parse.difficulty = difficulty;
                parse.encounterID = int.Parse(jobj["encounterID"].ToString());
                parse.encounterName = jobj["encounterName"].ToString();
                parse.spec = jobj["spec"].ToString();
                parse.percentile = double.Parse(jobj["percentile"].ToString());
                parse.total = double.Parse(jobj["total"].ToString());
                bool iffind = false;
                for (int j = 0;j < cParses.Count; j++)
                {
                    if (cParses[j].encounterID == parse.encounterID 
                        && cParses[j].difficulty == parse.difficulty
                        && cParses[j].spec == parse.spec)
                    {
                        iffind = true;
                        if (parse.percentile > cParses[j].percentile)
                        {
                            cParses[j].percentile = parse.percentile;
                        }
                        if (parse.total > cParses[j].total)
                        {
                            cParses[j].total = parse.total;
                        }
                        break;
                    }
                }
                if (!iffind)
                {
                    cParses.Add(parse);
                }
            }
        }
    }
}
