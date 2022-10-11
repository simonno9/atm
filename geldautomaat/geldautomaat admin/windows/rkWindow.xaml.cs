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
using geldautomaat.classes;
using geldautomaat;
using System.Data;

namespace geldautomaat_admin.windows
{
    /// <summary>
    /// Interaction logic for rkWindow.xaml
    /// </summary>
    public partial class rkWindow : Window
    {
        cAdmin admin = new cAdmin();
        public int _user_id;


        public rkWindow(int user_id)
        {
            InitializeComponent();
            dgRekeningen.DataContext = admin.GetData("SELECT rekening_id, rekeningsnummer, saldo, pincode,status from rekening WHERE user_id = " + user_id);
            _user_id = user_id;
            backBtn.Click += BackBtn_Click;
            BtnCreate.Click += BtnCreate_Click;

        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            int pincode = r.Next(1000, 9999);
            int rekeningnummer = r.Next(1000, 9999);
            string thePin = Convert.ToString(pincode);
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(thePin);

            admin.NewRekening(_user_id, rekeningnummer, passwordHash);
            CreateRekening rekening = new CreateRekening(pincode, rekeningnummer, _user_id);
            rekening.Show();
            this.Close();
            dgRekeningen.DataContext = admin.GetData("SELECT rekening_id, rekeningsnummer, saldo, pincode from rekening WHERE " + _user_id);

        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            UserWindow window = new UserWindow();
            window.Show();
            this.Close();
        }


        private void btnDeblokkeren(object sender, RoutedEventArgs e)
        {
            object item = dgRekeningen.SelectedItem;
            int rekening_id = int.Parse((dgRekeningen.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            admin.rekeningDeblokkeren(rekening_id);
        }

        private void btnBlokkeren(object sender, RoutedEventArgs e)
        {
            object item = dgRekeningen.SelectedItem;
            int rekening_id = int.Parse((dgRekeningen.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            admin.rekeningBlokkeren(rekening_id);
        }



    }
}

