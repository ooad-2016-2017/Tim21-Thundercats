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
    public class Servis
    {
        public string ImeServisa { get; set; }
        private string TipServisa { get; set; }
        private List<dynamic> Servisira;
        private List<dynamic> NaČekanju;
        private int Kapacitet { get; set; }
        private string Lokacija { get; set; }
        public Servis(string ime, string tip, int kapacitet, string lokacija)
        {
            ImeServisa = ime;
            TipServisa = tip;
            Kapacitet = kapacitet;
            Lokacija = lokacija;
        }
    }
}