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
    /// Interaction logic for storten.xaml
    /// </summary>
    public partial class storten : Window
    {
        public string numbers;
        public int _saldo;
        private int _rekeningnummer;
        public int _rekening;

        classes.cSaldo csaldo = new classes.cSaldo();
        public storten(int Saldo, int rekening_id, int rekeningnummer)
        {
            InitializeComponent();
            btnOne.Click += BtnOne_Click;
            btnTwo.Click += BtnTwo_Click;
            btnThree.Click += BtnThree_Click;
            btnFour.Click += BtnFour_Click;
            btnfive.Click += Btnfive_Click;
            btnSix.Click += BtnSix_Click;
            btnSeven.Click += BtnSeven_Click;
            btnEight.Click += BtnEight_Click;
            btnNine.Click += BtnNine_Click;
            btnZero.Click += BtnZero_Click;
            btnCancel.Click += BtnCancel_Click;
            btnEnter.Click += BtnEnter_Click;
            _saldo = Saldo;
            _rekening = rekening_id;
            btnback.Click += Btnback_Click;
            _rekeningnummer = rekeningnummer;
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow menuWindow = new SecondWindow(_rekeningnummer);
            menuWindow.Show();
            this.Close();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            _saldo = _saldo + Convert.ToInt32(tb1.Text) ;
            csaldo.DepositSaldo(_saldo, _rekening , "+" +  tb1.Text);
            lbMessage.Content = "je hebt " + tb1.Text + " gestort";
        }



        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = "";
            numbers = "";
        }

        private void BtnZero_Click(object sender, RoutedEventArgs e)
        {
            numbers += "0";
            input();
        }

        private void BtnNine_Click(object sender, RoutedEventArgs e)
        {
            numbers += "9";
            input();
        }

        private void BtnEight_Click(object sender, RoutedEventArgs e)
        {
            numbers += "8";
            input();
        }

        private void BtnSeven_Click(object sender, RoutedEventArgs e)
        {
            numbers += "7";
            input();
        }

        private void BtnSix_Click(object sender, RoutedEventArgs e)
        {
            numbers += "6";
            input();
        }

        private void Btnfive_Click(object sender, RoutedEventArgs e)
        {
            numbers += "5";
            input();
        }

        private void BtnFour_Click(object sender, RoutedEventArgs e)
        {
            numbers += "4";
            input();
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e)
        {
            numbers += "3";
            input();
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            numbers += "2";
            input();
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            numbers += "1";
            input();
        }
        private void input()
        {
            tb1.Text = numbers;
        }
    }
}
