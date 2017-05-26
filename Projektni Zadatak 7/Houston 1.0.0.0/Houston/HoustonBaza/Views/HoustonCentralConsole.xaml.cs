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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
// Ova klasa poštuje CRUD metodu. Nije implementirana zbog Bug-a , ali je kod tu , pa se lako može implementirati brisanjem zastarjelog koda i
// znakova za komentar, uz opasku da ListBox ne poštuje neke mehanike, pa ih samo treba preimenovati u ListView. 
namespace Houston.HoustonBaza.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HoustonCentralConsole : Page
    {
        public Models.Houston House = new Models.Houston();      
        public HoustonCentralConsole()
        {
            this.InitializeComponent();
            House.Rampe.Add(new Models.Rampa("Kennedy Space Centre", "Titusville , Florida, USA"));
            House.Rampe.Add(new Models.Rampa("Vostochny Cosmodrome", "Amur Oblast, Russia"));
            House.Rampe.Add(new Models.Rampa("Kapani Tonneo OTRAG Launch Center", "Shaba North , Congo(Zaire)"));
            House.Rampe.Add(new Models.Rampa("Tawiwa OTRAG Launch Center", "Sabha, , Libya"));
            House.Rampe.Add(new Models.Rampa("Vikram Sarabhai Space Centre", "Thiruvananthapuram , Kerala, India"));
            House.Rampe.Add(new Models.Rampa("Stasiun Peluncuran Roket", "Pameungpeuk, Garut, Indonesia"));
            House.Rampe.Add(new Models.Rampa("Tanegashima Space Center", "Tanegashima Island,Japan"));
            House.Rampe.Add(new Models.Rampa("Baikonur Cosmodrome", "Tyuratam, Kazakhstan"));
            House.Rampe.Add(new Models.Rampa("Naro Space Center", "Gohueng, South Korea"));
            House.Rampe.Add(new Models.Rampa("Tilla Satellite Launch Center", "Jhelum District, Punjab, Pakistan"));
            House.Rampe[0].Servisi.Add(new Models.Servis("NASA Repair", "Cargo/Passenger/Rockets", 10, "Florida"));
            House.Rampe[1].Servisi.Add(new Models.Servis("Zdobrojka", "Cargo/Passenger/Rockets", 8, "Amur Oblast"));
            House.Rampe[2].Servisi.Add(new Models.Servis("Shaka Zulu", "Cargo Modules", 3, "Shaba North"));
            House.Rampe[3].Servisi.Add(new Models.Servis("Yyndyyrlic", "Rockets", 6, "Sabha"));
            House.Rampe[4].Servisi.Add(new Models.Servis("Smiling Buddha", "Cargo/Passenger Modules", 12, "Kerala"));
            House.Rampe[5].Servisi.Add(new Models.Servis("Panay Pendek", "Passenger/Rocekts", 9, "Garut"));
            House.Rampe[6].Servisi.Add(new Models.Servis("Sora", "Cargo/Passenger/Rockets", 7, "Tanageshima"));
            House.Rampe[7].Servisi.Add(new Models.Servis("Vostlzka", "Rockets", 2, "Tyuratam"));
            House.Rampe[8].Servisi.Add(new Models.Servis("Horako", "Cargo/Passenger Modules", 11, "Gohueng"));
            House.Rampe[9].Servisi.Add(new Models.Servis("Manyabu", "Rockets", 5, "Punjab"));
            House.Rampe[0].Letjelice.Add(new Models.Letjelica("Saturn 1", "Staurn-V", "3 Tone ili 4-Člani Putnićki Modul", false, "USA"));
            House.Rampe[0].Letjelice.Add(new Models.Letjelica("Saturn 2", "Staurn-V", "3 Tone ili 4-Člani Putnićki Modul", false, "USA"));
            House.Rampe[0].Letjelice.Add(new Models.Letjelica("Saturn 3", "Staurn-V", "3 Tone ili 4-Člani Putnićki Modul", false, "USA"));
            House.Rampe[0].Letjelice.Add(new Models.Letjelica("Saturn 4", "Staurn-V", "3 Tone ili 4-Člani Putnićki Modul", false, "USA"));
            House.Rampe[0].Letjelice.Add(new Models.Letjelica("Saturn 5", "Staurn-V", "3 Tone ili 4-Člani Putnićki Modul", false, "USA"));
            House.Rampe[1].Letjelice.Add(new Models.Letjelica("Soyuz 1", "Soyuz-2", "2 Tone ili 3-Člani Putnićki Modul", false, "RUS"));
            House.Rampe[1].Letjelice.Add(new Models.Letjelica("Soyuz 1", "Soyuz-2", "2 Tone ili 3-Člani Putnićki Modul", false, "RUS"));
            House.Rampe[1].Letjelice.Add(new Models.Letjelica("Soyuz 1", "Soyuz-2", "2 Tone ili 3-Člani Putnićki Modul", false, "RUS"));
            House.Rampe[1].Letjelice.Add(new Models.Letjelica("Soyuz 1", "Soyuz-2", "2 Tone ili 3-Člani Putnićki Modul", false, "RUS"));
            House.Rampe[1].Letjelice.Add(new Models.Letjelica("Soyuz 1", "Soyuz-2", "2 Tone ili 3-Člani Putnićki Modul", false, "RUS"));
            House.Rampe[6].Letjelice.Add(new Models.Letjelica("Yamato 1", "Staurn-V(MOD)", "3 Tone ili 6-Člani Putnićki Modul", false, "USA/JAP"));
            House.Rampe[6].Letjelice.Add(new Models.Letjelica("Yamato 2", "Staurn-V(MOD)", "3 Tone ili 6-Člani Putnićki Modul", false, "USA/JAP"));
            House.Rampe[6].Letjelice.Add(new Models.Letjelica("Yamato 3", "Staurn-V(MOD)", "3 Tone ili 6-Člani Putnićki Modul", false, "USA/JAP"));
            House.Rampe[7].Letjelice.Add(new Models.Letjelica("Soyuz 1", "Soyuz-1", "1 Tona ili 2-Člani Putnićki Modul", false, "USA/JAP"));
            House.Rampe[7].Letjelice.Add(new Models.Letjelica("Soyuz 2", "Soyuz-1", "1 Tona ili 2-Člani Putnićki Modul", false, "USA/JAP"));
            House.Rampe[0].Moduli.Add(new Models.Modul("Challenger", "Putnićki", 5));
            House.Rampe[0].Moduli.Add(new Models.Modul("Voyager", "Teretni", 3));
            House.Rampe[0].Moduli.Add(new Models.Modul("Discovery", "Putnićki", 2));
            House.Rampe[0].Moduli.Add(new Models.Modul("Spirit", "Teretni", 3));
            House.Rampe[0].Moduli.Add(new Models.Modul("Challenger", "Putnićki", 5));
            House.Rampe[1].Moduli.Add(new Models.Modul("Gorbachov", "Putnićki", 5));
            House.Rampe[1].Moduli.Add(new Models.Modul("Gorbachov", "Putnićki", 5));
            House.Rampe[1].Moduli.Add(new Models.Modul("Gorbachov", "Putnićki", 5));
            House.Rampe[1].Moduli.Add(new Models.Modul("Lennin", "Teretni", 2));
            House.Rampe[1].Moduli.Add(new Models.Modul("Lenin", "Teretni", 2));
            if (ListaRampi.SelectedItem == null)
            {
                button1.Opacity = 0;
                button2.Opacity = 0;
                button3.Opacity = 0;
                textBox.Opacity = 0;
                textBox.IsReadOnly = true;
                textBox1.Opacity = 0;
                textBox1.IsReadOnly = true;
                textBox2.Opacity = 0;
                textBox2.IsReadOnly = true;
                comboBox.Opacity = 0;
                comboBox1.Opacity = 0;
                comboBox2.Opacity = 0;
            }
        }
        public void DodajRampu_Click(object sender, RoutedEventArgs e)
        {
            Models.Rampa R = new Models.Rampa("R");
            this.Frame.Navigate(typeof(DodavanjeTemplate), R);
        }
        public void DodajLetjelicu_Click(object sender, RoutedEventArgs e)
        {
            Models.Rampa L = new Models.Rampa("L");
            this.Frame.Navigate(typeof(DodavanjeTemplate), L);
        }
        public void DodajModul_Click(object sender, RoutedEventArgs e)
        {
            Models.Rampa M = new Models.Rampa("M");
            this.Frame.Navigate(typeof(DodavanjeTemplate), M);
        }
        public void DodajServis_Click(object sender, RoutedEventArgs e)
        {
            Models.Rampa S = new Models.Rampa("S");
            this.Frame.Navigate(typeof(DodavanjeTemplate), S);
        }
        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            /*
             // DB Verzija. Imam bug , pa idem na kontejner
             using (var db = new Models.RampaDbContext())
            {
                ListaRampi.ItemsSource = db.Rampe.OrderBy(x => x.imeRampe).ToList();
            }
            */
            try
            {
                for (int i = 0; i < House.DajRampe().Count; i++)
                {
                    ListaRampi.Items.Add(House.DajRampe()[i].imeRampe);
                }
            }
            catch (Exception ep) { }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

             try
             {
                 Models.Rampa R = e.Parameter as Models.Rampa;
                 House.Rampe.Add(R); ;
             }
             catch (Exception ep) { }
        }

        private void ListaRampi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            button1.Opacity = 1;
            button2.Opacity = 1;
            button3.Opacity = 1;
            textBox.Opacity = 1;
            textBox1.Opacity = 1;
            textBox2.Opacity = 1;
            comboBox.Opacity = 1;
            comboBox1.Opacity = 1;
            comboBox2.Opacity = 1;
            textBox.Text = "Servis/i:";
            textBox1.Text = "Modul/i";
            textBox2.Text = "Letjelica/e";
            for(int i = 0; i < House.Rampe.Count; i++)
            {
                try
                {
                    if (House.Rampe[i].imeRampe == ListaRampi.SelectedItem.ToString())
                    {
                        try
                        {
                            for (int j = 0; j < House.Rampe[i].Servisi.Count; j++)
                            {
                                comboBox.Items.Add(House.Rampe[i].Servisi[j].ImeServisa);
                            }
                        }
                        catch { }
                        try
                        {
                            for (int k = 0; k < House.Rampe[i].Moduli.Count; k++)
                            {
                                comboBox1.Items.Add(House.Rampe[i].Moduli[k].imeModula);
                            }
                        }
                        catch { }
                        try
                        {
                            for (int l = 0; l < House.Rampe[i].Letjelice.Count; l++)
                            {
                                comboBox2.Items.Add(House.Rampe[i].Letjelice[l].imeLetjelice);
                            }
                        }
                        catch { }
                        if (comboBox.Items.Count == 0)
                        {
                            comboBox.Items.Add("Nema Servisa");
                        }
                        if (comboBox1.Items.Count == 0)
                        {
                            comboBox1.Items.Add("Nema Modula");
                        }
                        if (comboBox2.Items.Count == 0)
                        {
                            comboBox2.Items.Add("Nema Letjelica");
                        }
                    }
                }
                catch { }
            }
        }
    }
}
