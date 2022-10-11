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
    /// Interaction logic for transactie.xaml
    /// </summary>
    public partial class transactie : Window
    {
        classes.cTransaction transaction = new classes.cTransaction();

        private int _rekeningsnummer;
        public transactie(Int32 rekeningsnummer)
        {
            InitializeComponent();
            dgTransactie.DataContext = transaction.GetData(rekeningsnummer);
            _rekeningsnummer = rekeningsnummer;
            btnBack.Click += BtnBack_Click;

        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow menuWindow = new SecondWindow(_rekeningsnummer);
            menuWindow.Show();
            this.Close();
        }
    }
}
