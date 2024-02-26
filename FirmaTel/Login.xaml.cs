using FirmaTel.FirmaBasa;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Login : Window
    {
        private static FirmaDbContext fdc = new FirmaDbContext();
        public Login()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            this.Close();
            registration.Show();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = from abonnent_ in fdc.Abonnents
                       where abonnent_.Inn == ClientCodeTextBox.Text && abonnent_.NomberTelefona == PhoneTextBox.Text
                       select abonnent_.KodAbonenta;
            if(user != null) 
            { 
                MainWindow mw = new MainWindow(user.Single());
                this.Close();
                mw.Show();
            }
        }
    }
}
