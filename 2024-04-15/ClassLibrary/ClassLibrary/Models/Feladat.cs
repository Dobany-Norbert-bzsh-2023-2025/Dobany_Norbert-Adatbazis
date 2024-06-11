using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Feladat
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int SzemelyId { get; set; }
        public string Megnevezes { get; set; }

        public Feladat() { }

        public Feladat(string sor)
        {
            string[] split = sor.Split('\t');
            Id = Convert.ToInt32(split[0]);
            FilmId = Convert.ToInt32(split[1]);
            SzemelyId = Convert.ToInt32(split[2]);
            Megnevezes = split[3];
        }
    }
}
