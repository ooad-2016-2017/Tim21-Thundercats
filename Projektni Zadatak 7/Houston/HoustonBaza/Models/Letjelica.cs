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
    class Letjelica
    {
        private string imeLetjelice { get; set; }
        private string tipLetjelice { get; set; }
        private string Kapacitet { get; set; }
        private DateTime PosljednjaMisija;
        private DateTime PosljednjiServisa;
        private bool DaLiSeServisira = false;
        private Servis servis;
        private bool Komercijalna = false;
        private string Porjeklo { get; set; }
        public Letjelica(string ime, string tip, string kapacitet, bool privatna, string zemlja)
        {
            imeLetjelice = ime;
            tipLetjelice = tip;
            Kapacitet = kapacitet;
            Komercijalna = privatna;
            Porjeklo = zemlja;
        }
    }
}