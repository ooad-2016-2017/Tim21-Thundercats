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
// Budući da baze ne mogu ćuvati liste i da se može imati samo jedna baza , za potrebe projekta se koristi ova kontejner klasa. U budućnosti se treba povezati sa više baza.
namespace Houston.HoustonBaza.Models
{
    public class Houston
    {
        public List<Rampa> Rampe { get; set; }
        // Zbog buga sa Database-om , uvodim string marker. Kada se rješimo bug-a , lako je modifikovati aplikaciju.
        // Ovaj string se može koristiti kao pomoć pri navigaciji. Ne preporućujem korištenje , niti ću koristiti.
        public string marker { get; set; }
        public Houston()
        {
            this.Rampe = new List<Rampa>();
        }
        // Ukoliko neko proba da vuće podatke kroz forme , ovdje stoji kopirajući konstruktor. Ukoliko se radi u DB , slobodno izbriši-
        public Houston(Houston previousHouston)
        {
            Rampe = new List<Rampa>();
            Rampe = previousHouston.Rampe;
            marker = previousHouston.marker;
        }
        public List<Rampa> DajRampe()
        {
            return this.Rampe;
        }
        public void DodajRampu(string ime , string lokacija)
        {
            this.Rampe.Add(new Rampa(ime,lokacija)); 
        }
        public void PostaviMarker(string mark)
        {
            this.marker = mark;
        }
        public string DajMarker()
        {
            return this.marker;
        }
    }
}
