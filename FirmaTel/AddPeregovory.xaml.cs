using FirmaTel.FirmaBasa;
using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Логика взаимодействия для AddAdvertisement.xaml
    /// </summary>
    public partial class AddPeregovory : Window
    {
        private static FirmaDbContext fdc = new FirmaDbContext();
        public AddPeregovory()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int lastInt = 0;
            do
            {
                lastInt++;
            } while (fdc.Peregovories.Any(x => x.KodPeregovorov == lastInt) == true);

            Peregovory transmission = new Peregovory()
            {
                KodPeregovorov = lastInt,
                KodAbonenta = Convert.ToInt32(AbonentTB.Text),
                KodGoroda = Convert.ToInt32(GorodTB.Text),
                Data = DateOnly.FromDateTime((DateTime)DateConclusionPicker.SelectedDate), 
                KolichestvoMinut = Convert.ToInt32(DurationMinutesTextBox.Text),
                VremyaSutok = SutkiTB.Text

            };

            fdc.Peregovories.Add(transmission);
            fdc.SaveChanges();
            this.Close();
        }
    }
}
