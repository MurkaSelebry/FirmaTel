using FirmaTel.FirmaBasa;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmerAgency
{
    public partial class MainWindow : Window
    {
        private static FirmaDbContext fdc = new FirmaDbContext();
        private static int Kod;
        public MainWindow(int kod)
        {
            InitializeComponent();
            Kod = kod;
            LoadData();
        }

   

        private void LoadData()
        {
            dgAbonenti.ItemsSource = new ObservableCollection<Abonnent>(fdc.Abonnents.ToList());
            dgGoroda.ItemsSource = new ObservableCollection<Gorodum>(fdc.Goroda.ToList());
            dgPeregovori.ItemsSource = new ObservableCollection<Peregovory>(fdc.Peregovories.ToList());
        }



        private void OnCalculateButtonClick(object sender, RoutedEventArgs e)
        {
            Gorodum selectedGorod = (Gorodum)dgGoroda.SelectedItem;
            Peregovory selectedPeregovori = (Peregovory)dgPeregovori.SelectedItem;

            if (selectedPeregovori != null && selectedGorod != null)
            {
                Cost.Content = CalculateCenaRazgovor(selectedGorod.KodGoroda, selectedGorod.TarifDnevnoy, selectedGorod.TarifNochnoy, selectedPeregovori.KolichestvoMinut, selectedPeregovori.VremyaSutok);
            }
        }

        private decimal CalculateCenaRazgovor(int kodGoroda, decimal? tarifDnevnoy, decimal? tarifNochnoy, int? kolichestvoMinut, string? vremyaSutok)
        {
            var sale = (from skidka in fdc.Skidkis
                       where skidka.KodGoroda == kodGoroda
                       select skidka.Skidka).FirstOrDefault();
            if (sale != null) { 
                if(vremyaSutok == "день")
                {
                    return tarifDnevnoy.Value * kolichestvoMinut.Value - (tarifDnevnoy.Value * kolichestvoMinut.Value) * sale.Value;
                }
                else if (vremyaSutok == "ночь")
                {
                    return tarifNochnoy.Value * kolichestvoMinut.Value - (tarifNochnoy.Value * kolichestvoMinut.Value) * sale.Value;
                }
                else
                {
                    var sredniyTarif = (tarifDnevnoy + tarifNochnoy) / 2;
                    return sredniyTarif.Value * kolichestvoMinut.Value - (sredniyTarif.Value * kolichestvoMinut.Value) * sale.Value;
                }
            }
            return -1;
        }



    

        private void DeleteRow(object sender, RoutedEventArgs e)
        {
            //if (dgGoroda.SelectedItem != null)
            //{
            //    Gorodum selectedGorod = dgGoroda.SelectedItem as Gorodum;


            //    fdc.Goroda.Remove(selectedGorod);
            //    fdc.SaveChanges();
            //}

            if (dgPeregovori.SelectedItem != null)
            {
                Peregovory selectedPer = dgPeregovori.SelectedItem as Peregovory;


                fdc.Peregovories.Remove(selectedPer);
                fdc.SaveChanges();
            }

            //if (dgAbonenti.SelectedItem != null)
            //{
            //    Abonnent selectedAb = dgAbonenti.SelectedItem as Abonnent;


            //    fdc.Abonnents.Remove(selectedAb);
            //    fdc.SaveChanges();
            //}
            LoadData();
        }

        private void AddShowClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddGorod addShow = new AddGorod();
            addShow.ShowDialog();
            this.Show();
            LoadData();
        }

        private void AddAdvertisementClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddPeregovory addAdvertisement = new AddPeregovory();
            addAdvertisement.ShowDialog();
            this.Show();
            LoadData();
        }
    }
}
