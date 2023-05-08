using PartyManagerLib.Models;
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
    /// Логика взаимодействия для EmployeeListView.xaml
    /// </summary>
    public partial class EmployeeListView : Page
    {
        public EmployeeListView()
        {
            InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LVEmployees.ItemsSource = DBConnection.Employees;     
        }

        private void LVEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedEmployee = LVEmployees.SelectedItem as Employee;
            if(selectedEmployee == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }
            NavigationService.Navigate(new EmployeeInfoView(selectedEmployee));
        }

        private void BCreate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeProfileView(new Employee()));
        }
    }
}
