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
using geldautomaat;
using geldautomaat.classes;

namespace geldautomaat_admin.windows
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        cAdmin admin = new cAdmin();

        public CreateUser()
        {
            InitializeComponent();
            btnCreate.Click += BtnCreate_Click;
            btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            UserWindow window = new UserWindow();
            window.Show();
            this.Close();
        }

        public void BtnCreate_Click(object sender, RoutedEventArgs e)
            {
                lbResponse.Content = admin.NewUser(tbVoornaam.Text, tbAchternaam.Text);
            }
         }
}
