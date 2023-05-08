using PartyManagerLib.Models.Enums;
using PartyManagerLib.Services;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PartyManagerHR.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var login = TBLogin.Text;
            var password = PBPassword.Password;
            var employee = await NetManager.Login(login, password);
            if (employee != null && employee.RoleId == (int)RoleList.HRManager)
            {
                App.LoggedEmployee = employee;
                NavigationService.Navigate(new MainMenuView());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
        }
    }
}
