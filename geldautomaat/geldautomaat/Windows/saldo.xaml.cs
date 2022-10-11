﻿using System;
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
    /// Interaction logic for saldo.xaml
    /// </summary>
    public partial class saldo : Window
    {
        cLogin login = new cLogin();
        private int _rekeningnummer;

        public saldo(int saldo, int rekeningnummer)
        {
            InitializeComponent();
            lbSaldo.Content = "$" + saldo;
            _rekeningnummer = rekeningnummer;
            btnBack.Click += BtnBack_Click;
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow menuWindow = new SecondWindow(_rekeningnummer);
            menuWindow.Show();
            this.Close();
        }
    }
}
