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


            for (int i = 0; i < champions.Count; i++)
            {
                string currInsertInto = "";
                string currInsertTags = "";
                string currCreateTable = "";

                
                ChampionData currChamp = champions[i];


                currCreateTable = @$"CREATE TABLE {currChamp.Id} (Id VARCHAR(20), CKey VARCHAR(5), Name VARCHAR(20), Title VARCHAR(30), Blurb VARCHAR(500), Partype VARCHAR(20), Tags VARCHAR(40), Info VARCHAR(20), Image VARCHAR(80), Stats VARCHAR(100));";
                currInsertInto = @$"INSERT INTO {currChamp.Id} (Id, CKey, Name, Title, Blurb, Partype) VALUES ('{currChamp.Id}', '{currChamp.Key}', '{currChamp.Name}', '{currChamp.Title}', '{currChamp.Blurb}', '{currChamp.Partype}');";

                
                foreach (var item in currChamp.Tags)
                {
                    currInsertTags = currInsertTags + $@"INSERT INTO {currChamp.Id} (Tags) VALUES ('{item}');";
                }

                
                /*foreach (var item in currChamp.Stats)
                {
                    //item.Key;
                    //item.Value;
                }*/

                
                File.AppendAllText("sql.txt", currCreateTable + currInsertInto + currInsertTags);
            }
        }
    }
}
