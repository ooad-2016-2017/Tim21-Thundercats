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
    public class Rampa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RampaID { get; set; }
        public string fourSquareID { get; set; }
        public string imeRampe { get; set; }
        public List<Letjelica> Letjelice { get; set; }
        public List<Modul> Moduli { get; set; }
        public List<Servis> Servisi { get; set; }
        public string Lokacija { get; set; }
        public List<DateTime> KadaJeZauzeta { get; set; }
        // Katkada je lakše rediti preko konstruktora. Ovdje su nepotrebni ali znaju olakšati posao.
        public Rampa(string ime , string lokacija)
        {
            this.imeRampe = ime;
            this.Lokacija = lokacija;
            Letjelice = new List<Letjelica>();
            Moduli = new List<Modul>();
            Servisi = new List<Servis>();
        }
        public Rampa()
        { }
        // Urađeno za kontejner. Obavezno obrisati pri prebacivanju na DB!
        public Rampa(string Fsq)
        {
            fourSquareID = Fsq;
        }
    }
   
}