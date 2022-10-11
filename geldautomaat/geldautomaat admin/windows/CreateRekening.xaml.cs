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

namespace geldautomaat_admin.windows
{
    /// <summary>
    /// Interaction logic for CreateRekening.xaml
    /// </summary>
    public partial class CreateRekening : Window
    {
        private int _user_id;
        public CreateRekening(int lbsPincode, int lbsrekeningnummer,int user_id)
        {
            InitializeComponent();
            lbPincode.Content = lbsPincode;
            lbRekeningnummer.Content = lbsrekeningnummer;
            btnback.Click += Btnback_Click;
            _user_id = user_id;
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            rkWindow window = new rkWindow(_user_id);
            window.Show();
            this.Close();
        }
    }
}
