using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Linq;
using System.Text;

namespace LeagueAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("champions.json", Encoding.GetEncoding("utf-8"));


            List<ChampionData> champions = new List<ChampionData>();


            foreach (var champion in JsonConvert.DeserializeObject<ChampionsRoot>(json).data.Values)
            {
                champions.Add(champion);
            }


            File.WriteAllText("sql.txt", "");

            string CreateTable = @$"CREATE TABLE Champions (Id VARCHAR(20), CKey VARCHAR(5), Name VARCHAR(20), Title VARCHAR(30), Blurb VARCHAR(400), Partype VARCHAR(20), Attack int, Defense int, Magic int, Difficulty int, Hp int, Hpperlevel DOUBLE, Mp DOUBLE, Mpperlevel DOUBLE, Movespeed int, Armor int, Armorperlevel DOUBLE, Spellblock int, Spellblockperlevel DOUBLE, Attackrange int, Hpregen DOUBLE, Hpregenperlevel DOUBLE, Mpregen DOUBLE, Mpregenperlevel DOUBLE, Attackdamage int, Attackdamageperlevel DOUBLE, Attackspeedperlevel DOUBLE, Attackspeed DOUBLE, PRIMARY KEY (Id));";
            File.AppendAllText("sql.txt", CreateTable);

            File.AppendAllText("sql.txt", Environment.NewLine);

            string CreateTableTags = @$"CREATE TABLE Tags (TagId int AUTO_INCREMENT, Id VARCHAR(20), Tag VARCHAR(20), PRIMARY KEY (TagId), FOREIGN KEY (Id) REFERENCES Champions(Id));";
            File.AppendAllText("sql.txt", CreateTableTags);

            Dictionary<string, string> StatsDot = new Dictionary<string, string>();

            for (int i = 0; i < champions.Count; i++)
            {
                ChampionData currChamp = champions[i];


                foreach (KeyValuePair<string, double> entry in currChamp.Stats)
                {
                    string valueDot = entry.Value.ToString().Replace(',','.');
                    StatsDot[entry.Key] = valueDot;
                }


                string InsertInto = @$"INSERT INTO Champions (Id, CKey, Name, Title, Blurb, Partype, Attack, Defense, Magic, Difficulty, Hp, Hpperlevel, Mp, Mpperlevel, Movespeed, Armor, Armorperlevel, Spellblock, Spellblockperlevel, Attackrange, Hpregen, Hpregenperlevel, Mpregen, Mpregenperlevel, Attackdamage, Attackdamageperlevel, Attackspeedperlevel, Attackspeed) VALUES ('{currChamp.Id}', '{currChamp.Key}', '{currChamp.Name}', '{currChamp.Title}', '{currChamp.Blurb}', '{currChamp.Partype}', '{currChamp.Info.GetValueOrDefault("attack")}', '{currChamp.Info.GetValueOrDefault("defense")}', '{currChamp.Info.GetValueOrDefault("magic")}', '{currChamp.Info.GetValueOrDefault("difficulty")}', '{StatsDot.GetValueOrDefault("hp").ToString()}', '{StatsDot.GetValueOrDefault("hpperlevel")}', '{StatsDot.GetValueOrDefault("mp")}', '{StatsDot.GetValueOrDefault("mpperlevel")}', '{StatsDot.GetValueOrDefault("movespeed")}', '{StatsDot.GetValueOrDefault("armor")}', '{StatsDot.GetValueOrDefault("armorperlevel")}', '{StatsDot.GetValueOrDefault("spellblock")}', '{StatsDot.GetValueOrDefault("spellblockperlevel")}', '{StatsDot.GetValueOrDefault("attackrange")}', '{StatsDot.GetValueOrDefault("hpregen")}', '{StatsDot.GetValueOrDefault("hpregenperlevel")}', '{StatsDot.GetValueOrDefault("mpregen")}', '{StatsDot.GetValueOrDefault("mpregenperlevel")}', '{StatsDot.GetValueOrDefault("attackdamage")}', '{StatsDot.GetValueOrDefault("attackdamageperlevel")}', '{StatsDot.GetValueOrDefault("attackspeedperlevel")}', '{StatsDot.GetValueOrDefault("attackspeed")}');";

                foreach (var item in currChamp.Tags)
                {
                    InsertInto += @$"INSERT INTO Tags (Id, Tag) VALUES ('{currChamp.Id}', '{item}');";
                }

                File.AppendAllText("sql.txt", InsertInto);
            }
        }
    }
}
