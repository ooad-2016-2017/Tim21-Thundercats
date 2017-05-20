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
        private string param { get; set; }
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
            string parametar = e.Parameter as String;
            param = parametar;
            if (parametar == "R")
            {
                textBox.Text = "Naziv Rampe";
                textBox.IsReadOnly = true;
                textBox2.Text = "Lokacija";
                textBox2.IsReadOnly = true;
            }
            if (parametar == "L")
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
            if (parametar == "M")
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
            if (parametar == "S")
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
            if (param == "S")
            {
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
                }               
            }
            this.Frame.Navigate(typeof(HoustonCentralConsole));
        }
    }
}
