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
using geldautomaat;

namespace geldautomaat_admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        cLogin login = new cLogin();



        public MainWindow()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            login.loginAdmin(tbPassword.Password, tbUsername.Text);

            if (tbUsername.Text == login.username && tbPassword.Password == login.password)
            {
                UserWindow window = new  UserWindow();
                window.Show();
                this.Close();
            }
        }
    }
}
