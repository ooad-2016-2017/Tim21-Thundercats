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
    class Houston
    {
        private List<Rampa> Rampe;
        public Houston()
        {
            Rampe = new List<Rampa>();
        }
        public List<Rampa> DajRampe()
        {
            return Rampe;
        }
    }
}
