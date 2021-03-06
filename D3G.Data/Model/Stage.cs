﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3G.Data.Model {
    public class Stage {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }               // enum
        public int Visibility { get; set; }         // enum
        public string City { get; set; }
        public string Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int? CacheId { get; set; }
        public int? NextStageId { get; set; }

        public static Stage Generate(int index, int number, int? cacheId, int? nextStageId, List<Tuple<string, string>> places, Random random) {
            int i = random.Next(places.Count);
            string country = places[i].Item1;
            string city = places[i].Item2;

            return new Stage {
                Id = index,
                Number = number,
                Description = string.Format("description{0}", index),
                Type = random.Next(0,2),
                Visibility = random.Next(0,3),
                City = city,
                Country = country,
                Longitude = Math.Round(random.Next(-179, 179) + random.NextDouble(), 6),
                Latitude = Math.Round(random.Next(-89, 89) + random.NextDouble(), 6),
                CacheId = cacheId,
                NextStageId = nextStageId
            };
        }

        public override string ToString() {
            string s = "({0}, {1}, \"{2}\", {3}, {4}, \"{5}\", \"{6}\", {7}, {8}, {9}, {10})";
            return string.Format(s, this.Id, this.Number, this.Description, this.Type, this.Visibility, this.City, this.Country, this.Longitude, this.Latitude,
                (this.CacheId == null) ? "null" : this.CacheId.ToString(),
                (this.NextStageId == null) ? "null" : this.NextStageId.ToString());
        }
    }
}
