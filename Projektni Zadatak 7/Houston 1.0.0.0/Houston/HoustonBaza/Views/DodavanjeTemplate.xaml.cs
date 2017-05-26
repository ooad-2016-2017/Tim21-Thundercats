using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using System.ComponentModel.DataAnnotations.Schema;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Houston.HoustonBaza.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodavanjeTemplate : Page
    {
        // Ko hoće da sve svede u jednu bazu , a forme mjenja šaljući klase sa jedne na drugu formu preko EventArgs može , zato su i ostavljena
        // ova dva parametra ovdje. Ja to neću uraditi , niti preporućujem da se radi zbog null vrijednosti , koje mogu praviti mnogo problema 
        // pri kopiranju ili referenciranju podataka.
        private string param { get; set; }
        public Models.Rampa Ramp;
        // Otvaranje default prozora
        public DodavanjeTemplate()
        {
            this.InitializeComponent();
            textBox4.Opacity = 0;
            textBox4.IsReadOnly = true;
            comboBox.Opacity = 0;
            textBoxZaNepobrojaneTipove.Opacity = 0;
            textBox5.Opacity = 0;
            textBox5.IsReadOnly = true;
            textBox6.Opacity = 0;
            textBox6.IsReadOnly = true;
            textBox7.Opacity = 0;
        }
        //Budući da je ovo template prozor , overridujemo navigaciju da možemo modelirati prozor po potrebama
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Models.Rampa parametar = e.Parameter as Models.Rampa;
            Ramp = parametar;
            param = parametar.fourSquareID;
            if (param == "R")
            {
                textBox.Text = "Naziv Rampe";
                textBox.IsReadOnly = true;
                textBox2.Text = "Lokacija";
                textBox2.IsReadOnly = true;
            }
            if (param == "L")
            {
                textBox.Text = "Naziv Letjelice";
                textBox.IsReadOnly = true;
                textBox2.Text = "Kapacitet";
                textBox2.IsReadOnly = true;
                textBox4.Opacity = 1;
                textBox4.Text = "Tip usluge";
                textBoxZaNepobrojaneTipove.Opacity = 1;
                comboBox.Opacity = 1;
                comboBox.Items.Add("Vladini");
                comboBox.Items.Add("Komercijalni");
                textBox5.Opacity = 1;
                textBox5.Text = "Tip Letjelice";
                textBox6.Opacity = 1;
                textBox6.Text = "Zemlja Porjekla";
                textBox7.Opacity = 1;

            }
            if (param == "M")
            {
                textBox.Text = "Naziv Modula";
                textBox.IsReadOnly = true;
                textBox2.Text = "Kapacitet";
                textBox2.IsReadOnly = true;
                textBox4.Opacity = 1;
                textBox4.Text = "Tip";
                comboBox.Opacity = 1;
                comboBox.Items.Add("Teretni");
                comboBox.Items.Add("Putnićki");
            }
            if (param == "S")
            {
                textBox.Text = "Naziv Servisa";
                textBox.IsReadOnly = true;
                textBox2.Text = "Lokacija";
                textBox2.IsReadOnly = true;
                comboBox.Opacity = 1;
                comboBox.Items.Add("Moduli");
                comboBox.Items.Add("Letjelice");
                textBox4.Text = "Tip Servisa";
                textBox4.Opacity = 1;
                textBox5.Opacity = 1;
                textBox5.Text = "Kapacitet";
                textBoxZaNepobrojaneTipove.Opacity = 1;
            }
        }
        public void Nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HoustonCentralConsole));
        }
        public void Spasi_Click(object sender, RoutedEventArgs e)
        {
            if (param == "R")
            {
                /*
                 // Database Verzija spasavanja. Budući da imam bug , ne koristim je , već idemo na kontejner
                 using (var db = new Models.RampaDbContext())
                {
                    var Rampa = new Models.Rampa
                    {
                        imeRampe = textBox1.Text,
                        Lokacija = textBox3.Text
                    };
                    db.Rampe.Add(Rampa);
                    db.SaveChanges();
                    textBox1.Text = string.Empty;
                    textBox3.Text = string.Empty;
                }  */
                this.Frame.Navigate(typeof(HoustonCentralConsole), new Models.Rampa(textBox1.Text, textBox2.Text));
            }
            if (param == "L")
            {
                bool b;
                if (comboBox.SelectedItem.ToString() == "Vladini")
                {
                    b = false;
                }
                else b = true;
                Models.Letjelica Leti = new Models.Letjelica(textBox1.Text, textBoxZaNepobrojaneTipove.Text, textBox3.Text, b, textBox7.Text);
                //Ramp.Letjelice.Add(Leti);
                this.Frame.Navigate(typeof(HoustonCentralConsole), Ramp);
            }
            if (param == "S")
            {
                Models.Servis Serv = new Models.Servis(textBox1.Text, comboBox.SelectedItem.ToString(), int.Parse(textBoxZaNepobrojaneTipove.Text), textBox3.Text);
                //Ramp.Servisi.Add(Serv);
                this.Frame.Navigate(typeof(HoustonCentralConsole), Ramp);
            }
            if (param == "M")
            {
                Models.Modul Mod = new Models.Modul(textBox1.Text, comboBox.SelectedItem.ToString(), int.Parse(textBox3.Text));
                //Ramp.Moduli.Add(Mod);
                this.Frame.Navigate(typeof(HoustonCentralConsole), Ramp);
            }
        }
    }
}
