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
    public class Modul
    {
        public string imeModula { get; set; }
        private string tipModula { get; set; }
        private int Kapacitet { get; set; }
        private DateTime PosljednjaMisija;
        private DateTime PosljednjiServisa;
        private bool DaLiSeServisira = false;
        private Servis servis { get; set; }
        public Modul(string ime, string tip, int kapacitet)
        {
            imeModula = ime;
            tipModula = tip;
            Kapacitet = kapacitet;
        }
    }
}