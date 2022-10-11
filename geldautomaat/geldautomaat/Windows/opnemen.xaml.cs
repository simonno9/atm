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
    public partial class opnemen : Window
    {
        classes.cSaldo csaldo = new classes.cSaldo();

        private int Saldo;
        private int _rekening_id; 
        private int _rekeningnummer;
        public bool withdrawAllowd;
        public opnemen(int saldo, int rekening_id,int rekeningnummer)
        {
            InitializeComponent();
            btnback.Click += BtnBack_Click;
            Saldo = saldo;
            btnATM2.Click += BtnTwo_Click;
            btnATM3.Click += BtnThree_Click;
            btnATM4.Click += BtnFour_Click;
            btnATM5.Click += Btnfive_Click;
            btnATM6.Click += BtnSix_Click;
            _rekening_id = rekening_id;
            _rekeningnummer = rekeningnummer;


        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow menuWindow = new SecondWindow(_rekeningnummer);
            menuWindow.Show();
            this.Close();
        }

        private void BtnSix_Click(object sender, RoutedEventArgs e)
        {
            if(Saldo >= 500)
            {
                string message = csaldo.updateSaldo(Saldo - 500, _rekening_id, "-500", "je hebt 500 opgenomen");
                lbOpgenomen.Content = message;

            }
            else
            {
                lbOpgenomen.Content = "je hebt teweinig geld je saldo is " + Saldo + "$";
            }

        }

        private void Btnfive_Click(object sender, RoutedEventArgs e)
        {
            if (Saldo >= 300)
            {
                string message =  csaldo.updateSaldo(Saldo - 300, _rekening_id, "-300", "je hebt 300 opgenomen");
                lbOpgenomen.Content = message;
            }
            else
            {
                lbOpgenomen.Content = "je hebt teweinig geld je saldo is " + Saldo + "$";
            }

        }

        private void BtnFour_Click(object sender, RoutedEventArgs e)
        {
            if (Saldo >= 100)
            {
                string message = csaldo.updateSaldo(Saldo - 100, _rekening_id, "-100", "je hebt 100 opgenomen");
                lbOpgenomen.Content = message;

            }
            else
            {
                lbOpgenomen.Content = "je hebt teweinig geld je saldo is " + Saldo + "$";
            }
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            if (Saldo >= 400)
            {
                string message = csaldo.updateSaldo(Saldo - 400, _rekening_id, "-400", "je hebt 400 opgenomen");
                lbOpgenomen.Content = message;

            }
            else
            {
                lbOpgenomen.Content = "je hebt teweinig geld je saldo is " + Saldo + "$";
            }

        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (Saldo >= 200)
            {
                MessageBox.Show("you have withdraw 200");
                string message = csaldo.updateSaldo(Saldo - 200, _rekening_id, "-200", "je hebt 200 opgenomen");
                lbOpgenomen.Content = message;

            }
            else
            {
                lbOpgenomen.Content = "je hebt teweinig geld je saldo is " + Saldo + "$";
            }


        }
    }
}
