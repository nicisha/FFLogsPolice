using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FFLogsPolice
{
    internal class CPlayer
    {
        List<CParse> cParses = new List<CParse>();
        public CParse FindParse(int encounterID)
        {
            for (int i = 0; i < cParses.Count; i++)
            {
                CParse par = cParses[i];
                if (par.encounterID == encounterID)
                    return par;
            }
            return null;
        }
        public void ConvertFromJson(string json)
        {
            Newtonsoft.Json.Linq.JArray array = (Newtonsoft.Json.Linq.JArray)Newtonsoft.Json.JsonConvert.DeserializeObject(json);
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
                    if (cParses[j].encounterID == parse.encounterID && cParses[j].difficulty == parse.difficulty)
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
