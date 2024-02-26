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
    public partial class Registration : Window
    {
        private static FirmaDbContext fdc = new FirmaDbContext();
        public Registration()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            int lastInt = 0;
            do
            {
                lastInt++;
            } while (fdc.Abonnents.Any(x => x.KodAbonenta == lastInt) == true);

            Abonnent client = new Abonnent
            {
                KodAbonenta = lastInt,
                Adres = adressTextBox.Text,
                Inn = BankDetailsTextBox.Text,
                NomberTelefona = PhoneTextBox.Text
            };
            fdc.Abonnents.Add(client);
            fdc.SaveChanges();
            MainWindow mw = new MainWindow(lastInt);
            this.Close();
            mw.Show();
        }
    }
}
