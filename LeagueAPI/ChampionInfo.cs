using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueAPI
{
    internal class ChampionData
    {
        public string Version { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public string Partype { get; set; }
        public List<string> Tags { get; set; }
        public Dictionary<string, string> Info { get; set; }
        public Dictionary<string, string> Image { get; set; }
        public Dictionary<string, double> Stats { get; set; }
    }
}
