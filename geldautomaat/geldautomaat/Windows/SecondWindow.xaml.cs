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

namespace geldautomaat.Windows
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        cLogin login = new cLogin();
        private int _pincode;
        private int _rekeningnummer;
        public SecondWindow(int rekeningnummer)
        {
            InitializeComponent();
            _rekeningnummer = rekeningnummer;
            login.read(Convert.ToString(rekeningnummer));

            btnATMFive.Click += BtnATMFive_Click;
            btnATMFour.Click += BtnATMFour_Click;
            btnATMTwo.Click += BtnATMTwo_Click;
            btnATMOne.Click += BtnATMOne_Click;
        }
        private void BtnATMOne_Click(object sender, RoutedEventArgs e)
        {
            Windows.saldo window1 = new Windows.saldo(login.saldo, _rekeningnummer);
            window1.Show();
            this.Close();
        }
        private void BtnATMTwo_Click(object sender, RoutedEventArgs e)
        {
            Windows.transactie window1 = new Windows.transactie(login.rekeneingsnummer);
            window1.Show();
            this.Close();
        }
        private void BtnATMFour_Click(object sender, RoutedEventArgs e)
        {
            Windows.storten window1 = new Windows.storten(login.saldo, login.rekening_id, _rekeningnummer);
            window1.Show();
            this.Close();
        }

        private void BtnATMFive_Click(object sender, RoutedEventArgs e)
        {
            Windows.opnemen window1 = new Windows.opnemen(login.saldo, login.rekening_id, _rekeningnummer);
            window1.Show();
            this.Close();
        }
    }
}
