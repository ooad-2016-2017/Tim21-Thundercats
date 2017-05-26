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
    public class Letjelica
    {
        public string imeLetjelice { get; set; }
        private string tipLetjelice { get; set; }
        private string Kapacitet { get; set; }
        private DateTime PosljednjaMisija;
        private DateTime PosljednjiServisa;
        private bool DaLiSeServisira = false;
        private Servis servis { get; set; }
        private bool Komercijalna = false;
        private string Porjeklo { get; set; }
        public Letjelica(string ime, string tip, string kapacitet, bool privatna, string zemlja)
        {
            this.imeLetjelice = ime;
            this.tipLetjelice = tip;
            this.Kapacitet = kapacitet;
            this.Komercijalna = privatna;
            this.Porjeklo = zemlja;
        }
    }
}