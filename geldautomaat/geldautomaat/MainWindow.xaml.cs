using geldautomaat.Windows;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace geldautomaat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string numbers;
        public bool rekeningsnummer;
        public bool ATMBTN;
        public bool blocked = false;



        SQL sql = new SQL();
        cLogin login = new cLogin();
        public MainWindow()
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
        }

      

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (rekeningsnummer == false)
            {
                login.read(tbOne.Password);

                if(login.status == "inactive")
                {
                    lberror.Content = "       your account is blocked";
                    blocked = true;
                }
            }



            if (Convert.ToString(login.rekeneingsnummer) == tbOne.Password && rekeningsnummer == false && blocked == false)
            {
                rekeningsnummer = true;
                tbOne.Password = "";
                lb1.Content = "       Pincode";
                numbers = "";
                tbOne.MaxLength = 4;
            }
            else if (rekeningsnummer == true && blocked == false)
            {
                bool verified = BCrypt.Net.BCrypt.Verify(tbOne.Password, login.pincode);

                if (verified == true && blocked == false)
                {

                    ATMBTN = true;
                    SecondWindow menuWindow = new SecondWindow(login.rekeneingsnummer);
                    menuWindow.Show();
                    this.Close();
                }

            }

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            tbOne.Password = "";
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
            tbOne.Password = numbers;
        }
    }
}
