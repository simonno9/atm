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
using System.Windows.Shapes;
using geldautomaat;
using geldautomaat.classes;

namespace geldautomaat_admin
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        cLogin login = new cLogin();
        cAdmin admin = new cAdmin();

        public UserWindow()
        {
            InitializeComponent();
            dgUsers.DataContext = admin.GetData("SELECT * from user");
            backBtn.Click += BackBtn_Click;
            BtnCreate.Click += BtnCreate_Click;
            btnSearch.Click += BtnSearch_Click;
            btnReset.Click += BtnReset_Click;

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            dgUsers.DataContext = admin.GetData("SELECT * from user");

        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            dgUsers.DataContext = admin.GetData("SELECT * from user WHERE voornaam = '" + searchTextBox.Text + "' OR achternaam =  '" + searchTextBox.Text + "'");
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            windows.CreateUser create = new windows.CreateUser();
            create.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();

            window.Show();
            this.Close();

        }
        private void btnrekeningnummers(object sender, RoutedEventArgs e)
        {
            try
            {
                object item = dgUsers.SelectedItem;
                int user_id = int.Parse((dgUsers.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                windows.rkWindow window = new windows.rkWindow(user_id);
                
                window.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }
}
