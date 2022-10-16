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

            string CreateTable = @$"CREATE TABLE Champions (Id VARCHAR(20), CKey VARCHAR(5), Name VARCHAR(20), Title VARCHAR(30), Blurb VARCHAR(400), Partype VARCHAR(20), Attack int, Defense int, Magic int, Difficulty int, Hp int, Hpperlevel DECIMAL(6,3), Mp VARCHAR(8), Mpperlevel DECIMAL(6,3), Movespeed int, Armor int, Armorperlevel DECIMAL(6,3), Spellblock int, Spellblockperlevel DECIMAL(6,3), Attackrange int, Hpregen DECIMAL(6,3), Hpregenperlevel DECIMAL(6,3), Mpregen DECIMAL(6,3), Mpregenperlevel DECIMAL(6,3), Attackdamage int, Attackdamageperlevel DECIMAL(6,3), Attackspeedperlevel DECIMAL(6,3), Attackspeed DECIMAL(6,3), PRIMARY KEY (Id));";
            File.AppendAllText("sql.txt", CreateTable);

            File.AppendAllText("sql.txt", Environment.NewLine);

            string CreateTableTags = @$"CREATE TABLE Tags (TagId int AUTO_INCREMENT, Id VARCHAR(20), Tag VARCHAR(20), PRIMARY KEY (TagId), FOREIGN KEY (Id) REFERENCES Champions(Id));";
            File.AppendAllText("sql.txt", CreateTableTags);

            for (int i = 0; i < champions.Count; i++)
            {
                ChampionData currChamp = champions[i];

                string InsertInto = @$"INSERT INTO Champions (Id, CKey, Name, Title, Blurb, Partype, Attack, Defense, Magic, Difficulty, Hp, Hpperlevel, Mp, Mpperlevel, Movespeed, Armor, Armorperlevel, Spellblock, Spellblockperlevel, Attackrange, Hpregen, Hpregenperlevel, Mpregen, Mpregenperlevel, Attackdamage, Attackdamageperlevel, Attackspeedperlevel, Attackspeed) VALUES ('{currChamp.Id}', '{currChamp.Key}', '{currChamp.Name}', '{currChamp.Title}', '{currChamp.Blurb}', '{currChamp.Partype}', '{currChamp.Info.GetValueOrDefault("attack")}', '{currChamp.Info.GetValueOrDefault("defense")}', '{currChamp.Info.GetValueOrDefault("magic")}', '{currChamp.Info.GetValueOrDefault("difficulty")}', '{currChamp.Stats.GetValueOrDefault("hp").ToString()}', '{currChamp.Stats.GetValueOrDefault("hpperlevel")}', '{currChamp.Stats.GetValueOrDefault("mp")}', '{currChamp.Stats.GetValueOrDefault("mpperlevel")}', '{currChamp.Stats.GetValueOrDefault("movespeed")}', '{currChamp.Stats.GetValueOrDefault("armor")}', '{currChamp.Stats.GetValueOrDefault("armorperlevel")}', '{currChamp.Stats.GetValueOrDefault("spellblock")}', '{currChamp.Stats.GetValueOrDefault("spellblockperlevel")}', '{currChamp.Stats.GetValueOrDefault("attackrange")}', '{currChamp.Stats.GetValueOrDefault("hpregen")}', '{currChamp.Stats.GetValueOrDefault("hpregenperlevel")}', '{currChamp.Stats.GetValueOrDefault("mpregen")}', '{currChamp.Stats.GetValueOrDefault("mpregenperlevel")}', '{currChamp.Stats.GetValueOrDefault("attackdamage")}', '{currChamp.Stats.GetValueOrDefault("attackdamageperlevel")}', '{currChamp.Stats.GetValueOrDefault("attackspeedperlevel")}', '{currChamp.Stats.GetValueOrDefault("attackspeed")}');";

                Console.WriteLine(InsertInto);

                foreach (var item in currChamp.Tags)
                {
                    InsertInto += @$"INSERT INTO Tags (Id, Tag) VALUES ('{currChamp.Id}', '{item}');";
                }

                File.AppendAllText("sql.txt", InsertInto);
            }
        }
    }
}
