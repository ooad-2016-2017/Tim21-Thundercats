using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using System.ComponentModel.DataAnnotations.Schema;

namespace Houston.HoustonBaza.Models
{
    class Rampa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RampaID { get; set; }
        public string fourSquareID { get; set; }
        public string imeRampe { get; set; }
        public List<Letjelica> Letjelice;
        public List<Modul> Moduli;
        public List<Servis> Servisi;
        public string Lokacija { get; set; }
        public List<DateTime> KadaJeZauzeta;
    }
   
}