using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFLogsPolice
{
	internal class CParse
	{
		public int encounterID { get; set; }
		public string encounterName { get; set; }
		public string spec { get; set; }
		public int rank { get; set; }
		public int outOf { get; set; }
		public int duration { get; set; }
		public int startTime { get; set; }
		public string reportID { get; set; }
		public int fightID { get; set; }
		public int difficulty { get; set; }
		public int characterID { get; set; }
		public string characterName { get; set; }
		public string server { get; set; }
		public double percentile { get; set; }
		public int ilvlKeyOrPatch { get; set; }
		public double total { get; set; }
		public string estimated { get; set; }
		public string getpercentile()
        {
			if (percentile < 1)
				return "1";
			return Math.Floor(Convert.ToDecimal(percentile)).ToString();
        }
		string getspec()
        {
			if (spec == "Astrologian")
				return "占";
			else if (spec == "Bard")
				return "诗";
			else if (spec == "Black Mage")
				return "黑";
			else if (spec == "Dark Knight")
				return "暗";
			else if (spec == "Dragoon")
				return "龙";
			else if (spec == "Machinist")
				return "机";
			else if (spec == "Monk")
				return "僧";
			else if (spec == "Ninja")
				return "忍";
			else if (spec == "Paladin")
				return "骑";
			else if (spec == "Scholar")
				return "学";
			else if (spec == "Summoner")
				return "召";
			else if (spec == "Warrior")
				return "战";
			else if (spec == "White Mage")
				return "白";
			else if (spec == "Red Mage")
				return "赤";
			else if (spec == "Samurai")
				return "侍";
			else if (spec == "Dancer")
				return "舞";
			else if (spec == "Gunbreaker")
				return "枪";
			else if (spec == "Reaper")
				return "镰";
			else if (spec == "Sage")
				return "贤";
			return "";
		}
		public string getspecpct()
        {
			return getspec() + getpercentile();

		}
	}
}
