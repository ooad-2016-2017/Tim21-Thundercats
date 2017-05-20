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

namespace Houston.HoustonBaza.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HoustonCentralConsole : Page
    {
        public HoustonCentralConsole()
        {
            this.InitializeComponent();
            if(ListaRampi.SelectedItem == null)
            {
                button1.Opacity = 0;
                button2.Opacity = 0;
                button3.Opacity = 0;
            }
        }
        public void DodajRampu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeTemplate), "R");
        }
        public void DodajLetjelicu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeTemplate), "L");
        }
        public void DodajModul_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeTemplate), "M");
        }
        public void DodajServis_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeTemplate), "S");
        }
        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new Models.RampaDbContext())
            {
                ListaRampi.ItemsSource = db.Rampe.OrderBy(x => x.imeRampe).ToList();
            }
        }
    }
}
