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
	}
}
