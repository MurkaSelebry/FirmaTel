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
    /// Логика взаимодействия для AddShow.xaml
    /// </summary>
    public partial class AddGorod : Window
    {
        private static FirmaDbContext fdc = new FirmaDbContext();
        public AddGorod()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int lastInt = 0;
            do
            {
                lastInt++;
            } while (fdc.Goroda.Any(x => x.KodGoroda == lastInt) == true);

            Gorodum transmission = new Gorodum()
            {
                KodGoroda = lastInt,
                Nazvanie = TitleTextBox.Text,
                TarifDnevnoy = Convert.ToDecimal(RatingTextBox.Text),
                TarifNochnoy = Convert.ToDecimal(RatingTextBox1.Text)
            };

            fdc.Goroda.Add(transmission);
            fdc.SaveChanges();
            this.Close();
        }
    }
}
